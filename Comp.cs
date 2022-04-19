using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameGomoku
{
    /// <summary>
    /// Класс элемента игрового поля
    /// </summary>


    public class Comp
    {
        public GameSetting gameSetting;
        public ItemGamePole[,] gamePoleComp;
       // public GamePole gamePoleCompGeniral;
        public List<ItemGamePole> gamePoleCompList;

        class Otbor
        {
            public ItemGamePole itemGamePole;
            public int maxValue;
        }

        public Comp(GameSetting igameSetting)
        {
            gameSetting = igameSetting;
        }

        public void NewGamePoleComp(GamePole GamePole)
        {
            
            int size = gameSetting.GetSizePole();
            //gamePoleCompGeniral = new GamePole(size, size);
            gamePoleComp = new ItemGamePole[size, size];
           gamePoleComp = GamePole.gamePole;
            gamePoleCompList = new List<ItemGamePole>();

            gamePoleCompList = GamePole.gamePoleList;
        }

        public ItemGamePole aaa(GamePole GamePole) 
        {
            NewGamePoleComp(GamePole);
            int size = gameSetting.GetSizePole();

            var xx = from item in gamePoleCompList
                        where item.busy_cell == 1 
                        select item.x_gamePole;

            var min_x = xx.Min();
            var max_x = xx.Max();

            var yy = from item in gamePoleCompList
                     where item.busy_cell == 1
                     select item.y_gamePole;

            var min_y = yy.Min();
            var max_y = yy.Max();

            if (min_x == 1){}
            else if(min_x == 2){min_x = min_x - 1;}
            else{min_x = min_x - 2;}

            if (min_y == 1){}
            else if (min_y == 2){ min_y = min_y - 1;}
            else { min_y = min_y - 2;}

            if (max_x == size) { }
            else if (max_x == size - 1) { max_x = max_x + 1; }
            else { max_x = max_x + 2; }

            if (max_y == size) { }
            else if (max_y == size - 1) { max_y = max_y + 1; }
            else { max_y = max_y + 2; }

            var bbb = from item in gamePoleCompList
                      where item.x_gamePole <= max_x &
                            item.x_gamePole >= min_x &
                            item.y_gamePole <= max_y &
                            item.y_gamePole >= min_y &
                            item.busy_cell == 0
                      select item;

            List<Otbor> listOtbor = new List<Otbor>();

            foreach (var item in bbb)
            {
                NewGamePoleComp(GamePole);
                //gamePoleComp[item.x_gamePole, item.y_gamePole].playerNumber = 2;
                //gamePoleComp[item.x_gamePole, item.y_gamePole].busy_cell= 1;

                int a = checkVertical(item);
                int b = checkHorizontal(item);
                int c = checkDiagonal_1(item);
                int d = checkDiagonal_2(item);

                int[] arr_tmp = { a, b, c, d };
                var maxxx = arr_tmp.Max();
                Otbor tmp_otbor = new Otbor();
                tmp_otbor.itemGamePole = item;
                tmp_otbor.maxValue = maxxx;
                listOtbor.Add(tmp_otbor);
            }
            
            var sortedlistOtbor = from item in listOtbor
                                  orderby item.maxValue descending
                              select item;

            ItemGamePole vvv = sortedlistOtbor.First().itemGamePole;
            return vvv;
        }

        public List<int> checkMax(int[] array)
        {
            
            List<int> List_tmp = new List<int>();
            
            foreach (var item in array)
            {
                if (item == 5)
                {
                    List_tmp.Add(100000);
                   
                }
                else if (item == 4)
                {
                    List_tmp.Add(10000);
                   
                }
                else if (item == 3)
                {
                    List_tmp.Add(1000);
                   
                }
                else if (item == 2)
                {
                    List_tmp.Add(100);
                    
                }
                else if (item == 1)
                {
                    List_tmp.Add(10);
                }
                else
                {
                    List_tmp.Add(0);
                }
                
            }
            return List_tmp;
        }


        public int[] checkLine(ItemGamePole item_pole, int[] array_tmp, int y_pole, int x_pole, int y_delta, int x_delta)
        {
            int arrayItem = 0;
            int SummStones = 0;
            int y_gamePolePrevious = 0;
            int x_gamePolePrevious = 0;
            int playerNumberPrevious = 0;

            for (int i = 1; i < array_tmp.Count(); i++)
            {
                var cellCurrent = gamePole[x_pole - 1, y_pole - 1];

                int x_gamePoleCurrent = cellCurrent.x_gamePole;
                int y_gamePoleCurrent = cellCurrent.y_gamePole;
                var busy_cellCurrent = cellCurrent.busy_cell;
                var playerNumberCurrent = cellCurrent.playerNumber;

                if (playerNumberCurrent == playerNumberPrevious)
                {
                    playerNumberPrevious = playerNumberCurrent;
                }

                if (y_gamePolePrevious + y_delta == y_gamePoleCurrent &&
                    x_gamePolePrevious + x_delta == x_gamePoleCurrent &&
                    busy_cellCurrent == 1 &&
                    playerNumberPrevious == playerNumberCurrent &&
                    playerNumberCurrent == item_pole.playerNumber)
                {
                    SummStones += 1;
                    array_tmp[arrayItem] = SummStones;
                }
                else if (busy_cellCurrent == 1 &&
                    playerNumberCurrent == item_pole.playerNumber)
                {
                    if (SummStones == 0)
                    { arrayItem = 0; }
                    else
                    { arrayItem += 1; }

                    SummStones = 1;
                    array_tmp[arrayItem] = SummStones;
                }

                y_gamePolePrevious = y_gamePoleCurrent;
                x_gamePolePrevious = x_gamePoleCurrent;
                playerNumberPrevious = playerNumberCurrent;

                y_pole = y_pole + y_delta;
                x_pole = x_pole + x_delta;
            }
            return array_tmp;
        }

       
        public int checkVertical(ItemGamePole item_pole) //по вертикали
        {
            int[] array_tmp; //временный массив
            int size_array = 0;
            int y_pole = 0, x_pole = 0, y_delta = 0, x_delta = 0;
            size_array = gameSetting.GetSizePole();
            y_pole = 1;
            x_pole = item_pole.x_gamePole;
            y_delta = 1;
            x_delta = 0;

            array_tmp = new int[size_array];
            array_tmp = checkLine(item_pole, array_tmp, y_pole, x_pole, y_delta, x_delta);
            var aa = array_tmp.Max();
            var List_tmp = checkMax(array_tmp);
            var max = List_tmp.Max();
            return max; // проверка на 5  
        }

        public int checkHorizontal(ItemGamePole item_pole)
        {
            int[] array_tmp;
            int size_array = 0;
            int y_pole = 0, x_pole = 0, y_delta = 0, x_delta = 0;
            size_array = gameSetting.GetSizePole();
            y_pole = item_pole.y_gamePole;
            x_pole = 1;
            y_delta = 0;
            x_delta = 1;

            array_tmp = new int[size_array];
            array_tmp = checkLine(item_pole, array_tmp, y_pole, x_pole, y_delta, x_delta);
            var aa = array_tmp.Max();
            var List_tmp = checkMax(array_tmp);
            var max = List_tmp.Max();
            return max; // проверка на 5   
        }

        public int checkDiagonal_1(ItemGamePole item_pole) // по диагонали  "/"   
        {
            int y_SelectPole = item_pole.y_gamePole; // строки m
            int x_SelectPole = item_pole.x_gamePole; // столбцы n

            int[] array_tmp; //временный массив
            int size_array = 0;
            int y_pole = 0, x_pole = 0, y_delta = 0, x_delta = 0;

            if (y_SelectPole + x_SelectPole <= gameSetting.GetSizePole() + 1) //до диоганалью "/"
            {
                size_array = y_SelectPole + x_SelectPole - 1;
                y_pole = y_SelectPole + x_SelectPole - 1;
                x_pole = 1;
                y_delta = -1;
                x_delta = 1;
            }
            else if (y_SelectPole + x_SelectPole > gameSetting.GetSizePole() + 1) //после диагонали "/"
            {
                size_array = 2 * gameSetting.GetSizePole() - (y_SelectPole + x_SelectPole - 1);
                y_pole = gameSetting.GetSizePole();
                x_pole = y_SelectPole + x_SelectPole - gameSetting.GetSizePole();
                y_delta = -1;
                x_delta = 1;
            }

            array_tmp = new int[size_array];
            array_tmp = checkLine(item_pole, array_tmp, y_pole, x_pole, y_delta, x_delta);
            var aa = array_tmp.Max();
            var List_tmp = checkMax(array_tmp);
            var max = List_tmp.Max();
            return max; // проверка на 5   
        }

        public int checkDiagonal_2(ItemGamePole item_pole)// по диагонали  "\" 
        {
            int y_SelectPole = item_pole.y_gamePole; // строки m
            int x_SelectPole = item_pole.x_gamePole; // столбцы n

            int[] array_tmp; //временный массив
            int size_array = 0;
            int y_pole = 0, x_pole = 0, y_delta = 0, x_delta = 0;

            if (y_SelectPole >= x_SelectPole) // до диоганалью "\"
            {
                y_pole = y_SelectPole - x_SelectPole + 1;
                x_pole = 1;
                size_array = gameSetting.GetSizePole() - y_pole + 1;

                y_delta = 1;
                x_delta = 1;
            }
            else if (y_SelectPole < x_SelectPole)
            {
                y_pole = 1;// m_a = 1;
                x_pole = x_SelectPole - y_SelectPole + 1;
                size_array = gameSetting.GetSizePole() - x_pole + 1;

                y_delta = 1;
                x_delta = 1;
            }

            array_tmp = new int[size_array];
            array_tmp = checkLine(item_pole, array_tmp, y_pole, x_pole, y_delta, x_delta);
            var aa = array_tmp.Max();
            var List_tmp = checkMax(array_tmp);
            var max = List_tmp.Max();
            return max; // проверка на 5 

        }

        //public int[] arr1 =  


    };



}

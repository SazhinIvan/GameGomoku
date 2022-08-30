using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGomoku
{
    /// <summary>
    /// Класс элемента игрового поля
    /// </summary>
    public class ItemGamePole
    {
        public int num { get; set; }
        public int y_gamePole { get; set; }
        public int x_gamePole { get; set; }
        public int busy_cell { get; set; }
        public int playerNumber { get; set; }
    }

    /// <summary>
    /// Класс Игрового Поля
    /// </summary>
    public class GamePole
    {
        public ItemGamePole[,] gamePole { get; set; }
        public GameSetting gameSetting { get; set; }
        public List<ItemGamePole> gamePoleList { get; set; }


        public GamePole(int width_x, int height_y)
        {
            gamePole = new ItemGamePole[width_x, height_y];
            gameSetting = new GameSetting();
            gamePoleList = new List<ItemGamePole>();
        }

        public void SetGameSetting(GameSetting tmp_gameSetting)
        {
            gameSetting = tmp_gameSetting;
        }

        public ItemGamePole GetItemGamePole(int x, int y)
        {
            return gamePole[x -1 , y - 1];
        }


        public void SetNewItemGamePole(int x, int y, int num)
        {
            gamePole[x - 1, y - 1] = new ItemGamePole();
            gamePole[x - 1, y - 1].x_gamePole = x;
            gamePole[x - 1, y - 1].y_gamePole = y;
            gamePole[x - 1, y - 1].busy_cell = 0;
            gamePole[x - 1, y - 1].num = num;

            gamePoleList.Add(new ItemGamePole());            
            gamePoleList[num].x_gamePole = x;
            gamePoleList[num].y_gamePole = y;
            gamePoleList[num].busy_cell = 0;
            gamePoleList[num].num = num;
        }

        public void SetItemPlayerGamePole(int x, int y, int player, int num)
        {            
            gamePole[x - 1, y - 1].busy_cell = 1;
            gamePole[x - 1, y - 1].playerNumber = player;

            gamePoleList[num].busy_cell = 1;
            gamePoleList[num].playerNumber = player;
        }

        public void SetItemBusyGamePole(int x, int y, int num)
        {
            gamePole[x - 1, y - 1].busy_cell = 1;

            gamePoleList[num].busy_cell = 1;
        }

        public void SetItemNotBusyGamePole(int x, int y, int num, int bb)
        {
            gamePole[x - 1, y - 1].busy_cell = bb;

            gamePoleList[num].busy_cell = bb;
        }

        public bool checkFive(int[] array)
        {
            bool result = false;
            foreach (var item in array)
            {
                if (item == 5)
                { result = true; }

            }
            return result;
        }

        public int[] checkLine(ItemGamePole item_pole, int[] array_tmp, int y_pole, int x_pole, int y_delta, int x_delta)
        {
            int arrayItem = 0;
            int SummStones = 0;
            int y_gamePolePrevious = 0;
            int x_gamePolePrevious = 0;
            int playerNumberPrevious = 0;

            for (int i = 1; i <= array_tmp.Count(); i++)
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

        public bool checkVertical(ItemGamePole item_pole) //по вертикали
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
            return checkFive(array_tmp); // проверка на 5  
        }

        public bool checkHorizontal(ItemGamePole item_pole)
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
            return checkFive(array_tmp); // проверка на 5  
        }

        public bool checkDiagonal_1(ItemGamePole item_pole) // по диагонали  "/"   
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
            return checkFive(array_tmp); // проверка на 5         
        }

        public bool checkDiagonal_2(ItemGamePole item_pole)// по диагонали  "\" 
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
            return checkFive(array_tmp); // проверка на 5 

        }

        public bool Check_win(ItemGamePole item_pole)
        {

            bool five_vert = checkVertical(item_pole);       //првоерка по вертикали
            bool five_horiz = checkHorizontal(item_pole);     // првоерка по горизонтали
            bool five_diag = checkDiagonal_1(item_pole);     // проверка по диагонали "/"
            bool five_diag_2 = checkDiagonal_2(item_pole);   // проверка по диагонали "\"

            // проверка на победу
            return five_vert | five_horiz | five_diag | five_diag_2;

        }

        public bool Check_noOne(ItemGamePole item_pole)
        {

            var item = GetItemGamePole(item_pole.x_gamePole, item_pole.y_gamePole);
            //var item_x = item.x_gamePole;
            //var item_y = item.y_gamePole;
            var item_buzy = item.busy_cell;
            var item_num = item.num;
            SetItemBusyGamePole(item_pole.x_gamePole, item_pole.y_gamePole, item_pole.num);


            var ss = from obj in gamePoleList
                     where obj.busy_cell == 0
                     select obj;

            var count_ss = ss.Count();
            if (count_ss > 0)
            {
                SetItemNotBusyGamePole(item_pole.x_gamePole, item_pole.y_gamePole, item_num, item_buzy);
                return false;
                
            }
            else
            {
                return true;
            }
            // проверка на победу
             
                

        }


    }
}

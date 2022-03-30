using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public class GamePole
        {
            public int y_gamePole { get; set; }
            public int x_gamePole { get; set; }
            public int busy_cell { get; set; }
            public int playerNumber { get; set; }
            
        }

        public class buttonsPosition
        {
            public int y_gamePole { get; set; }
            public int x_gamePole { get; set; }          
 
        }

        public int size_pole;

        public int height_y;
        public int width_x;
        public buttonsPosition[] _buttonsPosition;

        //public GamePole[,] _GamePole;
        public GamePole[,] _GamePole;

        public bool player1 = true;
        public bool win =false;

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
        
        public int[] checkLine(GamePole item_pole, int[]  array_tmp,int y_pole, int x_pole, int y_delta, int x_delta)
        {
            int arrayItem = 0;
            int SummStones = 0;
            int y_gamePolePrevious = 0;
            int x_gamePolePrevious = 0;
            int playerNumberPrevious = 0;

            for (int i = 1; i < array_tmp.Count(); i++)
            {
                var cellCurrent = _GamePole[x_pole - 1, y_pole - 1];

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

        public bool checkVertical(GamePole item_pole) //по вертикали
        {
            int y_SelectPole = item_pole.y_gamePole; // строки m
            int x_SelectPole = item_pole.x_gamePole; // столбцы n

            int[] array_tmp; //временный массив
            int size_array = 0;
            int y_pole = 0, x_pole = 0, y_delta = 0, x_delta = 0;            
            size_array = size_pole;
            y_pole = 1;
            x_pole = x_SelectPole;
            y_delta = 1;
            x_delta = 0;           

            array_tmp = new int[size_array];
            array_tmp = checkLine(item_pole, array_tmp, y_pole, x_pole, y_delta, x_delta);
            return checkFive(array_tmp); // проверка на 5  
        }

        public bool checkHorizontal(GamePole item_pole)
        {
            int y_SelectPole = item_pole.y_gamePole; // строки m
            int x_SelectPole = item_pole.x_gamePole; // столбцы n

            int[] array_tmp;
            int size_array = 0;
            int y_pole = 0, x_pole = 0, y_delta = 0, x_delta = 0;
            size_array = size_pole;
            y_pole = y_SelectPole;
            x_pole = 1;
            y_delta = 0;
            x_delta = 1;

            array_tmp = new int[size_array];
            array_tmp = checkLine(item_pole, array_tmp, y_pole, x_pole, y_delta, x_delta);
            return checkFive(array_tmp); // проверка на 5  
        }

        public bool checkDiagonal_1(GamePole item_pole) // по диагонали  "/"   
        {
            int y_SelectPole = item_pole.y_gamePole; // строки m
            int x_SelectPole = item_pole.x_gamePole; // столбцы n

            int[] array_tmp; //временный массив
            int size_array = 0;
            int y_pole = 0, x_pole = 0, y_delta = 0, x_delta = 0;                      

            if (y_SelectPole + x_SelectPole <= size_pole + 1) //до диоганалью "/"
            {
                size_array = y_SelectPole + x_SelectPole - 1;
                y_pole = y_SelectPole + x_SelectPole - 1;
                x_pole = 1;
                y_delta = -1;
                x_delta = 1;
            }
            else if (y_SelectPole + x_SelectPole > size_pole + 1) //после диагонали "/"
            {
                size_array = 2 * size_pole - (y_SelectPole + x_SelectPole - 1);
                y_pole = size_pole;                
                x_pole = y_SelectPole + x_SelectPole - size_pole;
                y_delta = -1;
                x_delta = 1;
            }

            array_tmp = new int[size_array];
            array_tmp = checkLine(item_pole, array_tmp, y_pole, x_pole,  y_delta, x_delta);      
            return checkFive(array_tmp); // проверка на 5         
        }


        public bool checkDiagonal_2(GamePole item_pole)// по диагонали  "\" 
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
                size_array = size_pole - y_pole + 1; 

                y_delta = 1;
                x_delta = 1;
            }
            else if (y_SelectPole < x_SelectPole) 
            {
                y_pole = 1;// m_a = 1;
                x_pole = x_SelectPole - y_SelectPole + 1;
                size_array = size_pole - x_pole + 1 ;

                y_delta = 1; 
                x_delta = 1; 
            }

            array_tmp = new int[size_array];
            array_tmp = checkLine(item_pole, array_tmp, y_pole, x_pole, y_delta, x_delta);
            return checkFive(array_tmp); // проверка на 5 

        }


        public Form1()
        {
           // _pole = new pole[15 * 15];           
            InitializeComponent();           
        }

     
        public void obr_pole(GamePole item_pole)
        {

            bool five_vert = checkVertical(item_pole);       //првоерка по вертикали
            bool five_horiz = checkHorizontal(item_pole);     // првоерка по горизонтали
            bool five_diag = checkDiagonal_1(item_pole);     // проверка по диагонали "/"
            bool five_diag_2 = checkDiagonal_2(item_pole);   // проверка по диагонали "\"

            // проверка на победу
            win = five_vert | five_horiz | five_diag | five_diag_2;
           
        }

        public void button_color(Button button)
        {
            var _tag = (int)button.Tag;

            buttonsPosition item_pole = _buttonsPosition[_tag];

            int y_gamePole_test = item_pole.y_gamePole - 1; // строки m
            int x_gamePole_test = item_pole.x_gamePole - 1; // столбцы n

            GamePole item_pole_test = _GamePole[x_gamePole_test, y_gamePole_test];


            if (player1)
            {
                button.BackColor = Color.Black;
                player1 = !player1;
                

                ///////////////////////
                _GamePole[x_gamePole_test, y_gamePole_test].playerNumber = 1;
                ///////////////////////
            }
            else
            {
                button.BackColor = Color.White;
                player1 = !player1;
              
                ///////////////////////
                _GamePole[x_gamePole_test, y_gamePole_test].playerNumber = 2;
                ///////////////////////////////
            }
        }

        
        private void button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;   
            string _name = button.Name;
            int _tag = (int) button.Tag;
            buttonsPosition item_pole = _buttonsPosition[_tag];

            ///////////////////////
            int y_gamePole_test = item_pole.y_gamePole - 1; // строки m
            int x_gamePole_test = item_pole.x_gamePole - 1; // столбцы n

            GamePole item_pole_test = _GamePole[x_gamePole_test, y_gamePole_test];
            ///////////////////////
            


            ///////////////////////
            if (_GamePole[x_gamePole_test, y_gamePole_test].busy_cell == 1)
            {
            }
            else
            {
                button_color(button);
                _GamePole[x_gamePole_test, y_gamePole_test].busy_cell = 1;
            }
            ///////////////////////


            //obr_pole(item_pole);

            obr_pole(item_pole_test);

            string pl = item_pole_test.playerNumber.ToString();
            if (win == true)   
            {

                MessageBox.Show("выиграл игнок номер" + pl);
            }
        }

    }
}

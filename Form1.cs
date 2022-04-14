using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;


namespace GameGomoku
{
    public partial class Form1 : Form
    {  
        GameSetting gameSetting;     
       
        public buttonsPosition[] _buttonsPosition;
        public GamePole GamePoleTest;
        public bool activePlayerBlack = true;         
        
        /// <summary>
        /// Инициализация формы Form1
        /// </summary>
        public Form1()
        {           
            gameSetting = new GameSetting();
            InitializeComponent();
            MenuControls();
        }

        /// <summary>
        /// Метод установки цвета кнопки 
        /// </summary>
        /// <param name="button"></param>
        public void button_color(Button button)
        {
            var _tag = (int)button.Tag;

            buttonsPosition item_pole = _buttonsPosition[_tag];

            int y_gamePole_test = item_pole.y_gamePole /*- 1*/; // строки m
            int x_gamePole_test = item_pole.x_gamePole /*- 1*/; // столбцы n
            
            if (activePlayerBlack)
            {
                button.BackgroundImage = GameGomoku.Properties.Resources.circleBlack;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                //button.BackColor = Color.Black;
                activePlayerBlack = !activePlayerBlack;
               

                GamePoleTest.SetItemPlayerGamePole(x_gamePole_test, y_gamePole_test, 1);
            }
            else
            {
                button.BackgroundImage = GameGomoku.Properties.Resources.circleWhite;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                //button.BackColor = Color.White;
                activePlayerBlack = !activePlayerBlack;               

                GamePoleTest.SetItemPlayerGamePole(x_gamePole_test, y_gamePole_test, 2);
            }
        }

        ////////////////////////////Блок кнопок////////////////////////////////////
        /// <summary>
        /// Кнопка обработки нажатия ячейки поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;   
            int _tag = (int) button.Tag;
            buttonsPosition itemButtonPole = _buttonsPosition[_tag];

            int x_gamePole_test = itemButtonPole.x_gamePole; // столбцы n
            int y_gamePole_test = itemButtonPole.y_gamePole; // строки m           

            ItemGamePole item_pole_test = GamePoleTest.GetItemGamePole(x_gamePole_test, y_gamePole_test);
           
            if (GamePoleTest.GetItemGamePole(x_gamePole_test, y_gamePole_test).busy_cell == 1)
            {
            }
            else
            {
                button_color(button);
                GamePoleTest.SetItemBusyGamePole(x_gamePole_test, y_gamePole_test);               
            }

            string playerNum = item_pole_test.playerNumber.ToString();
            if (GamePoleTest.Check_win(item_pole_test))   
            {
                MessageBox.Show("Победитель игрок номер" + playerNum);
            } 
        }

        /// <summary>
        /// Кнопка старт новой игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClickStartGameTwoPlayersu(object sender, EventArgs e)
        {
            var fl = File.ReadAllLines("play.csv");

            foreach (var item in fl)
            {

            }
            List<string> list = new List<string>();
            list.Add("aaaaa");
          
            File.AppendAllText("play.csv" , $"{list[0]},{list[0]} ");
            fl = File.ReadAllLines("play.csv");

            RunGameTwoPlayers();
        }
        
        /// <summary>
        /// Кнопка открытия рейтинга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClickRating(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundImage = GameGomoku.Properties.Resources.circle22;
        }

        /// <summary>
        /// Кнопка выбора размера поля 15
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkSizePole15_CheckedChanged(object sender, EventArgs e)
        {
            gameSetting.SetSizePole(15);
        }

        /// <summary>
        /// Кнопка выбора размера поля 19
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkSizePole19_CheckedChanged(object sender, EventArgs e)
        {
            gameSetting.SetSizePole(19);
        }

        /// <summary>
        /// Кнопка открытия меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClickMenu(object sender, EventArgs e)
        {
            ClearGameSettingControls();
            InitializeComponentMenu();
            MenuControls();
        }
        /// <summary>
        /// Кнопка открытия настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClickGameSetting(object sender, EventArgs e)
        {
            ClearMenuControls();
            InitializeComponentSetting();
            GameSettingControls();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //////////////////////////////////////////////////////////////////////////
    }
}

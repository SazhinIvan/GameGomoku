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
        public ListOfPlayers listOfPlayers;

        public Player playerBlack;
        public Player playerWhite;

        /// <summary>
        /// Инициализация формы Form1
        /// </summary>
        public Form1()
        {           
            gameSetting = new GameSetting();
            InitializeGeneral();

            //InitializeComponent();
            //MenuControls();
            //InitializePanels();
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



        private void buttonClickbuttonBackGame(object sender, EventArgs e)
        {
            this.panelMenu.Visible = false;
            this.panelGamePole.Visible = true;
            this.panelSetting.Visible = false;
        }


        /// <summary>
        /// Кнопка старт новой игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClickStartGameTwoPlayersu(object sender, EventArgs e)
        {
            SetNamePlayer();

            //this.panelMenu.Visible = false;
            //this.panelGamePole.Visible = true;
            //this.ButtonOpenMenuFromSetting.Visible = true;
            //this.buttonBackGame.Visible = true;

            // RunGameTwoPlayers();

            
        }

        private void SetNamePlayer()
        {
            this.panelMenu.Visible = false;
            this.panelGamePole.Visible = false;
            //this.ButtonOpenMenuFromSetting.Visible = false;
            this.buttonBackGame.Visible = false;
            this.panelPlayerWhite.Visible = false;
            this.panelPlayerBlack.Visible = true;

            listOfPlayers = new ListOfPlayers();
            OpenpanelPlayerBlack(listOfPlayers);
        }

        private void RadioButtonClickSetName(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            int tag = (int)button.Tag;
            var item = listOfPlayers.ListPlayers[tag];
            var name = item.NamePlayer;
            playerBlack = new Player();
            playerBlack.NamePlayer = name;
            playerBlack.IdPlayer = tag;

        }

        private void buttonNextSetNamePlayer(object sender, EventArgs e)
        {
            var ttt = this.TextBoxNamePlayer.Text;
            if (ttt == "")
            {
                
                
                listOfPlayers.ListPlayers.Remove(playerBlack);
            }
            else
            {
                playerBlack = new Player();
                listOfPlayers.csvAddItem(ttt);


                listOfPlayers.ListPlayers.Remove(playerBlack);
            }
            

            OpenpanelPlayerWhite(listOfPlayers);
            this.panelPlayerWhite.Visible = true;
            this.panelPlayerBlack.Visible = false;
        }

        

        private void StartGame(object sender, EventArgs e)
        {
            this.panelMenu.Visible = false;
            this.panelGamePole.Visible = true;
            this.ButtonOpenMenuFromSetting.Visible = true;
            this.buttonBackGame.Visible = true;


            RunGameTwoPlayers();
        }

        /// <summary>
        /// Кнопка открытия рейтинга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClickRating(object sender, EventArgs e)
        { 

            this.panelMenu.Visible = false;
            this.panelGamePole.Visible = false;
            this.panelSetting.Visible = false;
            this.panelRating.Visible = true;


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
            //ClearGameSettingControls();
            //InitializeComponentMenu();
            //MenuControls();
            this.panelMenu.Visible = true;
            this.panelGamePole.Visible = false;
            this.panelSetting.Visible = false;
        }

        /// <summary>
        /// Кнопка открытия настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClickGameSetting(object sender, EventArgs e)
        {
            //ClearMenuControls();
            //InitializeComponentSetting();
            //GameSettingControls();

            this.panelMenu.Visible = false;
            this.panelGamePole.Visible = false;
            this.panelSetting.Visible = true;

        }
        private void buttonClickQuit(object sender, EventArgs e)
        {
            this.Close();

        }
            

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //////////////////////////////////////////////////////////////////////////
    }
}

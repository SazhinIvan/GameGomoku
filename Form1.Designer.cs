using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Linq;

namespace GameGomoku
{
    public class button_x
    {
        public int m { get; set; }
        public int n { get; set; }
        public System.Windows.Forms.Button _button { get; set; }
    }


    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeGeneral()
        {
            rating = new Rating();
            rating.csvOpen();



            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(596, 424);
            this.Name = "Form1";
            this.ResumeLayout(false);


            InitializeComponent();
            InitializePanels();


            InitializeComponentMenu();
            MenuControls();

            InitializeComponentSetting();
            GameSettingControls();

            InitializeComponentRating();

            //
            // ButtonOpenMenuFromSetting
            //
            this.ButtonOpenMenuFromGamePole.Location = new System.Drawing.Point(20, 50);
            this.ButtonOpenMenuFromGamePole.Name = "Menu";
            this.ButtonOpenMenuFromGamePole.Size = new System.Drawing.Size(150, 30);
            this.ButtonOpenMenuFromGamePole.TabIndex = 0;
            this.ButtonOpenMenuFromGamePole.Text = "Меню";
            this.ButtonOpenMenuFromGamePole.Click += new System.EventHandler(this.ButtonClickMenu);
            this.panelGamePole.Controls.Add(ButtonOpenMenuFromGamePole);
            //
            //CurentPlayer
            //
            this.CurentPlayer.Location = new System.Drawing.Point(400, 50);
            this.CurentPlayer.Name = "CurentPlayer";
            this.CurentPlayer.Size = new System.Drawing.Size(150, 30);
            this.CurentPlayer.TabIndex = 0;
            this.CurentPlayer.Text = "";
            this.CurentPlayer.Click += new System.EventHandler(this.ButtonClickMenu);
            this.panelGamePole.Controls.Add(CurentPlayer);

            this.buttonBackGame.Visible = false;  /////
        }

        private void ClearGameSettingControls()
        {
            foreach (var item in this.GroupCheckSizePole.Controls)
            {
                this.GroupCheckSizePole.Controls.Remove(item as Control);
                (item as Control).Dispose();
            }

            foreach (var item in this.GroupGameMode.Controls)
            {
                this.GroupGameMode.Controls.Remove(item as Control);
                (item as Control).Dispose();
            }
            this.Controls.Remove(ButtonOpenMenuFromSetting);
            this.ButtonOpenMenuFromSetting.Dispose();
            this.Controls.Remove(GroupCheckSizePole);
            this.GroupCheckSizePole.Dispose();
            this.Controls.Remove(GroupGameMode);
            this.GroupGameMode.Dispose();

        }

        private void GameSettingControls()
        {
            //this.GroupMenu.Visible = false;
            //this.ButtonOpenMenuFromSetting.Visible = true;
            //this.GroupCheckSizePole.Visible = true;
            //this.GroupGameMode.Visible = true;
            //
            // ButtonOpenMenuFromSetting
            //
            this.ButtonOpenMenuFromSetting.Location = new System.Drawing.Point(300, 50);
            this.ButtonOpenMenuFromSetting.Name = "Menu";
            this.ButtonOpenMenuFromSetting.Size = new System.Drawing.Size(150, 30);
            this.ButtonOpenMenuFromSetting.TabIndex = 0;
            this.ButtonOpenMenuFromSetting.Text = "Меню";
            this.ButtonOpenMenuFromSetting.Click += new System.EventHandler(this.ButtonClickMenu);
            this.panelSetting.Controls.Add(ButtonOpenMenuFromSetting);
            // 
            // GroupCheckSizePole
            // 
            this.GroupCheckSizePole.Controls.Add(this.CheckSizePole15);
            this.GroupCheckSizePole.Controls.Add(this.CheckSizePole19);
            this.GroupCheckSizePole.Location = new System.Drawing.Point(300, 100);
            this.GroupCheckSizePole.Name = "groupBox1";
            this.GroupCheckSizePole.Size = new System.Drawing.Size(150, 100);
            this.GroupCheckSizePole.TabIndex = 3;
            this.GroupCheckSizePole.TabStop = false;
            this.GroupCheckSizePole.Text = "Размер поля";
            // 
            // checkSizePole15
            // 
            this.CheckSizePole15.Location = new System.Drawing.Point(20, 30);
            this.CheckSizePole15.Name = "checkSizePole15";
            this.CheckSizePole15.Size = new System.Drawing.Size(100, 15);
            this.CheckSizePole15.TabIndex = 0;
            this.CheckSizePole15.Text = "15х15";
            this.CheckSizePole15.CheckedChanged += new System.EventHandler(this.checkSizePole15_CheckedChanged);
            // 
            // checkSizePole19
            // 
            this.CheckSizePole19.Location = new System.Drawing.Point(20, 60);
            this.CheckSizePole19.Name = "checkSizePole19";
            this.CheckSizePole19.Size = new System.Drawing.Size(100, 15);
            this.CheckSizePole19.TabIndex = 1;
            this.CheckSizePole19.Text = "19х19";
            this.CheckSizePole19.CheckedChanged += new System.EventHandler(this.checkSizePole19_CheckedChanged);

            this.panelSetting.Controls.Add(this.GroupCheckSizePole);

            // 
            // gameMode
            // 
            this.GroupGameMode.Controls.Add(this.checkOneByOne);
            this.GroupGameMode.Controls.Add(this.checkVSComp);
            this.GroupGameMode.Location = new System.Drawing.Point(300, 200);
            this.GroupGameMode.Name = "groupBox1";
            this.GroupGameMode.Size = new System.Drawing.Size(150, 100);
            this.GroupGameMode.TabIndex = 3;
            this.GroupGameMode.TabStop = false;
            this.GroupGameMode.Text = "Режим игры";
            // 
            // checkSizePole15
            // 
            this.checkOneByOne.Location = new System.Drawing.Point(20, 30);
            this.checkOneByOne.Name = "checkOneByOne";
            this.checkOneByOne.Size = new System.Drawing.Size(100, 15);
            this.checkOneByOne.TabIndex = 0;
            this.checkOneByOne.Text = "Один на один";
            this.checkOneByOne.CheckedChanged += new System.EventHandler(this.checkOneByOne_CheckedChanged);
            // 
            // checkSizePole19
            // 
            this.checkVSComp.Location = new System.Drawing.Point(20, 60);
            this.checkVSComp.Name = "checkVSComp";
            this.checkVSComp.Size = new System.Drawing.Size(100, 15);
            this.checkVSComp.TabIndex = 1;
            this.checkVSComp.Text = "Проитив компьютера";
            this.checkVSComp.CheckedChanged += new System.EventHandler(this.checkVSComp_CheckedChanged);

            this.panelSetting.Controls.Add(this.GroupGameMode);

        }

        private void ClearMenuControls()
        {
            foreach (var item in this.GroupMenu.Controls)
            {
                this.GroupCheckSizePole.Controls.Remove(item as Control);
                (item as Control).Dispose();
            }
            this.GroupMenu.Dispose();
            this.Controls.Remove(GroupMenu);
        }

        private void InitializePanels()
        {

            this.panelMenu.Visible = true;
            

            this.panelGamePole.Visible = false;
            this.panelSetting.Visible = false;
            this.panelRating.Visible = false;

            this.Width = gameSetting.GetSizeForm();
            this.Height = gameSetting.GetSizeForm();
            this.MaximumSize = new Size(this.Width, this.Height);

            this.panelMenu.Width = this.Width;
            this.panelMenu.Height = this.Height;

            this.panelSetting.Width = this.Width;
            this.panelSetting.Height = this.Height;

            this.panelRating.Width = this.Width;
            this.panelRating.Height = this.Height;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelGamePole";
            this.panelMenu.Width = this.Width;
            this.panelMenu.Height = this.Height;
            this.panelMenu.TabIndex = 0;
            // panelGamePole
            // 
            this.panelGamePole.BackColor = System.Drawing.Color.Gray;
            this.panelGamePole.Location = new System.Drawing.Point(0, 0);
            this.panelGamePole.Name = "panelGamePole";
            this.panelGamePole.Width = this.Width;
            this.panelGamePole.Height = this.Height;
            this.panelGamePole.TabIndex = 0;
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.Gray;
            this.panelSetting.Location = new System.Drawing.Point(0, 0);
            this.panelSetting.Name = "panelGamePole";
            this.panelSetting.Width = this.Width;
            this.panelSetting.Height = this.Height;
            this.panelSetting.TabIndex = 0;
            // 
            // panelRating
            // 
            this.panelRating.BackColor = System.Drawing.Color.Gray;
            this.panelRating.Location = new System.Drawing.Point(0, 0);
            this.panelRating.Name = "panelGamePole";
            this.panelRating.Width = this.Width;
            this.panelRating.Height = this.Height;
            this.panelRating.TabIndex = 0;
            // 
            // panelPlayerBlack
            // 
            this.panelPlayerBlack.BackColor = System.Drawing.Color.Gray;
            this.panelPlayerBlack.Location = new System.Drawing.Point(0, 0);
            this.panelPlayerBlack.Name = "panelGamePole";
            this.panelPlayerBlack.Width = this.Width;
            this.panelPlayerBlack.Height = this.Height;
            this.panelPlayerBlack.TabIndex = 0;
            // 
            // panelPlayerWhite
            // 
            this.panelPlayerWhite.BackColor = System.Drawing.Color.Gray;
            this.panelPlayerWhite.Location = new System.Drawing.Point(0, 0);
            this.panelPlayerWhite.Name = "panelGamePole";
            this.panelPlayerWhite.Width = this.Width;
            this.panelPlayerWhite.Height = this.Height;
            this.panelPlayerWhite.TabIndex = 0;


            this.Controls.Add(panelMenu);
            this.Controls.Add(panelGamePole);
            this.Controls.Add(panelSetting);
            this.Controls.Add(panelRating);

            this.Controls.Add(panelPlayerBlack);
            this.Controls.Add(panelPlayerWhite);
        }


        private void MenuControls()
        {
            //this.ButtonOpenMenu.Visible = false;
            //this.GroupCheckSizePole.Visible = false;
            //this.GroupGameMode.Visible = false;

            //this.GroupMenu.Visible = true;
            // 
            // GroupMenu
            // 
            this.GroupMenu.Controls.Add(this.buttonBackGame);
            this.GroupMenu.Controls.Add(this.buttonStartGame);
            this.GroupMenu.Controls.Add(this._buttonGameSetting);
            this.GroupMenu.Controls.Add(this.buttonRating);
            this.GroupMenu.Controls.Add(this.buttonQuit);
            this.GroupMenu.Location = new System.Drawing.Point(300, 80);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Size = new System.Drawing.Size(180, 220);
            this.GroupMenu.TabIndex = 3;
            this.GroupMenu.TabStop = false;
            this.GroupMenu.Text = "Меню";
            // 
            // buttonBackGame
            // 
            this.buttonBackGame.Location = new System.Drawing.Point(20, 20);
            this.buttonBackGame.Name = "buttonBackGame";
            this.buttonBackGame.Size = new System.Drawing.Size(150, 30);
            this.buttonBackGame.TabIndex = 0;
            this.buttonBackGame.Text = "Вернуться в игру";
            this.buttonBackGame.Click += new System.EventHandler(this.buttonClickbuttonBackGame);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(20, 60);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(150, 30);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Начало игры";
            this.buttonStartGame.Click += new System.EventHandler(this.buttonClickStartGameTwoPlayersu);
            // 
            // _buttonGameSetting
            // 
            this._buttonGameSetting.Location = new System.Drawing.Point(20, 100);
            this._buttonGameSetting.Name = "_buttonGameSetting";
            this._buttonGameSetting.Size = new System.Drawing.Size(150, 30);
            this._buttonGameSetting.TabIndex = 1;
            this._buttonGameSetting.Text = "Настройки игры";
            this._buttonGameSetting.Click += new System.EventHandler(this.buttonClickGameSetting);
            // 
            // buttonRating
            // 
            this.buttonRating.Location = new System.Drawing.Point(20, 140);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(150, 30);
            this.buttonRating.TabIndex = 2;
            this.buttonRating.Text = "Рейтинг";
            this.buttonRating.Click += new System.EventHandler(this.buttonClickRating);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(20, 180);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(150, 30);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Закрыть";
            this.buttonQuit.Click += new System.EventHandler(this.buttonClickQuit);



            this.GroupMenu.ResumeLayout(false);
            this.panelMenu.Controls.Add(this.GroupMenu);
        }


        private void InitializeComponentMenu()
        {
            this.GroupMenu = new System.Windows.Forms.GroupBox();
            this.buttonBackGame = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this._buttonGameSetting = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            //
            // ListView1
            //
            ListView1 = new ListView();
            this.ListView1.Location = new System.Drawing.Point(300, 0);
            this.ListView1.Name = "Список";
            this.ListView1.Size = new System.Drawing.Size(200, 100);
            this.ListView1.TabIndex = 0;
            this.ListView1.TabStop = false;
            this.ListView1.BackColor = Color.Wheat;
          

        }

        private void InitializeComponentRating()
        {

            this.ButtonOpenMenuFromRating.Visible = true;
            //this.GroupCheckSizePole.Visible = true;
            //this.GroupGameMode.Visible = true;
            //
            // ButtonOpenMenuFromSetting
            //
            this.ButtonOpenMenuFromRating.Location = new System.Drawing.Point(300, 50);
            this.ButtonOpenMenuFromRating.Name = "Menu";
            this.ButtonOpenMenuFromRating.Size = new System.Drawing.Size(150, 30);
            this.ButtonOpenMenuFromRating.TabIndex = 0;
            this.ButtonOpenMenuFromRating.Text = "Меню";
            this.ButtonOpenMenuFromRating.Click += new System.EventHandler(this.ButtonClickMenu);
            this.panelRating.Controls.Add(ButtonOpenMenuFromRating);


            //rating = new Rating();

            ListBox = new ListBox();

            List<string> list_rating = new List<string>();
            list_rating = rating.ListRating;

            var tmp_listName = (from item in list_rating

                           select item).Distinct();

            List<Rating_count> tmp_rating_count = new List<Rating_count>();

            int tmp_count = 0;
            foreach (var item in tmp_listName)
            {
                var tmp = from tmpitem in list_rating
                          where tmpitem == item
                           select tmpitem;

                tmp_count = tmp.Count();
                Rating_count new_rt = new Rating_count();
                new_rt.count = tmp_count;
                new_rt.Name = item;

                tmp_rating_count.Add(new_rt);
            }

            var tmp_sort_rating_count = from item in tmp_rating_count
                                        orderby item.count descending
                                        select item;


            foreach (var item in tmp_sort_rating_count)
            {
                string strItem = item.Name + " : Побед " + item.count.ToString() ;

                ListBox.Items.Add(strItem);
            }


            this.ListBox.Size = new System.Drawing.Size(150, 200);
            this.ListBox.Location = new System.Drawing.Point(300, 100);
            this.panelRating.Controls.Add(ListBox);


            



          
        }

        private void InitializeComponentSetting()
        {
            this.GroupCheckSizePole = new System.Windows.Forms.GroupBox();
            this.CheckSizePole15 = new System.Windows.Forms.RadioButton();
            this.CheckSizePole19 = new System.Windows.Forms.RadioButton();
            this.GroupGameMode = new System.Windows.Forms.GroupBox();
            this.checkOneByOne = new System.Windows.Forms.RadioButton();
            this.checkVSComp = new System.Windows.Forms.RadioButton();


        }
       

        private void InitializeComponent()
        {
            this.ButtonOpenMenuFromSetting = new System.Windows.Forms.Button();
            this.ButtonOpenMenuFromGamePole = new System.Windows.Forms.Button();
            this.CurentPlayer = new System.Windows.Forms.Label();
            this.ButtonOpenMenuFromRating = new System.Windows.Forms.Button();
            this.GroupGamePole = new System.Windows.Forms.GroupBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelGamePole = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panelRating = new System.Windows.Forms.Panel();
            this.panelPlayerBlack = new System.Windows.Forms.Panel();
            this.panelPlayerWhite = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ButtonOpenMenuFromSetting
            // 
            this.ButtonOpenMenuFromSetting.Location = new System.Drawing.Point(0, 0);
            this.ButtonOpenMenuFromSetting.Name = "ButtonOpenMenuFromSetting";
            this.ButtonOpenMenuFromSetting.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenMenuFromSetting.TabIndex = 0;
            // 
            // ButtonOpenMenuFromGamePole
            // 
            this.ButtonOpenMenuFromGamePole.Location = new System.Drawing.Point(0, 0);
            this.ButtonOpenMenuFromGamePole.Name = "ButtonOpenMenuFromGamePole";
            this.ButtonOpenMenuFromGamePole.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenMenuFromGamePole.TabIndex = 0;
            // 
            // ButtonOpenMenuFromRating
            // 
            this.ButtonOpenMenuFromRating.Location = new System.Drawing.Point(0, 0);
            this.ButtonOpenMenuFromRating.Name = "ButtonOpenMenuFromRating";
            this.ButtonOpenMenuFromRating.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenMenuFromRating.TabIndex = 0;
            // 
            // GroupGamePole
            // 
            this.GroupGamePole.Location = new System.Drawing.Point(0, 0);
            this.GroupGamePole.Name = "GroupGamePole";
            this.GroupGamePole.Size = new System.Drawing.Size(200, 100);
            this.GroupGamePole.TabIndex = 0;
            this.GroupGamePole.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 100);
            this.panelMenu.TabIndex = 0;
            // 
            // panelGamePole
            // 
            this.panelGamePole.Location = new System.Drawing.Point(0, 0);
            this.panelGamePole.Name = "panelGamePole";
            this.panelGamePole.Size = new System.Drawing.Size(200, 100);
            this.panelGamePole.TabIndex = 0;
            // 
            // panelSetting
            // 
            this.panelSetting.Location = new System.Drawing.Point(0, 0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(200, 100);
            this.panelSetting.TabIndex = 0;
            // 
            // panelRating
            // 
            this.panelRating.Location = new System.Drawing.Point(0, 0);
            this.panelRating.Name = "panelRating";
            this.panelRating.Size = new System.Drawing.Size(200, 100);
            this.panelRating.TabIndex = 0;
            // 
            // panelPlayerBlack
            // 
            this.panelPlayerBlack.Location = new System.Drawing.Point(0, 0);
            this.panelPlayerBlack.Name = "panelPlayerBlack";
            this.panelPlayerBlack.Size = new System.Drawing.Size(200, 100);
            this.panelPlayerBlack.TabIndex = 0;
            // 
            // panelPlayerWhite
            // 
            this.panelPlayerWhite.Location = new System.Drawing.Point(0, 0);
            this.panelPlayerWhite.Name = "panelPlayerWhite";
            this.panelPlayerWhite.Size = new System.Drawing.Size(200, 100);
            this.panelPlayerWhite.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        private void RunGame()
        {


            this.ButtonOpenMenuFromGamePole.Visible = true;  
            this.panelGamePole.Controls.Add(ButtonOpenMenuFromGamePole);


            //Настрйоки
            int size_pole = gameSetting.GetSizePole();
          //////
            int buttonWidth = 30;
            int buttonHeight = 30;

            _buttonsPosition = new buttonsPosition[size_pole * size_pole];            

            ////////////////Тест
            ObjGamePole = new GamePole(size_pole, size_pole);
            ////////////////Тест
            ///
            int space_x = 0;
            int step_space = 0;

            int SizeGroupGamePole = size_pole * buttonWidth + 40 * 2;

            int startPole_x = (gameSetting.GetSizeForm() - SizeGroupGamePole) /2;
            int startPole_y = (gameSetting.GetSizeForm() - SizeGroupGamePole) / 2;

            this.GroupGamePole.Controls.Clear();
            this.GroupGamePole.Location = new System.Drawing.Point(startPole_x , startPole_y);
            this.GroupGamePole.Name = "GroupGamePole";
            this.GroupGamePole.Size = new System.Drawing.Size(size_pole * buttonWidth + 80  , size_pole * buttonHeight + 80 );
            this.GroupGamePole.TabIndex = 0;
            this.GroupGamePole.TabStop = false;
            this.panelGamePole.Controls.Add(GroupGamePole);
            

            int max_x = 0;
            int max_y = 0;
            int num = 0;


            for (int tmp_y = 0; tmp_y < size_pole; tmp_y++)
            {
                int space_y = 0;
                
                for (int tmp_x = 0; tmp_x < size_pole; tmp_x++)
                {
                  
                    Button _button = new Button();
                    _button.Width = buttonWidth;
                    _button.Height = buttonHeight;

                    int x = tmp_x + 1;
                    int y = tmp_y + 1;
                    
                    ObjGamePole.SetNewItemGamePole(x, y, num); 
                    
                    _buttonsPosition[num] = new buttonsPosition();
                    _buttonsPosition[num].y_gamePole = y;
                    _buttonsPosition[num].x_gamePole = x;

                    //_buttonsPosition[num].busy_cell = 0;                    

                    _button.Location = new System.Drawing.Point(30 +_button.Width * tmp_x + space_x, 30 + _button.Height * tmp_y + space_y);
                    _button.Text = "";
                    _button.Name = (num + 1).ToString();
                    _button.Tag = num;
                    _button.Click += new System.EventHandler(this.button_Click);

                    GroupGamePole.Controls.Add(_button);
                    _buttonsPosition[num].button = _button;
                    num += 1;
                    space_x += step_space;
                    max_x =  _button.Width * x + space_x;
                    max_y =  _button.Height * y + space_y;

                }
                space_y += step_space;
            }

            string[] strAlf = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S" };
            
            for (int i = 0; i < size_pole; i++)
            {
                Label textTop = new Label();
                textTop.Text = strAlf[i].ToString();
                textTop.Size = new Size(15, 15);
                textTop.Location = new System.Drawing.Point( (i + 1) * buttonWidth + 10, startPole_y);
                GroupGamePole.Controls.Add(textTop);

                Label textBottom = new Label();      
                textBottom.Text = strAlf[i].ToString();
                textBottom.Size = new Size(15, 15);
                textBottom.Location = new System.Drawing.Point( (i + 1) * buttonWidth + 10,  max_y + buttonHeight );
                GroupGamePole.Controls.Add(textBottom);

                Label numbLeft = new Label();
                numbLeft.Text = (size_pole - i).ToString();
                numbLeft.Size = new Size(20, 15);
                numbLeft.Location = new System.Drawing.Point(0,  (i + 1) * buttonHeight + 10);
                GroupGamePole.Controls.Add(numbLeft);

                Label numbRight = new Label();
                numbRight.Text = (size_pole - i).ToString();
                numbRight.Size = new Size(20, 15);
                numbRight.Location = new System.Drawing.Point(max_x + 2 * buttonWidth -10 ,  (i + 1) * buttonHeight + 10);
                GroupGamePole.Controls.Add(numbRight);

            }

        }

        

        private void OpenpanelPlayerBlack(ListOfPlayers listOfPlayers)
        {

            var list = listOfPlayers.ListPlayers;

            int i = 0;
            foreach (var item in list)
            {
                var id = item.IdPlayer;
                var name = item.NamePlayer;
                RadioButton rb = new RadioButton();
                rb.Checked = false;
                rb.Tag = i;
                rb.Text = name;
                rb.Location = new System.Drawing.Point(300, 40 + i * 20);
                rb.Name = name;
                rb.Size = new System.Drawing.Size(150, 20);
                rb.Click += new System.EventHandler(this.RadioButtonClickSetNameBlack);
                this.panelPlayerBlack.Controls.Add(rb);
                i = i + 1;
            }

            TextBoxNamePlayer = new TextBox();

            this.TextBoxNamePlayer.Location = new System.Drawing.Point(300, 40 + i * 20);
            this.TextBoxNamePlayer.Size = new System.Drawing.Size(150, 20);
            this.panelPlayerBlack.Controls.Add(TextBoxNamePlayer);

            ButtonNextPanelPlayer = new Button();

            ButtonNextPanelPlayer.Location = new System.Drawing.Point(300, 40 + (i+1) * 20);
            ButtonNextPanelPlayer.Text = "Далее";
            ButtonNextPanelPlayer.Name = "Далее";
            ButtonNextPanelPlayer.Click += new System.EventHandler(this.buttonNextSetNamePlayer);
            this.panelPlayerBlack.Controls.Add(ButtonNextPanelPlayer);

        }


        private void OpenpanelPlayerWhite(ListOfPlayers listOfPlayers)
        {

            var list = listOfPlayers.ListPlayers;

            int i = 0;
            foreach (var item in list)
            {
                var id = item.IdPlayer;
                var name = item.NamePlayer;
                RadioButton rb = new RadioButton();
                rb.Tag = id;
                rb.Text = name;
                rb.Location = new System.Drawing.Point(300, 40 + i * 20);
                rb.Name = name;
                rb.Size = new System.Drawing.Size(150, 20);
                rb.Click += new System.EventHandler(this.RadioButtonClickSetNameWhite);
                this.panelPlayerWhite.Controls.Add(rb);
                i = i + 1;
            }

            TextBoxNamePlayer = new TextBox();

            this.TextBoxNamePlayer.Location = new System.Drawing.Point(300, 40 + i * 20);
            this.TextBoxNamePlayer.Size = new System.Drawing.Size(150, 20);
            this.panelPlayerWhite.Controls.Add(TextBoxNamePlayer);

            ButtonNextPanelPlayer = new Button();

            ButtonNextPanelPlayer.Location = new System.Drawing.Point(300, 40 + (i + 1) * 20);
            ButtonNextPanelPlayer.Text = "Старт";
            ButtonNextPanelPlayer.Name = "Старт";
            ButtonNextPanelPlayer.Click += new System.EventHandler(this.StartGame);
            this.panelPlayerWhite.Controls.Add(ButtonNextPanelPlayer);
        }

        private GroupBox GroupMenu;
        private Button buttonBackGame;
        private Button buttonStartGame;
        private Button _buttonGameSetting;
        private Button buttonRating;
        private Button buttonQuit;


        private GroupBox GroupCheckSizePole;
        private RadioButton CheckSizePole15;
        private RadioButton CheckSizePole19;

        private GroupBox GroupGameMode;
        private RadioButton checkOneByOne;
        private RadioButton checkVSComp;
        private Button ButtonOpenMenuFromSetting;

        private GroupBox GroupGamePole;
        private Button ButtonOpenMenuFromGamePole;

        private Button ButtonOpenMenuFromRating;

        private Panel panelGamePole;
        private Panel panelSetting;
        private Panel panelMenu;
        private Panel panelRating;

        private Panel panelPlayerBlack;
        private Panel panelPlayerWhite;
        private TextBox TextBoxNamePlayer;
        private Button ButtonNextPanelPlayer;

        private ListView ListView1;
        private ListBox ListBox;
        private Label CurentPlayer;
    }
}


using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Reflection;


namespace GameGomoku
{
    public class button_x
    {
        public int m { get; set; }
        public int n { get; set; }
        public System.Windows.Forms.Button _button { get; set; }
    }



    //static class NativeMethods
    //    {
    //        public static Cursor LoadCustomCursor(string path)
    //        {
    //            IntPtr hCurs = LoadCursorFromFile(path);
    //            if (hCurs == IntPtr.Zero) throw new Win32Exception();
    //            var curs = new Cursor(hCurs);
    //            // Note: force the cursor to own the handle so it gets released properly
    //            var fi = typeof(Cursor).GetField("ownHandle", BindingFlags.NonPublic | BindingFlags.Instance);
    //            fi.SetValue(curs, true);
    //            return curs;
    //        }
    //        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    //        private static extern IntPtr LoadCursorFromFile(string path);
    //    }

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

        //#region Код, автоматически созданный конструктором форм Windows


        private void GameSettingControls()
        {
            this.GroupMenu.Visible = false;

            // 
            // GroupCheckSizePole
            // 
            this.GroupCheckSizePole.Controls.Add(this.CheckSizePole15);
            this.GroupCheckSizePole.Controls.Add(this.CheckSizePole19);
            this.GroupCheckSizePole.Location = new System.Drawing.Point(20, 100);
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

            this.Controls.Add(this.GroupCheckSizePole);

            // 
            // gameMode
            // 
            this.GroupGameMode.Controls.Add(this.CheckSizePole15);
            this.GroupGameMode.Controls.Add(this.CheckSizePole19);
            this.GroupGameMode.Location = new System.Drawing.Point(20, 100);
            this.GroupGameMode.Name = "groupBox1";
            this.GroupGameMode.Size = new System.Drawing.Size(150, 100);
            this.GroupGameMode.TabIndex = 3;
            this.GroupGameMode.TabStop = false;
            this.GroupGameMode.Text = "Размер поля";
            // 
            // checkSizePole15
            // 
            this.checkOneByOne.Location = new System.Drawing.Point(20, 30);
            this.checkOneByOne.Name = "checkSizePole15";
            this.checkOneByOne.Size = new System.Drawing.Size(100, 15);
            this.checkOneByOne.TabIndex = 0;
            this.checkOneByOne.Text = "15х15";
            this.checkOneByOne.CheckedChanged += new System.EventHandler(this.checkSizePole15_CheckedChanged);
            // 
            // checkSizePole19
            // 
            this.checkVSComp.Location = new System.Drawing.Point(20, 60);
            this.checkVSComp.Name = "checkSizePole19";
            this.checkVSComp.Size = new System.Drawing.Size(100, 15);
            this.checkVSComp.TabIndex = 1;
            this.checkVSComp.Text = "19х19";
            this.checkVSComp.CheckedChanged += new System.EventHandler(this.checkSizePole19_CheckedChanged);

            this.Controls.Add(this.GroupGameMode);
            
        }


        private void MenuControls ()
        {



        }

        private void InitializeComponent()
        {
            //Меню
            this.GroupMenu = new System.Windows.Forms.GroupBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this._buttonGameSetting = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();           
            
           //настройки
           //настройки поля
            this.GroupCheckSizePole = new System.Windows.Forms.GroupBox();
            this.CheckSizePole15 = new System.Windows.Forms.RadioButton();
            this.CheckSizePole19 = new System.Windows.Forms.RadioButton();
            this.GroupCheckSizePole.SuspendLayout();
            this.SuspendLayout();
            //настройки режима игры
            this.GroupGameMode = new System.Windows.Forms.GroupBox();             
            this.checkOneByOne = new System.Windows.Forms.RadioButton();
            this.checkVSComp = new System.Windows.Forms.RadioButton();


            // 
            // GroupMenu
            // 
            this.GroupMenu.Controls.Add(this.buttonStartGame);
            this.GroupMenu.Controls.Add(this._buttonGameSetting);
            this.GroupMenu.Controls.Add(this.buttonRating);
            this.GroupMenu.Location = new System.Drawing.Point(20, 80);
            this.GroupMenu.Name = "Menu";
            this.GroupMenu.Size = new System.Drawing.Size(200, 220);
            this.GroupMenu.TabIndex = 3;
            this.GroupMenu.TabStop = false;
            this.GroupMenu.Text = "Меню";

            // 
            // buttonStartGameTwoPlayers
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(20, 20);
            this.buttonStartGame.Name = "buttonStartGameTwoPlayers";
            this.buttonStartGame.Size = new System.Drawing.Size(150, 30);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Два игрока";
            this.buttonStartGame.Click += new System.EventHandler(this.buttonClickStartGameTwoPlayersu);
            // 
            // _buttonStartGameVSComp
            // 
            this._buttonGameSetting.Location = new System.Drawing.Point(20, 60);
            this._buttonGameSetting.Name = "_buttonStartGameVSComp";
            this._buttonGameSetting.Size = new System.Drawing.Size(150, 30);
            this._buttonGameSetting.TabIndex = 1;
            this._buttonGameSetting.Text = "Настройки игры";
            this._buttonGameSetting.Click += new System.EventHandler(this.buttonClickGameSetting);
            // 
            // buttonRating
            // 
            this.buttonRating.Location = new System.Drawing.Point(20, 100);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(150, 30);
            this.buttonRating.TabIndex = 2;
            this.buttonRating.Text = "Рейтинг";
            this.buttonRating.Click += new System.EventHandler(this.buttonClickRating);
            
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(300, 424);
            this.Controls.Add(this.GroupMenu);
            //this.Controls.Add(this.buttonStartGameTwoPlayers);
            //this.Controls.Add(this._buttonGameSetting);
            //this.Controls.Add(this.buttonRating);
          
            this.Name = "Form1";
            this.GroupCheckSizePole.ResumeLayout(false);
            this.ResumeLayout(false);
            
        }


        private void RunGameTwoPlayers()
        {
            //Настрйоки
            int size_pole = gameSetting.size_pole;
            ///////

            
            this.buttonRating.Visible = false;

            height_y = size_pole;
            width_x = size_pole;

            this.Width = (size_pole + 1) * 50;
            this.Height = (size_pole + 1) * 50;

            _buttonsPosition = new buttonsPosition[width_x * height_y];
            _GamePole = new GamePole[width_x, height_y];
            

            int space_x = 0;
            int step_space = 0;
            int startPole_x = 200;
            int startPole_y = 10;

            int max_x = 0;
            int max_y = 0;

            int num = 0;

            int buttonWidth = 30;
            int buttonHeight = 30;

            for (int tmp_y = 0; tmp_y < height_y; tmp_y++)
            {
                int space_y = 0;

                
                for (int tmp_x = 0; tmp_x < width_x; tmp_x++)
                {
                  
                    Button _buttons = new Button();
                    _buttons.Width = buttonWidth;
                    _buttons.Height = buttonHeight;

                    int x = tmp_x + 1;
                    int y = tmp_y + 1;
                    ///////////////////////////////////////
                    _GamePole[tmp_x, tmp_y] = new GamePole();
                    _GamePole[tmp_x, tmp_y].x_gamePole = x;
                    _GamePole[tmp_x, tmp_y].y_gamePole = y;
                    _GamePole[tmp_x, tmp_y].busy_cell = 0;
                    //////////////////////////////
                    _buttonsPosition[num] = new buttonsPosition();
                    _buttonsPosition[num].y_gamePole = y;
                    _buttonsPosition[num].x_gamePole = x;
                    //_buttonsPosition[num].busy_cell = 0;                    

                    _buttons.Location = new System.Drawing.Point(startPole_x + _buttons.Width * x + space_x, startPole_y + _buttons.Height * y + space_y);
                    _buttons.Text = "";
                    _buttons.Name = (num + 1).ToString();
                    _buttons.Tag = num;
                    _buttons.Click += new System.EventHandler(this.button_Click);

                    this.Controls.Add(_buttons);
                    num += 1;
                    space_x += step_space;
                    max_x = startPole_x + _buttons.Width * x + space_x;
                    max_y = startPole_y + _buttons.Height * y + space_y;

                }
                space_y += step_space;
            }

            string[] strAlf = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S" };
            
            for (int i = 0; i < size_pole; i++)
            {
                Label textTop = new Label();
                textTop.Text = strAlf[i].ToString();
                textTop.Size = new Size(15, 15);
                textTop.Location = new System.Drawing.Point(startPole_x + (i + 1) * buttonWidth + 10, startPole_y);
                this.Controls.Add(textTop);

                Label textBottom = new Label();      
                textBottom.Text = strAlf[i].ToString();
                textBottom.Size = new Size(15, 15);
                textBottom.Location = new System.Drawing.Point(startPole_x + (i + 1) * buttonWidth + 10, startPole_y + max_y + buttonHeight );
                this.Controls.Add(textBottom);

                Label numbLeft = new Label();
                numbLeft.Text = (size_pole - i).ToString();
                numbLeft.Size = new Size(20, 15);
                numbLeft.Location = new System.Drawing.Point(startPole_x, startPole_y + (i + 1) * buttonHeight + 10);
                this.Controls.Add(numbLeft);

                Label numbRight = new Label();
                numbRight.Text = (size_pole - i).ToString();
                numbRight.Size = new Size(20, 15);
                numbRight.Location = new System.Drawing.Point(max_x + 2 * buttonWidth -10 , startPole_y + (i + 1) * buttonHeight + 10);
                this.Controls.Add(numbRight);

            }

        }

        private GroupBox GroupMenu;
        private Button buttonStartGame;
        private Button _buttonGameSetting;
        private Button buttonRating;


        private GroupBox GroupCheckSizePole;
        private RadioButton CheckSizePole15;
        private RadioButton CheckSizePole19;

        private GroupBox GroupGameMode;
        private RadioButton checkOneByOne;
        private RadioButton checkVSComp;

    }
}


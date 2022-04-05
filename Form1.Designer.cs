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

            

        


        private void InitializeComponent()
        {
            this.buttonStartGameTwoPlayers = new System.Windows.Forms.Button();
            this._buttonStartGameVSComp = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartGameTwoPlayers
            // 
            this.buttonStartGameTwoPlayers.Location = new System.Drawing.Point(20, 100);
            this.buttonStartGameTwoPlayers.Name = "buttonStartGameTwoPlayers";
            this.buttonStartGameTwoPlayers.Size = new System.Drawing.Size(150, 30);
            this.buttonStartGameTwoPlayers.TabIndex = 0;
            this.buttonStartGameTwoPlayers.Text = "Два игрока";
            this.buttonStartGameTwoPlayers.Click += new System.EventHandler(this.buttonClickStartGameTwoPlayersu);
            // 
            // _buttonStartGameVSComp
            // 
            this._buttonStartGameVSComp.Location = new System.Drawing.Point(20, 140);
            this._buttonStartGameVSComp.Name = "_buttonStartGameVSComp";
            this._buttonStartGameVSComp.Size = new System.Drawing.Size(150, 30);
            this._buttonStartGameVSComp.TabIndex = 1;
            this._buttonStartGameVSComp.Text = "Против компьютера";
            this._buttonStartGameVSComp.Click += new System.EventHandler(this.buttonClickStartGameVSComp);
            // 
            // buttonRating
            // 
            this.buttonRating.Location = new System.Drawing.Point(20, 180);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(150, 30);
            this.buttonRating.TabIndex = 2;
            this.buttonRating.Text = "Рейтинг";
            this.buttonRating.Click += new System.EventHandler(this.buttonClickRating);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(187, 306);
            this.Controls.Add(this.buttonStartGameTwoPlayers);
            this.Controls.Add(this._buttonStartGameVSComp);
            this.Controls.Add(this.buttonRating);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
        private PictureBox pictureBox1;

        private void RunGameTwoPlayers()
        {
            size_pole = 19;
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


            int num = 0;
            for (int i = 0; i < height_y; i++)
            {
                int space_y = 0;

                for (int j = 0; j < width_x; j++)
                {

                    Button _buttons = new Button();
                    _buttons.Width = 30;
                    _buttons.Height = 30;

                    int x = i + 1;
                    int y = j + 1;
                    ///////////////////////////////////////
                    _GamePole[i, j] = new GamePole();
                    _GamePole[i, j].x_gamePole = x;
                    _GamePole[i, j].y_gamePole = y;
                    _GamePole[i, j].busy_cell = 0;
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

                    space_y += step_space;
                }
                space_x += step_space;
            }

            int ii = 0;
            int n = 0;
            Label[] arr_text = new Label[26];

            for (char i = 'A'; i <= 'S'; i++)
            {
                arr_text[ii] = new Label();
                arr_text[ii].Location = new System.Drawing.Point(235 + n, 10);
                arr_text[ii].Text = i.ToString();
                arr_text[ii].Size = new Size(15, 15);
                arr_text[ii].Name = i.ToString();
                this.Controls.Add(arr_text[ii]);
                n += 30;
                ii += 1;
            }

        }

        private Button buttonStartGameTwoPlayers;
        private Button _buttonStartGameVSComp;
        private Button buttonRating;
    }
}


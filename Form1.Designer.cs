using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Reflection;


namespace WindowsFormsApp1
{
    public class button_x
    {
        public int m { get; set; }
        public int n { get; set; }
        public System.Windows.Forms.Button _button { get; set; }
    }


 
static class NativeMethods
    {
        public static Cursor LoadCustomCursor(string path)
        {
            IntPtr hCurs = LoadCursorFromFile(path);
            if (hCurs == IntPtr.Zero) throw new Win32Exception();
            var curs = new Cursor(hCurs);
            // Note: force the cursor to own the handle so it gets released properly
            var fi = typeof(Cursor).GetField("ownHandle", BindingFlags.NonPublic | BindingFlags.Instance);
            fi.SetValue(curs, true);
            return curs;
        }
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr LoadCursorFromFile(string path);
    }

    partial class Form1
    {
        Bitmap bmp;
        Graphics graph;



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

            // 
            // Form1
            // 
            size_pole = 19;
            height_y = size_pole;
            width_x = size_pole;

            this.Width = (size_pole + 1) * 50;
            this.Height = (size_pole + 1) * 50;
            this.Cursor = NativeMethods.LoadCustomCursor(@"D:/cursorm.cur");         

            //_buttons = new Button[width_x * height_y];

            _buttonsPosition = new buttonsPosition[width_x * height_y];
            _GamePole = new GamePole[width_x, height_y];           

            int space_x = 0;
            int step_space = 10;
            int num = 0;
            for (int i = 0; i < height_y; i++)
            {
                int space_y = 0;

                for (int j = 0; j < width_x; j++) {

                    Button _buttons = new Button();

                    _buttons.Width = 35;
                    _buttons.Height = 35;

                    int x = i+1;
                    int y = j+1;

                    ///////////////////////////////////////
                    _GamePole[i, j] = new GamePole();
                    _GamePole[i, j].x_gamePole = x;
                    _GamePole[i, j].y_gamePole = y;
                    _GamePole[i, j].busy_cell = 0;

                    ///////////////////////////////
                    ///
                    _buttonsPosition[num] = new buttonsPosition();
                    _buttonsPosition[num].y_gamePole = y;
                    _buttonsPosition[num].x_gamePole = x;
                    //_buttonsPosition[num].busy_cell = 0;                    

                    _GamePole[i, j] = new GamePole();
                    _GamePole[i, j].y_gamePole = y;
                    _GamePole[i, j].x_gamePole = x;
                    _GamePole[i, j].busy_cell = 0;

                    _buttons.Location = new System.Drawing.Point(_buttons.Width * x+ space_x, _buttons.Height * y+ space_y);
                    _buttons.Text = (num + 1).ToString();
                    _buttons.Name = (num + 1).ToString();
                    _buttons.Tag = num;
                    _buttons.Click += new System.EventHandler(this.button_Click);


                    this.Controls.Add(_buttons);
                    num += 1;
                    
                    space_y += step_space;
                }
                space_x += step_space;
            }

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size((size_pole + 1) * 50, (size_pole + 1) * 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            //this.ClientSize = new System.Drawing.Size((size_pole + 1) * 50, (size_pole + 1) * 50);
            this.Controls.Add(this.pictureBox1);
            //this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);



            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bmp);

            Pen pen = new Pen(Color.Red);
            graph.DrawLine(pen, 10, 0, 10, 50);
            pictureBox1.Image = bmp;

        }
        private PictureBox pictureBox1;
    }
}


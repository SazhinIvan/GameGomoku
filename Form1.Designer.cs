using System.Collections.Generic;
using System.Windows.Forms;
namespace WindowsFormsApp1
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

        //#region Код, автоматически созданный конструктором форм Windows
       
        private void InitializeComponent()
        {
            size_pole = 19;
            height_y = size_pole;
            width_x = size_pole;

            this.Width = (size_pole + 1) * 50;
            this.Height = (size_pole + 1) * 50;
            
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

        }
        
    }
}


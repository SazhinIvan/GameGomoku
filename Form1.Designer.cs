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

        public List<button_x> buttons_list;
               
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

        public int m = 15;
        public int n = 15;
        public Button[] _buttons;

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {           

            this.Width =  800;
            this.Height = 800;
            
            _buttons = new Button[m * n];

            _pole = new pole[15 * 15];
            _pole2 = new pole[15, 15];

            int otstup_x = 0;
            int num = 0;
            for (int i = 0; i < m; i++)
            {
                int otstup_y = 0;
                for (int j = 0; j < n; j++) { 

                    _buttons[num] = new Button();

                    _buttons[num].Width =30;
                    _buttons[num].Height = 30;

                    int x = i+1;
                    int y = j+1;

                    _pole[num] = new pole();
                    _pole[num].m = y;
                    _pole[num].n = x;
                    _pole[num].zn = 0;
                    

                    _pole2[i, j] = new pole();
                    _pole2[i, j].m = y;
                    _pole2[i, j].n = x;
                    _pole2[i, j].zn = 0;

                    _buttons[num].Location = new System.Drawing.Point(_buttons[num].Width * x+ otstup_x, _buttons[num].Height * y+ otstup_y);
                    _buttons[num].Text = (num + 1).ToString();
                    _buttons[num].Name = (num + 1).ToString();
                    _buttons[num].Tag = num;
                    _buttons[num].Click += new System.EventHandler(this.button_Click);


                    this.Controls.Add(_buttons[num]);
                    num += 1;
                    
                    otstup_y += 10;
                }
                otstup_x += 10;
            }

           

        }

        //            // mn1_1
        //            // 
        //            this.mn1_1.Cursor = System.Windows.Forms.Cursors.No;
        //            this.mn1_1.Location = new System.Drawing.Point(16, 21);
        //            this.mn1_1.Name = "mn1_1";
        //            this.mn1_1.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_1.TabIndex = 0;
        //            this.mn1_1.UseVisualStyleBackColor = true;
        //            this.mn1_1.Click += new System.EventHandler(this.button1_Click);


       
        //            // 
        //            // pictureBox1
        //            // 
        //            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
        //            this.pictureBox1.Name = "pictureBox1";
        //            this.pictureBox1.Size = new System.Drawing.Size(1004, 651);
        //            this.pictureBox1.TabIndex = 225;
        //            this.pictureBox1.TabStop = false;
        //            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
        //            // 
        //            // Form1
        //            // 
        //            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        //            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //            this.ClientSize = new System.Drawing.Size(1085, 741);
        //            this.Controls.Add(this.button121);
        //            
        //            this.Controls.Add(this.pictureBox1);
        //            this.Name = "Form1";
        //            this.Text = "Form1";
        //            this.Load += new System.EventHandler(this.Form1_Load);
        //            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        //            this.ResumeLayout(false);

        //        

        //        #endregion

        //        private System.Windows.Forms.Button mn1_1;
        

       // #endregion
        
    }
}


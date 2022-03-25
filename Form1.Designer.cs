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

        #region Код, автоматически созданный конструктором форм Windows

        public int m = 15;
        public int n = 15;
        public Button[] _buttons;

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {



            //    buttons_list = new List<button_x>();


            //button_x _btn = new button_x()
            //    {

            //    };

            //    buttons_list.Add(_btn);

            //    foreach (var item in buttons_list)
            //    {
            //        item._button.Location = new System.Drawing.Point(285, 21);                
            //        item._button.Name = "mn1_5";
            //        item._button.Size = new System.Drawing.Size(19, 19);
            //        item._button.TabIndex = 4;
            //        item._button.UseVisualStyleBackColor = true;
            //        item._button.Click += new System.EventHandler(this.button5_Click);

            //        this.Controls.Add(item._button);
            //    }
            this.Width =  600;
            this.Height = 600;
            
            _buttons = new Button[m * n];

            _pole = new pole[15 * 15];
            _pole2 = new pole[15, 15];

            int num = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) { 

                    _buttons[num] = new Button();

                    _buttons[num].Width = 30;
                    _buttons[num].Height = 30;

                    int x = i+1;
                    int y = j+1;

                    _pole[num] = new pole();
                    _pole[num].m = i + 1;
                    _pole[num].n = j + 1;
                    _pole[num].zn = 0;
                    

                    _pole2[i, j] = new pole();
                    _pole2[i, j].m = i + 1;
                    _pole2[i, j].n = j + 1;
                    _pole2[i, j].zn = 0;

                    _buttons[num].Location = new System.Drawing.Point(_buttons[num].Width * x, _buttons[num].Height * y);
                    _buttons[num].Text = (num + 1).ToString();
                    _buttons[num].Name = (num + 1).ToString();
                    _buttons[num].Tag = num;
                    _buttons[num].Click += new System.EventHandler(this.button_Click);


                    this.Controls.Add(_buttons[num]);
                    num += 1;
                }
            }

           

        }



        //            this.mn1_1 = new System.Windows.Forms.Button();
        //            this.mn1_2 = new System.Windows.Forms.Button();
        //            this.mn1_3 = new System.Windows.Forms.Button();
        //            this.mn1_4 = new System.Windows.Forms.Button();
        //            //this.mn1_5 = new System.Windows.Forms.Button();
        //            this.mn1_6 = new System.Windows.Forms.Button();
        //            this.mn1_7 = new System.Windows.Forms.Button();
        //            this.mn1_8 = new System.Windows.Forms.Button();
        //            this.mn1_9 = new System.Windows.Forms.Button();
        //            this.mn1_10 = new System.Windows.Forms.Button();
        //            this.mn1_11 = new System.Windows.Forms.Button();
        //            this.mn1_12 = new System.Windows.Forms.Button();
        //            this.mn1_13 = new System.Windows.Forms.Button();
        //            this.mn1_14 = new System.Windows.Forms.Button();
        //            this.mn1_15 = new System.Windows.Forms.Button();
        //            this.mn2_15 = new System.Windows.Forms.Button();
        //            this.mn2_14 = new System.Windows.Forms.Button();
        //            this.mn2_13 = new System.Windows.Forms.Button();
        //            this.mn2_12 = new System.Windows.Forms.Button();
        //            this.mn2_11 = new System.Windows.Forms.Button();
        //            this.mn2_10 = new System.Windows.Forms.Button();
        //            this.mn2_9 = new System.Windows.Forms.Button();
        //            this.mn2_8 = new System.Windows.Forms.Button();
        //            this.mn2_7 = new System.Windows.Forms.Button();
        //            this.mn2_6 = new System.Windows.Forms.Button();
        //            this.mn2_5 = new System.Windows.Forms.Button();
        //            this.mn2_4 = new System.Windows.Forms.Button();
        //            this.mn2_3 = new System.Windows.Forms.Button();
        //            this.mn2_2 = new System.Windows.Forms.Button();
        //            this.mn2_1 = new System.Windows.Forms.Button();
        //            this.mn4_15 = new System.Windows.Forms.Button();
        //            this.mn4_14 = new System.Windows.Forms.Button();
        //            this.mn4_13 = new System.Windows.Forms.Button();
        //            this.mn4_12 = new System.Windows.Forms.Button();
        //            this.mn4_11 = new System.Windows.Forms.Button();
        //            this.mn4_10 = new System.Windows.Forms.Button();
        //            this.mn4_9 = new System.Windows.Forms.Button();
        //            this.mn4_8 = new System.Windows.Forms.Button();
        //            this.mn4_7 = new System.Windows.Forms.Button();
        //            this.mn4_6 = new System.Windows.Forms.Button();
        //            this.mn4_5 = new System.Windows.Forms.Button();
        //            this.mn4_4 = new System.Windows.Forms.Button();
        //            this.mn4_3 = new System.Windows.Forms.Button();
        //            this.mn4_2 = new System.Windows.Forms.Button();
        //            this.mn4_1 = new System.Windows.Forms.Button();
        //            this.mn3_15 = new System.Windows.Forms.Button();
        //            this.mn3_14 = new System.Windows.Forms.Button();
        //            this.mn3_13 = new System.Windows.Forms.Button();
        //            this.mn3_12 = new System.Windows.Forms.Button();
        //            this.mn3_11 = new System.Windows.Forms.Button();
        //            this.mn3_10 = new System.Windows.Forms.Button();
        //            this.mn3_9 = new System.Windows.Forms.Button();
        //            this.mn3_8 = new System.Windows.Forms.Button();
        //            this.mn3_7 = new System.Windows.Forms.Button();
        //            this.mn3_6 = new System.Windows.Forms.Button();
        //            this.mn3_5 = new System.Windows.Forms.Button();
        //            this.mn3_4 = new System.Windows.Forms.Button();
        //            this.mn3_3 = new System.Windows.Forms.Button();
        //            this.mn3_2 = new System.Windows.Forms.Button();
        //            this.mn3_1 = new System.Windows.Forms.Button();
        //            this.button61 = new System.Windows.Forms.Button();
        //            this.button62 = new System.Windows.Forms.Button();
        //            this.button63 = new System.Windows.Forms.Button();
        //            this.button64 = new System.Windows.Forms.Button();
        //            this.button65 = new System.Windows.Forms.Button();
        //            this.button66 = new System.Windows.Forms.Button();
        //            this.button67 = new System.Windows.Forms.Button();
        //            this.button68 = new System.Windows.Forms.Button();
        //            this.button69 = new System.Windows.Forms.Button();
        //            this.button70 = new System.Windows.Forms.Button();
        //            this.button71 = new System.Windows.Forms.Button();
        //            this.button72 = new System.Windows.Forms.Button();
        //            this.button73 = new System.Windows.Forms.Button();
        //            this.button74 = new System.Windows.Forms.Button();
        //            this.button75 = new System.Windows.Forms.Button();
        //            this.button76 = new System.Windows.Forms.Button();
        //            this.button77 = new System.Windows.Forms.Button();
        //            this.button78 = new System.Windows.Forms.Button();
        //            this.button79 = new System.Windows.Forms.Button();
        //            this.button80 = new System.Windows.Forms.Button();
        //            this.button81 = new System.Windows.Forms.Button();
        //            this.button82 = new System.Windows.Forms.Button();
        //            this.button83 = new System.Windows.Forms.Button();
        //            this.button84 = new System.Windows.Forms.Button();
        //            this.button85 = new System.Windows.Forms.Button();
        //            this.button86 = new System.Windows.Forms.Button();
        //            this.button87 = new System.Windows.Forms.Button();
        //            this.button88 = new System.Windows.Forms.Button();
        //            this.button89 = new System.Windows.Forms.Button();
        //            this.button90 = new System.Windows.Forms.Button();
        //            this.button91 = new System.Windows.Forms.Button();
        //            this.button92 = new System.Windows.Forms.Button();
        //            this.button93 = new System.Windows.Forms.Button();
        //            this.button94 = new System.Windows.Forms.Button();
        //            this.button95 = new System.Windows.Forms.Button();
        //            this.button96 = new System.Windows.Forms.Button();
        //            this.button97 = new System.Windows.Forms.Button();
        //            this.button98 = new System.Windows.Forms.Button();
        //            this.button99 = new System.Windows.Forms.Button();
        //            this.button100 = new System.Windows.Forms.Button();
        //            this.button101 = new System.Windows.Forms.Button();
        //            this.button102 = new System.Windows.Forms.Button();
        //            this.mn6_3 = new System.Windows.Forms.Button();
        //            this.mn6_2 = new System.Windows.Forms.Button();
        //            this.mn6_1 = new System.Windows.Forms.Button();
        //            this.mn5_15 = new System.Windows.Forms.Button();
        //            this.mn5_14 = new System.Windows.Forms.Button();
        //            this.mn5_13 = new System.Windows.Forms.Button();
        //            this.mn5_12 = new System.Windows.Forms.Button();
        //            this.mn5_11 = new System.Windows.Forms.Button();
        //            this.mn5_10 = new System.Windows.Forms.Button();
        //            this.mn5_9 = new System.Windows.Forms.Button();
        //            this.mn5_8 = new System.Windows.Forms.Button();
        //            this.mn5_7 = new System.Windows.Forms.Button();
        //            this.mn5_6 = new System.Windows.Forms.Button();
        //            this.mn5_5 = new System.Windows.Forms.Button();
        //            this.mn5_4 = new System.Windows.Forms.Button();
        //            this.mn5_3 = new System.Windows.Forms.Button();
        //            this.mn5_2 = new System.Windows.Forms.Button();
        //            this.mn5_1 = new System.Windows.Forms.Button();
        //            this.button121 = new System.Windows.Forms.Button();
        //            this.button122 = new System.Windows.Forms.Button();
        //            this.button123 = new System.Windows.Forms.Button();
        //            this.button124 = new System.Windows.Forms.Button();
        //            this.button125 = new System.Windows.Forms.Button();
        //            this.button126 = new System.Windows.Forms.Button();
        //            this.button127 = new System.Windows.Forms.Button();
        //            this.button128 = new System.Windows.Forms.Button();
        //            this.button129 = new System.Windows.Forms.Button();
        //            this.button130 = new System.Windows.Forms.Button();
        //            this.button131 = new System.Windows.Forms.Button();
        //            this.button132 = new System.Windows.Forms.Button();
        //            this.button133 = new System.Windows.Forms.Button();
        //            this.button134 = new System.Windows.Forms.Button();
        //            this.button135 = new System.Windows.Forms.Button();
        //            this.button136 = new System.Windows.Forms.Button();
        //            this.button137 = new System.Windows.Forms.Button();
        //            this.button138 = new System.Windows.Forms.Button();
        //            this.button139 = new System.Windows.Forms.Button();
        //            this.button140 = new System.Windows.Forms.Button();
        //            this.button141 = new System.Windows.Forms.Button();
        //            this.button142 = new System.Windows.Forms.Button();
        //            this.button143 = new System.Windows.Forms.Button();
        //            this.button144 = new System.Windows.Forms.Button();
        //            this.button145 = new System.Windows.Forms.Button();
        //            this.button146 = new System.Windows.Forms.Button();
        //            this.button147 = new System.Windows.Forms.Button();
        //            this.button148 = new System.Windows.Forms.Button();
        //            this.button149 = new System.Windows.Forms.Button();
        //            this.button150 = new System.Windows.Forms.Button();
        //            this.button151 = new System.Windows.Forms.Button();
        //            this.button152 = new System.Windows.Forms.Button();
        //            this.button153 = new System.Windows.Forms.Button();
        //            this.button154 = new System.Windows.Forms.Button();
        //            this.button155 = new System.Windows.Forms.Button();
        //            this.button156 = new System.Windows.Forms.Button();
        //            this.button157 = new System.Windows.Forms.Button();
        //            this.button158 = new System.Windows.Forms.Button();
        //            this.button159 = new System.Windows.Forms.Button();
        //            this.button160 = new System.Windows.Forms.Button();
        //            this.button161 = new System.Windows.Forms.Button();
        //            this.button162 = new System.Windows.Forms.Button();
        //            this.button163 = new System.Windows.Forms.Button();
        //            this.button164 = new System.Windows.Forms.Button();
        //            this.button165 = new System.Windows.Forms.Button();
        //            this.button166 = new System.Windows.Forms.Button();
        //            this.button167 = new System.Windows.Forms.Button();
        //            this.button168 = new System.Windows.Forms.Button();
        //            this.button169 = new System.Windows.Forms.Button();
        //            this.button170 = new System.Windows.Forms.Button();
        //            this.button171 = new System.Windows.Forms.Button();
        //            this.button172 = new System.Windows.Forms.Button();
        //            this.button173 = new System.Windows.Forms.Button();
        //            this.button174 = new System.Windows.Forms.Button();
        //            this.button175 = new System.Windows.Forms.Button();
        //            this.button176 = new System.Windows.Forms.Button();
        //            this.button177 = new System.Windows.Forms.Button();
        //            this.button178 = new System.Windows.Forms.Button();
        //            this.button179 = new System.Windows.Forms.Button();
        //            this.button180 = new System.Windows.Forms.Button();
        //            this.button181 = new System.Windows.Forms.Button();
        //            this.button182 = new System.Windows.Forms.Button();
        //            this.button183 = new System.Windows.Forms.Button();
        //            this.button184 = new System.Windows.Forms.Button();
        //            this.button185 = new System.Windows.Forms.Button();
        //            this.button186 = new System.Windows.Forms.Button();
        //            this.button187 = new System.Windows.Forms.Button();
        //            this.button188 = new System.Windows.Forms.Button();
        //            this.button189 = new System.Windows.Forms.Button();
        //            this.button190 = new System.Windows.Forms.Button();
        //            this.button191 = new System.Windows.Forms.Button();
        //            this.button192 = new System.Windows.Forms.Button();
        //            this.button193 = new System.Windows.Forms.Button();
        //            this.button194 = new System.Windows.Forms.Button();
        //            this.button195 = new System.Windows.Forms.Button();
        //            this.button196 = new System.Windows.Forms.Button();
        //            this.button197 = new System.Windows.Forms.Button();
        //            this.button198 = new System.Windows.Forms.Button();
        //            this.button199 = new System.Windows.Forms.Button();
        //            this.button200 = new System.Windows.Forms.Button();
        //            this.button201 = new System.Windows.Forms.Button();
        //            this.button202 = new System.Windows.Forms.Button();
        //            this.button203 = new System.Windows.Forms.Button();
        //            this.button204 = new System.Windows.Forms.Button();
        //            this.button205 = new System.Windows.Forms.Button();
        //            this.button206 = new System.Windows.Forms.Button();
        //            this.button207 = new System.Windows.Forms.Button();
        //            this.button208 = new System.Windows.Forms.Button();
        //            this.button209 = new System.Windows.Forms.Button();
        //            this.button210 = new System.Windows.Forms.Button();
        //            this.button211 = new System.Windows.Forms.Button();
        //            this.button212 = new System.Windows.Forms.Button();
        //            this.button213 = new System.Windows.Forms.Button();
        //            this.button214 = new System.Windows.Forms.Button();
        //            this.button215 = new System.Windows.Forms.Button();
        //            this.button216 = new System.Windows.Forms.Button();
        //            this.button217 = new System.Windows.Forms.Button();
        //            this.button218 = new System.Windows.Forms.Button();
        //            this.button219 = new System.Windows.Forms.Button();
        //            this.button220 = new System.Windows.Forms.Button();
        //            this.button221 = new System.Windows.Forms.Button();
        //            this.button222 = new System.Windows.Forms.Button();
        //            this.button223 = new System.Windows.Forms.Button();
        //            this.button224 = new System.Windows.Forms.Button();
        //            this.button225 = new System.Windows.Forms.Button();
        //            this.pictureBox1 = new System.Windows.Forms.PictureBox();
        //            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        //            this.SuspendLayout();
        //            // 
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
        //            // mn1_2
        //            // 
        //            this.mn1_2.Location = new System.Drawing.Point(79, 21);
        //            this.mn1_2.Name = "mn1_2";
        //            this.mn1_2.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_2.TabIndex = 1;
        //            this.mn1_2.UseVisualStyleBackColor = true;
        //            this.mn1_2.Click += new System.EventHandler(this.button2_Click);
        //            // 
        //            // mn1_3
        //            // 
        //            this.mn1_3.Location = new System.Drawing.Point(144, 21);
        //            this.mn1_3.Name = "mn1_3";
        //            this.mn1_3.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_3.TabIndex = 2;
        //            this.mn1_3.UseVisualStyleBackColor = true;
        //            this.mn1_3.Click += new System.EventHandler(this.button3_Click);
        //            // 
        //            // mn1_4
        //            // 
        //            this.mn1_4.Location = new System.Drawing.Point(214, 21);
        //            this.mn1_4.Name = "mn1_4";
        //            this.mn1_4.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_4.TabIndex = 3;
        //            this.mn1_4.UseVisualStyleBackColor = true;
        //            this.mn1_4.Click += new System.EventHandler(this.button4_Click);
        //            // 
        //            // mn1_5
        //            // 
        //            //this.mn1_5.Location = new System.Drawing.Point(285, 21);
        //            //this.mn1_5.Name = "mn1_5";
        //            //this.mn1_5.Size = new System.Drawing.Size(19, 19);
        //            //this.mn1_5.TabIndex = 4;
        //            //this.mn1_5.UseVisualStyleBackColor = true;
        //            //this.mn1_5.Click += new System.EventHandler(this.button5_Click);
        //            // 
        //            // mn1_6
        //            // 
        //            this.mn1_6.Location = new System.Drawing.Point(353, 21);
        //            this.mn1_6.Name = "mn1_6";
        //            this.mn1_6.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_6.TabIndex = 5;
        //            this.mn1_6.UseVisualStyleBackColor = true;
        //            this.mn1_6.Click += new System.EventHandler(this.button6_Click);
        //            // 
        //            // mn1_7
        //            // 
        //            this.mn1_7.Location = new System.Drawing.Point(422, 21);
        //            this.mn1_7.Name = "mn1_7";
        //            this.mn1_7.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_7.TabIndex = 6;
        //            this.mn1_7.UseVisualStyleBackColor = true;
        //            this.mn1_7.Click += new System.EventHandler(this.button7_Click);
        //            // 
        //            // mn1_8
        //            // 
        //            this.mn1_8.Location = new System.Drawing.Point(490, 21);
        //            this.mn1_8.Name = "mn1_8";
        //            this.mn1_8.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_8.TabIndex = 7;
        //            this.mn1_8.UseVisualStyleBackColor = true;
        //            this.mn1_8.Click += new System.EventHandler(this.button8_Click);
        //            // 
        //            // mn1_9
        //            // 
        //            this.mn1_9.Location = new System.Drawing.Point(560, 21);
        //            this.mn1_9.Name = "mn1_9";
        //            this.mn1_9.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_9.TabIndex = 8;
        //            this.mn1_9.UseVisualStyleBackColor = true;
        //            this.mn1_9.Click += new System.EventHandler(this.button9_Click);
        //            // 
        //            // mn1_10
        //            // 
        //            this.mn1_10.Location = new System.Drawing.Point(623, 21);
        //            this.mn1_10.Name = "mn1_10";
        //            this.mn1_10.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_10.TabIndex = 9;
        //            this.mn1_10.UseVisualStyleBackColor = true;
        //            this.mn1_10.Click += new System.EventHandler(this.button10_Click);
        //            // 
        //            // mn1_11
        //            // 
        //            this.mn1_11.Location = new System.Drawing.Point(691, 21);
        //            this.mn1_11.Name = "mn1_11";
        //            this.mn1_11.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_11.TabIndex = 10;
        //            this.mn1_11.UseVisualStyleBackColor = true;
        //            this.mn1_11.Click += new System.EventHandler(this.button11_Click);
        //            // 
        //            // mn1_12
        //            // 
        //            this.mn1_12.Location = new System.Drawing.Point(756, 21);
        //            this.mn1_12.Name = "mn1_12";
        //            this.mn1_12.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_12.TabIndex = 11;
        //            this.mn1_12.UseVisualStyleBackColor = true;
        //            this.mn1_12.Click += new System.EventHandler(this.button12_Click);
        //            // 
        //            // mn1_13
        //            // 
        //            this.mn1_13.Location = new System.Drawing.Point(820, 21);
        //            this.mn1_13.Name = "mn1_13";
        //            this.mn1_13.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_13.TabIndex = 12;
        //            this.mn1_13.UseVisualStyleBackColor = true;
        //            this.mn1_13.Click += new System.EventHandler(this.button13_Click);
        //            // 
        //            // mn1_14
        //            // 
        //            this.mn1_14.Location = new System.Drawing.Point(887, 21);
        //            this.mn1_14.Name = "mn1_14";
        //            this.mn1_14.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_14.TabIndex = 13;
        //            this.mn1_14.UseVisualStyleBackColor = true;
        //            this.mn1_14.Click += new System.EventHandler(this.button14_Click);
        //            // 
        //            // mn1_15
        //            // 
        //            this.mn1_15.Location = new System.Drawing.Point(954, 21);
        //            this.mn1_15.Name = "mn1_15";
        //            this.mn1_15.Size = new System.Drawing.Size(19, 19);
        //            this.mn1_15.TabIndex = 14;
        //            this.mn1_15.UseVisualStyleBackColor = true;
        //            this.mn1_15.Click += new System.EventHandler(this.button15_Click);
        //            // 
        //            // mn2_15
        //            // 
        //            this.mn2_15.Location = new System.Drawing.Point(954, 65);
        //            this.mn2_15.Name = "mn2_15";
        //            this.mn2_15.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_15.TabIndex = 29;
        //            this.mn2_15.Text = "button16";
        //            this.mn2_15.UseVisualStyleBackColor = true;
        //            this.mn2_15.Click += new System.EventHandler(this.button16_Click);
        //            // 
        //            // mn2_14
        //            // 
        //            this.mn2_14.Location = new System.Drawing.Point(887, 65);
        //            this.mn2_14.Name = "mn2_14";
        //            this.mn2_14.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_14.TabIndex = 28;
        //            this.mn2_14.Text = "button17";
        //            this.mn2_14.UseVisualStyleBackColor = true;
        //            this.mn2_14.Click += new System.EventHandler(this.button17_Click);
        //            // 
        //            // mn2_13
        //            // 
        //            this.mn2_13.Location = new System.Drawing.Point(820, 65);
        //            this.mn2_13.Name = "mn2_13";
        //            this.mn2_13.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_13.TabIndex = 27;
        //            this.mn2_13.Text = "button18";
        //            this.mn2_13.UseVisualStyleBackColor = true;
        //            this.mn2_13.Click += new System.EventHandler(this.button18_Click);
        //            // 
        //            // mn2_12
        //            // 
        //            this.mn2_12.Location = new System.Drawing.Point(756, 65);
        //            this.mn2_12.Name = "mn2_12";
        //            this.mn2_12.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_12.TabIndex = 26;
        //            this.mn2_12.Text = "button19";
        //            this.mn2_12.UseVisualStyleBackColor = true;
        //            this.mn2_12.Click += new System.EventHandler(this.button19_Click);
        //            // 
        //            // mn2_11
        //            // 
        //            this.mn2_11.Location = new System.Drawing.Point(691, 65);
        //            this.mn2_11.Name = "mn2_11";
        //            this.mn2_11.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_11.TabIndex = 25;
        //            this.mn2_11.Text = "button20";
        //            this.mn2_11.UseVisualStyleBackColor = true;
        //            this.mn2_11.Click += new System.EventHandler(this.button20_Click);
        //            // 
        //            // mn2_10
        //            // 
        //            this.mn2_10.Location = new System.Drawing.Point(623, 65);
        //            this.mn2_10.Name = "mn2_10";
        //            this.mn2_10.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_10.TabIndex = 24;
        //            this.mn2_10.Text = "button21";
        //            this.mn2_10.UseVisualStyleBackColor = true;
        //            this.mn2_10.Click += new System.EventHandler(this.button21_Click);
        //            // 
        //            // mn2_9
        //            // 
        //            this.mn2_9.Location = new System.Drawing.Point(560, 65);
        //            this.mn2_9.Name = "mn2_9";
        //            this.mn2_9.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_9.TabIndex = 23;
        //            this.mn2_9.Text = "button22";
        //            this.mn2_9.UseVisualStyleBackColor = true;
        //            this.mn2_9.Click += new System.EventHandler(this.button22_Click);
        //            // 
        //            // mn2_8
        //            // 
        //            this.mn2_8.Location = new System.Drawing.Point(490, 65);
        //            this.mn2_8.Name = "mn2_8";
        //            this.mn2_8.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_8.TabIndex = 22;
        //            this.mn2_8.Text = "button23";
        //            this.mn2_8.UseVisualStyleBackColor = true;
        //            this.mn2_8.Click += new System.EventHandler(this.button23_Click);
        //            // 
        //            // mn2_7
        //            // 
        //            this.mn2_7.Location = new System.Drawing.Point(422, 65);
        //            this.mn2_7.Name = "mn2_7";
        //            this.mn2_7.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_7.TabIndex = 21;
        //            this.mn2_7.Text = "button24";
        //            this.mn2_7.UseVisualStyleBackColor = true;
        //            this.mn2_7.Click += new System.EventHandler(this.button24_Click);
        //            // 
        //            // mn2_6
        //            // 
        //            this.mn2_6.Location = new System.Drawing.Point(353, 65);
        //            this.mn2_6.Name = "mn2_6";
        //            this.mn2_6.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_6.TabIndex = 20;
        //            this.mn2_6.Text = "button25";
        //            this.mn2_6.UseVisualStyleBackColor = true;
        //            this.mn2_6.Click += new System.EventHandler(this.button25_Click);
        //            // 
        //            // mn2_5
        //            // 
        //            this.mn2_5.Location = new System.Drawing.Point(285, 65);
        //            this.mn2_5.Name = "mn2_5";
        //            this.mn2_5.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_5.TabIndex = 19;
        //            this.mn2_5.Text = "button26";
        //            this.mn2_5.UseVisualStyleBackColor = true;
        //            this.mn2_5.Click += new System.EventHandler(this.button26_Click);
        //            // 
        //            // mn2_4
        //            // 
        //            this.mn2_4.Location = new System.Drawing.Point(214, 65);
        //            this.mn2_4.Name = "mn2_4";
        //            this.mn2_4.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_4.TabIndex = 18;
        //            this.mn2_4.Text = "button27";
        //            this.mn2_4.UseVisualStyleBackColor = true;
        //            this.mn2_4.Click += new System.EventHandler(this.button27_Click);
        //            // 
        //            // mn2_3
        //            // 
        //            this.mn2_3.Location = new System.Drawing.Point(144, 65);
        //            this.mn2_3.Name = "mn2_3";
        //            this.mn2_3.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_3.TabIndex = 17;
        //            this.mn2_3.UseVisualStyleBackColor = true;
        //            this.mn2_3.Click += new System.EventHandler(this.button28_Click);
        //            // 
        //            // mn2_2
        //            // 
        //            this.mn2_2.Location = new System.Drawing.Point(79, 65);
        //            this.mn2_2.Name = "mn2_2";
        //            this.mn2_2.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_2.TabIndex = 16;
        //            this.mn2_2.UseVisualStyleBackColor = true;
        //            this.mn2_2.Click += new System.EventHandler(this.button29_Click);
        //            // 
        //            // mn2_1
        //            // 
        //            this.mn2_1.Location = new System.Drawing.Point(16, 65);
        //            this.mn2_1.Name = "mn2_1";
        //            this.mn2_1.Size = new System.Drawing.Size(19, 19);
        //            this.mn2_1.TabIndex = 15;
        //            this.mn2_1.UseVisualStyleBackColor = true;
        //            this.mn2_1.Click += new System.EventHandler(this.button30_Click);
        //            // 
        //            // mn4_15
        //            // 
        //            this.mn4_15.Location = new System.Drawing.Point(954, 151);
        //            this.mn4_15.Name = "mn4_15";
        //            this.mn4_15.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_15.TabIndex = 59;
        //            this.mn4_15.Text = "button31";
        //            this.mn4_15.UseVisualStyleBackColor = true;
        //            this.mn4_15.Click += new System.EventHandler(this.button31_Click);
        //            // 
        //            // mn4_14
        //            // 
        //            this.mn4_14.Location = new System.Drawing.Point(887, 151);
        //            this.mn4_14.Name = "mn4_14";
        //            this.mn4_14.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_14.TabIndex = 58;
        //            this.mn4_14.Text = "button32";
        //            this.mn4_14.UseVisualStyleBackColor = true;
        //            this.mn4_14.Click += new System.EventHandler(this.button32_Click);
        //            // 
        //            // mn4_13
        //            // 
        //            this.mn4_13.Location = new System.Drawing.Point(820, 151);
        //            this.mn4_13.Name = "mn4_13";
        //            this.mn4_13.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_13.TabIndex = 57;
        //            this.mn4_13.Text = "button33";
        //            this.mn4_13.UseVisualStyleBackColor = true;
        //            this.mn4_13.Click += new System.EventHandler(this.button33_Click);
        //            // 
        //            // mn4_12
        //            // 
        //            this.mn4_12.Location = new System.Drawing.Point(756, 151);
        //            this.mn4_12.Name = "mn4_12";
        //            this.mn4_12.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_12.TabIndex = 56;
        //            this.mn4_12.Text = "button34";
        //            this.mn4_12.UseVisualStyleBackColor = true;
        //            this.mn4_12.Click += new System.EventHandler(this.button34_Click);
        //            // 
        //            // mn4_11
        //            // 
        //            this.mn4_11.Location = new System.Drawing.Point(691, 151);
        //            this.mn4_11.Name = "mn4_11";
        //            this.mn4_11.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_11.TabIndex = 55;
        //            this.mn4_11.Text = "button35";
        //            this.mn4_11.UseVisualStyleBackColor = true;
        //            this.mn4_11.Click += new System.EventHandler(this.button35_Click);
        //            // 
        //            // mn4_10
        //            // 
        //            this.mn4_10.Location = new System.Drawing.Point(623, 151);
        //            this.mn4_10.Name = "mn4_10";
        //            this.mn4_10.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_10.TabIndex = 54;
        //            this.mn4_10.Text = "button36";
        //            this.mn4_10.UseVisualStyleBackColor = true;
        //            this.mn4_10.Click += new System.EventHandler(this.button36_Click);
        //            // 
        //            // mn4_9
        //            // 
        //            this.mn4_9.Location = new System.Drawing.Point(560, 151);
        //            this.mn4_9.Name = "mn4_9";
        //            this.mn4_9.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_9.TabIndex = 53;
        //            this.mn4_9.Text = "button37";
        //            this.mn4_9.UseVisualStyleBackColor = true;
        //            this.mn4_9.Click += new System.EventHandler(this.button37_Click);
        //            // 
        //            // mn4_8
        //            // 
        //            this.mn4_8.Location = new System.Drawing.Point(490, 151);
        //            this.mn4_8.Name = "mn4_8";
        //            this.mn4_8.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_8.TabIndex = 52;
        //            this.mn4_8.Text = "button38";
        //            this.mn4_8.UseVisualStyleBackColor = true;
        //            this.mn4_8.Click += new System.EventHandler(this.button38_Click);
        //            // 
        //            // mn4_7
        //            // 
        //            this.mn4_7.Location = new System.Drawing.Point(422, 151);
        //            this.mn4_7.Name = "mn4_7";
        //            this.mn4_7.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_7.TabIndex = 51;
        //            this.mn4_7.Text = "button39";
        //            this.mn4_7.UseVisualStyleBackColor = true;
        //            this.mn4_7.Click += new System.EventHandler(this.button39_Click);
        //            // 
        //            // mn4_6
        //            // 
        //            this.mn4_6.Location = new System.Drawing.Point(353, 151);
        //            this.mn4_6.Name = "mn4_6";
        //            this.mn4_6.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_6.TabIndex = 50;
        //            this.mn4_6.Text = "button40";
        //            this.mn4_6.UseVisualStyleBackColor = true;
        //            this.mn4_6.Click += new System.EventHandler(this.button40_Click);
        //            // 
        //            // mn4_5
        //            // 
        //            this.mn4_5.Location = new System.Drawing.Point(285, 151);
        //            this.mn4_5.Name = "mn4_5";
        //            this.mn4_5.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_5.TabIndex = 49;
        //            this.mn4_5.Text = "button41";
        //            this.mn4_5.UseVisualStyleBackColor = true;
        //            this.mn4_5.Click += new System.EventHandler(this.button41_Click);
        //            // 
        //            // mn4_4
        //            // 
        //            this.mn4_4.Location = new System.Drawing.Point(214, 151);
        //            this.mn4_4.Name = "mn4_4";
        //            this.mn4_4.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_4.TabIndex = 48;
        //            this.mn4_4.Text = "button42";
        //            this.mn4_4.UseVisualStyleBackColor = true;
        //            this.mn4_4.Click += new System.EventHandler(this.button42_Click);
        //            // 
        //            // mn4_3
        //            // 
        //            this.mn4_3.Location = new System.Drawing.Point(144, 151);
        //            this.mn4_3.Name = "mn4_3";
        //            this.mn4_3.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_3.TabIndex = 47;
        //            this.mn4_3.Text = "button43";
        //            this.mn4_3.UseVisualStyleBackColor = true;
        //            this.mn4_3.Click += new System.EventHandler(this.button43_Click);
        //            // 
        //            // mn4_2
        //            // 
        //            this.mn4_2.Location = new System.Drawing.Point(79, 151);
        //            this.mn4_2.Name = "mn4_2";
        //            this.mn4_2.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_2.TabIndex = 46;
        //            this.mn4_2.Text = "button44";
        //            this.mn4_2.UseVisualStyleBackColor = true;
        //            this.mn4_2.Click += new System.EventHandler(this.button44_Click);
        //            // 
        //            // mn4_1
        //            // 
        //            this.mn4_1.Location = new System.Drawing.Point(16, 151);
        //            this.mn4_1.Name = "mn4_1";
        //            this.mn4_1.Size = new System.Drawing.Size(19, 19);
        //            this.mn4_1.TabIndex = 45;
        //            this.mn4_1.Text = "button45";
        //            this.mn4_1.UseVisualStyleBackColor = true;
        //            this.mn4_1.Click += new System.EventHandler(this.button45_Click);
        //            // 
        //            // mn3_15
        //            // 
        //            this.mn3_15.Location = new System.Drawing.Point(954, 107);
        //            this.mn3_15.Name = "mn3_15";
        //            this.mn3_15.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_15.TabIndex = 44;
        //            this.mn3_15.Text = "button46";
        //            this.mn3_15.UseVisualStyleBackColor = true;
        //            this.mn3_15.Click += new System.EventHandler(this.button46_Click);
        //            // 
        //            // mn3_14
        //            // 
        //            this.mn3_14.Location = new System.Drawing.Point(887, 107);
        //            this.mn3_14.Name = "mn3_14";
        //            this.mn3_14.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_14.TabIndex = 43;
        //            this.mn3_14.Text = "button47";
        //            this.mn3_14.UseVisualStyleBackColor = true;
        //            this.mn3_14.Click += new System.EventHandler(this.button47_Click);
        //            // 
        //            // mn3_13
        //            // 
        //            this.mn3_13.Location = new System.Drawing.Point(820, 107);
        //            this.mn3_13.Name = "mn3_13";
        //            this.mn3_13.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_13.TabIndex = 42;
        //            this.mn3_13.Text = "button48";
        //            this.mn3_13.UseVisualStyleBackColor = true;
        //            this.mn3_13.Click += new System.EventHandler(this.button48_Click);
        //            // 
        //            // mn3_12
        //            // 
        //            this.mn3_12.Location = new System.Drawing.Point(756, 107);
        //            this.mn3_12.Name = "mn3_12";
        //            this.mn3_12.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_12.TabIndex = 41;
        //            this.mn3_12.Text = "button49";
        //            this.mn3_12.UseVisualStyleBackColor = true;
        //            this.mn3_12.Click += new System.EventHandler(this.button49_Click);
        //            // 
        //            // mn3_11
        //            // 
        //            this.mn3_11.Location = new System.Drawing.Point(691, 107);
        //            this.mn3_11.Name = "mn3_11";
        //            this.mn3_11.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_11.TabIndex = 40;
        //            this.mn3_11.Text = "button50";
        //            this.mn3_11.UseVisualStyleBackColor = true;
        //            this.mn3_11.Click += new System.EventHandler(this.button50_Click);
        //            // 
        //            // mn3_10
        //            // 
        //            this.mn3_10.Location = new System.Drawing.Point(623, 107);
        //            this.mn3_10.Name = "mn3_10";
        //            this.mn3_10.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_10.TabIndex = 39;
        //            this.mn3_10.Text = "button51";
        //            this.mn3_10.UseVisualStyleBackColor = true;
        //            this.mn3_10.Click += new System.EventHandler(this.button51_Click);
        //            // 
        //            // mn3_9
        //            // 
        //            this.mn3_9.Location = new System.Drawing.Point(560, 107);
        //            this.mn3_9.Name = "mn3_9";
        //            this.mn3_9.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_9.TabIndex = 38;
        //            this.mn3_9.Text = "button52";
        //            this.mn3_9.UseVisualStyleBackColor = true;
        //            this.mn3_9.Click += new System.EventHandler(this.button52_Click);
        //            // 
        //            // mn3_8
        //            // 
        //            this.mn3_8.Location = new System.Drawing.Point(490, 107);
        //            this.mn3_8.Name = "mn3_8";
        //            this.mn3_8.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_8.TabIndex = 37;
        //            this.mn3_8.Text = "button53";
        //            this.mn3_8.UseVisualStyleBackColor = true;
        //            this.mn3_8.Click += new System.EventHandler(this.button53_Click);
        //            // 
        //            // mn3_7
        //            // 
        //            this.mn3_7.Location = new System.Drawing.Point(422, 107);
        //            this.mn3_7.Name = "mn3_7";
        //            this.mn3_7.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_7.TabIndex = 36;
        //            this.mn3_7.Text = "button54";
        //            this.mn3_7.UseVisualStyleBackColor = true;
        //            this.mn3_7.Click += new System.EventHandler(this.button54_Click);
        //            // 
        //            // mn3_6
        //            // 
        //            this.mn3_6.Location = new System.Drawing.Point(353, 107);
        //            this.mn3_6.Name = "mn3_6";
        //            this.mn3_6.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_6.TabIndex = 35;
        //            this.mn3_6.Text = "button55";
        //            this.mn3_6.UseVisualStyleBackColor = true;
        //            this.mn3_6.Click += new System.EventHandler(this.button55_Click);
        //            // 
        //            // mn3_5
        //            // 
        //            this.mn3_5.Location = new System.Drawing.Point(285, 107);
        //            this.mn3_5.Name = "mn3_5";
        //            this.mn3_5.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_5.TabIndex = 34;
        //            this.mn3_5.Text = "button56";
        //            this.mn3_5.UseVisualStyleBackColor = true;
        //            this.mn3_5.Click += new System.EventHandler(this.button56_Click);
        //            // 
        //            // mn3_4
        //            // 
        //            this.mn3_4.Location = new System.Drawing.Point(214, 107);
        //            this.mn3_4.Name = "mn3_4";
        //            this.mn3_4.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_4.TabIndex = 33;
        //            this.mn3_4.Text = "button57";
        //            this.mn3_4.UseVisualStyleBackColor = true;
        //            this.mn3_4.Click += new System.EventHandler(this.button57_Click);
        //            // 
        //            // mn3_3
        //            // 
        //            this.mn3_3.Location = new System.Drawing.Point(144, 107);
        //            this.mn3_3.Name = "mn3_3";
        //            this.mn3_3.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_3.TabIndex = 32;
        //            this.mn3_3.Text = "button58";
        //            this.mn3_3.UseVisualStyleBackColor = true;
        //            this.mn3_3.Click += new System.EventHandler(this.button58_Click);
        //            // 
        //            // mn3_2
        //            // 
        //            this.mn3_2.Location = new System.Drawing.Point(79, 107);
        //            this.mn3_2.Name = "mn3_2";
        //            this.mn3_2.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_2.TabIndex = 31;
        //            this.mn3_2.Text = "button59";
        //            this.mn3_2.UseVisualStyleBackColor = true;
        //            this.mn3_2.Click += new System.EventHandler(this.button59_Click);
        //            // 
        //            // mn3_1
        //            // 
        //            this.mn3_1.Location = new System.Drawing.Point(16, 107);
        //            this.mn3_1.Name = "mn3_1";
        //            this.mn3_1.Size = new System.Drawing.Size(19, 19);
        //            this.mn3_1.TabIndex = 30;
        //            this.mn3_1.Text = "button60";
        //            this.mn3_1.UseVisualStyleBackColor = true;
        //            this.mn3_1.Click += new System.EventHandler(this.button60_Click);
        //            // 
        //            // button61
        //            // 
        //            this.button61.Location = new System.Drawing.Point(954, 322);
        //            this.button61.Name = "button61";
        //            this.button61.Size = new System.Drawing.Size(19, 19);
        //            this.button61.TabIndex = 119;
        //            this.button61.Text = "button61";
        //            this.button61.UseVisualStyleBackColor = true;
        //            this.button61.Click += new System.EventHandler(this.button61_Click);
        //            // 
        //            // button62
        //            // 
        //            this.button62.Location = new System.Drawing.Point(887, 322);
        //            this.button62.Name = "button62";
        //            this.button62.Size = new System.Drawing.Size(19, 19);
        //            this.button62.TabIndex = 118;
        //            this.button62.Text = "button62";
        //            this.button62.UseVisualStyleBackColor = true;
        //            this.button62.Click += new System.EventHandler(this.button62_Click);
        //            // 
        //            // button63
        //            // 
        //            this.button63.Location = new System.Drawing.Point(820, 322);
        //            this.button63.Name = "button63";
        //            this.button63.Size = new System.Drawing.Size(19, 19);
        //            this.button63.TabIndex = 117;
        //            this.button63.Text = "button63";
        //            this.button63.UseVisualStyleBackColor = true;
        //            this.button63.Click += new System.EventHandler(this.button63_Click);
        //            // 
        //            // button64
        //            // 
        //            this.button64.Location = new System.Drawing.Point(756, 322);
        //            this.button64.Name = "button64";
        //            this.button64.Size = new System.Drawing.Size(19, 19);
        //            this.button64.TabIndex = 116;
        //            this.button64.Text = "button64";
        //            this.button64.UseVisualStyleBackColor = true;
        //            this.button64.Click += new System.EventHandler(this.button64_Click);
        //            // 
        //            // button65
        //            // 
        //            this.button65.Location = new System.Drawing.Point(691, 322);
        //            this.button65.Name = "button65";
        //            this.button65.Size = new System.Drawing.Size(19, 19);
        //            this.button65.TabIndex = 115;
        //            this.button65.Text = "button65";
        //            this.button65.UseVisualStyleBackColor = true;
        //            this.button65.Click += new System.EventHandler(this.button65_Click);
        //            // 
        //            // button66
        //            // 
        //            this.button66.Location = new System.Drawing.Point(623, 322);
        //            this.button66.Name = "button66";
        //            this.button66.Size = new System.Drawing.Size(19, 19);
        //            this.button66.TabIndex = 114;
        //            this.button66.Text = "button66";
        //            this.button66.UseVisualStyleBackColor = true;
        //            this.button66.Click += new System.EventHandler(this.button66_Click);
        //            // 
        //            // button67
        //            // 
        //            this.button67.Location = new System.Drawing.Point(560, 322);
        //            this.button67.Name = "button67";
        //            this.button67.Size = new System.Drawing.Size(19, 19);
        //            this.button67.TabIndex = 113;
        //            this.button67.Text = "button67";
        //            this.button67.UseVisualStyleBackColor = true;
        //            this.button67.Click += new System.EventHandler(this.button67_Click);
        //            // 
        //            // button68
        //            // 
        //            this.button68.Location = new System.Drawing.Point(490, 322);
        //            this.button68.Name = "button68";
        //            this.button68.Size = new System.Drawing.Size(19, 19);
        //            this.button68.TabIndex = 112;
        //            this.button68.Text = "button68";
        //            this.button68.UseVisualStyleBackColor = true;
        //            this.button68.Click += new System.EventHandler(this.button68_Click);
        //            // 
        //            // button69
        //            // 
        //            this.button69.Location = new System.Drawing.Point(422, 322);
        //            this.button69.Name = "button69";
        //            this.button69.Size = new System.Drawing.Size(19, 19);
        //            this.button69.TabIndex = 111;
        //            this.button69.Text = "button69";
        //            this.button69.UseVisualStyleBackColor = true;
        //            this.button69.Click += new System.EventHandler(this.button69_Click);
        //            // 
        //            // button70
        //            // 
        //            this.button70.Location = new System.Drawing.Point(353, 322);
        //            this.button70.Name = "button70";
        //            this.button70.Size = new System.Drawing.Size(19, 19);
        //            this.button70.TabIndex = 110;
        //            this.button70.Text = "button70";
        //            this.button70.UseVisualStyleBackColor = true;
        //            this.button70.Click += new System.EventHandler(this.button70_Click);
        //            // 
        //            // button71
        //            // 
        //            this.button71.Location = new System.Drawing.Point(285, 322);
        //            this.button71.Name = "button71";
        //            this.button71.Size = new System.Drawing.Size(19, 19);
        //            this.button71.TabIndex = 109;
        //            this.button71.Text = "button71";
        //            this.button71.UseVisualStyleBackColor = true;
        //            this.button71.Click += new System.EventHandler(this.button71_Click);
        //            // 
        //            // button72
        //            // 
        //            this.button72.Location = new System.Drawing.Point(214, 322);
        //            this.button72.Name = "button72";
        //            this.button72.Size = new System.Drawing.Size(19, 19);
        //            this.button72.TabIndex = 108;
        //            this.button72.Text = "button72";
        //            this.button72.UseVisualStyleBackColor = true;
        //            this.button72.Click += new System.EventHandler(this.button72_Click);
        //            // 
        //            // button73
        //            // 
        //            this.button73.Location = new System.Drawing.Point(144, 322);
        //            this.button73.Name = "button73";
        //            this.button73.Size = new System.Drawing.Size(19, 19);
        //            this.button73.TabIndex = 107;
        //            this.button73.Text = "button73";
        //            this.button73.UseVisualStyleBackColor = true;
        //            this.button73.Click += new System.EventHandler(this.button73_Click);
        //            // 
        //            // button74
        //            // 
        //            this.button74.Location = new System.Drawing.Point(79, 322);
        //            this.button74.Name = "button74";
        //            this.button74.Size = new System.Drawing.Size(19, 19);
        //            this.button74.TabIndex = 106;
        //            this.button74.Text = "button74";
        //            this.button74.UseVisualStyleBackColor = true;
        //            this.button74.Click += new System.EventHandler(this.button74_Click);
        //            // 
        //            // button75
        //            // 
        //            this.button75.Location = new System.Drawing.Point(16, 322);
        //            this.button75.Name = "button75";
        //            this.button75.Size = new System.Drawing.Size(19, 19);
        //            this.button75.TabIndex = 105;
        //            this.button75.Text = "button75";
        //            this.button75.UseVisualStyleBackColor = true;
        //            this.button75.Click += new System.EventHandler(this.button75_Click);
        //            // 
        //            // button76
        //            // 
        //            this.button76.Location = new System.Drawing.Point(954, 278);
        //            this.button76.Name = "button76";
        //            this.button76.Size = new System.Drawing.Size(19, 19);
        //            this.button76.TabIndex = 104;
        //            this.button76.Text = "button76";
        //            this.button76.UseVisualStyleBackColor = true;
        //            this.button76.Click += new System.EventHandler(this.button76_Click);
        //            // 
        //            // button77
        //            // 
        //            this.button77.Location = new System.Drawing.Point(887, 278);
        //            this.button77.Name = "button77";
        //            this.button77.Size = new System.Drawing.Size(19, 19);
        //            this.button77.TabIndex = 103;
        //            this.button77.Text = "button77";
        //            this.button77.UseVisualStyleBackColor = true;
        //            this.button77.Click += new System.EventHandler(this.button77_Click);
        //            // 
        //            // button78
        //            // 
        //            this.button78.Location = new System.Drawing.Point(820, 278);
        //            this.button78.Name = "button78";
        //            this.button78.Size = new System.Drawing.Size(19, 19);
        //            this.button78.TabIndex = 102;
        //            this.button78.Text = "button78";
        //            this.button78.UseVisualStyleBackColor = true;
        //            this.button78.Click += new System.EventHandler(this.button78_Click);
        //            // 
        //            // button79
        //            // 
        //            this.button79.Location = new System.Drawing.Point(756, 278);
        //            this.button79.Name = "button79";
        //            this.button79.Size = new System.Drawing.Size(19, 19);
        //            this.button79.TabIndex = 101;
        //            this.button79.Text = "button79";
        //            this.button79.UseVisualStyleBackColor = true;
        //            this.button79.Click += new System.EventHandler(this.button79_Click);
        //            // 
        //            // button80
        //            // 
        //            this.button80.Location = new System.Drawing.Point(691, 278);
        //            this.button80.Name = "button80";
        //            this.button80.Size = new System.Drawing.Size(19, 19);
        //            this.button80.TabIndex = 100;
        //            this.button80.Text = "button80";
        //            this.button80.UseVisualStyleBackColor = true;
        //            this.button80.Click += new System.EventHandler(this.button80_Click);
        //            // 
        //            // button81
        //            // 
        //            this.button81.Location = new System.Drawing.Point(623, 278);
        //            this.button81.Name = "button81";
        //            this.button81.Size = new System.Drawing.Size(19, 19);
        //            this.button81.TabIndex = 99;
        //            this.button81.Text = "button81";
        //            this.button81.UseVisualStyleBackColor = true;
        //            this.button81.Click += new System.EventHandler(this.button81_Click);
        //            // 
        //            // button82
        //            // 
        //            this.button82.Location = new System.Drawing.Point(560, 278);
        //            this.button82.Name = "button82";
        //            this.button82.Size = new System.Drawing.Size(19, 19);
        //            this.button82.TabIndex = 98;
        //            this.button82.Text = "button82";
        //            this.button82.UseVisualStyleBackColor = true;
        //            this.button82.Click += new System.EventHandler(this.button82_Click);
        //            // 
        //            // button83
        //            // 
        //            this.button83.Location = new System.Drawing.Point(490, 278);
        //            this.button83.Name = "button83";
        //            this.button83.Size = new System.Drawing.Size(19, 19);
        //            this.button83.TabIndex = 97;
        //            this.button83.Text = "button83";
        //            this.button83.UseVisualStyleBackColor = true;
        //            this.button83.Click += new System.EventHandler(this.button83_Click);
        //            // 
        //            // button84
        //            // 
        //            this.button84.Location = new System.Drawing.Point(422, 278);
        //            this.button84.Name = "button84";
        //            this.button84.Size = new System.Drawing.Size(19, 19);
        //            this.button84.TabIndex = 96;
        //            this.button84.Text = "button84";
        //            this.button84.UseVisualStyleBackColor = true;
        //            this.button84.Click += new System.EventHandler(this.button84_Click);
        //            // 
        //            // button85
        //            // 
        //            this.button85.Location = new System.Drawing.Point(353, 278);
        //            this.button85.Name = "button85";
        //            this.button85.Size = new System.Drawing.Size(19, 19);
        //            this.button85.TabIndex = 95;
        //            this.button85.Text = "button85";
        //            this.button85.UseVisualStyleBackColor = true;
        //            this.button85.Click += new System.EventHandler(this.button85_Click);
        //            // 
        //            // button86
        //            // 
        //            this.button86.Location = new System.Drawing.Point(285, 278);
        //            this.button86.Name = "button86";
        //            this.button86.Size = new System.Drawing.Size(19, 19);
        //            this.button86.TabIndex = 94;
        //            this.button86.Text = "button86";
        //            this.button86.UseVisualStyleBackColor = true;
        //            this.button86.Click += new System.EventHandler(this.button86_Click);
        //            // 
        //            // button87
        //            // 
        //            this.button87.Location = new System.Drawing.Point(214, 278);
        //            this.button87.Name = "button87";
        //            this.button87.Size = new System.Drawing.Size(19, 19);
        //            this.button87.TabIndex = 93;
        //            this.button87.Text = "button87";
        //            this.button87.UseVisualStyleBackColor = true;
        //            this.button87.Click += new System.EventHandler(this.button87_Click);
        //            // 
        //            // button88
        //            // 
        //            this.button88.Location = new System.Drawing.Point(144, 278);
        //            this.button88.Name = "button88";
        //            this.button88.Size = new System.Drawing.Size(19, 19);
        //            this.button88.TabIndex = 92;
        //            this.button88.Text = "button88";
        //            this.button88.UseVisualStyleBackColor = true;
        //            this.button88.Click += new System.EventHandler(this.button88_Click);
        //            // 
        //            // button89
        //            // 
        //            this.button89.Location = new System.Drawing.Point(79, 278);
        //            this.button89.Name = "button89";
        //            this.button89.Size = new System.Drawing.Size(19, 19);
        //            this.button89.TabIndex = 91;
        //            this.button89.Text = "button89";
        //            this.button89.UseVisualStyleBackColor = true;
        //            this.button89.Click += new System.EventHandler(this.button89_Click);
        //            // 
        //            // button90
        //            // 
        //            this.button90.Location = new System.Drawing.Point(16, 278);
        //            this.button90.Name = "button90";
        //            this.button90.Size = new System.Drawing.Size(19, 19);
        //            this.button90.TabIndex = 90;
        //            this.button90.Text = "button90";
        //            this.button90.UseVisualStyleBackColor = true;
        //            this.button90.Click += new System.EventHandler(this.button90_Click);
        //            // 
        //            // button91
        //            // 
        //            this.button91.Location = new System.Drawing.Point(954, 236);
        //            this.button91.Name = "button91";
        //            this.button91.Size = new System.Drawing.Size(19, 19);
        //            this.button91.TabIndex = 89;
        //            this.button91.Text = "button91";
        //            this.button91.UseVisualStyleBackColor = true;
        //            this.button91.Click += new System.EventHandler(this.button91_Click);
        //            // 
        //            // button92
        //            // 
        //            this.button92.Location = new System.Drawing.Point(887, 236);
        //            this.button92.Name = "button92";
        //            this.button92.Size = new System.Drawing.Size(19, 19);
        //            this.button92.TabIndex = 88;
        //            this.button92.Text = "button92";
        //            this.button92.UseVisualStyleBackColor = true;
        //            this.button92.Click += new System.EventHandler(this.button92_Click);
        //            // 
        //            // button93
        //            // 
        //            this.button93.Location = new System.Drawing.Point(820, 236);
        //            this.button93.Name = "button93";
        //            this.button93.Size = new System.Drawing.Size(19, 19);
        //            this.button93.TabIndex = 87;
        //            this.button93.Text = "button93";
        //            this.button93.UseVisualStyleBackColor = true;
        //            this.button93.Click += new System.EventHandler(this.button93_Click);
        //            // 
        //            // button94
        //            // 
        //            this.button94.Location = new System.Drawing.Point(756, 236);
        //            this.button94.Name = "button94";
        //            this.button94.Size = new System.Drawing.Size(19, 19);
        //            this.button94.TabIndex = 86;
        //            this.button94.Text = "button94";
        //            this.button94.UseVisualStyleBackColor = true;
        //            this.button94.Click += new System.EventHandler(this.button94_Click);
        //            // 
        //            // button95
        //            // 
        //            this.button95.Location = new System.Drawing.Point(691, 236);
        //            this.button95.Name = "button95";
        //            this.button95.Size = new System.Drawing.Size(19, 19);
        //            this.button95.TabIndex = 85;
        //            this.button95.Text = "button95";
        //            this.button95.UseVisualStyleBackColor = true;
        //            this.button95.Click += new System.EventHandler(this.button95_Click);
        //            // 
        //            // button96
        //            // 
        //            this.button96.Location = new System.Drawing.Point(623, 236);
        //            this.button96.Name = "button96";
        //            this.button96.Size = new System.Drawing.Size(19, 19);
        //            this.button96.TabIndex = 84;
        //            this.button96.Text = "button96";
        //            this.button96.UseVisualStyleBackColor = true;
        //            this.button96.Click += new System.EventHandler(this.button96_Click);
        //            // 
        //            // button97
        //            // 
        //            this.button97.Location = new System.Drawing.Point(560, 236);
        //            this.button97.Name = "button97";
        //            this.button97.Size = new System.Drawing.Size(19, 19);
        //            this.button97.TabIndex = 83;
        //            this.button97.Text = "button97";
        //            this.button97.UseVisualStyleBackColor = true;
        //            this.button97.Click += new System.EventHandler(this.button97_Click);
        //            // 
        //            // button98
        //            // 
        //            this.button98.Location = new System.Drawing.Point(490, 236);
        //            this.button98.Name = "button98";
        //            this.button98.Size = new System.Drawing.Size(19, 19);
        //            this.button98.TabIndex = 82;
        //            this.button98.Text = "button98";
        //            this.button98.UseVisualStyleBackColor = true;
        //            this.button98.Click += new System.EventHandler(this.button98_Click);
        //            // 
        //            // button99
        //            // 
        //            this.button99.Location = new System.Drawing.Point(422, 236);
        //            this.button99.Name = "button99";
        //            this.button99.Size = new System.Drawing.Size(19, 19);
        //            this.button99.TabIndex = 81;
        //            this.button99.Text = "button99";
        //            this.button99.UseVisualStyleBackColor = true;
        //            this.button99.Click += new System.EventHandler(this.button99_Click);
        //            // 
        //            // button100
        //            // 
        //            this.button100.Location = new System.Drawing.Point(353, 236);
        //            this.button100.Name = "button100";
        //            this.button100.Size = new System.Drawing.Size(19, 19);
        //            this.button100.TabIndex = 80;
        //            this.button100.Text = "button100";
        //            this.button100.UseVisualStyleBackColor = true;
        //            this.button100.Click += new System.EventHandler(this.button100_Click);
        //            // 
        //            // button101
        //            // 
        //            this.button101.Location = new System.Drawing.Point(285, 236);
        //            this.button101.Name = "button101";
        //            this.button101.Size = new System.Drawing.Size(19, 19);
        //            this.button101.TabIndex = 79;
        //            this.button101.Text = "button101";
        //            this.button101.UseVisualStyleBackColor = true;
        //            this.button101.Click += new System.EventHandler(this.button101_Click);
        //            // 
        //            // button102
        //            // 
        //            this.button102.Location = new System.Drawing.Point(214, 236);
        //            this.button102.Name = "button102";
        //            this.button102.Size = new System.Drawing.Size(19, 19);
        //            this.button102.TabIndex = 78;
        //            this.button102.Text = "button102";
        //            this.button102.UseVisualStyleBackColor = true;
        //            this.button102.Click += new System.EventHandler(this.button102_Click);
        //            // 
        //            // mn6_3
        //            // 
        //            this.mn6_3.Location = new System.Drawing.Point(144, 236);
        //            this.mn6_3.Name = "mn6_3";
        //            this.mn6_3.Size = new System.Drawing.Size(19, 19);
        //            this.mn6_3.TabIndex = 77;
        //            this.mn6_3.Text = "button103";
        //            this.mn6_3.UseVisualStyleBackColor = true;
        //            this.mn6_3.Click += new System.EventHandler(this.button103_Click);
        //            // 
        //            // mn6_2
        //            // 
        //            this.mn6_2.Location = new System.Drawing.Point(79, 236);
        //            this.mn6_2.Name = "mn6_2";
        //            this.mn6_2.Size = new System.Drawing.Size(19, 19);
        //            this.mn6_2.TabIndex = 76;
        //            this.mn6_2.Text = "button104";
        //            this.mn6_2.UseVisualStyleBackColor = true;
        //            this.mn6_2.Click += new System.EventHandler(this.button104_Click);
        //            // 
        //            // mn6_1
        //            // 
        //            this.mn6_1.Location = new System.Drawing.Point(16, 236);
        //            this.mn6_1.Name = "mn6_1";
        //            this.mn6_1.Size = new System.Drawing.Size(19, 19);
        //            this.mn6_1.TabIndex = 75;
        //            this.mn6_1.Text = "button105";
        //            this.mn6_1.UseVisualStyleBackColor = true;
        //            this.mn6_1.Click += new System.EventHandler(this.button105_Click);
        //            // 
        //            // mn5_15
        //            // 
        //            this.mn5_15.Location = new System.Drawing.Point(954, 192);
        //            this.mn5_15.Name = "mn5_15";
        //            this.mn5_15.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_15.TabIndex = 74;
        //            this.mn5_15.Text = "button106";
        //            this.mn5_15.UseVisualStyleBackColor = true;
        //            this.mn5_15.Click += new System.EventHandler(this.button106_Click);
        //            // 
        //            // mn5_14
        //            // 
        //            this.mn5_14.Location = new System.Drawing.Point(887, 192);
        //            this.mn5_14.Name = "mn5_14";
        //            this.mn5_14.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_14.TabIndex = 73;
        //            this.mn5_14.Text = "button107";
        //            this.mn5_14.UseVisualStyleBackColor = true;
        //            this.mn5_14.Click += new System.EventHandler(this.button107_Click);
        //            // 
        //            // mn5_13
        //            // 
        //            this.mn5_13.Location = new System.Drawing.Point(820, 192);
        //            this.mn5_13.Name = "mn5_13";
        //            this.mn5_13.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_13.TabIndex = 72;
        //            this.mn5_13.Text = "button108";
        //            this.mn5_13.UseVisualStyleBackColor = true;
        //            this.mn5_13.Click += new System.EventHandler(this.button108_Click);
        //            // 
        //            // mn5_12
        //            // 
        //            this.mn5_12.Location = new System.Drawing.Point(756, 192);
        //            this.mn5_12.Name = "mn5_12";
        //            this.mn5_12.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_12.TabIndex = 71;
        //            this.mn5_12.Text = "button109";
        //            this.mn5_12.UseVisualStyleBackColor = true;
        //            this.mn5_12.Click += new System.EventHandler(this.button109_Click);
        //            // 
        //            // mn5_11
        //            // 
        //            this.mn5_11.Location = new System.Drawing.Point(691, 192);
        //            this.mn5_11.Name = "mn5_11";
        //            this.mn5_11.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_11.TabIndex = 70;
        //            this.mn5_11.Text = "button110";
        //            this.mn5_11.UseVisualStyleBackColor = true;
        //            this.mn5_11.Click += new System.EventHandler(this.button110_Click);
        //            // 
        //            // mn5_10
        //            // 
        //            this.mn5_10.Location = new System.Drawing.Point(623, 192);
        //            this.mn5_10.Name = "mn5_10";
        //            this.mn5_10.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_10.TabIndex = 69;
        //            this.mn5_10.Text = "button111";
        //            this.mn5_10.UseVisualStyleBackColor = true;
        //            this.mn5_10.Click += new System.EventHandler(this.button111_Click);
        //            // 
        //            // mn5_9
        //            // 
        //            this.mn5_9.Location = new System.Drawing.Point(560, 192);
        //            this.mn5_9.Name = "mn5_9";
        //            this.mn5_9.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_9.TabIndex = 68;
        //            this.mn5_9.Text = "button112";
        //            this.mn5_9.UseVisualStyleBackColor = true;
        //            this.mn5_9.Click += new System.EventHandler(this.button112_Click);
        //            // 
        //            // mn5_8
        //            // 
        //            this.mn5_8.Location = new System.Drawing.Point(490, 192);
        //            this.mn5_8.Name = "mn5_8";
        //            this.mn5_8.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_8.TabIndex = 67;
        //            this.mn5_8.Text = "button113";
        //            this.mn5_8.UseVisualStyleBackColor = true;
        //            this.mn5_8.Click += new System.EventHandler(this.button113_Click);
        //            // 
        //            // mn5_7
        //            // 
        //            this.mn5_7.Location = new System.Drawing.Point(422, 192);
        //            this.mn5_7.Name = "mn5_7";
        //            this.mn5_7.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_7.TabIndex = 66;
        //            this.mn5_7.Text = "button114";
        //            this.mn5_7.UseVisualStyleBackColor = true;
        //            this.mn5_7.Click += new System.EventHandler(this.button114_Click);
        //            // 
        //            // mn5_6
        //            // 
        //            this.mn5_6.Location = new System.Drawing.Point(353, 192);
        //            this.mn5_6.Name = "mn5_6";
        //            this.mn5_6.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_6.TabIndex = 65;
        //            this.mn5_6.Text = "button115";
        //            this.mn5_6.UseVisualStyleBackColor = true;
        //            this.mn5_6.Click += new System.EventHandler(this.button115_Click);
        //            // 
        //            // mn5_5
        //            // 
        //            this.mn5_5.Location = new System.Drawing.Point(285, 192);
        //            this.mn5_5.Name = "mn5_5";
        //            this.mn5_5.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_5.TabIndex = 64;
        //            this.mn5_5.Text = "button116";
        //            this.mn5_5.UseVisualStyleBackColor = true;
        //            this.mn5_5.Click += new System.EventHandler(this.button116_Click);
        //            // 
        //            // mn5_4
        //            // 
        //            this.mn5_4.Location = new System.Drawing.Point(214, 192);
        //            this.mn5_4.Name = "mn5_4";
        //            this.mn5_4.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_4.TabIndex = 63;
        //            this.mn5_4.Text = "button117";
        //            this.mn5_4.UseVisualStyleBackColor = true;
        //            this.mn5_4.Click += new System.EventHandler(this.button117_Click);
        //            // 
        //            // mn5_3
        //            // 
        //            this.mn5_3.Location = new System.Drawing.Point(144, 192);
        //            this.mn5_3.Name = "mn5_3";
        //            this.mn5_3.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_3.TabIndex = 62;
        //            this.mn5_3.Text = "button118";
        //            this.mn5_3.UseVisualStyleBackColor = true;
        //            this.mn5_3.Click += new System.EventHandler(this.button118_Click);
        //            // 
        //            // mn5_2
        //            // 
        //            this.mn5_2.Location = new System.Drawing.Point(79, 192);
        //            this.mn5_2.Name = "mn5_2";
        //            this.mn5_2.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_2.TabIndex = 61;
        //            this.mn5_2.Text = "button119";
        //            this.mn5_2.UseVisualStyleBackColor = true;
        //            this.mn5_2.Click += new System.EventHandler(this.button119_Click);
        //            // 
        //            // mn5_1
        //            // 
        //            this.mn5_1.Location = new System.Drawing.Point(16, 192);
        //            this.mn5_1.Name = "mn5_1";
        //            this.mn5_1.Size = new System.Drawing.Size(19, 19);
        //            this.mn5_1.TabIndex = 60;
        //            this.mn5_1.Text = "button120";
        //            this.mn5_1.UseVisualStyleBackColor = true;
        //            this.mn5_1.Click += new System.EventHandler(this.button120_Click);
        //            // 
        //            // button121
        //            // 
        //            this.button121.Location = new System.Drawing.Point(954, 615);
        //            this.button121.Name = "button121";
        //            this.button121.Size = new System.Drawing.Size(19, 19);
        //            this.button121.TabIndex = 224;
        //            this.button121.Text = "button121";
        //            this.button121.UseVisualStyleBackColor = true;
        //            this.button121.Click += new System.EventHandler(this.button121_Click);
        //            // 
        //            // button122
        //            // 
        //            this.button122.Location = new System.Drawing.Point(887, 615);
        //            this.button122.Name = "button122";
        //            this.button122.Size = new System.Drawing.Size(19, 19);
        //            this.button122.TabIndex = 223;
        //            this.button122.Text = "button122";
        //            this.button122.UseVisualStyleBackColor = true;
        //            this.button122.Click += new System.EventHandler(this.button122_Click);
        //            // 
        //            // button123
        //            // 
        //            this.button123.Location = new System.Drawing.Point(820, 615);
        //            this.button123.Name = "button123";
        //            this.button123.Size = new System.Drawing.Size(19, 19);
        //            this.button123.TabIndex = 222;
        //            this.button123.Text = "button123";
        //            this.button123.UseVisualStyleBackColor = true;
        //            this.button123.Click += new System.EventHandler(this.button123_Click);
        //            // 
        //            // button124
        //            // 
        //            this.button124.Location = new System.Drawing.Point(756, 615);
        //            this.button124.Name = "button124";
        //            this.button124.Size = new System.Drawing.Size(19, 19);
        //            this.button124.TabIndex = 221;
        //            this.button124.Text = "button124";
        //            this.button124.UseVisualStyleBackColor = true;
        //            this.button124.Click += new System.EventHandler(this.button124_Click);
        //            // 
        //            // button125
        //            // 
        //            this.button125.Location = new System.Drawing.Point(691, 615);
        //            this.button125.Name = "button125";
        //            this.button125.Size = new System.Drawing.Size(19, 19);
        //            this.button125.TabIndex = 220;
        //            this.button125.Text = "button125";
        //            this.button125.UseVisualStyleBackColor = true;
        //            this.button125.Click += new System.EventHandler(this.button125_Click);
        //            // 
        //            // button126
        //            // 
        //            this.button126.Location = new System.Drawing.Point(623, 615);
        //            this.button126.Name = "button126";
        //            this.button126.Size = new System.Drawing.Size(19, 19);
        //            this.button126.TabIndex = 219;
        //            this.button126.Text = "button126";
        //            this.button126.UseVisualStyleBackColor = true;
        //            this.button126.Click += new System.EventHandler(this.button126_Click);
        //            // 
        //            // button127
        //            // 
        //            this.button127.Location = new System.Drawing.Point(560, 615);
        //            this.button127.Name = "button127";
        //            this.button127.Size = new System.Drawing.Size(19, 19);
        //            this.button127.TabIndex = 218;
        //            this.button127.Text = "button127";
        //            this.button127.UseVisualStyleBackColor = true;
        //            this.button127.Click += new System.EventHandler(this.button127_Click);
        //            // 
        //            // button128
        //            // 
        //            this.button128.Location = new System.Drawing.Point(490, 615);
        //            this.button128.Name = "button128";
        //            this.button128.Size = new System.Drawing.Size(19, 19);
        //            this.button128.TabIndex = 217;
        //            this.button128.Text = "button128";
        //            this.button128.UseVisualStyleBackColor = true;
        //            this.button128.Click += new System.EventHandler(this.button128_Click);
        //            // 
        //            // button129
        //            // 
        //            this.button129.Location = new System.Drawing.Point(422, 615);
        //            this.button129.Name = "button129";
        //            this.button129.Size = new System.Drawing.Size(19, 19);
        //            this.button129.TabIndex = 216;
        //            this.button129.Text = "button129";
        //            this.button129.UseVisualStyleBackColor = true;
        //            this.button129.Click += new System.EventHandler(this.button129_Click);
        //            // 
        //            // button130
        //            // 
        //            this.button130.Location = new System.Drawing.Point(353, 615);
        //            this.button130.Name = "button130";
        //            this.button130.Size = new System.Drawing.Size(19, 19);
        //            this.button130.TabIndex = 215;
        //            this.button130.Text = "button130";
        //            this.button130.UseVisualStyleBackColor = true;
        //            this.button130.Click += new System.EventHandler(this.button130_Click);
        //            // 
        //            // button131
        //            // 
        //            this.button131.Location = new System.Drawing.Point(285, 615);
        //            this.button131.Name = "button131";
        //            this.button131.Size = new System.Drawing.Size(19, 19);
        //            this.button131.TabIndex = 214;
        //            this.button131.Text = "button131";
        //            this.button131.UseVisualStyleBackColor = true;
        //            this.button131.Click += new System.EventHandler(this.button131_Click);
        //            // 
        //            // button132
        //            // 
        //            this.button132.Location = new System.Drawing.Point(214, 615);
        //            this.button132.Name = "button132";
        //            this.button132.Size = new System.Drawing.Size(19, 19);
        //            this.button132.TabIndex = 213;
        //            this.button132.Text = "button132";
        //            this.button132.UseVisualStyleBackColor = true;
        //            this.button132.Click += new System.EventHandler(this.button132_Click);
        //            // 
        //            // button133
        //            // 
        //            this.button133.Location = new System.Drawing.Point(144, 615);
        //            this.button133.Name = "button133";
        //            this.button133.Size = new System.Drawing.Size(19, 19);
        //            this.button133.TabIndex = 212;
        //            this.button133.Text = "button133";
        //            this.button133.UseVisualStyleBackColor = true;
        //            this.button133.Click += new System.EventHandler(this.button133_Click);
        //            // 
        //            // button134
        //            // 
        //            this.button134.Location = new System.Drawing.Point(79, 615);
        //            this.button134.Name = "button134";
        //            this.button134.Size = new System.Drawing.Size(19, 19);
        //            this.button134.TabIndex = 211;
        //            this.button134.Text = "button134";
        //            this.button134.UseVisualStyleBackColor = true;
        //            this.button134.Click += new System.EventHandler(this.button134_Click);
        //            // 
        //            // button135
        //            // 
        //            this.button135.Location = new System.Drawing.Point(16, 615);
        //            this.button135.Name = "button135";
        //            this.button135.Size = new System.Drawing.Size(19, 19);
        //            this.button135.TabIndex = 210;
        //            this.button135.Text = "button135";
        //            this.button135.UseVisualStyleBackColor = true;
        //            this.button135.Click += new System.EventHandler(this.button135_Click);
        //            // 
        //            // button136
        //            // 
        //            this.button136.Location = new System.Drawing.Point(954, 573);
        //            this.button136.Name = "button136";
        //            this.button136.Size = new System.Drawing.Size(19, 19);
        //            this.button136.TabIndex = 209;
        //            this.button136.Text = "button136";
        //            this.button136.UseVisualStyleBackColor = true;
        //            this.button136.Click += new System.EventHandler(this.button136_Click);
        //            // 
        //            // button137
        //            // 
        //            this.button137.Location = new System.Drawing.Point(887, 573);
        //            this.button137.Name = "button137";
        //            this.button137.Size = new System.Drawing.Size(19, 19);
        //            this.button137.TabIndex = 208;
        //            this.button137.Text = "button137";
        //            this.button137.UseVisualStyleBackColor = true;
        //            this.button137.Click += new System.EventHandler(this.button137_Click);
        //            // 
        //            // button138
        //            // 
        //            this.button138.Location = new System.Drawing.Point(820, 573);
        //            this.button138.Name = "button138";
        //            this.button138.Size = new System.Drawing.Size(19, 19);
        //            this.button138.TabIndex = 207;
        //            this.button138.Text = "button138";
        //            this.button138.UseVisualStyleBackColor = true;
        //            this.button138.Click += new System.EventHandler(this.button138_Click);
        //            // 
        //            // button139
        //            // 
        //            this.button139.Location = new System.Drawing.Point(756, 573);
        //            this.button139.Name = "button139";
        //            this.button139.Size = new System.Drawing.Size(19, 19);
        //            this.button139.TabIndex = 206;
        //            this.button139.Text = "button139";
        //            this.button139.UseVisualStyleBackColor = true;
        //            this.button139.Click += new System.EventHandler(this.button139_Click);
        //            // 
        //            // button140
        //            // 
        //            this.button140.Location = new System.Drawing.Point(691, 573);
        //            this.button140.Name = "button140";
        //            this.button140.Size = new System.Drawing.Size(19, 19);
        //            this.button140.TabIndex = 205;
        //            this.button140.Text = "button140";
        //            this.button140.UseVisualStyleBackColor = true;
        //            this.button140.Click += new System.EventHandler(this.button140_Click);
        //            // 
        //            // button141
        //            // 
        //            this.button141.Location = new System.Drawing.Point(623, 573);
        //            this.button141.Name = "button141";
        //            this.button141.Size = new System.Drawing.Size(19, 19);
        //            this.button141.TabIndex = 204;
        //            this.button141.Text = "button141";
        //            this.button141.UseVisualStyleBackColor = true;
        //            this.button141.Click += new System.EventHandler(this.button141_Click);
        //            // 
        //            // button142
        //            // 
        //            this.button142.Location = new System.Drawing.Point(560, 573);
        //            this.button142.Name = "button142";
        //            this.button142.Size = new System.Drawing.Size(19, 19);
        //            this.button142.TabIndex = 203;
        //            this.button142.Text = "button142";
        //            this.button142.UseVisualStyleBackColor = true;
        //            this.button142.Click += new System.EventHandler(this.button142_Click);
        //            // 
        //            // button143
        //            // 
        //            this.button143.Location = new System.Drawing.Point(490, 573);
        //            this.button143.Name = "button143";
        //            this.button143.Size = new System.Drawing.Size(19, 19);
        //            this.button143.TabIndex = 202;
        //            this.button143.Text = "button143";
        //            this.button143.UseVisualStyleBackColor = true;
        //            this.button143.Click += new System.EventHandler(this.button143_Click);
        //            // 
        //            // button144
        //            // 
        //            this.button144.Location = new System.Drawing.Point(422, 573);
        //            this.button144.Name = "button144";
        //            this.button144.Size = new System.Drawing.Size(19, 19);
        //            this.button144.TabIndex = 201;
        //            this.button144.Text = "button144";
        //            this.button144.UseVisualStyleBackColor = true;
        //            this.button144.Click += new System.EventHandler(this.button144_Click);
        //            // 
        //            // button145
        //            // 
        //            this.button145.Location = new System.Drawing.Point(353, 573);
        //            this.button145.Name = "button145";
        //            this.button145.Size = new System.Drawing.Size(19, 19);
        //            this.button145.TabIndex = 200;
        //            this.button145.Text = "button145";
        //            this.button145.UseVisualStyleBackColor = true;
        //            this.button145.Click += new System.EventHandler(this.button145_Click);
        //            // 
        //            // button146
        //            // 
        //            this.button146.Location = new System.Drawing.Point(285, 573);
        //            this.button146.Name = "button146";
        //            this.button146.Size = new System.Drawing.Size(19, 19);
        //            this.button146.TabIndex = 199;
        //            this.button146.Text = "button146";
        //            this.button146.UseVisualStyleBackColor = true;
        //            this.button146.Click += new System.EventHandler(this.button146_Click);
        //            // 
        //            // button147
        //            // 
        //            this.button147.Location = new System.Drawing.Point(214, 573);
        //            this.button147.Name = "button147";
        //            this.button147.Size = new System.Drawing.Size(19, 19);
        //            this.button147.TabIndex = 198;
        //            this.button147.Text = "button147";
        //            this.button147.UseVisualStyleBackColor = true;
        //            this.button147.Click += new System.EventHandler(this.button147_Click);
        //            // 
        //            // button148
        //            // 
        //            this.button148.Location = new System.Drawing.Point(144, 573);
        //            this.button148.Name = "button148";
        //            this.button148.Size = new System.Drawing.Size(19, 19);
        //            this.button148.TabIndex = 197;
        //            this.button148.Text = "button148";
        //            this.button148.UseVisualStyleBackColor = true;
        //            this.button148.Click += new System.EventHandler(this.button148_Click);
        //            // 
        //            // button149
        //            // 
        //            this.button149.Location = new System.Drawing.Point(79, 573);
        //            this.button149.Name = "button149";
        //            this.button149.Size = new System.Drawing.Size(19, 19);
        //            this.button149.TabIndex = 196;
        //            this.button149.Text = "button149";
        //            this.button149.UseVisualStyleBackColor = true;
        //            this.button149.Click += new System.EventHandler(this.button149_Click);
        //            // 
        //            // button150
        //            // 
        //            this.button150.Location = new System.Drawing.Point(16, 573);
        //            this.button150.Name = "button150";
        //            this.button150.Size = new System.Drawing.Size(19, 19);
        //            this.button150.TabIndex = 195;
        //            this.button150.Text = "button150";
        //            this.button150.UseVisualStyleBackColor = true;
        //            this.button150.Click += new System.EventHandler(this.button150_Click);
        //            // 
        //            // button151
        //            // 
        //            this.button151.Location = new System.Drawing.Point(954, 529);
        //            this.button151.Name = "button151";
        //            this.button151.Size = new System.Drawing.Size(19, 19);
        //            this.button151.TabIndex = 194;
        //            this.button151.Text = "button151";
        //            this.button151.UseVisualStyleBackColor = true;
        //            this.button151.Click += new System.EventHandler(this.button151_Click);
        //            // 
        //            // button152
        //            // 
        //            this.button152.Location = new System.Drawing.Point(887, 529);
        //            this.button152.Name = "button152";
        //            this.button152.Size = new System.Drawing.Size(19, 19);
        //            this.button152.TabIndex = 193;
        //            this.button152.Text = "button152";
        //            this.button152.UseVisualStyleBackColor = true;
        //            this.button152.Click += new System.EventHandler(this.button152_Click);
        //            // 
        //            // button153
        //            // 
        //            this.button153.Location = new System.Drawing.Point(820, 529);
        //            this.button153.Name = "button153";
        //            this.button153.Size = new System.Drawing.Size(19, 19);
        //            this.button153.TabIndex = 192;
        //            this.button153.Text = "button153";
        //            this.button153.UseVisualStyleBackColor = true;
        //            this.button153.Click += new System.EventHandler(this.button153_Click);
        //            // 
        //            // button154
        //            // 
        //            this.button154.Location = new System.Drawing.Point(756, 529);
        //            this.button154.Name = "button154";
        //            this.button154.Size = new System.Drawing.Size(19, 19);
        //            this.button154.TabIndex = 191;
        //            this.button154.Text = "button154";
        //            this.button154.UseVisualStyleBackColor = true;
        //            this.button154.Click += new System.EventHandler(this.button154_Click);
        //            // 
        //            // button155
        //            // 
        //            this.button155.Location = new System.Drawing.Point(691, 529);
        //            this.button155.Name = "button155";
        //            this.button155.Size = new System.Drawing.Size(19, 19);
        //            this.button155.TabIndex = 190;
        //            this.button155.Text = "button155";
        //            this.button155.UseVisualStyleBackColor = true;
        //            this.button155.Click += new System.EventHandler(this.button155_Click);
        //            // 
        //            // button156
        //            // 
        //            this.button156.Location = new System.Drawing.Point(623, 529);
        //            this.button156.Name = "button156";
        //            this.button156.Size = new System.Drawing.Size(19, 19);
        //            this.button156.TabIndex = 189;
        //            this.button156.Text = "button156";
        //            this.button156.UseVisualStyleBackColor = true;
        //            this.button156.Click += new System.EventHandler(this.button156_Click);
        //            // 
        //            // button157
        //            // 
        //            this.button157.Location = new System.Drawing.Point(560, 529);
        //            this.button157.Name = "button157";
        //            this.button157.Size = new System.Drawing.Size(19, 19);
        //            this.button157.TabIndex = 188;
        //            this.button157.Text = "button157";
        //            this.button157.UseVisualStyleBackColor = true;
        //            this.button157.Click += new System.EventHandler(this.button157_Click);
        //            // 
        //            // button158
        //            // 
        //            this.button158.Location = new System.Drawing.Point(490, 529);
        //            this.button158.Name = "button158";
        //            this.button158.Size = new System.Drawing.Size(19, 19);
        //            this.button158.TabIndex = 187;
        //            this.button158.Text = "button158";
        //            this.button158.UseVisualStyleBackColor = true;
        //            this.button158.Click += new System.EventHandler(this.button158_Click);
        //            // 
        //            // button159
        //            // 
        //            this.button159.Location = new System.Drawing.Point(422, 529);
        //            this.button159.Name = "button159";
        //            this.button159.Size = new System.Drawing.Size(19, 19);
        //            this.button159.TabIndex = 186;
        //            this.button159.Text = "button159";
        //            this.button159.UseVisualStyleBackColor = true;
        //            this.button159.Click += new System.EventHandler(this.button159_Click);
        //            // 
        //            // button160
        //            // 
        //            this.button160.Location = new System.Drawing.Point(353, 529);
        //            this.button160.Name = "button160";
        //            this.button160.Size = new System.Drawing.Size(19, 19);
        //            this.button160.TabIndex = 185;
        //            this.button160.Text = "button160";
        //            this.button160.UseVisualStyleBackColor = true;
        //            this.button160.Click += new System.EventHandler(this.button160_Click);
        //            // 
        //            // button161
        //            // 
        //            this.button161.Location = new System.Drawing.Point(285, 529);
        //            this.button161.Name = "button161";
        //            this.button161.Size = new System.Drawing.Size(19, 19);
        //            this.button161.TabIndex = 184;
        //            this.button161.Text = "button161";
        //            this.button161.UseVisualStyleBackColor = true;
        //            this.button161.Click += new System.EventHandler(this.button161_Click);
        //            // 
        //            // button162
        //            // 
        //            this.button162.Location = new System.Drawing.Point(214, 529);
        //            this.button162.Name = "button162";
        //            this.button162.Size = new System.Drawing.Size(19, 19);
        //            this.button162.TabIndex = 183;
        //            this.button162.Text = "button162";
        //            this.button162.UseVisualStyleBackColor = true;
        //            this.button162.Click += new System.EventHandler(this.button162_Click);
        //            // 
        //            // button163
        //            // 
        //            this.button163.Location = new System.Drawing.Point(144, 529);
        //            this.button163.Name = "button163";
        //            this.button163.Size = new System.Drawing.Size(19, 19);
        //            this.button163.TabIndex = 182;
        //            this.button163.Text = "button163";
        //            this.button163.UseVisualStyleBackColor = true;
        //            this.button163.Click += new System.EventHandler(this.button163_Click);
        //            // 
        //            // button164
        //            // 
        //            this.button164.Location = new System.Drawing.Point(79, 529);
        //            this.button164.Name = "button164";
        //            this.button164.Size = new System.Drawing.Size(19, 19);
        //            this.button164.TabIndex = 181;
        //            this.button164.Text = "button164";
        //            this.button164.UseVisualStyleBackColor = true;
        //            this.button164.Click += new System.EventHandler(this.button164_Click);
        //            // 
        //            // button165
        //            // 
        //            this.button165.Location = new System.Drawing.Point(16, 529);
        //            this.button165.Name = "button165";
        //            this.button165.Size = new System.Drawing.Size(19, 19);
        //            this.button165.TabIndex = 180;
        //            this.button165.Text = "button165";
        //            this.button165.UseVisualStyleBackColor = true;
        //            this.button165.Click += new System.EventHandler(this.button165_Click);
        //            // 
        //            // button166
        //            // 
        //            this.button166.Location = new System.Drawing.Point(954, 488);
        //            this.button166.Name = "button166";
        //            this.button166.Size = new System.Drawing.Size(19, 19);
        //            this.button166.TabIndex = 179;
        //            this.button166.Text = "button166";
        //            this.button166.UseVisualStyleBackColor = true;
        //            this.button166.Click += new System.EventHandler(this.button166_Click);
        //            // 
        //            // button167
        //            // 
        //            this.button167.Location = new System.Drawing.Point(887, 488);
        //            this.button167.Name = "button167";
        //            this.button167.Size = new System.Drawing.Size(19, 19);
        //            this.button167.TabIndex = 178;
        //            this.button167.Text = "button167";
        //            this.button167.UseVisualStyleBackColor = true;
        //            this.button167.Click += new System.EventHandler(this.button167_Click);
        //            // 
        //            // button168
        //            // 
        //            this.button168.Location = new System.Drawing.Point(820, 488);
        //            this.button168.Name = "button168";
        //            this.button168.Size = new System.Drawing.Size(19, 19);
        //            this.button168.TabIndex = 177;
        //            this.button168.Text = "button168";
        //            this.button168.UseVisualStyleBackColor = true;
        //            this.button168.Click += new System.EventHandler(this.button168_Click);
        //            // 
        //            // button169
        //            // 
        //            this.button169.Location = new System.Drawing.Point(756, 488);
        //            this.button169.Name = "button169";
        //            this.button169.Size = new System.Drawing.Size(19, 19);
        //            this.button169.TabIndex = 176;
        //            this.button169.Text = "button169";
        //            this.button169.UseVisualStyleBackColor = true;
        //            this.button169.Click += new System.EventHandler(this.button169_Click);
        //            // 
        //            // button170
        //            // 
        //            this.button170.Location = new System.Drawing.Point(691, 488);
        //            this.button170.Name = "button170";
        //            this.button170.Size = new System.Drawing.Size(19, 19);
        //            this.button170.TabIndex = 175;
        //            this.button170.Text = "button170";
        //            this.button170.UseVisualStyleBackColor = true;
        //            this.button170.Click += new System.EventHandler(this.button170_Click);
        //            // 
        //            // button171
        //            // 
        //            this.button171.Location = new System.Drawing.Point(623, 488);
        //            this.button171.Name = "button171";
        //            this.button171.Size = new System.Drawing.Size(19, 19);
        //            this.button171.TabIndex = 174;
        //            this.button171.Text = "button171";
        //            this.button171.UseVisualStyleBackColor = true;
        //            this.button171.Click += new System.EventHandler(this.button171_Click);
        //            // 
        //            // button172
        //            // 
        //            this.button172.Location = new System.Drawing.Point(560, 488);
        //            this.button172.Name = "button172";
        //            this.button172.Size = new System.Drawing.Size(19, 19);
        //            this.button172.TabIndex = 173;
        //            this.button172.Text = "button172";
        //            this.button172.UseVisualStyleBackColor = true;
        //            this.button172.Click += new System.EventHandler(this.button172_Click);
        //            // 
        //            // button173
        //            // 
        //            this.button173.Location = new System.Drawing.Point(490, 488);
        //            this.button173.Name = "button173";
        //            this.button173.Size = new System.Drawing.Size(19, 19);
        //            this.button173.TabIndex = 172;
        //            this.button173.Text = "button173";
        //            this.button173.UseVisualStyleBackColor = true;
        //            this.button173.Click += new System.EventHandler(this.button173_Click);
        //            // 
        //            // button174
        //            // 
        //            this.button174.Location = new System.Drawing.Point(422, 488);
        //            this.button174.Name = "button174";
        //            this.button174.Size = new System.Drawing.Size(19, 19);
        //            this.button174.TabIndex = 171;
        //            this.button174.Text = "button174";
        //            this.button174.UseVisualStyleBackColor = true;
        //            this.button174.Click += new System.EventHandler(this.button174_Click);
        //            // 
        //            // button175
        //            // 
        //            this.button175.Location = new System.Drawing.Point(353, 488);
        //            this.button175.Name = "button175";
        //            this.button175.Size = new System.Drawing.Size(19, 19);
        //            this.button175.TabIndex = 170;
        //            this.button175.Text = "button175";
        //            this.button175.UseVisualStyleBackColor = true;
        //            this.button175.Click += new System.EventHandler(this.button175_Click);
        //            // 
        //            // button176
        //            // 
        //            this.button176.Location = new System.Drawing.Point(285, 488);
        //            this.button176.Name = "button176";
        //            this.button176.Size = new System.Drawing.Size(19, 19);
        //            this.button176.TabIndex = 169;
        //            this.button176.Text = "button176";
        //            this.button176.UseVisualStyleBackColor = true;
        //            this.button176.Click += new System.EventHandler(this.button176_Click);
        //            // 
        //            // button177
        //            // 
        //            this.button177.Location = new System.Drawing.Point(214, 488);
        //            this.button177.Name = "button177";
        //            this.button177.Size = new System.Drawing.Size(19, 19);
        //            this.button177.TabIndex = 168;
        //            this.button177.Text = "button177";
        //            this.button177.UseVisualStyleBackColor = true;
        //            this.button177.Click += new System.EventHandler(this.button177_Click);
        //            // 
        //            // button178
        //            // 
        //            this.button178.Location = new System.Drawing.Point(144, 488);
        //            this.button178.Name = "button178";
        //            this.button178.Size = new System.Drawing.Size(19, 19);
        //            this.button178.TabIndex = 167;
        //            this.button178.Text = "button178";
        //            this.button178.UseVisualStyleBackColor = true;
        //            this.button178.Click += new System.EventHandler(this.button178_Click);
        //            // 
        //            // button179
        //            // 
        //            this.button179.Location = new System.Drawing.Point(79, 488);
        //            this.button179.Name = "button179";
        //            this.button179.Size = new System.Drawing.Size(19, 19);
        //            this.button179.TabIndex = 166;
        //            this.button179.Text = "button179";
        //            this.button179.UseVisualStyleBackColor = true;
        //            this.button179.Click += new System.EventHandler(this.button179_Click);
        //            // 
        //            // button180
        //            // 
        //            this.button180.Location = new System.Drawing.Point(16, 488);
        //            this.button180.Name = "button180";
        //            this.button180.Size = new System.Drawing.Size(19, 19);
        //            this.button180.TabIndex = 165;
        //            this.button180.Text = "button180";
        //            this.button180.UseVisualStyleBackColor = true;
        //            this.button180.Click += new System.EventHandler(this.button180_Click);
        //            // 
        //            // button181
        //            // 
        //            this.button181.Location = new System.Drawing.Point(954, 444);
        //            this.button181.Name = "button181";
        //            this.button181.Size = new System.Drawing.Size(19, 19);
        //            this.button181.TabIndex = 164;
        //            this.button181.Text = "button181";
        //            this.button181.UseVisualStyleBackColor = true;
        //            this.button181.Click += new System.EventHandler(this.button181_Click);
        //            // 
        //            // button182
        //            // 
        //            this.button182.Location = new System.Drawing.Point(887, 444);
        //            this.button182.Name = "button182";
        //            this.button182.Size = new System.Drawing.Size(19, 19);
        //            this.button182.TabIndex = 163;
        //            this.button182.Text = "button182";
        //            this.button182.UseVisualStyleBackColor = true;
        //            this.button182.Click += new System.EventHandler(this.button182_Click);
        //            // 
        //            // button183
        //            // 
        //            this.button183.Location = new System.Drawing.Point(820, 444);
        //            this.button183.Name = "button183";
        //            this.button183.Size = new System.Drawing.Size(19, 19);
        //            this.button183.TabIndex = 162;
        //            this.button183.Text = "button183";
        //            this.button183.UseVisualStyleBackColor = true;
        //            this.button183.Click += new System.EventHandler(this.button183_Click);
        //            // 
        //            // button184
        //            // 
        //            this.button184.Location = new System.Drawing.Point(756, 444);
        //            this.button184.Name = "button184";
        //            this.button184.Size = new System.Drawing.Size(19, 19);
        //            this.button184.TabIndex = 161;
        //            this.button184.Text = "button184";
        //            this.button184.UseVisualStyleBackColor = true;
        //            this.button184.Click += new System.EventHandler(this.button184_Click);
        //            // 
        //            // button185
        //            // 
        //            this.button185.Location = new System.Drawing.Point(691, 444);
        //            this.button185.Name = "button185";
        //            this.button185.Size = new System.Drawing.Size(19, 19);
        //            this.button185.TabIndex = 160;
        //            this.button185.Text = "button185";
        //            this.button185.UseVisualStyleBackColor = true;
        //            this.button185.Click += new System.EventHandler(this.button185_Click);
        //            // 
        //            // button186
        //            // 
        //            this.button186.Location = new System.Drawing.Point(623, 444);
        //            this.button186.Name = "button186";
        //            this.button186.Size = new System.Drawing.Size(19, 19);
        //            this.button186.TabIndex = 159;
        //            this.button186.Text = "button186";
        //            this.button186.UseVisualStyleBackColor = true;
        //            this.button186.Click += new System.EventHandler(this.button186_Click);
        //            // 
        //            // button187
        //            // 
        //            this.button187.Location = new System.Drawing.Point(560, 444);
        //            this.button187.Name = "button187";
        //            this.button187.Size = new System.Drawing.Size(19, 19);
        //            this.button187.TabIndex = 158;
        //            this.button187.Text = "button187";
        //            this.button187.UseVisualStyleBackColor = true;
        //            this.button187.Click += new System.EventHandler(this.button187_Click);
        //            // 
        //            // button188
        //            // 
        //            this.button188.Location = new System.Drawing.Point(490, 444);
        //            this.button188.Name = "button188";
        //            this.button188.Size = new System.Drawing.Size(19, 19);
        //            this.button188.TabIndex = 157;
        //            this.button188.Text = "button188";
        //            this.button188.UseVisualStyleBackColor = true;
        //            this.button188.Click += new System.EventHandler(this.button188_Click);
        //            // 
        //            // button189
        //            // 
        //            this.button189.Location = new System.Drawing.Point(422, 444);
        //            this.button189.Name = "button189";
        //            this.button189.Size = new System.Drawing.Size(19, 19);
        //            this.button189.TabIndex = 156;
        //            this.button189.Text = "button189";
        //            this.button189.UseVisualStyleBackColor = true;
        //            this.button189.Click += new System.EventHandler(this.button189_Click);
        //            // 
        //            // button190
        //            // 
        //            this.button190.Location = new System.Drawing.Point(353, 444);
        //            this.button190.Name = "button190";
        //            this.button190.Size = new System.Drawing.Size(19, 19);
        //            this.button190.TabIndex = 155;
        //            this.button190.Text = "button190";
        //            this.button190.UseVisualStyleBackColor = true;
        //            this.button190.Click += new System.EventHandler(this.button190_Click);
        //            // 
        //            // button191
        //            // 
        //            this.button191.Location = new System.Drawing.Point(285, 444);
        //            this.button191.Name = "button191";
        //            this.button191.Size = new System.Drawing.Size(19, 19);
        //            this.button191.TabIndex = 154;
        //            this.button191.Text = "button191";
        //            this.button191.UseVisualStyleBackColor = true;
        //            this.button191.Click += new System.EventHandler(this.button191_Click);
        //            // 
        //            // button192
        //            // 
        //            this.button192.Location = new System.Drawing.Point(214, 444);
        //            this.button192.Name = "button192";
        //            this.button192.Size = new System.Drawing.Size(19, 19);
        //            this.button192.TabIndex = 153;
        //            this.button192.Text = "button192";
        //            this.button192.UseVisualStyleBackColor = true;
        //            this.button192.Click += new System.EventHandler(this.button192_Click);
        //            // 
        //            // button193
        //            // 
        //            this.button193.Location = new System.Drawing.Point(144, 444);
        //            this.button193.Name = "button193";
        //            this.button193.Size = new System.Drawing.Size(19, 19);
        //            this.button193.TabIndex = 152;
        //            this.button193.Text = "button193";
        //            this.button193.UseVisualStyleBackColor = true;
        //            this.button193.Click += new System.EventHandler(this.button193_Click);
        //            // 
        //            // button194
        //            // 
        //            this.button194.Location = new System.Drawing.Point(79, 444);
        //            this.button194.Name = "button194";
        //            this.button194.Size = new System.Drawing.Size(19, 19);
        //            this.button194.TabIndex = 151;
        //            this.button194.Text = "button194";
        //            this.button194.UseVisualStyleBackColor = true;
        //            this.button194.Click += new System.EventHandler(this.button194_Click);
        //            // 
        //            // button195
        //            // 
        //            this.button195.Location = new System.Drawing.Point(16, 444);
        //            this.button195.Name = "button195";
        //            this.button195.Size = new System.Drawing.Size(19, 19);
        //            this.button195.TabIndex = 150;
        //            this.button195.Text = "button195";
        //            this.button195.UseVisualStyleBackColor = true;
        //            this.button195.Click += new System.EventHandler(this.button195_Click);
        //            // 
        //            // button196
        //            // 
        //            this.button196.Location = new System.Drawing.Point(954, 402);
        //            this.button196.Name = "button196";
        //            this.button196.Size = new System.Drawing.Size(19, 19);
        //            this.button196.TabIndex = 149;
        //            this.button196.Text = "button196";
        //            this.button196.UseVisualStyleBackColor = true;
        //            this.button196.Click += new System.EventHandler(this.button196_Click);
        //            // 
        //            // button197
        //            // 
        //            this.button197.Location = new System.Drawing.Point(887, 402);
        //            this.button197.Name = "button197";
        //            this.button197.Size = new System.Drawing.Size(19, 19);
        //            this.button197.TabIndex = 148;
        //            this.button197.Text = "button197";
        //            this.button197.UseVisualStyleBackColor = true;
        //            this.button197.Click += new System.EventHandler(this.button197_Click);
        //            // 
        //            // button198
        //            // 
        //            this.button198.Location = new System.Drawing.Point(820, 402);
        //            this.button198.Name = "button198";
        //            this.button198.Size = new System.Drawing.Size(19, 19);
        //            this.button198.TabIndex = 147;
        //            this.button198.Text = "button198";
        //            this.button198.UseVisualStyleBackColor = true;
        //            this.button198.Click += new System.EventHandler(this.button198_Click);
        //            // 
        //            // button199
        //            // 
        //            this.button199.Location = new System.Drawing.Point(756, 402);
        //            this.button199.Name = "button199";
        //            this.button199.Size = new System.Drawing.Size(19, 19);
        //            this.button199.TabIndex = 146;
        //            this.button199.Text = "button199";
        //            this.button199.UseVisualStyleBackColor = true;
        //            this.button199.Click += new System.EventHandler(this.button199_Click);
        //            // 
        //            // button200
        //            // 
        //            this.button200.Location = new System.Drawing.Point(691, 402);
        //            this.button200.Name = "button200";
        //            this.button200.Size = new System.Drawing.Size(19, 19);
        //            this.button200.TabIndex = 145;
        //            this.button200.Text = "button200";
        //            this.button200.UseVisualStyleBackColor = true;
        //            this.button200.Click += new System.EventHandler(this.button200_Click);
        //            // 
        //            // button201
        //            // 
        //            this.button201.Location = new System.Drawing.Point(623, 402);
        //            this.button201.Name = "button201";
        //            this.button201.Size = new System.Drawing.Size(19, 19);
        //            this.button201.TabIndex = 144;
        //            this.button201.Text = "button201";
        //            this.button201.UseVisualStyleBackColor = true;
        //            this.button201.Click += new System.EventHandler(this.button201_Click);
        //            // 
        //            // button202
        //            // 
        //            this.button202.Location = new System.Drawing.Point(560, 402);
        //            this.button202.Name = "button202";
        //            this.button202.Size = new System.Drawing.Size(19, 19);
        //            this.button202.TabIndex = 143;
        //            this.button202.Text = "button202";
        //            this.button202.UseVisualStyleBackColor = true;
        //            this.button202.Click += new System.EventHandler(this.button202_Click);
        //            // 
        //            // button203
        //            // 
        //            this.button203.Location = new System.Drawing.Point(490, 402);
        //            this.button203.Name = "button203";
        //            this.button203.Size = new System.Drawing.Size(19, 19);
        //            this.button203.TabIndex = 142;
        //            this.button203.Text = "button203";
        //            this.button203.UseVisualStyleBackColor = true;
        //            this.button203.Click += new System.EventHandler(this.button203_Click);
        //            // 
        //            // button204
        //            // 
        //            this.button204.Location = new System.Drawing.Point(422, 402);
        //            this.button204.Name = "button204";
        //            this.button204.Size = new System.Drawing.Size(19, 19);
        //            this.button204.TabIndex = 141;
        //            this.button204.Text = "button204";
        //            this.button204.UseVisualStyleBackColor = true;
        //            this.button204.Click += new System.EventHandler(this.button204_Click);
        //            // 
        //            // button205
        //            // 
        //            this.button205.Location = new System.Drawing.Point(353, 402);
        //            this.button205.Name = "button205";
        //            this.button205.Size = new System.Drawing.Size(19, 19);
        //            this.button205.TabIndex = 140;
        //            this.button205.Text = "button205";
        //            this.button205.UseVisualStyleBackColor = true;
        //            this.button205.Click += new System.EventHandler(this.button205_Click);
        //            // 
        //            // button206
        //            // 
        //            this.button206.Location = new System.Drawing.Point(285, 402);
        //            this.button206.Name = "button206";
        //            this.button206.Size = new System.Drawing.Size(19, 19);
        //            this.button206.TabIndex = 139;
        //            this.button206.Text = "button206";
        //            this.button206.UseVisualStyleBackColor = true;
        //            this.button206.Click += new System.EventHandler(this.button206_Click);
        //            // 
        //            // button207
        //            // 
        //            this.button207.Location = new System.Drawing.Point(214, 402);
        //            this.button207.Name = "button207";
        //            this.button207.Size = new System.Drawing.Size(19, 19);
        //            this.button207.TabIndex = 138;
        //            this.button207.Text = "button207";
        //            this.button207.UseVisualStyleBackColor = true;
        //            this.button207.Click += new System.EventHandler(this.button207_Click);
        //            // 
        //            // button208
        //            // 
        //            this.button208.Location = new System.Drawing.Point(144, 402);
        //            this.button208.Name = "button208";
        //            this.button208.Size = new System.Drawing.Size(19, 19);
        //            this.button208.TabIndex = 137;
        //            this.button208.Text = "button208";
        //            this.button208.UseVisualStyleBackColor = true;
        //            this.button208.Click += new System.EventHandler(this.button208_Click);
        //            // 
        //            // button209
        //            // 
        //            this.button209.Location = new System.Drawing.Point(79, 402);
        //            this.button209.Name = "button209";
        //            this.button209.Size = new System.Drawing.Size(19, 19);
        //            this.button209.TabIndex = 136;
        //            this.button209.Text = "button209";
        //            this.button209.UseVisualStyleBackColor = true;
        //            this.button209.Click += new System.EventHandler(this.button209_Click);
        //            // 
        //            // button210
        //            // 
        //            this.button210.Location = new System.Drawing.Point(16, 402);
        //            this.button210.Name = "button210";
        //            this.button210.Size = new System.Drawing.Size(19, 19);
        //            this.button210.TabIndex = 135;
        //            this.button210.Text = "button210";
        //            this.button210.UseVisualStyleBackColor = true;
        //            this.button210.Click += new System.EventHandler(this.button210_Click);
        //            // 
        //            // button211
        //            // 
        //            this.button211.Location = new System.Drawing.Point(954, 358);
        //            this.button211.Name = "button211";
        //            this.button211.Size = new System.Drawing.Size(19, 19);
        //            this.button211.TabIndex = 134;
        //            this.button211.Text = "button211";
        //            this.button211.UseVisualStyleBackColor = true;
        //            this.button211.Click += new System.EventHandler(this.button211_Click);
        //            // 
        //            // button212
        //            // 
        //            this.button212.Location = new System.Drawing.Point(887, 358);
        //            this.button212.Name = "button212";
        //            this.button212.Size = new System.Drawing.Size(19, 19);
        //            this.button212.TabIndex = 133;
        //            this.button212.Text = "button212";
        //            this.button212.UseVisualStyleBackColor = true;
        //            this.button212.Click += new System.EventHandler(this.button212_Click);
        //            // 
        //            // button213
        //            // 
        //            this.button213.Location = new System.Drawing.Point(820, 358);
        //            this.button213.Name = "button213";
        //            this.button213.Size = new System.Drawing.Size(19, 19);
        //            this.button213.TabIndex = 132;
        //            this.button213.Text = "button213";
        //            this.button213.UseVisualStyleBackColor = true;
        //            this.button213.Click += new System.EventHandler(this.button213_Click);
        //            // 
        //            // button214
        //            // 
        //            this.button214.Location = new System.Drawing.Point(756, 358);
        //            this.button214.Name = "button214";
        //            this.button214.Size = new System.Drawing.Size(19, 19);
        //            this.button214.TabIndex = 131;
        //            this.button214.Text = "button214";
        //            this.button214.UseVisualStyleBackColor = true;
        //            this.button214.Click += new System.EventHandler(this.button214_Click);
        //            // 
        //            // button215
        //            // 
        //            this.button215.Location = new System.Drawing.Point(691, 358);
        //            this.button215.Name = "button215";
        //            this.button215.Size = new System.Drawing.Size(19, 19);
        //            this.button215.TabIndex = 130;
        //            this.button215.Text = "button215";
        //            this.button215.UseVisualStyleBackColor = true;
        //            this.button215.Click += new System.EventHandler(this.button215_Click);
        //            // 
        //            // button216
        //            // 
        //            this.button216.Location = new System.Drawing.Point(623, 358);
        //            this.button216.Name = "button216";
        //            this.button216.Size = new System.Drawing.Size(19, 19);
        //            this.button216.TabIndex = 129;
        //            this.button216.Text = "button216";
        //            this.button216.UseVisualStyleBackColor = true;
        //            this.button216.Click += new System.EventHandler(this.button216_Click);
        //            // 
        //            // button217
        //            // 
        //            this.button217.Location = new System.Drawing.Point(560, 358);
        //            this.button217.Name = "button217";
        //            this.button217.Size = new System.Drawing.Size(19, 19);
        //            this.button217.TabIndex = 128;
        //            this.button217.Text = "button217";
        //            this.button217.UseVisualStyleBackColor = true;
        //            this.button217.Click += new System.EventHandler(this.button217_Click);
        //            // 
        //            // button218
        //            // 
        //            this.button218.Location = new System.Drawing.Point(490, 358);
        //            this.button218.Name = "button218";
        //            this.button218.Size = new System.Drawing.Size(19, 19);
        //            this.button218.TabIndex = 127;
        //            this.button218.Text = "button218";
        //            this.button218.UseVisualStyleBackColor = true;
        //            this.button218.Click += new System.EventHandler(this.button218_Click);
        //            // 
        //            // button219
        //            // 
        //            this.button219.Location = new System.Drawing.Point(422, 358);
        //            this.button219.Name = "button219";
        //            this.button219.Size = new System.Drawing.Size(19, 19);
        //            this.button219.TabIndex = 126;
        //            this.button219.Text = "button219";
        //            this.button219.UseVisualStyleBackColor = true;
        //            this.button219.Click += new System.EventHandler(this.button219_Click);
        //            // 
        //            // button220
        //            // 
        //            this.button220.Location = new System.Drawing.Point(353, 358);
        //            this.button220.Name = "button220";
        //            this.button220.Size = new System.Drawing.Size(19, 19);
        //            this.button220.TabIndex = 125;
        //            this.button220.Text = "button220";
        //            this.button220.UseVisualStyleBackColor = true;
        //            this.button220.Click += new System.EventHandler(this.button220_Click);
        //            // 
        //            // button221
        //            // 
        //            this.button221.Location = new System.Drawing.Point(285, 358);
        //            this.button221.Name = "button221";
        //            this.button221.Size = new System.Drawing.Size(19, 19);
        //            this.button221.TabIndex = 124;
        //            this.button221.Text = "button221";
        //            this.button221.UseVisualStyleBackColor = true;
        //            this.button221.Click += new System.EventHandler(this.button221_Click);
        //            // 
        //            // button222
        //            // 
        //            this.button222.Location = new System.Drawing.Point(214, 358);
        //            this.button222.Name = "button222";
        //            this.button222.Size = new System.Drawing.Size(19, 19);
        //            this.button222.TabIndex = 123;
        //            this.button222.Text = "button222";
        //            this.button222.UseVisualStyleBackColor = true;
        //            this.button222.Click += new System.EventHandler(this.button222_Click);
        //            // 
        //            // button223
        //            // 
        //            this.button223.Location = new System.Drawing.Point(144, 358);
        //            this.button223.Name = "button223";
        //            this.button223.Size = new System.Drawing.Size(19, 19);
        //            this.button223.TabIndex = 122;
        //            this.button223.Text = "button223";
        //            this.button223.UseVisualStyleBackColor = true;
        //            this.button223.Click += new System.EventHandler(this.button223_Click);
        //            // 
        //            // button224
        //            // 
        //            this.button224.Location = new System.Drawing.Point(79, 358);
        //            this.button224.Name = "button224";
        //            this.button224.Size = new System.Drawing.Size(19, 19);
        //            this.button224.TabIndex = 121;
        //            this.button224.Text = "button224";
        //            this.button224.UseVisualStyleBackColor = true;
        //            this.button224.Click += new System.EventHandler(this.button224_Click);
        //            // 
        //            // button225
        //            // 
        //            this.button225.Cursor = System.Windows.Forms.Cursors.No;
        //            this.button225.Location = new System.Drawing.Point(16, 358);
        //            this.button225.Name = "button225";
        //            this.button225.Size = new System.Drawing.Size(19, 19);
        //            this.button225.TabIndex = 120;
        //            this.button225.Text = "button225";
        //            this.button225.UseVisualStyleBackColor = true;
        //            this.button225.Click += new System.EventHandler(this.button225_Click);
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
        //            this.Controls.Add(this.button122);
        //            this.Controls.Add(this.button123);
        //            this.Controls.Add(this.button124);
        //            this.Controls.Add(this.button125);
        //            this.Controls.Add(this.button126);
        //            this.Controls.Add(this.button127);
        //            this.Controls.Add(this.button128);
        //            this.Controls.Add(this.button129);
        //            this.Controls.Add(this.button130);
        //            this.Controls.Add(this.button131);
        //            this.Controls.Add(this.button132);
        //            this.Controls.Add(this.button133);
        //            this.Controls.Add(this.button134);
        //            this.Controls.Add(this.button135);
        //            this.Controls.Add(this.button136);
        //            this.Controls.Add(this.button137);
        //            this.Controls.Add(this.button138);
        //            this.Controls.Add(this.button139);
        //            this.Controls.Add(this.button140);
        //            this.Controls.Add(this.button141);
        //            this.Controls.Add(this.button142);
        //            this.Controls.Add(this.button143);
        //            this.Controls.Add(this.button144);
        //            this.Controls.Add(this.button145);
        //            this.Controls.Add(this.button146);
        //            this.Controls.Add(this.button147);
        //            this.Controls.Add(this.button148);
        //            this.Controls.Add(this.button149);
        //            this.Controls.Add(this.button150);
        //            this.Controls.Add(this.button151);
        //            this.Controls.Add(this.button152);
        //            this.Controls.Add(this.button153);
        //            this.Controls.Add(this.button154);
        //            this.Controls.Add(this.button155);
        //            this.Controls.Add(this.button156);
        //            this.Controls.Add(this.button157);
        //            this.Controls.Add(this.button158);
        //            this.Controls.Add(this.button159);
        //            this.Controls.Add(this.button160);
        //            this.Controls.Add(this.button161);
        //            this.Controls.Add(this.button162);
        //            this.Controls.Add(this.button163);
        //            this.Controls.Add(this.button164);
        //            this.Controls.Add(this.button165);
        //            this.Controls.Add(this.button166);
        //            this.Controls.Add(this.button167);
        //            this.Controls.Add(this.button168);
        //            this.Controls.Add(this.button169);
        //            this.Controls.Add(this.button170);
        //            this.Controls.Add(this.button171);
        //            this.Controls.Add(this.button172);
        //            this.Controls.Add(this.button173);
        //            this.Controls.Add(this.button174);
        //            this.Controls.Add(this.button175);
        //            this.Controls.Add(this.button176);
        //            this.Controls.Add(this.button177);
        //            this.Controls.Add(this.button178);
        //            this.Controls.Add(this.button179);
        //            this.Controls.Add(this.button180);
        //            this.Controls.Add(this.button181);
        //            this.Controls.Add(this.button182);
        //            this.Controls.Add(this.button183);
        //            this.Controls.Add(this.button184);
        //            this.Controls.Add(this.button185);
        //            this.Controls.Add(this.button186);
        //            this.Controls.Add(this.button187);
        //            this.Controls.Add(this.button188);
        //            this.Controls.Add(this.button189);
        //            this.Controls.Add(this.button190);
        //            this.Controls.Add(this.button191);
        //            this.Controls.Add(this.button192);
        //            this.Controls.Add(this.button193);
        //            this.Controls.Add(this.button194);
        //            this.Controls.Add(this.button195);
        //            this.Controls.Add(this.button196);
        //            this.Controls.Add(this.button197);
        //            this.Controls.Add(this.button198);
        //            this.Controls.Add(this.button199);
        //            this.Controls.Add(this.button200);
        //            this.Controls.Add(this.button201);
        //            this.Controls.Add(this.button202);
        //            this.Controls.Add(this.button203);
        //            this.Controls.Add(this.button204);
        //            this.Controls.Add(this.button205);
        //            this.Controls.Add(this.button206);
        //            this.Controls.Add(this.button207);
        //            this.Controls.Add(this.button208);
        //            this.Controls.Add(this.button209);
        //            this.Controls.Add(this.button210);
        //            this.Controls.Add(this.button211);
        //            this.Controls.Add(this.button212);
        //            this.Controls.Add(this.button213);
        //            this.Controls.Add(this.button214);
        //            this.Controls.Add(this.button215);
        //            this.Controls.Add(this.button216);
        //            this.Controls.Add(this.button217);
        //            this.Controls.Add(this.button218);
        //            this.Controls.Add(this.button219);
        //            this.Controls.Add(this.button220);
        //            this.Controls.Add(this.button221);
        //            this.Controls.Add(this.button222);
        //            this.Controls.Add(this.button223);
        //            this.Controls.Add(this.button224);
        //            this.Controls.Add(this.button225);
        //            this.Controls.Add(this.button61);
        //            this.Controls.Add(this.button62);
        //            this.Controls.Add(this.button63);
        //            this.Controls.Add(this.button64);
        //            this.Controls.Add(this.button65);
        //            this.Controls.Add(this.button66);
        //            this.Controls.Add(this.button67);
        //            this.Controls.Add(this.button68);
        //            this.Controls.Add(this.button69);
        //            this.Controls.Add(this.button70);
        //            this.Controls.Add(this.button71);
        //            this.Controls.Add(this.button72);
        //            this.Controls.Add(this.button73);
        //            this.Controls.Add(this.button74);
        //            this.Controls.Add(this.button75);
        //            this.Controls.Add(this.button76);
        //            this.Controls.Add(this.button77);
        //            this.Controls.Add(this.button78);
        //            this.Controls.Add(this.button79);
        //            this.Controls.Add(this.button80);
        //            this.Controls.Add(this.button81);
        //            this.Controls.Add(this.button82);
        //            this.Controls.Add(this.button83);
        //            this.Controls.Add(this.button84);
        //            this.Controls.Add(this.button85);
        //            this.Controls.Add(this.button86);
        //            this.Controls.Add(this.button87);
        //            this.Controls.Add(this.button88);
        //            this.Controls.Add(this.button89);
        //            this.Controls.Add(this.button90);
        //            this.Controls.Add(this.button91);
        //            this.Controls.Add(this.button92);
        //            this.Controls.Add(this.button93);
        //            this.Controls.Add(this.button94);
        //            this.Controls.Add(this.button95);
        //            this.Controls.Add(this.button96);
        //            this.Controls.Add(this.button97);
        //            this.Controls.Add(this.button98);
        //            this.Controls.Add(this.button99);
        //            this.Controls.Add(this.button100);
        //            this.Controls.Add(this.button101);
        //            this.Controls.Add(this.button102);
        //            this.Controls.Add(this.mn6_3);
        //            this.Controls.Add(this.mn6_2);
        //            this.Controls.Add(this.mn6_1);
        //            this.Controls.Add(this.mn5_15);
        //            this.Controls.Add(this.mn5_14);
        //            this.Controls.Add(this.mn5_13);
        //            this.Controls.Add(this.mn5_12);
        //            this.Controls.Add(this.mn5_11);
        //            this.Controls.Add(this.mn5_10);
        //            this.Controls.Add(this.mn5_9);
        //            this.Controls.Add(this.mn5_8);
        //            this.Controls.Add(this.mn5_7);
        //            this.Controls.Add(this.mn5_6);
        //            this.Controls.Add(this.mn5_5);
        //            this.Controls.Add(this.mn5_4);
        //            this.Controls.Add(this.mn5_3);
        //            this.Controls.Add(this.mn5_2);
        //            this.Controls.Add(this.mn5_1);
        //            this.Controls.Add(this.mn4_15);
        //            this.Controls.Add(this.mn4_14);
        //            this.Controls.Add(this.mn4_13);
        //            this.Controls.Add(this.mn4_12);
        //            this.Controls.Add(this.mn4_11);
        //            this.Controls.Add(this.mn4_10);
        //            this.Controls.Add(this.mn4_9);
        //            this.Controls.Add(this.mn4_8);
        //            this.Controls.Add(this.mn4_7);
        //            this.Controls.Add(this.mn4_6);
        //            this.Controls.Add(this.mn4_5);
        //            this.Controls.Add(this.mn4_4);
        //            this.Controls.Add(this.mn4_3);
        //            this.Controls.Add(this.mn4_2);
        //            this.Controls.Add(this.mn4_1);
        //            this.Controls.Add(this.mn3_15);
        //            this.Controls.Add(this.mn3_14);
        //            this.Controls.Add(this.mn3_13);
        //            this.Controls.Add(this.mn3_12);
        //            this.Controls.Add(this.mn3_11);
        //            this.Controls.Add(this.mn3_10);
        //            this.Controls.Add(this.mn3_9);
        //            this.Controls.Add(this.mn3_8);
        //            this.Controls.Add(this.mn3_7);
        //            this.Controls.Add(this.mn3_6);
        //            this.Controls.Add(this.mn3_5);
        //            this.Controls.Add(this.mn3_4);
        //            this.Controls.Add(this.mn3_3);
        //            this.Controls.Add(this.mn3_2);
        //            this.Controls.Add(this.mn3_1);
        //            this.Controls.Add(this.mn2_15);
        //            this.Controls.Add(this.mn2_14);
        //            this.Controls.Add(this.mn2_13);
        //            this.Controls.Add(this.mn2_12);
        //            this.Controls.Add(this.mn2_11);
        //            this.Controls.Add(this.mn2_10);
        //            this.Controls.Add(this.mn2_9);
        //            this.Controls.Add(this.mn2_8);
        //            this.Controls.Add(this.mn2_7);
        //            this.Controls.Add(this.mn2_6);
        //            this.Controls.Add(this.mn2_5);
        //            this.Controls.Add(this.mn2_4);
        //            this.Controls.Add(this.mn2_3);
        //            this.Controls.Add(this.mn2_2);
        //            this.Controls.Add(this.mn2_1);
        //            this.Controls.Add(this.mn1_15);
        //            this.Controls.Add(this.mn1_14);
        //            this.Controls.Add(this.mn1_13);
        //            this.Controls.Add(this.mn1_12);
        //            this.Controls.Add(this.mn1_11);
        //            this.Controls.Add(this.mn1_10);
        //            this.Controls.Add(this.mn1_9);
        //            this.Controls.Add(this.mn1_8);
        //            this.Controls.Add(this.mn1_7);
        //            this.Controls.Add(this.mn1_6);
        //            //this.Controls.Add(this.mn1_5);
        //            this.Controls.Add(this.mn1_4);
        //            this.Controls.Add(this.mn1_3);
        //            this.Controls.Add(this.mn1_2);
        //            this.Controls.Add(this.mn1_1);
        //            this.Controls.Add(this.pictureBox1);
        //            this.Name = "Form1";
        //            this.Text = "Form1";
        //            this.Load += new System.EventHandler(this.Form1_Load);
        //            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        //            this.ResumeLayout(false);

        //        }

        //        #endregion

        //        private System.Windows.Forms.Button mn1_1;
        //        private System.Windows.Forms.Button mn1_2;
        //        private System.Windows.Forms.Button mn1_3;
        //        private System.Windows.Forms.Button mn1_4;
        //        //private System.Windows.Forms.Button mn1_5;
        //        private System.Windows.Forms.Button mn1_6;
        //        private System.Windows.Forms.Button mn1_7;
        //        private System.Windows.Forms.Button mn1_8;
        //        private System.Windows.Forms.Button mn1_9;
        //        private System.Windows.Forms.Button mn1_10;
        //        private System.Windows.Forms.Button mn1_11;
        //        private System.Windows.Forms.Button mn1_12;
        //        private System.Windows.Forms.Button mn1_13;
        //        private System.Windows.Forms.Button mn1_14;
        //        private System.Windows.Forms.Button mn1_15;
        //        private System.Windows.Forms.Button mn2_15;
        //        private System.Windows.Forms.Button mn2_14;
        //        private System.Windows.Forms.Button mn2_13;
        //        private System.Windows.Forms.Button mn2_12;
        //        private System.Windows.Forms.Button mn2_11;
        //        private System.Windows.Forms.Button mn2_10;
        //        private System.Windows.Forms.Button mn2_9;
        //        private System.Windows.Forms.Button mn2_8;
        //        private System.Windows.Forms.Button mn2_7;
        //        private System.Windows.Forms.Button mn2_6;
        //        private System.Windows.Forms.Button mn2_5;
        //        private System.Windows.Forms.Button mn2_4;
        //        private System.Windows.Forms.Button mn2_3;
        //        private System.Windows.Forms.Button mn2_2;
        //        private System.Windows.Forms.Button mn2_1;
        //        private System.Windows.Forms.Button mn4_15;
        //        private System.Windows.Forms.Button mn4_14;
        //        private System.Windows.Forms.Button mn4_13;
        //        private System.Windows.Forms.Button mn4_12;
        //        private System.Windows.Forms.Button mn4_11;
        //        private System.Windows.Forms.Button mn4_10;
        //        private System.Windows.Forms.Button mn4_9;
        //        private System.Windows.Forms.Button mn4_8;
        //        private System.Windows.Forms.Button mn4_7;
        //        private System.Windows.Forms.Button mn4_6;
        //        private System.Windows.Forms.Button mn4_5;
        //        private System.Windows.Forms.Button mn4_4;
        //        private System.Windows.Forms.Button mn4_3;
        //        private System.Windows.Forms.Button mn4_2;
        //        private System.Windows.Forms.Button mn4_1;
        //        private System.Windows.Forms.Button mn3_15;
        //        private System.Windows.Forms.Button mn3_14;
        //        private System.Windows.Forms.Button mn3_13;
        //        private System.Windows.Forms.Button mn3_12;
        //        private System.Windows.Forms.Button mn3_11;
        //        private System.Windows.Forms.Button mn3_10;
        //        private System.Windows.Forms.Button mn3_9;
        //        private System.Windows.Forms.Button mn3_8;
        //        private System.Windows.Forms.Button mn3_7;
        //        private System.Windows.Forms.Button mn3_6;
        //        private System.Windows.Forms.Button mn3_5;
        //        private System.Windows.Forms.Button mn3_4;
        //        private System.Windows.Forms.Button mn3_3;
        //        private System.Windows.Forms.Button mn3_2;
        //        private System.Windows.Forms.Button mn3_1;
        //        private System.Windows.Forms.Button button61;
        //        private System.Windows.Forms.Button button62;
        //        private System.Windows.Forms.Button button63;
        //        private System.Windows.Forms.Button button64;
        //        private System.Windows.Forms.Button button65;
        //        private System.Windows.Forms.Button button66;
        //        private System.Windows.Forms.Button button67;
        //        private System.Windows.Forms.Button button68;
        //        private System.Windows.Forms.Button button69;
        //        private System.Windows.Forms.Button button70;
        //        private System.Windows.Forms.Button button71;
        //        private System.Windows.Forms.Button button72;
        //        private System.Windows.Forms.Button button73;
        //        private System.Windows.Forms.Button button74;
        //        private System.Windows.Forms.Button button75;
        //        private System.Windows.Forms.Button button76;
        //        private System.Windows.Forms.Button button77;
        //        private System.Windows.Forms.Button button78;
        //        private System.Windows.Forms.Button button79;
        //        private System.Windows.Forms.Button button80;
        //        private System.Windows.Forms.Button button81;
        //        private System.Windows.Forms.Button button82;
        //        private System.Windows.Forms.Button button83;
        //        private System.Windows.Forms.Button button84;
        //        private System.Windows.Forms.Button button85;
        //        private System.Windows.Forms.Button button86;
        //        private System.Windows.Forms.Button button87;
        //        private System.Windows.Forms.Button button88;
        //        private System.Windows.Forms.Button button89;
        //        private System.Windows.Forms.Button button90;
        //        private System.Windows.Forms.Button button91;
        //        private System.Windows.Forms.Button button92;
        //        private System.Windows.Forms.Button button93;
        //        private System.Windows.Forms.Button button94;
        //        private System.Windows.Forms.Button button95;
        //        private System.Windows.Forms.Button button96;
        //        private System.Windows.Forms.Button button97;
        //        private System.Windows.Forms.Button button98;
        //        private System.Windows.Forms.Button button99;
        //        private System.Windows.Forms.Button button100;
        //        private System.Windows.Forms.Button button101;
        //        private System.Windows.Forms.Button button102;
        //        private System.Windows.Forms.Button mn6_3;
        //        private System.Windows.Forms.Button mn6_2;
        //        private System.Windows.Forms.Button mn6_1;
        //        private System.Windows.Forms.Button mn5_15;
        //        private System.Windows.Forms.Button mn5_14;
        //        private System.Windows.Forms.Button mn5_13;
        //        private System.Windows.Forms.Button mn5_12;
        //        private System.Windows.Forms.Button mn5_11;
        //        private System.Windows.Forms.Button mn5_10;
        //        private System.Windows.Forms.Button mn5_9;
        //        private System.Windows.Forms.Button mn5_8;
        //        private System.Windows.Forms.Button mn5_7;
        //        private System.Windows.Forms.Button mn5_6;
        //        private System.Windows.Forms.Button mn5_5;
        //        private System.Windows.Forms.Button mn5_4;
        //        private System.Windows.Forms.Button mn5_3;
        //        private System.Windows.Forms.Button mn5_2;
        //        private System.Windows.Forms.Button mn5_1;
        //        private System.Windows.Forms.Button button121;
        //        private System.Windows.Forms.Button button122;
        //        private System.Windows.Forms.Button button123;
        //        private System.Windows.Forms.Button button124;
        //        private System.Windows.Forms.Button button125;
        //        private System.Windows.Forms.Button button126;
        //        private System.Windows.Forms.Button button127;
        //        private System.Windows.Forms.Button button128;
        //        private System.Windows.Forms.Button button129;
        //        private System.Windows.Forms.Button button130;
        //        private System.Windows.Forms.Button button131;
        //        private System.Windows.Forms.Button button132;
        //        private System.Windows.Forms.Button button133;
        //        private System.Windows.Forms.Button button134;
        //        private System.Windows.Forms.Button button135;
        //        private System.Windows.Forms.Button button136;
        //        private System.Windows.Forms.Button button137;
        //        private System.Windows.Forms.Button button138;
        //        private System.Windows.Forms.Button button139;
        //        private System.Windows.Forms.Button button140;
        //        private System.Windows.Forms.Button button141;
        //        private System.Windows.Forms.Button button142;
        //        private System.Windows.Forms.Button button143;
        //        private System.Windows.Forms.Button button144;
        //        private System.Windows.Forms.Button button145;
        //        private System.Windows.Forms.Button button146;
        //        private System.Windows.Forms.Button button147;
        //        private System.Windows.Forms.Button button148;
        //        private System.Windows.Forms.Button button149;
        //        private System.Windows.Forms.Button button150;
        //        private System.Windows.Forms.Button button151;
        //        private System.Windows.Forms.Button button152;
        //        private System.Windows.Forms.Button button153;
        //        private System.Windows.Forms.Button button154;
        //        private System.Windows.Forms.Button button155;
        //        private System.Windows.Forms.Button button156;
        //        private System.Windows.Forms.Button button157;
        //        private System.Windows.Forms.Button button158;
        //        private System.Windows.Forms.Button button159;
        //        private System.Windows.Forms.Button button160;
        //        private System.Windows.Forms.Button button161;
        //        private System.Windows.Forms.Button button162;
        //        private System.Windows.Forms.Button button163;
        //        private System.Windows.Forms.Button button164;
        //        private System.Windows.Forms.Button button165;
        //        private System.Windows.Forms.Button button166;
        //        private System.Windows.Forms.Button button167;
        //        private System.Windows.Forms.Button button168;
        //        private System.Windows.Forms.Button button169;
        //        private System.Windows.Forms.Button button170;
        //        private System.Windows.Forms.Button button171;
        //        private System.Windows.Forms.Button button172;
        //        private System.Windows.Forms.Button button173;
        //        private System.Windows.Forms.Button button174;
        //        private System.Windows.Forms.Button button175;
        //        private System.Windows.Forms.Button button176;
        //        private System.Windows.Forms.Button button177;
        //        private System.Windows.Forms.Button button178;
        //        private System.Windows.Forms.Button button179;
        //        private System.Windows.Forms.Button button180;
        //        private System.Windows.Forms.Button button181;
        //        private System.Windows.Forms.Button button182;
        //        private System.Windows.Forms.Button button183;
        //        private System.Windows.Forms.Button button184;
        //        private System.Windows.Forms.Button button185;
        //        private System.Windows.Forms.Button button186;
        //        private System.Windows.Forms.Button button187;
        //        private System.Windows.Forms.Button button188;
        //        private System.Windows.Forms.Button button189;
        //        private System.Windows.Forms.Button button190;
        //        private System.Windows.Forms.Button button191;
        //        private System.Windows.Forms.Button button192;
        //        private System.Windows.Forms.Button button193;
        //        private System.Windows.Forms.Button button194;
        //        private System.Windows.Forms.Button button195;
        //        private System.Windows.Forms.Button button196;
        //        private System.Windows.Forms.Button button197;
        //        private System.Windows.Forms.Button button198;
        //        private System.Windows.Forms.Button button199;
        //        private System.Windows.Forms.Button button200;
        //        private System.Windows.Forms.Button button201;
        //        private System.Windows.Forms.Button button202;
        //        private System.Windows.Forms.Button button203;
        //        private System.Windows.Forms.Button button204;
        //        private System.Windows.Forms.Button button205;
        //        private System.Windows.Forms.Button button206;
        //        private System.Windows.Forms.Button button207;
        //        private System.Windows.Forms.Button button208;
        //        private System.Windows.Forms.Button button209;
        //        private System.Windows.Forms.Button button210;
        //        private System.Windows.Forms.Button button211;
        //        private System.Windows.Forms.Button button212;
        //        private System.Windows.Forms.Button button213;
        //        private System.Windows.Forms.Button button214;
        //        private System.Windows.Forms.Button button215;
        //        private System.Windows.Forms.Button button216;
        //        private System.Windows.Forms.Button button217;
        //        private System.Windows.Forms.Button button218;
        //        private System.Windows.Forms.Button button219;
        //        private System.Windows.Forms.Button button220;
        //        private System.Windows.Forms.Button button221;
        //        private System.Windows.Forms.Button button222;
        //        private System.Windows.Forms.Button button223;
        //        private System.Windows.Forms.Button button224;
        //        private System.Windows.Forms.Button button225;
        //        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
        
    }
}


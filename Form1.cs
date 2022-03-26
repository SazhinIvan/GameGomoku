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
        public class pole
        {
            public int m { get; set; }
            public int n { get; set; }
            public int zn { get; set; }
            public int player { get; set; }
            
        }

        public pole[] _pole;
        public pole[,] _pole2; 
        public bool player1 = true;
        public bool win =false;

        public Form1()
        {
           // _pole = new pole[15 * 15];

            

            InitializeComponent();

           
        }

        public void obr_pole(pole item_pole)
        {

            //var _obr = (from Item in _pole
            //            where Item.zn == 1 & Item.player == 1
            //            select Item) ;

                       


            //int[] _arrm = new int[_obr.Count()];
            //int i = 0;    
            //foreach (var item in _obr)
            //{
            //    _arrm[i] =item.n;
            //    i += 1;
            //}

            /////////////////////////////////////////
            var _obr_h = (from Item in _pole
                          where Item.zn == 1 && Item.player == 1 && Item.n == item_pole.n
                          select Item);





            int[] _arrm_h = new int[15]; // = new int[_obr.Count()];
            
            int i_h = 0;
            int i_sum = 0;
            int b = 0;
            bool five = false;
            bool more_five = false;

            foreach (var item in _obr_h)
            {
              
                int a = item.m;
                if (b + 1 == a)
                {
                    i_sum += 1;
                    _arrm_h[i_h] = i_sum;
                }
                else
                {
                    if (i_sum== 0)
                    {
                        i_h = 0;
                    }
                    else
                    {
                        i_h += 1;
                    }
                    
                    i_sum = 1;
                    _arrm_h[i_h] = i_sum;
                }
                b = a;

                if (i_sum == 5)
                {
                    five = true;
                }

                if (i_sum > 5)
                {
                    more_five = true;
                }
            }

            



            win = five;

            
            //int _count = _arrm.Count();


            //if (_count>=5)
            //{
            //    for (int ii = 0; ii < _count - 4; ii++)
            //    {
            //        int a = 3;
            //        if (_arrm[ii] + 1 == _arrm[ii + 1] &&
            //            _arrm[ii + 1] + 1 == _arrm[ii + 2] &&
            //            _arrm[ii + 2] + 1 == _arrm[ii + 3] &&
            //            _arrm[ii + 3] + 1 == _arrm[ii + 4])
                        
            //        {
            //            win = true;
            //        }
            //    }
            //}
        }

        public void button_color(Button button)
        {
            var _tag = (int)button.Tag;

            if (player1)
            {
                button.BackColor = Color.Black;
                player1 = !player1;
                _pole[_tag].player = 1;
            }
            else
            {
                button.BackColor = Color.White;
                player1 = !player1;
                _pole[_tag].player = 2;
            }
        }

        
        private void button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;   
            string _name = button.Name;
            int _tag = (int) button.Tag;
            pole item_pole = _pole[_tag];
            
            if (_pole[_tag].zn == 1)
            {               
            }
            else
            {
                button_color(button);
                _pole[_tag].zn = 1;
            }
            obr_pole(item_pole);


            string pl = item_pole.player.ToString();
            if (win == true)   
            {

                MessageBox.Show("выиграл игнок номер" + pl);
            }
        }

    }
}

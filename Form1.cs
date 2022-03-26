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

            //по вертикали
            var _obr_h = (from Item in _pole
                          where Item.zn == 1 && Item.player == item_pole.player && Item.n == item_pole.n
                          select Item);


            int[] _arrm_h = new int[15]; // = new int[_obr.Count()];


            int i_h = 0;
            int i_sum = 0;
            int b = 0;
            bool five_h = false;
            bool more_five_h = false;


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
                    if (i_sum == 0)
                    { i_h = 0; }
                    else
                    { i_h += 1; }

                    i_sum = 1;
                    _arrm_h[i_h] = i_sum;
                }
                b = a;

                if (i_sum == 5)
                { five_h = true; }

                if (i_sum > 5)
                { more_five_h = true; }
            }

            // по горизонтали

            var _obr_w = (from Item in _pole
                          where Item.zn == 1 && Item.player == item_pole.player && Item.m == item_pole.m
                          select Item);

            int[] _arrm_w = new int[15];

            int j_w = 0;
            int j_sum = 0;
            b = 0;
            bool five_w = false;
            bool more_five_w = false;

            foreach (var item in _obr_w)
            {
                int a = item.n;
                if (b + 1 == a)
                {
                    j_sum += 1;
                    _arrm_w[j_w] = j_sum;
                }
                else
                {
                    if (j_sum == 0)
                    { j_w = 0; }
                    else
                    { j_w += 1; }

                    j_sum = 1;
                    _arrm_w[j_w] = j_sum;
                }
                b = a;

                if (j_sum == 5)
                { five_w = true; }

                if (j_sum > 5)
                { more_five_w = true; }
            }

            // по диагонали            

            int h = item_pole.m; // строки m
            int w = item_pole.n; // столбцы n

            int[] _arrm_wh = new int[15];

            int ij_wh = 0;
            int ij_sum = 0;
            b = 0;
            bool five_wh = false;
            bool more_five_wh = false;

            int h_min = 1;
            int h_max = 15;
            int w_min = 1;
            int w_max = 15;
            int max = 0;
            int m_a = 0;
            int n_a = 0;
            //первая четверть
            if (h < 8 & w < 8)
            {
                //слева вверх
                if (h >= w)
                {
                    max = h + w - 1;


                    m_a = h + w - 1;
                    n_a = 1;

                }

                if (w > h)
                {
                    max = h + w - 1;
                    //n_a = h + w - 1;
                    //m_a = 1;

                    m_a = h + w - 1;
                    n_a = 1;

                }


                for (int i = 1; i < max; i++)
                {
                    var che = (from Item in _pole
                               where /*Item.zn == 1  && Item.player == item_pole.player && */  Item.m == m_a && Item.n == n_a
                               select Item);


                    int a = che.ElementAt(0).n;
                    var c = che.ElementAt(0).zn;
                    var d = che.ElementAt(0).player;


                    if (b + 1 == a && c == 1 && d == item_pole.player)
                    {
                        ij_sum += 1;
                        _arrm_wh[ij_wh] = ij_sum;
                    }
                    else
                    {
                        if (ij_sum == 0)
                        { ij_wh = 0; }
                        else
                        { ij_wh += 1; }

                        ij_sum = 1;
                        _arrm_wh[ij_wh] = ij_sum;
                    }
                    b = a;

                    if (ij_sum == 5)
                    { five_wh = true; }

                    if (ij_sum > 5)
                    { more_five_wh = true; }


                    m_a -= 1;
                    n_a += 1;



                }
                //слвева вниз


            }

            //Вторая четверть
            if (h < 8 & w > 8)
            {

            }
            //третья четверть

            if (h > 8 & w < 8)
            {

            }

            //четвертая четверть
            if (h > 8 & w > 8)
            {

            }



            win = five_h | five_w | five_wh;

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

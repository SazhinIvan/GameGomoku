﻿using System;
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

        public bool vert(pole item_pole)
        {

            //по вертикали
            var _obr_h = (from Item in _pole
                          where Item.zn == 1 && Item.player == item_pole.player && Item.n == item_pole.n
                          select Item);

            int[] _arrm_h = new int[15];

            int i_h = 0;
            int i_sum = 0;
            int b = 0;
            bool five_h = false;

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

            }

            foreach (var item in _arrm_h)
            {
                if (i_sum == 5)
                { five_h = true; }

            }

            
            return five_h;
        }

        public bool horiz(pole item_pole)
        {
            var _obr_w = (from Item in _pole
                          where Item.zn == 1 && Item.player == item_pole.player && Item.m == item_pole.m
                          select Item);

            int[] _arrm_w = new int[15];

            int j_w = 0;
            int j_sum = 0;
            int b = 0;
            bool five_w = false;

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

            }
            foreach (var item in _arrm_w)
            {
                if (item == 5)
                { five_w = true; }

            }

            return five_w;
        }

        public bool diag_1(pole item_pole) // по диагонали  "/"   
        {
            // по диагонали  "/"           

            int h = item_pole.m; // строки m
            int w = item_pole.n; // столбцы n

            int[] _arrm_wh = new int[15];

            int ij_wh = 0;
            int ij_sum = 0;
            int b_m = 0;
            int b_n = 0;
            bool five_wh = false;

            int max = 0;
            int m_a = 0;
            int n_a = 0;


            //перед диоганалью "/"
            if (h + w <= 16)
            {
                max = h + w - 1;
                m_a = h + w - 1;
                n_a = 1;

                int d2 = 0;


                for (int i = 1; i < max; i++)
                {
                    var che = (from Item in _pole
                               where Item.m == m_a && Item.n == n_a
                               select Item);


                    int a_n = che.ElementAt(0).n;
                    int a_m = che.ElementAt(0).m;

                    var c = che.ElementAt(0).zn;
                    var d = che.ElementAt(0).player;

                    if (d == d2)
                    {
                        d2 = d;
                    }

                    if (b_m - 1 == a_m &&
                        b_n + 1 == a_n &&
                        c == 1 &&
                        d2 == d &&
                        d == item_pole.player
                        )
                    {
                        ij_sum += 1;
                        _arrm_wh[ij_wh] = ij_sum;
                    }
                    else if (
                        c == 1 &&
                        d == item_pole.player
                        )
                    {
                        if (ij_sum == 0)
                        { ij_wh = 0; }
                        else
                        { ij_wh += 1; }

                        ij_sum = 1;
                        _arrm_wh[ij_wh] = ij_sum;
                    }

                    b_m = a_m;
                    b_n = a_n;
                    d2 = d;

                    m_a -= 1;
                    n_a += 1;

                }
                foreach (var item in _arrm_wh)
                {
                    if (item == 5)
                    { five_wh = true; }

                }


            }

            //после диагонали "/"
            if (h + w > 16)
            {
                max = 2 * 15 - (h + w - 1);
                m_a = h + w - 15;
                n_a = 15;


                int d2 = 0;


                for (int i = 1; i < max; i++)
                {
                    var che = (from Item in _pole
                               where Item.m == m_a && Item.n == n_a
                               select Item);


                    int a_n = che.ElementAt(0).n;
                    int a_m = che.ElementAt(0).m;


                    var c = che.ElementAt(0).zn;
                    var d = che.ElementAt(0).player;


                    if (d == d2)
                    {
                        d2 = d;
                    }

                    if (b_m + 1 == a_m &&
                       b_n - 1 == a_n &&
                       c == 1 &&
                       d2 == d &&
                       d == item_pole.player
                       )
                    {
                        ij_sum += 1;
                        _arrm_wh[ij_wh] = ij_sum;
                    }
                    else if (
                        c == 1 &&
                        d == item_pole.player
                        )

                    {
                        if (ij_sum == 0)
                        { ij_wh = 0; }
                        else
                        { ij_wh += 1; }

                        ij_sum = 1;
                        _arrm_wh[ij_wh] = ij_sum;
                    }
                    b_m = a_m;
                    b_n = a_n;
                    d2 = d;

                    m_a += 1;
                    n_a -= 1;

                }
                foreach (var item in _arrm_wh)
                {
                    if (item == 5)
                    { five_wh = true; }

                }

            }
            return five_wh;
        }


        public bool diag_2(pole item_pole)// по диагонали  "\" 
        {
            int h = item_pole.m; // строки m
            int w = item_pole.n; // столбцы n

            //int[] _arrm_wh = new int[15];

            int ij_wh = 0;
            int ij_sum = 0;
            int b_m = 0;
            int b_n = 0;
            //bool five_wh = false;

            int max = 0;
            int m_a = 0;
            int n_a = 0;


            // по диагонали  "\" 

            h = item_pole.m; // строки m
            w = item_pole.n; // столбцы n

            int[] _arrm_wh_b = new int[15];

            ij_wh = 0;
            ij_sum = 0;
            b_m = 0;
            b_n = 0;
            bool five_wh_b = false;

            max = 0;
            m_a = 0;
            n_a = 0;
            // до диагонали "\"


            if (h >= w)
            {
                m_a = h - w + 1;
                n_a = 1;
                max = 15 - m_a + 1;

                int d2 = 0;

                for (int i = 1; i < max; i++)
                {
                    var che = (from Item in _pole
                               where Item.m == m_a && Item.n == n_a
                               select Item);


                    int a_n = che.ElementAt(0).n;
                    int a_m = che.ElementAt(0).m;

                    var c = che.ElementAt(0).zn;
                    var d = che.ElementAt(0).player;

                    if (d == d2)
                    {
                        d2 = d;
                    }

                    if (b_m + 1 == a_m &&
                        b_n + 1 == a_n &&
                        c == 1 &&
                        d2 == d &&
                        d == item_pole.player
                        )
                    {
                        ij_sum += 1;
                        _arrm_wh_b[ij_wh] = ij_sum;
                    }
                    else if (
                        c == 1 &&
                        d == item_pole.player
                        )
                    {
                        if (ij_sum == 0)
                        { ij_wh = 0; }
                        else
                        { ij_wh += 1; }

                        ij_sum = 1;
                        _arrm_wh_b[ij_wh] = ij_sum;
                    }

                    b_m = a_m;
                    b_n = a_n;
                    d2 = d;

                    m_a += 1;
                    n_a += 1;

                }
                foreach (var item in _arrm_wh_b)
                {
                    if (item == 5)
                    { five_wh_b = true; }

                }


            }

            // после диагонали "\"
            if (h < w)
            {
                m_a = 1;
                n_a = w - h + 1;
                max = 15 - n_a + 1;

                int d2 = 0;

                for (int i = 1; i < max; i++)
                {
                    var che = (from Item in _pole
                               where Item.m == m_a && Item.n == n_a
                               select Item);


                    int a_n = che.ElementAt(0).n;
                    int a_m = che.ElementAt(0).m;


                    var c = che.ElementAt(0).zn;
                    var d = che.ElementAt(0).player;

                    if (d == d2)
                    {
                        d2 = d;
                    }

                    if (b_m + 1 == a_m &&
                       b_n + 1 == a_n &&
                       c == 1 &&
                       d2 == d &&
                       d == item_pole.player
                       )
                    {
                        ij_sum += 1;
                        _arrm_wh_b[ij_wh] = ij_sum;
                    }
                    else if (
                        c == 1 &&
                        d == item_pole.player
                        )

                    {
                        if (ij_sum == 0)
                        { ij_wh = 0; }
                        else
                        { ij_wh += 1; }

                        ij_sum = 1;
                        _arrm_wh_b[ij_wh] = ij_sum;
                    }
                    b_m = a_m;
                    b_n = a_n;
                    d2 = d;

                    m_a += 1;
                    n_a += 1;

                }
                foreach (var item in _arrm_wh_b)
                {
                    if (item == 5)
                    { five_wh_b = true; }

                }

            }

            return five_wh_b;
        }
        public void obr_pole(pole item_pole)
        {

            //по вертикали
            //var _obr_h = (from Item in _pole
            //              where Item.zn == 1 && Item.player == item_pole.player && Item.n == item_pole.n
            //              select Item);

            //int[] _arrm_h = new int[15];

            //int i_h = 0;
            //int i_sum = 0;
            int b = 0;
            //bool five_h = false;       

            //foreach (var item in _obr_h)
            //{
            //    int a = item.m;
            //    if (b + 1 == a)
            //    {
            //        i_sum += 1;
            //        _arrm_h[i_h] = i_sum;
            //    }
            //    else
            //    {
            //        if (i_sum == 0)
            //        { i_h = 0; }
            //        else
            //        { i_h += 1; }

            //        i_sum = 1;
            //        _arrm_h[i_h] = i_sum;
            //    }
            //    b = a;                                

            //}

            //foreach (var item in _arrm_h)
            //{
            //    if (i_sum == 5)
            //    { five_h = true; }

            //}


            bool five_h = vert(item_pole);
            bool five_w = horiz(item_pole);
            bool five_wh = diag_1(item_pole);
            bool five_wh_b = diag_2(item_pole);

            // по горизонтали

            //var _obr_w = (from Item in _pole
            //              where Item.zn == 1 && Item.player == item_pole.player && Item.m == item_pole.m
            //              select Item);

            //int[] _arrm_w = new int[15];

            //int j_w = 0;
            //int j_sum = 0;
            //b = 0;
            //bool five_w = false;           

            //foreach (var item in _obr_w)
            //{
            //    int a = item.n;
            //    if (b + 1 == a)
            //    {
            //        j_sum += 1;
            //        _arrm_w[j_w] = j_sum;
            //    }
            //    else
            //    {
            //        if (j_sum == 0)
            //        { j_w = 0; }
            //        else
            //        { j_w += 1; }

            //        j_sum = 1;
            //        _arrm_w[j_w] = j_sum;
            //    }
            //    b = a;

            //}
            //foreach (var item in _arrm_w)
            //{
            //    if (item == 5)
            //    { five_w = true; }

            //}

            // по диагонали  "/"           

            //int h = item_pole.m; // строки m
            //int w = item_pole.n; // столбцы n

            ////int[] _arrm_wh = new int[15];

            //int ij_wh = 0;
            //int ij_sum = 0;
            //int b_m = 0;
            //int b_n = 0;
            ////bool five_wh = false;
            
            //int max = 0;
            //int m_a = 0;
            //int n_a = 0;

            
            ////перед диоганалью "/"
            //if (h + w <= 16)
            //{               
            //        max = h + w - 1;
            //        m_a = h + w - 1;
            //        n_a = 1;

            //    int d2 = 0;


            //    for (int i = 1; i < max; i++)
            //    {
            //        var che = (from Item in _pole
            //                   where Item.m == m_a && Item.n == n_a
            //                   select Item);


            //        int a_n = che.ElementAt(0).n;
            //        int a_m = che.ElementAt(0).m;

            //        var c = che.ElementAt(0).zn;
            //        var d = che.ElementAt(0).player;

            //        if (d == d2)
            //        {
            //            d2 = d;
            //        }

            //        if (b_m - 1 == a_m &&
            //            b_n + 1 == a_n &&
            //            c == 1 &&
            //            d2 == d &&
            //            d == item_pole.player
            //            )
            //        {
            //            ij_sum += 1;
            //            _arrm_wh[ij_wh] = ij_sum;
            //        }
            //        else if(
            //            c == 1 &&
            //            d == item_pole.player
            //            )
            //        {
            //            if (ij_sum == 0)
            //            { ij_wh = 0; }
            //            else
            //            { ij_wh += 1; }

            //            ij_sum = 1;
            //            _arrm_wh[ij_wh] = ij_sum;
            //        }

            //        b_m = a_m;
            //        b_n = a_n;
            //        d2 = d;

            //        m_a -= 1;
            //        n_a += 1;

            //    }
            //    foreach (var item in _arrm_wh)
            //    {
            //        if (item == 5)
            //    { five_wh = true; }

            //    }              


            //}

            ////после диагонали "/"
            //if (h + w > 16)
            //{
            //    max = 2*15 - (h + w - 1);
            //    m_a = h + w - 15;
            //    n_a = 15;


            //    int d2 = 0;


            //    for (int i = 1; i < max; i++)
            //    {
            //        var che = (from Item in _pole
            //                   where Item.m == m_a && Item.n == n_a
            //                   select Item);


            //        int a_n = che.ElementAt(0).n;
            //        int a_m = che.ElementAt(0).m;


            //        var c = che.ElementAt(0).zn;
            //        var d = che.ElementAt(0).player;


            //        if (d == d2)
            //        {
            //            d2 = d;
            //        }

            //        if (b_m + 1 == a_m &&
            //           b_n - 1 == a_n &&
            //           c == 1 &&
            //           d2 == d &&
            //           d == item_pole.player
            //           )
            //        {
            //            ij_sum += 1;
            //            _arrm_wh[ij_wh] = ij_sum;
            //        }
            //        else if(
            //            c == 1 &&
            //            d == item_pole.player
            //            )

            //        {
            //            if (ij_sum == 0)
            //            { ij_wh = 0; }
            //            else
            //            { ij_wh += 1; }

            //            ij_sum = 1;
            //            _arrm_wh[ij_wh] = ij_sum;
            //        }
            //        b_m = a_m;
            //        b_n = a_n;
            //        d2 = d;
                                        
            //        m_a += 1;
            //        n_a -= 1;
                                       
            //    }
            //    foreach (var item in _arrm_wh)
            //    {
            //        if (item == 5)
            //        { five_wh = true; }

            //    }

            //}


            // по диагонали  "\" 

           //h = item_pole.m; // строки m
           // w = item_pole.n; // столбцы n

           // int[]  _arrm_wh_b = new int[15];

           // ij_wh = 0;
           // ij_sum = 0;
           // b_m = 0;
           // b_n = 0;
           // bool five_wh_b = false;

           // max = 0;
           // m_a = 0;
           // n_a = 0;
           // // до диагонали "\"


           // if (h >= w)
           // {
           //     m_a = h -  w + 1;
           //     n_a = 1;
           //     max = 15 - m_a + 1;

           //     int d2 = 0;

           //     for (int i = 1; i < max; i++)
           //     {
           //         var che = (from Item in _pole
           //                    where Item.m == m_a && Item.n == n_a
           //                    select Item);


           //         int a_n = che.ElementAt(0).n;
           //         int a_m = che.ElementAt(0).m;

           //         var c = che.ElementAt(0).zn;
           //         var d = che.ElementAt(0).player;

           //         if (d == d2)
           //         {
           //             d2 = d;
           //         }

           //         if (b_m + 1 == a_m &&
           //             b_n + 1 == a_n &&
           //             c == 1 &&
           //             d2 == d &&
           //             d == item_pole.player
           //             )
           //         {
           //             ij_sum += 1;
           //             _arrm_wh_b[ij_wh] = ij_sum;
           //         }
           //         else if (
           //             c == 1 &&
           //             d == item_pole.player
           //             )
           //         {
           //             if (ij_sum == 0)
           //             { ij_wh = 0; }
           //             else
           //             { ij_wh += 1; }

           //             ij_sum = 1;
           //             _arrm_wh_b[ij_wh] = ij_sum;
           //         }

           //         b_m = a_m;
           //         b_n = a_n;
           //         d2 = d;

           //         m_a += 1;
           //         n_a += 1;

           //     }
           //     foreach (var item in _arrm_wh_b)
           //     {
           //         if (item == 5)
           //         { five_wh_b = true; }

           //     }


           // }

           // // после диагонали "\"
           // if (h < w)
           // {
           //     m_a = 1;
           //     n_a = w - h + 1;
           //     max = 15 - n_a + 1;

           //     int d2 = 0;

           //     for (int i = 1; i < max; i++)
           //     {
           //         var che = (from Item in _pole
           //                    where Item.m == m_a && Item.n == n_a
           //                    select Item);


           //         int a_n = che.ElementAt(0).n;
           //         int a_m = che.ElementAt(0).m;


           //         var c = che.ElementAt(0).zn;
           //         var d = che.ElementAt(0).player;

           //         if (d == d2)
           //         {
           //             d2 = d;
           //         }

           //         if (b_m + 1 == a_m &&
           //            b_n + 1 == a_n &&
           //            c == 1 &&
           //            d2 == d &&
           //            d == item_pole.player
           //            )
           //         {
           //             ij_sum += 1;
           //             _arrm_wh_b[ij_wh] = ij_sum;
           //         }
           //         else if (
           //             c == 1 &&
           //             d == item_pole.player
           //             )

           //         {
           //             if (ij_sum == 0)
           //             { ij_wh = 0; }
           //             else
           //             { ij_wh += 1; }

           //             ij_sum = 1;
           //             _arrm_wh_b[ij_wh] = ij_sum;
           //         }
           //         b_m = a_m;
           //         b_n = a_n;
           //         d2 = d;

           //         m_a += 1;
           //         n_a += 1;

           //     }
           //     foreach (var item in _arrm_wh_b)
           //     {
           //         if (item == 5)
           //         { five_wh_b = true; }

           //     }

           // }
            // проверка на победу
            win = five_h | five_w | five_wh | five_wh_b;

           
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

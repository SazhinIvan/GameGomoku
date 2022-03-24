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

        public bool player1 = true;

        public Form1()
        {
           // _pole = new pole[15 * 15];

            

            InitializeComponent();

           
        }

        public void obr_pole()
        {

            var _obr = (from Item in _pole
                        where Item.zn == 1 & Item.player == 1
                        select Item) ;

            int[] _arrm = new int[_obr.Count()];
            int i = 0;    
            foreach (var item in _obr)
            {
                _arrm[i] =item.n;
                i += 1;
            }

           

            bool result = false;
            int _count = _arrm.Count();
            if (_count>=5)
            {
                for (int ii = 0; ii < _count - 4; ii++)
                {
                    int a = 3;
                    if (_arrm[ii] + 1 == _arrm[ii + 1] &&
                        _arrm[ii + 1] + 1 == _arrm[ii + 2] &&
                        _arrm[ii + 2] + 1 == _arrm[ii + 3] &&
                        _arrm[ii + 3] + 1 == _arrm[ii + 4])
                        
                    {
                        result = true;
                    }
                }
            }
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
            var _name = button.Name;
            var _tag = (int) button.Tag;
            var item_pole = _pole[_tag];

            if (_pole[_tag].zn == 1)
            {               
            }
            else
            {
                button_color(button);
                _pole[_tag].zn = 1;
            }
            obr_pole();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    button_color(button);
        //    var _name = button.Name;
        //    var _tag = button.Tag;
        //}



        //    private void button3_Click(object sender, EventArgs e)
        //    {
        //        if (player1)
        //        {
        //            mn1_3.BackColor = Color.Black;
        //            player1 = !player1;
        //        }
        //        else
        //        {
        //            mn1_3.BackColor = Color.White;
        //            player1 = !player1;
        //        }
        //    }

        //    private void button4_Click(object sender, EventArgs e)
        //    {
        //        mn1_4.BackColor = Color.Black;
        //    }

        //    private void button5_Click(object sender, EventArgs e)
        //    {
        //        this.buttons_list.ElementAt(1);
        //        this.buttons_list.ElementAt(1)._button.BackColor = Color.Black;
        //    }

        //    private void button6_Click(object sender, EventArgs e)
        //    {
        //        mn1_6.BackColor = Color.Black;
        //    }

        //    private void button7_Click(object sender, EventArgs e)
        //    {
        //        mn1_7.BackColor = Color.Black;
        //    }

        //    private void button8_Click(object sender, EventArgs e)
        //    {
        //        mn1_8.BackColor = Color.Black;
        //    }

        //    private void button9_Click(object sender, EventArgs e)
        //    {
        //        mn1_9.BackColor = Color.Black;
        //    }

        //    private void button10_Click(object sender, EventArgs e)
        //    {
        //        mn1_10.BackColor = Color.Black;
        //    }

        //    private void button11_Click(object sender, EventArgs e)
        //    {
        //        mn1_11.BackColor = Color.Black;
        //    }

        //    private void button12_Click(object sender, EventArgs e)
        //    {
        //        mn1_12.BackColor = Color.Black;
        //    }

        //    private void button13_Click(object sender, EventArgs e)
        //    {
        //        mn1_13.BackColor = Color.Black;
        //    }

        //    private void button14_Click(object sender, EventArgs e)
        //    {
        //        mn1_14.BackColor = Color.Black;
        //    }
        //    private void button15_Click(object sender, EventArgs e)
        //    {
        //        mn1_15.BackColor = Color.Black;
        //    }

        //    private void Form1_Load(object sender, EventArgs e)
        //    {

        //    }

        //    private void button30_Click(object sender, EventArgs e)
        //    {
        //        mn2_1.BackColor = Color.Black;
        //    }

        //    private void button29_Click(object sender, EventArgs e)
        //    {
        //        mn2_2.BackColor = Color.Black;
        //    }

        //    private void button28_Click(object sender, EventArgs e)
        //    {
        //        mn2_3.BackColor = Color.Black;
        //    }

        //    private void button27_Click(object sender, EventArgs e)
        //    {
        //        mn2_4.BackColor = Color.Black;
        //    }

        //    private void button26_Click(object sender, EventArgs e)
        //    {
        //        mn2_5.BackColor = Color.Black;
        //    }

        //    private void button25_Click(object sender, EventArgs e)
        //    {
        //        mn2_6.BackColor = Color.Black;
        //    }

        //    private void button24_Click(object sender, EventArgs e)
        //    {
        //        mn2_7.BackColor = Color.Black;
        //    }

        //    private void button23_Click(object sender, EventArgs e)
        //    {
        //        mn2_8.BackColor = Color.Black;
        //    }

        //    private void button22_Click(object sender, EventArgs e)
        //    {
        //        mn2_9.BackColor = Color.Black;
        //    }

        //    private void button21_Click(object sender, EventArgs e)
        //    {
        //        mn2_10.BackColor = Color.Black;
        //    }

        //    private void button20_Click(object sender, EventArgs e)
        //    {
        //        mn2_11.BackColor = Color.Black;
        //    }

        //    private void button19_Click(object sender, EventArgs e)
        //    {
        //        mn2_12.BackColor = Color.Black;
        //    }

        //    private void button18_Click(object sender, EventArgs e)
        //    {
        //        mn2_13.BackColor = Color.Black;
        //    }

        //    private void button17_Click(object sender, EventArgs e)
        //    {
        //        mn2_14.BackColor = Color.Black;
        //    }

        //    private void button16_Click(object sender, EventArgs e)
        //    {
        //        mn2_15.BackColor = Color.Black;
        //    }

        //    private void button60_Click(object sender, EventArgs e)
        //    {
        //        mn3_1.BackColor = Color.Black;
        //    }

        //    private void button59_Click(object sender, EventArgs e)
        //    {
        //        mn3_2.BackColor = Color.Black;
        //    }

        //    private void button58_Click(object sender, EventArgs e)
        //    {
        //        mn3_3.BackColor = Color.Black;
        //    }

        //    private void button57_Click(object sender, EventArgs e)
        //    {
        //        mn3_4.BackColor = Color.Black;
        //    }

        //    private void button56_Click(object sender, EventArgs e)
        //    {
        //        mn3_5.BackColor = Color.Black;
        //    }

        //    private void button55_Click(object sender, EventArgs e)
        //    {
        //        mn3_6.BackColor = Color.Black;
        //    }

        //    private void button54_Click(object sender, EventArgs e)
        //    {
        //        mn3_7.BackColor = Color.Black;

        //    }

        //    private void button53_Click(object sender, EventArgs e)
        //    {
        //        mn3_8.BackColor = Color.Black;
        //    }

        //    private void button52_Click(object sender, EventArgs e)
        //    {
        //        mn3_9.BackColor = Color.Black;
        //    }

        //    private void button51_Click(object sender, EventArgs e)
        //    {
        //        mn3_10.BackColor = Color.Black;
        //    }

        //    private void button50_Click(object sender, EventArgs e)
        //    {
        //        mn3_11.BackColor = Color.Black;
        //    }

        //    private void button49_Click(object sender, EventArgs e)
        //    {
        //        mn3_12.BackColor = Color.Black;
        //    }

        //    private void button48_Click(object sender, EventArgs e)
        //    {
        //        mn3_13.BackColor = Color.Black;
        //    }

        //    private void button47_Click(object sender, EventArgs e)
        //    {
        //        mn3_14.BackColor = Color.Black;
        //    }

        //    private void button46_Click(object sender, EventArgs e)
        //    {
        //        mn3_15.BackColor = Color.Black;
        //    }

        //    private void button45_Click(object sender, EventArgs e)
        //    {
        //        mn4_1.BackColor = Color.Black;
        //    }

        //    private void button44_Click(object sender, EventArgs e)
        //    {
        //        mn4_2.BackColor = Color.Black;
        //    }

        //    private void button43_Click(object sender, EventArgs e)
        //    {
        //        mn4_3.BackColor = Color.Black;
        //    }

        //    private void button42_Click(object sender, EventArgs e)
        //    {
        //        mn4_4.BackColor = Color.Black;
        //    }

        //    private void button41_Click(object sender, EventArgs e)
        //    {
        //        mn4_5.BackColor = Color.Black;
        //    }

        //    private void button40_Click(object sender, EventArgs e)
        //    {
        //        mn4_6.BackColor = Color.Black;
        //    }

        //    private void button39_Click(object sender, EventArgs e)
        //    {
        //        mn4_7.BackColor = Color.Black;
        //    }

        //    private void button38_Click(object sender, EventArgs e)
        //    {
        //        mn4_8.BackColor = Color.Black;
        //    }

        //    private void button37_Click(object sender, EventArgs e)
        //    {
        //        mn4_9.BackColor = Color.Black;
        //    }

        //    private void button36_Click(object sender, EventArgs e)
        //    {
        //        mn4_10.BackColor = Color.Black;
        //    }

        //    private void button35_Click(object sender, EventArgs e)
        //    {
        //        mn4_11.BackColor = Color.Black;
        //    }

        //    private void button34_Click(object sender, EventArgs e)
        //    {
        //        mn4_12.BackColor = Color.Black;
        //    }

        //    private void button32_Click(object sender, EventArgs e)
        //    {
        //        mn4_14.BackColor = Color.Black;
        //    }

        //    private void button33_Click(object sender, EventArgs e)
        //    {
        //        mn4_13.BackColor = Color.Black;
        //    }

        //    private void button31_Click(object sender, EventArgs e)
        //    {
        //        mn4_15.BackColor = Color.Black;
        //    }

        //    private void button61_Click(object sender, EventArgs e)
        //    {
        //        button61.BackColor = Color.Black;
        //    }

        //    private void button62_Click(object sender, EventArgs e)
        //    {
        //        button62.BackColor = Color.Black;
        //    }

        //    private void button63_Click(object sender, EventArgs e)
        //    {
        //        button63.BackColor = Color.Black;
        //    }

        //    private void button64_Click(object sender, EventArgs e)
        //    {
        //        button64.BackColor = Color.Black;
        //    }

        //    private void button65_Click(object sender, EventArgs e)
        //    {
        //        button65.BackColor = Color.Black;
        //    }

        //    private void button66_Click(object sender, EventArgs e)
        //    {
        //        button66.BackColor = Color.Black;
        //    }

        //    private void button67_Click(object sender, EventArgs e)
        //    {
        //        button67.BackColor = Color.Black;
        //    }

        //    private void button68_Click(object sender, EventArgs e)
        //    {
        //        button68.BackColor = Color.Black;
        //    }

        //    private void button69_Click(object sender, EventArgs e)
        //    {
        //        button69.BackColor = Color.Black;
        //    }

        //    private void button70_Click(object sender, EventArgs e)
        //    {
        //        button70.BackColor = Color.Black;
        //    }

        //    private void button71_Click(object sender, EventArgs e)
        //    {
        //        button71.BackColor = Color.Black;
        //    }

        //    private void button72_Click(object sender, EventArgs e)
        //    {
        //        button72.BackColor = Color.Black;
        //    }

        //    private void button73_Click(object sender, EventArgs e)
        //    {
        //        button73.BackColor = Color.Black;
        //    }

        //    private void button74_Click(object sender, EventArgs e)
        //    {
        //        button74.BackColor = Color.Black;
        //    }

        //    private void button75_Click(object sender, EventArgs e)
        //    {
        //        button75.BackColor = Color.Black;
        //    }

        //    private void button76_Click(object sender, EventArgs e)
        //    {
        //        button76.BackColor = Color.Black;
        //    }

        //    private void button77_Click(object sender, EventArgs e)
        //    {
        //        button77.BackColor = Color.Black;
        //    }

        //    private void button78_Click(object sender, EventArgs e)
        //    {
        //        button78.BackColor = Color.Black;
        //    }


        //    private void button79_Click(object sender, EventArgs e)
        //    {
        //        button79.BackColor = Color.Black;
        //    }

        //    private void button80_Click(object sender, EventArgs e)
        //    {
        //        button80.BackColor = Color.Black;
        //    }

        //    private void button81_Click(object sender, EventArgs e)
        //    {
        //        button81.BackColor = Color.Black;
        //    }

        //    private void button82_Click(object sender, EventArgs e)
        //    {
        //        button82.BackColor = Color.Black;
        //    }

        //    private void button83_Click(object sender, EventArgs e)
        //    {
        //        button83.BackColor = Color.Black;
        //    }

        //    private void button84_Click(object sender, EventArgs e)
        //    {
        //        button84.BackColor = Color.Black;
        //    }

        //    private void button85_Click(object sender, EventArgs e)
        //    {
        //        button85.BackColor = Color.Black;
        //    }

        //    private void button86_Click(object sender, EventArgs e)
        //    {
        //        button86.BackColor = Color.Black;
        //    }

        //    private void button87_Click(object sender, EventArgs e)
        //    {
        //        button87.BackColor = Color.Black;
        //    }

        //    private void button88_Click(object sender, EventArgs e)
        //    {
        //        button88.BackColor = Color.Black;
        //    }

        //    private void button89_Click(object sender, EventArgs e)
        //    {
        //        button89.BackColor = Color.Black;
        //    }

        //    private void button90_Click(object sender, EventArgs e)
        //    {
        //        button90.BackColor = Color.Black;
        //    }

        //    private void button91_Click(object sender, EventArgs e)
        //    {
        //        button91.BackColor = Color.Black;
        //    }

        //    private void button92_Click(object sender, EventArgs e)
        //    {
        //        button92.BackColor = Color.Black;
        //    }

        //    private void button93_Click(object sender, EventArgs e)
        //    {
        //        button93.BackColor = Color.Black;
        //    }

        //    private void button94_Click(object sender, EventArgs e)
        //    {
        //        button94.BackColor = Color.Black;

        //    }

        //    private void button95_Click(object sender, EventArgs e)
        //    {
        //        button95.BackColor = Color.Black;
        //    }

        //    private void button96_Click(object sender, EventArgs e)
        //    {
        //        button96.BackColor = Color.Black;
        //    }

        //    private void button97_Click(object sender, EventArgs e)
        //    {
        //        button97.BackColor = Color.Black;
        //    }

        //    private void button98_Click(object sender, EventArgs e)
        //    {
        //        button98.BackColor = Color.Black;
        //    }

        //    private void button99_Click(object sender, EventArgs e)
        //    {
        //        button99.BackColor = Color.Black;
        //    }

        //    private void button100_Click(object sender, EventArgs e)
        //    {
        //        button100.BackColor = Color.Black;
        //    }

        //    private void button101_Click(object sender, EventArgs e)
        //    {
        //        button101.BackColor = Color.Black;
        //    }

        //    private void button102_Click(object sender, EventArgs e)
        //    {
        //        button102.BackColor = Color.Black;
        //    }

        //    private void button103_Click(object sender, EventArgs e)
        //    {
        //        mn6_3.BackColor = Color.Black;
        //    }

        //    private void button104_Click(object sender, EventArgs e)
        //    {
        //        mn6_2.BackColor = Color.Black;
        //    }

        //    private void button105_Click(object sender, EventArgs e)
        //    {
        //        mn6_1.BackColor = Color.Black;
        //    }

        //    private void button106_Click(object sender, EventArgs e)
        //    {
        //        mn5_15.BackColor = Color.Black;
        //    }

        //    private void button107_Click(object sender, EventArgs e)
        //    {
        //        mn5_14.BackColor = Color.Black;
        //    }

        //    private void button108_Click(object sender, EventArgs e)
        //    {
        //        mn5_13.BackColor = Color.Black;
        //    }

        //    private void button109_Click(object sender, EventArgs e)
        //    {
        //        mn5_12.BackColor = Color.Black;
        //    }

        //    private void button110_Click(object sender, EventArgs e)
        //    {
        //        mn5_11.BackColor = Color.Black;
        //    }

        //    private void button111_Click(object sender, EventArgs e)
        //    {
        //        mn5_10.BackColor = Color.Black;
        //    }

        //    private void button112_Click(object sender, EventArgs e)
        //    {
        //        mn5_9.BackColor = Color.Black;
        //    }

        //    private void button113_Click(object sender, EventArgs e)
        //    {
        //        mn5_8.BackColor = Color.Black;
        //    }

        //    private void button114_Click(object sender, EventArgs e)
        //    {
        //        mn5_7.BackColor = Color.Black;
        //    }

        //    private void button115_Click(object sender, EventArgs e)
        //    {
        //        mn5_6.BackColor = Color.Black;
        //    }

        //    private void button116_Click(object sender, EventArgs e)
        //    {
        //        mn5_5.BackColor = Color.Black;
        //    }

        //    private void button117_Click(object sender, EventArgs e)
        //    {
        //        mn5_4.BackColor = Color.Black;
        //    }

        //    private void button118_Click(object sender, EventArgs e)
        //    {
        //        mn5_3.BackColor = Color.Black;
        //    }

        //    private void button119_Click(object sender, EventArgs e)
        //    {
        //        mn5_2.BackColor = Color.Black;
        //    }

        //    private void button120_Click(object sender, EventArgs e)
        //    {
        //        mn5_1.BackColor = Color.Black;
        //    }

        //    private void button225_Click(object sender, EventArgs e)
        //    {
        //        button225.BackColor = Color.Black;
        //    }

        //    private void button122_Click(object sender, EventArgs e)
        //    {
        //        button122.BackColor = Color.Black;
        //    }

        //    private void button123_Click(object sender, EventArgs e)
        //    {
        //        button123.BackColor = Color.Black;
        //    }

        //    private void button124_Click(object sender, EventArgs e)
        //    {
        //        button124.BackColor = Color.Black;
        //    }

        //    private void button125_Click(object sender, EventArgs e)
        //    {
        //        button125.BackColor = Color.Black;
        //    }

        //    private void button126_Click(object sender, EventArgs e)
        //    {
        //        button126.BackColor = Color.Black;
        //    }

        //    private void button127_Click(object sender, EventArgs e)
        //    {
        //        button127.BackColor = Color.Black;
        //    }

        //    private void button128_Click(object sender, EventArgs e)
        //    {
        //        button128.BackColor = Color.Black;
        //    }

        //    private void button129_Click(object sender, EventArgs e)
        //    {
        //        button129.BackColor = Color.Black;
        //    }

        //    private void button130_Click(object sender, EventArgs e)
        //    {
        //        button130.BackColor = Color.Black;
        //    }

        //    private void button131_Click(object sender, EventArgs e)
        //    {
        //        button131.BackColor = Color.Black;
        //    }

        //    private void button132_Click(object sender, EventArgs e)
        //    {
        //        button132.BackColor = Color.Black;
        //    }

        //    private void button133_Click(object sender, EventArgs e)
        //    {
        //        button133.BackColor = Color.Black;
        //    }

        //    private void button134_Click(object sender, EventArgs e)
        //    {
        //        button134.BackColor = Color.Black;
        //    }

        //    private void button135_Click(object sender, EventArgs e)
        //    {
        //        button135.BackColor = Color.Black;
        //    }

        //    private void button136_Click(object sender, EventArgs e)
        //    {
        //        button136.BackColor = Color.Black;
        //    }

        //    private void button137_Click(object sender, EventArgs e)
        //    {
        //        button137.BackColor = Color.Black;
        //    }

        //    private void button138_Click(object sender, EventArgs e)
        //    {
        //        button138.BackColor = Color.Black;
        //    }

        //    private void button139_Click(object sender, EventArgs e)
        //    {
        //        button139.BackColor = Color.Black;
        //    }

        //    private void button140_Click(object sender, EventArgs e)
        //    {
        //        button140.BackColor = Color.Black;
        //    }

        //    private void button141_Click(object sender, EventArgs e)
        //    {
        //        button141.BackColor = Color.Black;
        //    }

        //    private void button142_Click(object sender, EventArgs e)
        //    {
        //        button142.BackColor = Color.Black;
        //    }

        //    private void button143_Click(object sender, EventArgs e)
        //    {
        //        button143.BackColor = Color.Black;
        //    }

        //    private void button144_Click(object sender, EventArgs e)
        //    {
        //        button144.BackColor = Color.Black;
        //    }

        //    private void button145_Click(object sender, EventArgs e)
        //    {
        //        button145.BackColor = Color.Black;
        //    }

        //    private void button146_Click(object sender, EventArgs e)
        //    {
        //        button146.BackColor = Color.Black;
        //    }

        //    private void button147_Click(object sender, EventArgs e)
        //    {
        //        button147.BackColor = Color.Black;
        //    }

        //    private void button148_Click(object sender, EventArgs e)
        //    {
        //        button148.BackColor = Color.Black;
        //    }

        //    private void button149_Click(object sender, EventArgs e)
        //    {
        //        button149.BackColor = Color.Black;
        //    }

        //    private void button150_Click(object sender, EventArgs e)
        //    {
        //        button150.BackColor = Color.Black;
        //    }

        //    private void button151_Click(object sender, EventArgs e)
        //    {
        //        button151.BackColor = Color.Black;
        //    }

        //    private void button152_Click(object sender, EventArgs e)
        //    {
        //        button152.BackColor = Color.Black;
        //    }

        //    private void button153_Click(object sender, EventArgs e)
        //    {
        //        button153.BackColor = Color.Black;
        //    }

        //    private void button154_Click(object sender, EventArgs e)
        //    {
        //        button154.BackColor = Color.Black;
        //    }

        //    private void button155_Click(object sender, EventArgs e)
        //    {
        //        button155.BackColor = Color.Black;
        //    }

        //    private void button156_Click(object sender, EventArgs e)
        //    {
        //        button156.BackColor = Color.Black;
        //    }

        //    private void button157_Click(object sender, EventArgs e)
        //    {
        //        button157.BackColor = Color.Black;
        //    }

        //    private void button158_Click(object sender, EventArgs e)
        //    {
        //        button158.BackColor = Color.Black;
        //    }

        //    private void button159_Click(object sender, EventArgs e)
        //    {
        //        button159.BackColor = Color.Black;
        //    }

        //    private void button160_Click(object sender, EventArgs e)
        //    {
        //        button160.BackColor = Color.Black;
        //    }

        //    private void button121_Click(object sender, EventArgs e)
        //    {
        //        button121.BackColor = Color.Black;
        //    }

        //    private void button162_Click(object sender, EventArgs e)
        //    {
        //        button162.BackColor = Color.Black;
        //    }

        //    private void button163_Click(object sender, EventArgs e)
        //    {
        //        button163.BackColor = Color.Black;
        //    }

        //    private void button164_Click(object sender, EventArgs e)
        //    {
        //        button164.BackColor = Color.Black;
        //    }

        //    private void button165_Click(object sender, EventArgs e)
        //    {
        //        button165.BackColor = Color.Black;
        //    }

        //    private void button166_Click(object sender, EventArgs e)
        //    {
        //        button166.BackColor = Color.Black;
        //    }

        //    private void button167_Click(object sender, EventArgs e)
        //    {
        //        button167.BackColor = Color.Black;
        //    }

        //    private void button168_Click(object sender, EventArgs e)
        //    {
        //        button168.BackColor = Color.Black;
        //    }

        //    private void button169_Click(object sender, EventArgs e)
        //    {
        //        button169.BackColor = Color.Black;
        //    }

        //    private void button170_Click(object sender, EventArgs e)
        //    {
        //        button170.BackColor = Color.Black;
        //    }

        //    private void button171_Click(object sender, EventArgs e)
        //    {
        //        button171.BackColor = Color.Black;
        //    }

        //    private void button172_Click(object sender, EventArgs e)
        //    {
        //        button172.BackColor = Color.Black;
        //    }

        //    private void button173_Click(object sender, EventArgs e)
        //    {
        //        button173.BackColor = Color.Black;
        //    }

        //    private void button174_Click(object sender, EventArgs e)
        //    {
        //        button174.BackColor = Color.Black;
        //    }

        //    private void button175_Click(object sender, EventArgs e)
        //    {
        //        button175.BackColor = Color.Black;
        //    }

        //    private void button176_Click(object sender, EventArgs e)
        //    {
        //        button176.BackColor = Color.Black;
        //    }

        //    private void button177_Click(object sender, EventArgs e)
        //    {
        //        button177.BackColor = Color.Black;
        //    }

        //    private void button178_Click(object sender, EventArgs e)
        //    {
        //        button178.BackColor = Color.Black;
        //    }

        //    private void button179_Click(object sender, EventArgs e)
        //    {
        //        button179.BackColor = Color.Black;
        //    }

        //    private void button180_Click(object sender, EventArgs e)
        //    {
        //        button180.BackColor = Color.Black;
        //    }

        //    private void button181_Click(object sender, EventArgs e)
        //    {
        //        button181.BackColor = Color.Black;
        //    }

        //    private void button182_Click(object sender, EventArgs e)
        //    {
        //        button182.BackColor = Color.Black;
        //    }

        //    private void button183_Click(object sender, EventArgs e)
        //    {
        //        button183.BackColor = Color.Black;
        //    }

        //    private void button184_Click(object sender, EventArgs e)
        //    {
        //        button184.BackColor = Color.Black;
        //    }

        //    private void button185_Click(object sender, EventArgs e)
        //    {
        //        button185.BackColor = Color.Black;
        //    }

        //    private void button186_Click(object sender, EventArgs e)
        //    {
        //        button186.BackColor = Color.Black;
        //    }

        //    private void button187_Click(object sender, EventArgs e)
        //    {
        //        button187.BackColor = Color.Black;
        //    }

        //    private void button188_Click(object sender, EventArgs e)
        //    {
        //        button188.BackColor = Color.Black;
        //    }

        //    private void button189_Click(object sender, EventArgs e)
        //    {
        //        button189.BackColor = Color.Black;
        //    }

        //    private void button190_Click(object sender, EventArgs e)
        //    {
        //        button190.BackColor = Color.Black;
        //    }

        //    private void button191_Click(object sender, EventArgs e)
        //    {
        //        button191.BackColor = Color.Black;
        //    }

        //    private void button192_Click(object sender, EventArgs e)
        //    {
        //        button192.BackColor = Color.Black;
        //    }

        //    private void button193_Click(object sender, EventArgs e)
        //    {
        //        button193.BackColor = Color.Black;
        //    }

        //    private void button194_Click(object sender, EventArgs e)
        //    {
        //        button194.BackColor = Color.Black;
        //    }

        //    private void button195_Click(object sender, EventArgs e)
        //    {
        //        button195.BackColor = Color.Black;
        //    }

        //    private void button196_Click(object sender, EventArgs e)
        //    {
        //        button196.BackColor = Color.Black;
        //    }

        //    private void button197_Click(object sender, EventArgs e)
        //    {
        //        button197.BackColor = Color.Black;
        //    }

        //    private void button198_Click(object sender, EventArgs e)
        //    {
        //        button198.BackColor = Color.Black;
        //    }

        //    private void button199_Click(object sender, EventArgs e)
        //    {
        //        button199.BackColor = Color.Black;
        //    }

        //    private void button200_Click(object sender, EventArgs e)
        //    {
        //        button200.BackColor = Color.Black;
        //    }

        //    private void button201_Click(object sender, EventArgs e)
        //    {
        //        button201.BackColor = Color.Black;
        //    }

        //    private void button202_Click(object sender, EventArgs e)
        //    {
        //        button202.BackColor = Color.Black;
        //    }

        //    private void button203_Click(object sender, EventArgs e)
        //    {
        //        button203.BackColor = Color.Black;
        //    }

        //    private void button204_Click(object sender, EventArgs e)
        //    {
        //        button204.BackColor = Color.Black;
        //    }

        //    private void button205_Click(object sender, EventArgs e)
        //    {
        //        button205.BackColor = Color.Black;
        //    }

        //    private void button206_Click(object sender, EventArgs e)
        //    {
        //        button206.BackColor = Color.Black;
        //    }

        //    private void button207_Click(object sender, EventArgs e)
        //    {
        //        button207.BackColor = Color.Black;
        //    }

        //    private void button208_Click(object sender, EventArgs e)
        //    {
        //        button208.BackColor = Color.Black;
        //    }

        //    private void button209_Click(object sender, EventArgs e)
        //    {
        //        button209.BackColor = Color.Black;
        //    }

        //    private void button210_Click(object sender, EventArgs e)
        //    {
        //        button210.BackColor = Color.Black;
        //    }

        //    private void button211_Click(object sender, EventArgs e)
        //    {
        //        button211.BackColor = Color.Black;
        //    }

        //    private void button212_Click(object sender, EventArgs e)
        //    {
        //        button212.BackColor = Color.Black;
        //    }

        //    private void button213_Click(object sender, EventArgs e)
        //    {
        //        button213.BackColor = Color.Black;
        //    }

        //    private void button214_Click(object sender, EventArgs e)
        //    {
        //        button214.BackColor = Color.Black;
        //    }

        //    private void button215_Click(object sender, EventArgs e)
        //    {
        //        button215.BackColor = Color.Black;
        //    }

        //    private void button216_Click(object sender, EventArgs e)
        //    {
        //        button216.BackColor = Color.Black;
        //    }

        //    private void button217_Click(object sender, EventArgs e)
        //    {
        //        button217.BackColor = Color.Black;
        //    }

        //    private void button218_Click(object sender, EventArgs e)
        //    {
        //        button218.BackColor = Color.Black;
        //    }

        //    private void button219_Click(object sender, EventArgs e)
        //    {
        //        button219.BackColor = Color.Black;
        //    }

        //    private void button220_Click(object sender, EventArgs e)
        //    {
        //        button220.BackColor = Color.Black;
        //    }

        //    private void button221_Click(object sender, EventArgs e)
        //    {
        //        button221.BackColor = Color.Black;
        //    }

        //    private void button222_Click(object sender, EventArgs e)
        //    {
        //        button222.BackColor = Color.Black;
        //    }

        //    private void button223_Click(object sender, EventArgs e)
        //    {
        //        button223.BackColor = Color.Black;
        //    }

        //    private void button224_Click(object sender, EventArgs e)
        //    {
        //        button224.BackColor = Color.Black;
        //    }

        //    private void button161_Click(object sender, EventArgs e)
        //    {
        //        button161.BackColor = Color.Black;
        //    }

        //    private void pictureBox1_Click(object sender, EventArgs e)
        //    {

        //    }


        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameGomoku
{
    /// <summary>
    /// Класс элемента игрового поля
    /// </summary>
    public class Rating
    {
        private Player Player;        
        private int CountVictories;

        public void csvOpen() {
            var fl = File.ReadAllLines("play.csv");
            List<string> ienstr = new List<string>();
            foreach (var item in fl)
            {
                ienstr.Add(item);
                ienstr.Add("aa");
            }
            List<string> list = new List<string>();
            //list.Add("aaaaa");
            File.AppendAllLines("play.csv", ienstr);
           // File.AppendAllText("play.csv", $"{list[0]},{list[0]} ");
            fl = File.ReadAllLines("play.csv");
            
        }
        
    }

    
    
}

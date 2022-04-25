using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameGomoku
{


    public class Rating_count
    {
        public string Name;
        public int count;
    }
    public class Rating
    {
       
        public List<string> ListRating;
        private string path =  "Rating.csv";

        public void csvOpen() {
           // var fl =  GameGomoku.Properties.Resources.Rating;
            var fl = File.ReadAllLines(path);
            List<string> ienstr = new List<string>();
            foreach (var item in fl)
            {
                ienstr.Add(item);               
            }
            ListRating = ienstr;
        }

        public void csvAddItem(string nameplayer)
        {
            List<string> ienstr = new List<string>();
            ienstr.Add(nameplayer);
            File.AppendAllLines(path, ienstr);

            var fl = File.ReadAllLines(path);
            
            csvOpen();
        }

    }

    
    
}

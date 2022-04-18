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
    public class Player
    {
        public int IdPlayer;
        public string NamePlayer;
    };

    public class ListOfPlayers
    {
        private string path;
        public List<Player> ListPlayers;

        public ListOfPlayers()
        {
            path = "Players.csv";
            ListPlayers = new List<Player>();
            csvOpen();
            
        }
        public void csvOpen()
        {
            ListPlayers.Clear();
            var fl = File.ReadAllLines(path);
            
            foreach (var item in fl)
            {
                Player player = new Player();
                string[] arr = item.Split(',');
                player.IdPlayer = Int32.Parse(arr[0]);
                player.NamePlayer = arr[1];
                ListPlayers.Add(player);
            }
            

        }

        public void csvAddItem(string nameplayer)
        {
            var fl = File.ReadAllLines(path);
            
            var _count = fl.Length;

            var pl = fl[_count - 1];

            string[] arr = pl.Split(',');
            string _id = arr[0];
            string itemplayer = _id + "," + nameplayer;

            List<string> ienstr = new List<string>();
            ienstr.Add(itemplayer);
            File.AppendAllLines(path, ienstr);
            

            csvOpen();
        }

    };



}

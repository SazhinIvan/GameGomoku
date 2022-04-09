using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGomoku
{
    public class GameSetting
    {
        private int sizePole;
        private bool gameVsComp;
        private int sizeButton;
        
        //Конструктор по умолчанию
        public GameSetting()
        {
            sizeButton = 30;
            sizePole = 15;
            gameVsComp = false;
        }

        public void SetSizePole(int size)
        {
            sizePole = size;
        }
        public void SetGameVsComp(bool activate)
        {
            gameVsComp = activate;
        }
        public void SetSize_button(int size)
        {
            sizeButton = size;
        }

        public int GetSizePole()
        {
            return sizePole;
        }
        public bool GetGameVsComp()
        {
            return gameVsComp;
        }
        public int GetSize_button()
        {
            return sizeButton;
        }


    }
}

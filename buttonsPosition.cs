using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGomoku
{
    /// <summary>
    /// Класс Элемента поля со стороны пользователя
    /// </summary>
    public class buttonsPosition
    {
        public int y_gamePole { get; set; }
        public int x_gamePole { get; set; }
        public Button button { get; set; }
    }
}

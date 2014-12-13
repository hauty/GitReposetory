using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15_Ex02_Yadin_201058021_Dana_302595095
{
    class XOGameLogic
    {
        XOGameUI m_UI;
        public XOGameLogic(XOGameUI i_UI)
        {
            m_UI = i_UI;
            Player player1 = new Player(m_UI[0]);
            Player player2 = new Player(m_UI.getPlyerType()[1]);


        }



    }
}

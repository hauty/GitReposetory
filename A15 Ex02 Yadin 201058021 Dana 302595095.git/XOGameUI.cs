using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15_Ex02_Yadin_201058021_Dana_302595095
{
    class XOGameUI
    {
        private List<PlayerType> m_playerType;


        public PlayerType this[int i_playerNum]
        {
            get { return m_playerType[i_playerNum]; }
            set { m_playerType[i_playerNum] = value; } //TODO input from user
        }


    }
}

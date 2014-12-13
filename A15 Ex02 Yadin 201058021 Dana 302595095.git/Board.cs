using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15_Ex02_Yadin_201058021_Dana_302595095
{
    class Board
    {
        XO[,] m_matrix;


        public Board(int i_matrixSize)
        {
            m_matrix = new XO[i_matrixSize, i_matrixSize];
        }

    }
}

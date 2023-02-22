using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalSquareFormsVersion
{
    class Logic
    {
        public char diagonalSymb { get; private set; }
        public char[,] GenerateMas()
        {
            char[,] magicSquare = new char[10, 10];
            Random random = new Random();
            int control = 9;
            diagonalSymb = (char)random.Next(64, 149);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(j == control && i != 9)
                    {
                        control--;
                        magicSquare[i,j] = diagonalSymb;
                    }
                    else
                    {
                        magicSquare[i,j] = (char)random.Next(64, 149); 
                    }
                }
            }
            return magicSquare;
        }
    }
}

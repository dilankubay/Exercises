using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Project_Euler
{
    internal class Triangular__Pentagonal__and_Hexagonal
    {
        public void TriangularPentagonalandHexagonal(int n)
        {
            int x = Triangular(n);
            int y = Pentagonal(165);
            int z = Hexagonal(143);
        }
        public int Triangular(int n)
        {
            return n * (n + 1) / 2;
        }
        public int Pentagonal(int n)
        {
            return n * (3*n - 1) / 2;
        }
        public int Hexagonal(int n)
        {
            return n * (2 * n - 1);
        }
    }
}

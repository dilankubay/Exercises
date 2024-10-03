using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Project_Euler
{
    public class Triangular__Pentagonal__and_Hexagonal
    {
        int[] array1 = new int[1000];
        int[] array2 = new int[1000];
        int[] array3 = new int[1000];
        public  void TriangularPentagonalandHexagonal(int n)
        {
            //int x = Triangular(n);
            //int y = Pentagonal(165);
            //int z = Hexagonal(143);
        }
        public void Triangular()
        {             
            for (int j = 285; j < 1000; j++)
            {
                array1[j] =  j * (j + 1) / 2;            
            }              
        }
        public void Pentagonal()
        {
            for (int j = 165; j < 1000; j++)
            {
                array2[j] = j * (3*j - 1) / 2;
            }
            foreach(int n in array2)
            {
                Console.WriteLine(n);
            }
        }
        public void Hexagonal()
        {
            for (int j = 143; j < 1000; j++)
            {
                array2[j] = j * (2 * j - 1);
            }
            foreach (int n in array2)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}

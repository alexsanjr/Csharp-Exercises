using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatrizes {
    internal class Program {
        static void Main(string[] args) {
            string[] pos = Console.ReadLine().Split(' ');
            int m = int.Parse(pos[0]);
            int n = int.Parse(pos[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m ; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine($"Position: {i}, {j}");
                        if(j > 0) {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j < n - 1) {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i < m - 1) {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }

                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP_3
{
    class SimulationMarkov
    {
        Random random = new Random();

        public int Sim(double S0, double S1, double S2, double[] matrix) => Simulate(S0, S0 + S1, S0 + S1 + S2, matrix);

        int Simulate(double S0, double S1, double S2, double[] matrix)
        {
            int N = 0;
            int S = 0; // состояние
            double r;
            //double[] matrix = { 0.4, 0.8, 1, 0, 0.5, 1, 0, 0, 1 }; // матрица переходов

            r = random.NextDouble();

            if (r <= S1) { S = 0; N++; } // рандом меньше вероятности перехода в состояние 1
            else if (r > S1 && r <= S2) { S = 1; N++; } // рандом больше вероятности перехода в состояние 1 и меньше в состояние 2
            else { S = 2; N++; return N; } // рандом больше вероятности перехода в состояние 2

            while (S != 2)
            {
                if (S == 0)
                {
                    r = random.NextDouble();

                    if (r <= matrix[0]) N++;
                    else if (r > matrix[0] && r <= matrix[1]) { S = 1; N++; }
                    else { S = 2; N++; return N; }
                }
                else
                {
                    r = random.NextDouble();

                    if (r <= matrix[4]) N++;
                    else { S = 2; N++; return N; }
                }
            }

            return N;
        }
    }
}
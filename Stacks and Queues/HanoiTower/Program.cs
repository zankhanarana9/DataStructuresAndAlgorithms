using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HanoiTower
{
    class Program
    {
        private const int DISCS_COUNT = 5;
        private const int DELAY_MS = 250;
        private static int _columnSize = 30;

        static void Main(string[] args)
        {
            _columnSize = Math.Max(6, GetDiscWidth(DISCS_COUNT) + 2);
            HanoiTower algorithm = new HanoiTower(DISCS_COUNT);
            algorithm.MoveCompleted += Algorithm_Visualize;
            Algorithm_Visualize(algorithm, EventArgs.Empty);
            algorithm.Start();
            Console.Read();
        }

        private static void Algorithm_Visualize(object sender, EventArgs e)
        {
            Console.Clear();
            HanoiTower algorithm = (HanoiTower)sender;
            if(algorithm.DiscsCount <= 0)
            {
                return;
            }

            char[][] visualization = InitializeVisualization(algorithm);
            PrepareColumn(visualization, 1, algorithm.DiscsCount, algorithm.From);
            PrepareColumn(visualization, 2, algorithm.DiscsCount, algorithm.To);
            PrepareColumn(visualization, 3, algorithm.DiscsCount, algorithm.Auxiliary);

            Console.WriteLine(Center("FROM") + Center("TO") + Center("Auxiliary"));
            DrawVisualization(visualization);
            Console.WriteLine();
            Console.WriteLine($"Number of moves: {algorithm.MovesCount}");
            Console.WriteLine($"Number of dics: {algorithm.DiscsCount}");

            Thread.Sleep(DELAY_MS);
        }

        private static char[][] InitializeVisualization(HanoiTower algorithm)
        {
            char[][] visualization = new char[algorithm.DiscsCount][];

            for(int i = 0; i < visualization.Length; i++)
            {
                visualization[i] = new char[_columnSize * 3];
                for(int j = 0; j < _columnSize * 3; j++)
                {
                    visualization[i][j] = ' ';
                }
            }
            return visualization;
        }

        private static void PrepareColumn(char[][] visualization, int column, int discsCount, Stack<int> stack)
        {
            int margin = _columnSize * (column - 1);

            for (int y = 0; y < stack.Count; y++)
            {
                int size = stack.ElementAt(y);
                int row = discsCount - (stack.Count - y);
                int columnStart = margin + discsCount - size;
                int columnEnd = columnStart + GetDiscWidth(size);

                for (int x = columnStart; x <= columnEnd; x++)
                {
                    visualization[row][x] = '=';
                }
            }
        }

        private static void DrawVisualization(char[][] visualization)
        {
            for(int col = 0; col < visualization.Length; col++)
            {
                Console.WriteLine(visualization[col]);
            }
        }

        private static string Center(string text)
        {
            int margin = (_columnSize - text.Length) / 2;
            return text.PadLeft(margin + text.Length).PadRight(_columnSize);
        }

        private static int GetDiscWidth(int size)
        {
            return 2 * size - 1;
        }
    }
}

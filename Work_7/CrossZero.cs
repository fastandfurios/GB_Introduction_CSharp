using System;

namespace Work_7
{
    public class CrossZero
    {
        static int SIZE_X = 5;
        static int SIZE_Y = 5;

        private int _x;
        private int _y;
        private int _winLine = 4;

        char[,] field = new char[SIZE_Y, SIZE_X];

        char PLAYER_DOT = 'X';
        char AI_DOT = 'O';
        char EMPTY_DOT = '.';

        Random random = new Random();

        public CrossZero()
        {
            InitField();
            PrintField();

            while (true)
            {
                PlayerStep();
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Player Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
                AiStep();
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("SkyNet Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }
        }

        private void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-----------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
        }

        private void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        private bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void PlayerStep()
        {
            do
            {
                Console.WriteLine($"Введите координаты X Y (1-{SIZE_X})");
                _x = Int32.Parse(Console.ReadLine()) - 1;
                _y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(_y, _x));
            SetSym(_y, _x, PLAYER_DOT);
        }

        private void AiStep()
        {
            int x;
            int y;

            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }


        /// <summary>
        /// Проверяет вертикальную и горизонтальную линии
        /// </summary>
        /// <param name="sym">Символ в клетке</param>
        /// <param name="offsetX">Смещение по X</param>
        /// <param name="offsetY">Смещение по Y</param>
        /// <returns>Либо истина, либо ложь</returns>
        private bool CheckLines(char sym, int offsetX, int offsetY)
        {
            int column = 0, rows = 0;
            for (int i = offsetX; i < _winLine + offsetX; i++)
            {
                for (int j = offsetY; j < _winLine + offsetY; j++)
                {
                    if (field[i, j] == sym)
                        rows++;
                    if (field[j, i] == sym)
                        column++;
                }

                if (column == _winLine || rows == _winLine)
                    return true;

                column = 0;
                rows = 0;
            }

            return false;
        }

        /// <summary>
        /// Проверяет диагонали 
        /// </summary>
        /// <param name="sym">Символ в клетке</param>
        /// <param name="offsetX">Смещение по X</param>
        /// <param name="offsetY">Смещение по Y</param>
        /// <returns>Либо истину, либо ложь</returns>
        private bool CheckDiagonal(char sym, int offsetX, int offsetY)
        {
            bool toRight = true, toLeft = true;
            for (int i = 0; i < _winLine; i++)
            {
                toRight = toRight && (field[i + offsetX, i + offsetY] == sym);
                toLeft = toLeft && (field[_winLine - i - 1 + offsetX, i + offsetY] == sym);
            }

            if (toRight || toLeft)
                return true;

            return false;
        }

        private bool CheckWin(char sym)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (CheckLines(sym, i, j) || CheckDiagonal(sym, i, j))
                        return true;
                }
            }

            return false;
        }
    }
}
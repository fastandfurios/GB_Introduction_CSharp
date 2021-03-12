using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossZero
{
    public class Cross
    {
        static int SIZE_X = 5;
        static int SIZE_Y = 5;

	    char[,] field = new char[SIZE_Y, SIZE_X];

		char PLAYER_DOT = 'X';
        char AI_DOT = 'O';
        char EMPTY_DOT = '.';

        Random random = new Random();

        public Cross()
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
            int x;
            int y;
            do
            {
                Console.WriteLine($"Введите координаты X Y (1-{SIZE_X})");
                x = Int32.Parse(Console.ReadLine()) - 1;
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
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

        private bool CheckWin(char sym)
        {
	        for (int i = 0; i < field.GetLength(0); i++)
	        {
		        if (field[i, 0] == sym && field[i, 1] == sym && field[i, 2] == sym && field[i, 3] == sym)
			        return true;
		        else if (field[i, 1] == sym && field[i, 2] == sym && field[i, 3] == sym && field[i, 4] == sym)
			        return true;
                
		        if (field[0, i] == sym && field[1, i] == sym && field[2, i] == sym && field[3, i] == sym)
			        return true;
		        else if (field[1, i] == sym && field[2, i] == sym && field[3, i] == sym && field[4, i] == sym)
			        return true;
	        }

	        if (field[0, 0] == sym && field[1, 1] == sym && field[2, 2] == sym && field[3, 3] == sym)
		        return true;
	        else if (field[1, 1] == sym && field[2, 2] == sym && field[3, 3] == sym && field[4, 4] == sym)
		        return true;

	        if (field[4, 0] == sym && field[3, 1] == sym && field[2, 2] == sym && field[1, 3] == sym)
		        return true;
            else if (field[0, 4] == sym && field[1, 3] == sym && field[2, 2] == sym && field[3, 1] == sym)
		        return true;
            else if (field[3, 0] == sym && field[2, 1] == sym && field[1, 2] == sym && field[0, 3] == sym)
		        return true;
            else if (field[4, 1] == sym && field[3, 2] == sym && field[2, 3] == sym && field[1, 4] == sym)
		        return true;
            else if (field[1, 0] == sym && field[2, 1] == sym && field[3, 2] == sym && field[4, 3] == sym)
		        return true;
            else if (field[0, 1] == sym && field[1, 2] == sym && field[2, 3] == sym && field[3, 4] == sym)
		        return true;

            return false;
        }
    }
}

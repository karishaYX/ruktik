using System;

namespace MazeGame
{
    class Program
    {
        static int mazeWidth = 20;
        static int mazeHeight = 20;
        static char[,] maze = new char[mazeHeight, mazeWidth];
        static int playerX, playerY;
        static int exitX, exitY;
        static Random rand = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                InitializeMaze(); 
                bool gameRunning = true;

                while (gameRunning)
                {
                    Console.Clear();
                    DrawMaze();

                    Console.WriteLine("Цель: найти выход (E). Управление: W, A, S, D.");
                    var key = Console.ReadKey(true).Key;

                    
                    int newX = playerX, newY = playerY;
                    switch (key)
                    {
                        case ConsoleKey.W: newY--; break;
                        case ConsoleKey.S: newY++; break;
                        case ConsoleKey.A: newX--; break;
                        case ConsoleKey.D: newX++; break;
                        case ConsoleKey.Escape: return; 
                        default: continue;
                    }

                    
                    if (newX >= 0 && newX < mazeWidth && newY >= 0 && newY < mazeHeight && maze[newY, newX] != '#')
                    {
                        playerX = newX;
                        playerY = newY;

                        
                        if (playerX == exitX && playerY == exitY)
                        {
                            Console.Clear();
                            DrawMaze();
                            Console.WriteLine("Победа!УРАААААА");
                            Console.ReadKey();
                            gameRunning = false;
                        }
                    }
                }
            }
        }

        static void InitializeMaze()
        {
           
            for (int y = 0; y < mazeHeight; y++)
                for (int x = 0; x < mazeWidth; x++)
                    maze[y, x] = '#';

           
            GenerateMaze(1, 1);

          
            do
            {
                playerX = rand.Next(1, mazeWidth - 1);
                playerY = rand.Next(1, mazeHeight - 1);
            } while (maze[playerY, playerX] != ' ');

          
            SetExit();
        }

        static void GenerateMaze(int x, int y)
        {
            maze[y, x] = ' ';
            int[] dirs = { 0, 1, 2, 3 };
            Shuffle(dirs);

            foreach (int dir in dirs)
            {
                int nx = x, ny = y;
                switch (dir)
                {
                    case 0: ny -= 2; break; 
                    case 1: nx += 2; break; 
                    case 2: ny += 2; break; 
                    case 3: nx -= 2; break; 
                }

                if (nx > 0 && nx < mazeWidth - 1 && ny > 0 && ny < mazeHeight - 1 && maze[ny, nx] == '#')
                {
                    maze[(ny + y) / 2, (nx + x) / 2] = ' '; 
                    GenerateMaze(nx, ny);
                }
            }
        }

        static void Shuffle(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        static void SetExit()
        {
            
            int side = rand.Next(4);
            switch (side)
            {
                case 0: exitX = rand.Next(1, mazeWidth - 1); exitY = 0; break;               
                case 1: exitX = mazeWidth - 1; exitY = rand.Next(1, mazeHeight - 1); break;  
                case 2: exitX = rand.Next(1, mazeWidth - 1); exitY = mazeHeight - 1; break;  
                case 3: exitX = 0; exitY = rand.Next(1, mazeHeight - 1); break;              
            }
            maze[exitY, exitX] = 'E';
        }

        static void DrawMaze()
        {
            for (int y = 0; y < mazeHeight; y++)
            {
                for (int x = 0; x < mazeWidth; x++)
                {
                    if (x == playerX && y == playerY) Console.Write('@');
                    else Console.Write(maze[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}















   


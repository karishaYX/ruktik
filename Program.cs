using System;
using System.Reflection.Metadata.Ecma335;

namespace MazeGame
{
    class Program
    {
        static int mazeWidth = 20;
        static int mazeHeight = 20;
        static char[,] maze = new char[mazeHeight, mazeWidth];
        static int playerX;
        static int playerY;
        static int exitX;
        static int exitY;
        static Random rand = new Random();

        static void Main(string[] args)
        {
            // InitializeMaze();
            while (true)
            {
                bool gameRunning = true;
                while (gameRunning)
                {
                    Console.Clear();
                    // DrawMaze();

                    Console.WriteLine("Цель:найти выход (обозначен'E').");
                    Console.WriteLine("Управление:W - вверх,S - вниз,A - влево,D - вправо.");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    int newX = playerX;
                    int newY = playerY;

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.W:
                            newY--;
                            break;
                        case ConsoleKey.S:
                            newY++;
                            break;
                        case ConsoleKey.A:
                            newX--;
                            break;
                        case ConsoleKey.D:
                            newX++;
                            break;
                        default:
                            continue;
                    }
                    if (newX >= 0 && newX < mazeWidth && newY >= 0 && newY < mazeHeight)
                    {
                        if (maze[newY, newX] != '#')
                        {
                            playerX = newX;
                            playerY = newY;
                            if (playerX == exitX && playerY == exitY)
                            {
                                Console.Clear();
                                // DrawMaze();
                                Console.WriteLine("Конец");
                                Console.ReadKey();
                                // InitializeMaze();
                                gameRunning = false;
                            }

                        }
                    }
                }
            }
        }
        static void InitializeMaze()
        {
            // for (int y = 0; y < mazeHeight; y++)
            {
                // for (int x = 0; x < mazeWidth; x++)
                {
                    // maze[y, x] = '#';
                }
            }
            // GenerateMaze(1, 1);
            // playerX = 1;
            // playerY = 1;
            // SetExit();
        }

      //static void GenerateMaze(int x, int y);
      {
          //maze[y, x] = ' ';

          int[] directions = { 0, 1, 2, 3, };
        //Shiffle(directions);
        //foreach (int dir in directions)
        {
        //int nx = x;
        //int ny = y;
        // switch(dir)
        { 
        //case 0: ny -= 2; break;
        //case 1: nx += 2; break;
        //case 2: ny += 2; break;
        //case 3: nx -= 2; break;
    }
    //if (nx > 0 && nx < mazeWidth - 1 && ny > 0 && ny < mazeHeight - 1)
   {
      // if (maze[ny, nx] == '#')
      {
        // maze[(ny + y) / 2, (nx + x) / 2] = ' ';
        //GenerateMaze(nx, ny);
        }
}
}
}
 static void Shuffle(int[] array)
 {
    //for (int i = Array.Length - 1; i > 0; i--)
    {
        //int j = rand.Next(i + 1);
        //int temp = Array[i];
        //Array[i] = Array[j];
        //aaray[j] = temp;
    }
}

static void SetExit()
{
    bool placed = false;

    while (!placed)
    {
        int side = rand.Next(4);
        switch (side)
        {
            case 0:
            //exitX = rand.Next(1, mazeWidth - 2);
            //exitY = 0;
            //break;
            case 1:
            //exitX = mazeWidth - 1;
            //exitY = rand.Next(1, mazeHeight - 2);
            //break;
            case 2:
            //exitX = rand.Next(1, mazeWidht - 2);
            //exitY = mazeHeight - 1;
            //break;
            case3:
                //exitX = 0;
                //exitY = rand.Next(1, mazeHeight - 2);
                break;
        }

        if (maze[exitY, exitX] != '#')
        {
            maze[exitY, exitX] = 'E';
            placed = true;
        }
    }
}
static void DrawMaze()
{
    for (int y = 0; y < mazeHeight; y++)
    {
        for (int x = 0; x < mazeWidth; x++)
        {
            if (x == playerX && y == playerY)
                Console.Write('@');
            else
                Console.Write(maze[y, x]);
        }
        Console.WriteLine();
    }
}

}
}








  
    
            
         
     















   


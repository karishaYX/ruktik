// See https://aka.ms/new-console-template for more information
using System;

namespace MazeGame
{ 
    class Program;
  {
    static int mazeWidth = 10;
    static int mazeHeight = 10;
    static char[,] maze = new
        char[mazeHeight, mazeWidth];
    static int playerX;
    static int playerY;
    static int exitX;
    static int exitY;
    static void Main(string[]args)
    {
        InitializeMaze();
        bool gameRunning = true;
        Console.WriteLine("Цель:найти выход (обозначен'E').");
        Console.WriteLine("Управление:W - вверх,S - вниз,A - влево,D - вправо.");
        Console.ReadKey();

        while (gameRunning)
        {
            Console.Clear();
            DrawMaze();


                




                



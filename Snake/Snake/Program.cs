using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            //Отрисовка рамки
            HorizontalLine lineh1 = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineh2 = new HorizontalLine(0, 78, 24, '+');
            VerticalLine linev1 = new VerticalLine(0, 24, 0, '+');
            VerticalLine linev2 = new VerticalLine(0, 24, 78, '+');
            lineh1.Draw();
            lineh2.Draw();
            linev1.Draw(); 
            linev2.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(150);
                snake.Move();
            }
        }
    }
}

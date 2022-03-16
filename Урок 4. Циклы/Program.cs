using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Урок_4.Циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            //Turtle.TurnRight();
            int t = 0;

            while (t < 6)
            {
                Turtle.Move(40);
                Turtle.Turn(60);

                t++;


            }
            Turtle.Move(20);
            Turtle.TurnLeft();
            t = 0;
            while (t < 3)
            {
                Turtle.Move(20);
                Turtle.TurnRight();

                Turtle.Move(20);
                Turtle.TurnLeft();

                Turtle.Move(20);
                Turtle.TurnLeft();

                Turtle.Move(20);
                Turtle.TurnRight();
                t++;

            }



        }
    }
}

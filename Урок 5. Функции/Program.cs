using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace Урок_5.Функции
{
    internal class Program
    {

        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(3 * size);
            Turtle.TurnLeft();
            Turtle.Move(size);
            Turtle.Angle = 90;
            Turtle.Move(2 * size);

        }

        static void WriteO(int size)
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();

            }

        }

        static void WriteR(double size)
        {
            Turtle.Angle = 0;
            Turtle.Move(2 * size);
            Turtle.TurnRight();
            Turtle.Move(size);
            Turtle.TurnRight();
            Turtle.Move(size);
            Turtle.TurnRight();
            Turtle.Move(size);
            Turtle.Turn(-135);
            Turtle.Move(1.4*size);


        }

        static void WriteA(double size)
        {
            Turtle.Angle = 0;
            Turtle.Turn(15);
            Turtle.Move(size);
            Turtle.Turn(180-2*15);
            Turtle.Move(size);
            Turtle.Turn(180);
            Turtle.Move(size/2);
            Turtle.Turn(-(90- 15));
            Turtle.Move(size / 4);
        }
        static void WriteC(double size)
        {
            Turtle.Angle = 0;
            Turtle.TurnLeft();
            for (int i = 0; i < 3; i++)
            {
                
                Turtle.Move(size);
                Turtle.TurnRight();

            }
        }
        static void WriteSHA(double size)
        {

            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Move(-size);
            Turtle.TurnRight();
            Turtle.Move(size/2);
            Turtle.TurnLeft();
            Turtle.Move(size);
            Turtle.Move(-size);
            Turtle.TurnRight();
            Turtle.Move(size/2);
            Turtle.TurnLeft();
            Turtle.Move(size);


        }

        static void Main(string[] args)
        {
            Turtle.Speed = 8;

            Turtle.X = 200;
            Turtle.Y = 200;
            WriteT(20);

            Turtle.X = 250;
            Turtle.Y = 200;
            WriteO(30);

            Turtle.X = 300;
            Turtle.Y = 200;
            WriteR(15);


            Turtle.X = 350;
            Turtle.Y = 200;
            WriteT(10);

            Turtle.X = 200;
            Turtle.Y = 300;
            WriteC(50);

            Turtle.X = 225;
            Turtle.Y = 300;
            WriteA(30);


            Turtle.X = 250;
            Turtle.Y = 300;
            WriteSHA(30);

            Turtle.X = 300;
            Turtle.Y = 300;
            WriteA(30);

        }
    }
}

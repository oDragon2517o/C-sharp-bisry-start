using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace Урок_6.Разработка_игры_часть_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            int P = 50;
            int Ex = 200, Ey = 200;
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(P, P);
            Shapes.Move(eat, Ex, Ey);


            while(true)
            {
                Turtle.Move(10);

                if (Turtle.X > Ex && Turtle.X < Ex + P && Turtle.Y > Ey && Turtle.Y < Ey + P)
                {
                    Ex = Ex + P;
                    //Turtle.X = 250;
                    //Turtle.Y = 200;
                    Shapes.Move(eat, Ex, Ey);

                }
            }


        }

       

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;            
            }
            else if (GraphicsWindow.LastKey =="Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}

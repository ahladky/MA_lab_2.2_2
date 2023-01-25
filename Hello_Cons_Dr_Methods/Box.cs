using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box

        public enum Valid_char
        {
            Star = '*',
            Plus = '+',
            Dot = '.'
        }
        public int Width;
        public int Height;
        public Valid_char C;
        public string Msg;


        public Box(int w, int h, Valid_char c, string msg)
        {
            Width = w;
            Height = h; 
            C = c; 
            Msg = msg;     
        }

        private string Valid_msg(string msg)
        {
            string valid_msg;
            char[] charsToTrim = { '*', '.' };
            valid_msg = msg.Trim(charsToTrim);
            if (valid_msg.Length > Width - 2)
            {
                valid_msg = valid_msg.Substring(0, Width - 2);
            }
            return valid_msg;
        }

        private void Draw_rectangle (int x, int y, Valid_char c)
        {

            for (int i = 0; i <= Width; i+=2)
            {
                for (int j = 0; j <= Height; j++)
                {
                    if (j == 0 | j == Height)
                    {
                        Console.SetCursorPosition(i + x, j + y);
                        Console.WriteLine((char)c);
                    }
                    if (i == 0 | i == Width)
                    {
                        Console.SetCursorPosition(i + x, j + y);
                        Console.WriteLine((char)c);
                    }
                }
            }
            int e = 0; 
        }

        private void TextInFigure(int x, int y, string msg)
        {
            for (int i = 0; i <= Width; i++)
            {
                for (int j = 0; j <= Height; j++)
                {
                  if (i == Width / 2 - Msg.Length / 2 && j == Height / 2)
                    {
                        Console.SetCursorPosition(i + x, j + y);
                        Console.WriteLine(msg);
                    }
                }
            }
            Console.SetCursorPosition(0, y + Height + 1);
        }
        public void Draw()
        {
            int X = Console.WindowWidth / 2 - Width/2;
            int Y = Console.WindowHeight / 2  - Height / 2;

            Msg = Valid_msg(Msg);
            Draw_rectangle(X, Y, C);
            TextInFigure(X, Y, Msg);

            //draw(X, Y, C);
        }

        private void draw(int x, int y, Valid_char c)
        {
            int X = Console.WindowWidth / 2 - Width / 2;
            int Y = Console.WindowWidth / 2 - Width / 2;

            for (int i = 0; i <= 20; i+=2)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (j == 0 | j == 10)
                    {
                        Console.SetCursorPosition(i + x, j + y);
                        Console.WriteLine((char)c + " ");
                    }
                    if (i == 0 | i == 20)
                    {
                        Console.SetCursorPosition(i + x, j + y);
                        Console.WriteLine((char)c);
                    }
                }
            }
        }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary


    }
}

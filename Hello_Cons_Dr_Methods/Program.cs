using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Implement start position, width and height, symbol, message input

                //Create Box class instance

                //Use  Box.Draw() method
                Box b = new Box(Console.WindowWidth / 2,Console.WindowHeight /2, Box.Valid_char.Star, "...msg_text123456***");
                b.Draw();

            Console.WriteLine("Press any key...");
            Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}

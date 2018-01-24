using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
			int firstnum;
			int secondnum;
			int operation;
			int answer;

			Console.WriteLine("Welcome to my calc");

			Console.WriteLine("Enter the first number in your basic equation:");

			firstnum = Convert.ToInt32(Console.ReadLine());

			Console.Write("Now enter your second number:");

			secondnum = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter operation. (+,-,/,*):");
			operation = Convert.ToInt32(Console.ReadLine());

			switch (operation)


			{
				case 1:

					answer = firstnum - secondnum;
					break;


				case 2:

					answer = firstnum + secondnum;
					break;


				case 3:

					answer = firstnum / secondnum;
					break;


				case 4:

					answer = firstnum * secondnum;
					break;


				default:

					answer = 0;
					break;

			}
			{
				Console.WriteLine(firstnum.ToString() + "" + operation + "" + secondnum.ToString() + " = " + answer.ToString());


				Console.ReadLine();
				
			}

        }
    }
}

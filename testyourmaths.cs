using System;

namespace testyourmaths
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Random r = new Random();
			loop:
			int num1 = r.Next(1, 11);
			int num2 = r.Next(1, 11);
			Console.WriteLine("What is " + num1 + " times " + num2 + "?");
			int ans = Convert.ToInt32(Console.ReadLine());
            if(ans == num1 * num2)
			{
				Console.WriteLine("Well done!!! Correct answer..!!");
				Console.WriteLine("Want to play again..??Y/N");
				string reply = Console.ReadLine();
				if (reply[0] == 'Y' || reply[0] == 'y') 
				{
					goto loop;
				}
			}
			else
			{
				Console.WriteLine("Try Again..!!");
				goto loop;
			}
		}
    }
}

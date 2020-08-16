using System;
using Password_Maker;
using static System.Console;



class Program
{
    static void Main(string[] args)
    {
        var IsnotFinished = true;
        while (IsnotFinished)
        {
            char re;
            Write("Enter Your Password : ");
            string pass = ReadLine();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(ChangeParams.Change(pass));
            ResetColor();
            Write("do You Want to Retry? [Y/N] : ");
            try
            {
               re = Convert.ToChar(ReadLine().ToLower());
               if (re == 'y')
               {
                   IsnotFinished = true;
               }
               else if (re == 'n')
               {
                   IsnotFinished = false;
               }
               else
               {
                   ForegroundColor = ConsoleColor.Red;
                   WriteLine("Not found :(");
                   ResetColor();
               }
            }
            catch
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Ohhh No Just Select [Y/N]");
                ResetColor();
            }
          
        }
     
    }
}

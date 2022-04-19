using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Timer ---");
        Console.Write("Input hours: ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input minutes: ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        int periodInSeconds = hours * 60 * 60 + minutes * 60 + seconds;

        for (int i = 0; i < 20; i++)
        {
            StartTimer(periodInSeconds);
            drawTextBar(i, 19);
        }

        Console.CursorLeft = 35;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("Time is over! ");
        Console.ReadLine();
    }
    static string StartTimer(int periodInSeconds)
    {
        Thread.Sleep(periodInSeconds * 50);
        return "";
    }
    private static void drawTextBar(int progress, int total)
    {
        //draw empty progress bar
        Console.CursorLeft = 0;
        Console.Write("["); //start
        Console.CursorLeft = 32;
        Console.Write("]"); //end
        Console.CursorLeft = 1;
        float onechunk = 30.0f / total;

        //draw filled part
        int position = 1;
        for (int i = 0; i < onechunk * progress; i++)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.CursorLeft = position++;
            Console.Write(" ");
        }

        //draw unfilled part
        for (int i = position; i <= 31; i++)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.CursorLeft = position++;
            Console.Write(" ");
        }

        //draw totals
        Console.CursorLeft = 35;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("In progress...");
    }
}
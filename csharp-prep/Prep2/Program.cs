using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade in Percentage? ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);
        // int A = 90;
        // int B = 80;
        // int C = 70;
        // int D = 60;
        // int F = 59;
        string letter ="";

        if (grade >= 90)

        {
            letter = "A";    
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade>= 60)
        {
            letter= "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine ($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine ("You passed! Congrats!");
        }
        else
        {
            Console.WriteLine ("Better luck next time! ");
        }
    }
}
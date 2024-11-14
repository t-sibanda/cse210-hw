using System;
class LetterGradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        float gradePercentage = float.Parse(Console.ReadLine());

        string letterGrade = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        bool passed = gradePercentage >= 70;
        if (passed)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do it next time.");
        }

        string sign = "";
        if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }

        Console.WriteLine("Your letter grade is {0}{1}", letterGrade, sign);

        
        if (letterGrade == "A" && sign == "+")
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else
        {
            Console.WriteLine("Your letter grade is {0}{1}", letterGrade, sign);
        }

        if (letterGrade == "F")
        {
            Console.WriteLine("Your letter grade is F.");
        }
        else
        {
            Console.WriteLine("Your letter grade is {0}{1}", letterGrade, sign);
        }
    }
}
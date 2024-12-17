using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment basicAssignment = new Assignment("Laangah Atida", "Addition and Subtraction");
        Console.WriteLine(basicAssignment.GetSummary());
        
        MathAssignment mathAssignment = new MathAssignment("Terry Sibanda", "Calculus", "9.3", "18-29");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        
        WritingAssignment writingAssignment = new WritingAssignment("Nolu Tsitsi", "European History", "The Sarajevo Incident");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}

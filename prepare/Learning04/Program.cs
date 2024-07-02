using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Emily", "HW");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("Emily", "HW", "Chapter 12", "12");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("Emily", "HW", "Writing Title");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());

    }
}
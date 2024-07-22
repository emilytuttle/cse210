using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running("05 July 2024", 45, 5);
        Cycling cycling = new Cycling("07 July 2024", 30, 20);
        Swimming swimming = new Swimming("09 July 2024", 40, 40);

        activitiesList.Add(running);
        activitiesList.Add(cycling);
        activitiesList.Add(swimming);

        foreach (Activity activity in activitiesList)
        {
            activity.GetSummary();
        }
    }
}
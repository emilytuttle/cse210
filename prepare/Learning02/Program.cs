using System;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2014;
        job1._endYear = 2018;
    

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Adobe";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "emily";
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);
    
        resume1.Display();




    }
}
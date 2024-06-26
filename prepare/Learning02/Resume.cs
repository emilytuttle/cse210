using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobList = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (Job job in _jobList)
        {
            job.Display();
        }
    }
  
}
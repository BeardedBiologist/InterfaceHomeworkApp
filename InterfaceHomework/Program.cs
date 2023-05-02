using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IRun> runningObjects = new List<IRun>();
        runningObjects.Add(new Person());
        runningObjects.Add(new Animal());

        foreach (var runningObject in runningObjects)
        {
            runningObject.Run();
        }
    }
}
using System;

//Console.log //activites

namespace CsharpClasses
{

    //static (by using html we prepare static webpages) * dynamic
    static class Logger
    {
        public static void LogInfo(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogWarning(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogError(string message)
        {
            Console.WriteLine(message);
        }
        //public void getMessage()
        //{

        //}

    }


    class StaticMainProgram
    {
        public void getMessage()
        {

        }
        public static void Main()
        {
            Logger.LogInfo("My message");
            Logger.LogWarning("My message");
            Logger.LogError("My message");
        }

    }


}

// Information --> Log


// Person1 Mobile ________________ 10 days


// police he has to connect with one department , he want to see Report - he will get that

// Client has to check customer1 related activites. wen he logged in _> how long he has 
// stayed in the application . what kind of information he has searched in the app


// Exact real time -> For find out the ISSUES

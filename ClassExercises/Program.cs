using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //----- to use the stopwatch code, uncomment the following:

            //StopWatch stopWatch = new StopWatch();
            //string input = "";

            //Console.WriteLine("Welcome to the stopwatch! Please type \"start\" to start the watch, and \"stop\" to turn it off!");
            //Console.WriteLine("When done, type \"quit\" to quit.");

            //while(input != "quit")
            //{
            //    Console.WriteLine("Please insert input:");
            //    input = Console.ReadLine();
            //    switch (input)
            //    {
            //        case "start":
            //            Console.WriteLine("starting Stopwatch");
            //            stopWatch.Start();
            //            break;
            //        case "stop":
            //            Console.WriteLine("Duration was: " + (int)stopWatch.Stop().TotalSeconds + " seconds");
            //            break;
            //        case "quit":
            //            Console.WriteLine("Quitting");
            //            break;
            //    }
            //}

            //Console.ReadKey();

            //----- STOPWATCH END
            //----- Simulating a stackoverflow post

            Post post = new Post("Post nr. 1", "This is my first post! It's great!");
            Console.WriteLine(String.Format("Title: {0} \nDescription: {1} \nVotes: {2}", post.Title, post.Description, post.Votes));
            post.UpVote();
            post.UpVote();
            post.UpVote();
            Console.WriteLine("upvoted 3 times, current votes: " + post.Votes);
            post.DownVote();
            post.DownVote();
            Console.WriteLine("downvoted 2 times, current votes: " + post.Votes);
            Console.ReadKey();
        }
    }
}

using System;
using System.Diagnostics;
namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = string.Empty;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 1; i <=n; i++)
            {
                
                int N = int.Parse(Console.ReadLine());
                if(N==0)
                { output+=" "; }
                else if(N==2)
                { output +="a"; }
                else if (N == 22)
                { output += "b"; }
                else if (N == 222)
                { output += ("c"); }
                else if (N == 3)
                { output += ("d"); }
                else if (N == 33)
                { output += ("e"); }
                else if (N == 333)
                { output += ("f"); }
                else if (N == 4)
                { output += ("g"); }
                else if (N == 44)
                { output += ("h"); }
                else if (N == 444)
                { output += ("i"); }
                else if (N == 5)
                { output += ("j"); }
                else if (N == 55)
                { output += ("k"); }
                else if (N == 555)
                { output += ("l"); }
                else if (N == 6)
                { output += ("m"); }
                else if (N == 66)
                { output += ("n"); }
                else if (N == 666)
                { output += ("o"); }
                else if (N == 7)
                { output += ("p"); }
                else if (N == 77)
                { output += ("q"); }
                else if (N == 777)
                { output += ("r"); }
                else if (N == 7777)
                { output += ("s"); }
                else if (N == 8)
                { output += ("t"); }
                else if (N == 88)
                { output += ("u"); }
                else if (N == 888)
                { output += ("v"); }
                else if (N == 9)
                { output += ("w"); }
                else if (N == 99)
                { output += ("x"); }
                else if (N == 999)
                { output += ("y"); }
                else if (N == 9999)
                { output += ("z"); }
         

            }

            Console.WriteLine(output);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            Console.WriteLine(stopWatch.ElapsedMilliseconds);


        }
    }
}

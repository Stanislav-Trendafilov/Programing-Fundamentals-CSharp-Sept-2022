using System;
using System.Linq;
namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];
            int[] initialIndexes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (int index in initialIndexes)
            {
                if(index>=0&&index<field.Length)
                { 
                    field[index] = 1;
                }
            }
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] cmd = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybugsIndex = int.Parse(cmd[0]);
                string direction = cmd[1];
                int flyLength = int.Parse(cmd[2]);
                if(ladybugsIndex<0||ladybugsIndex>=field.Length)
                { 
                    continue; 
                }
                if(field[ladybugsIndex]==0)
                { 
                    continue;
                }

                field[ladybugsIndex] = 0;
                if(direction=="left")
                { 
                    flyLength *= -1;
                }
                int nextIndex = ladybugsIndex + flyLength;
                while(nextIndex>=0&&nextIndex<field.Length&&field[nextIndex]==1)
                {
                    nextIndex += flyLength; 
                }

                if(nextIndex<0||nextIndex>=field.Length)
                {
                    continue;
                }
                field[nextIndex] = 1;
            }
            Console.WriteLine(string.Join(" ",field));
        }


    }
}

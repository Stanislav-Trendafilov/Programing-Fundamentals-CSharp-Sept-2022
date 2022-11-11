using System;
using System.Collections.Generic;
using System.Linq;
namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                .ToList();

            string command = Console.ReadLine();
            while(command!= "course start")
            {
                string[] commandArg = command.Split(":");
                if(commandArg[0]=="Add")
                {
                    string word = commandArg[1];
                    if(!schedule.Contains(word))
                    { schedule.Add(word); }
                    
                }
                else if(commandArg[0]=="Insert")
                {
                    string word = commandArg[1];
                    int index = int .Parse(commandArg[2]);
                    if(!schedule.Contains(word))
                     { schedule.Insert(index,word); }
                }
                else if (commandArg[0] == "Remove")
                {
                    string word = commandArg[1];
                    if (schedule.Contains(word))
                    { schedule.Remove(word); }
                    if (schedule.Contains("Exercise")) ;
                    { schedule.Remove(word+"-Exercise"); }
                }
                else if (commandArg[0] == "Swap")
                {
                    string swap = string.Empty;
                    string word1 = commandArg[1];
                    string word2 = commandArg[2];
                    string word3="Exercise";
                    int br = 0;
                    int Ind1=0, Ind2=0, Ind3=0;
                    for (int i = 0; i < schedule.Count; i++)
                    {
                      
                        if(word1==schedule[i])
                        { 
                            word1 = schedule[i];
                            Ind1 = i;
                            br++;
                        }
                        if (word2 == schedule[i])
                        { 
                            word2 = schedule[i];
                            Ind2 = i;
                            br++;
                        }  
                        if(schedule[i].Contains("Exercise"))
                        {
                            {
                               word3 = schedule[i];
                               Ind3 = i;
                               br++;
                            }
                        }
                    }
                    if (br == 2)
                    {
                        swap = schedule[Ind1];
                        schedule[Ind1] = schedule[Ind2];
                        schedule[Ind2] = swap;

                    }
                    else if (br == 3)
                    {
                        swap = schedule[Ind1];
                        schedule[Ind1] = schedule[Ind2];
                        schedule[Ind2] = swap;
                        if (schedule[Ind3].Contains(word1))
                        {
                            schedule.Insert(Ind2 + 1, schedule[Ind3]);
                            schedule.RemoveAt(Ind3+1);
                        }
                        else if (schedule[Ind3].Contains(word2))
                        {
                            schedule.Insert(Ind1 + 1, schedule[Ind3]);
                            schedule.RemoveAt(Ind3+1);
                        }
                    }


                }
                else if(commandArg[0]== "Exercise")
                {
                    string title = commandArg[1];
                    int index = 0;
                    if(schedule.Contains(title)&&!schedule.Contains("Exercise"))
                    {
                        for (int i = 0; i < schedule.Count; i++)
                        {
                            if(title==schedule[i])
                            { index = i+1; }
                        }
                        string ex = title + "-Exercise";
                        schedule.Insert(index, ex);
                    }
                    else if(!schedule.Contains(title))
                    {
                        schedule.Insert(schedule.Count, title);
                        string ex = title + "-Exercise";  
                        schedule.Insert(schedule.Count,ex);
                    }
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < schedule.Count; i++)
            {
               
                Console.WriteLine($"{i+1}.{schedule[i]}");
            }
 
        }
    }
}

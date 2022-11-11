using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            string command = Console.ReadLine();
            while(command!="3:1")
            {
                string[] arg = command.Split(" ");
                string action = arg[0];
                if (action == "merge")
                {
                    int start = int.Parse(arg[1]);
                    int end = int.Parse(arg[2]);
                    if (start < 0||start>words.Count-1)
                    {
                        start = 0;
                    }
                    if (end > words.Count - 1)
                    {
                        end = words.Count - 1;
                    }
                    string mergedText = string.Empty;
                    for (int i = start; i <= end; i++)
                    {
                        mergedText+= words[start];
                        words.RemoveAt(start);
                    }
                    words.Insert(start,mergedText);
                }
                else if(action=="divide")
                {
                    int index = int.Parse(arg[1]);
                    int multiplator = int.Parse(arg[2]);
                    // simvola w edna chast            chast
                    int parts = words[index].Length / multiplator;
                    string currentString = words[index];
                    if (words[index].Length % multiplator == 0)
                    {
                        for (int i = 0; i < multiplator; i++)
                        {
                            string currentWord = string.Empty;

                            for (int j = i * parts; j < (i * parts) + parts; j++)
                            {
                                currentWord += currentString[j];
                            }
                            words.Insert(index + i, currentWord);
                        }
                        words.RemoveAt(index + multiplator);
                    }
                    else if(words[index].Length % multiplator != 0)
                    {
                        int ostatak = words[index].Length % multiplator;
                        for (int i = 0; i < multiplator; i++)
                        {
                            string currentWord = string.Empty;
                            if (i != multiplator - 1)
                            {
                                for (int j = i * parts; j < (i * parts) + parts; j++)
                                {
                                    currentWord += currentString[j];
                                }
                                words.Insert(index + i, currentWord);
                            }
                            else if(i==multiplator-1)
                            {
                                for (int j = i * parts; j < (i * parts) + parts+ostatak; j++)
                                {
                                    currentWord += currentString[j];
                                }
                                words.Insert(index + i, currentWord);
                            }
                        }
                        words.RemoveAt(index + multiplator);

                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",words));
        }
    }
}

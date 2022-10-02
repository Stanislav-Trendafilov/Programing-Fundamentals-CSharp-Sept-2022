using System;
using System.Linq;
namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input;
            int maxBr=0, currentBr = 0, maxIndex=0,currentSum=0,maxSum=0,arrIndex=0,maxArrIndex=0;

            int[] bestSequence = new int[sequenceLength];

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                arrIndex++;
                currentBr = 0;
                currentSum = 0;
                int[] sequence = input
                    .Split('!',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int k = 0; k < sequence.Length; k++)
                {
                    currentSum += sequence[k];
                }
                for (int i = 0; i < sequence.Length; i++)
                {
                    currentBr = 0;
                    for (int j = i + 1; j < sequence.Length; j++)
                    {
                        if (sequence[i]== sequence[j])
                        { 
                            currentBr++;
                        }
                        else 
                        {
                            break;
                        }
                    }

                    if (currentBr > maxBr)
                    {
                        maxBr = currentBr;
                        maxIndex = i;
                        maxSum = currentSum;
                        maxArrIndex = arrIndex;
                        for (int j = 0; j < sequenceLength; j++)
                        {
                            bestSequence[j] = sequence[j];
                        }
                    }
                    else if(currentBr==maxBr)
                    { 
                        if(maxIndex>i)
                        {
                            maxBr = currentBr;          
                            maxSum = currentSum;
                            maxIndex = i;
                            maxArrIndex = arrIndex;
                            for (int j = 0; j < sequenceLength; j++)
                            {
                                bestSequence[j] = sequence[j];
                            }
                        }
                        else if(maxIndex==i)
                        {
                            if(currentSum>maxSum)
                            {
                                maxBr = currentBr;
                                maxSum = currentSum;
                                maxIndex = i;
                                maxArrIndex = arrIndex;
                                for (int j = 0; j < sequenceLength; j++)
                                {
                                    bestSequence[j] = sequence[j];
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {maxArrIndex} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ",bestSequence));

            
        }
    }       
}

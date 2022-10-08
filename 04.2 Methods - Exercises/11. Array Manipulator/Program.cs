using System;
using System.Linq;
namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ');
                string cmdType = cmdArgs[0];
                if (cmdType == "exchange")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    arr = ExchangeArray(arr, index);
                }
                else if (cmdType == "max")
                {
                    string evenOrOddArg = cmdArgs[1];
                    int indexOfMaxEl = IndexOfMaxEvenOrOddEllement(arr, evenOrOddArg);
                    if(indexOfMaxEl==-1)
                    { 
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(indexOfMaxEl);
                }
                else if (cmdType == "min")
                {
                    string evenOrOddArg = cmdArgs[1];
                    int indexOfMinEl = IndexOfMinEvenOrOddEllement(arr, evenOrOddArg);
                    if (indexOfMinEl == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(indexOfMinEl);
                }
                else if(cmdType=="first"||cmdType=="last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    string evenOrOddArg = cmdArgs[2];
                    if(count>arr.Length)
                    { 
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    int[] elements;
                    if(cmdType=="first")
                    {
                        elements = FirstEvenOrOddElements(arr, count, evenOrOddArg); 
                    }
                    else
                    { elements = LastEvenOrOddElements(arr, count, evenOrOddArg); }
                    PrintArray(elements);
                }
               
            }
            PrintArray(arr);
        }
    

        static int[]ExchangeArray(int[]originalArr,int index)
        {
            int [] modifiedArr = new int[originalArr.Length];
            int modifiedArrIndex = 0;
            for (int i = index+1; i < originalArr.Length; i++)
            {
                modifiedArr[modifiedArrIndex] = originalArr[i];
                modifiedArrIndex++;
            }
            for (int i = 0; i <=index; i++)
            {
                modifiedArr[modifiedArrIndex] = originalArr[i];
                modifiedArrIndex++;
            }
            return modifiedArr;
        }
        static int IndexOfMaxEvenOrOddEllement(int[]arr,string evenOrOddArg)
        {
            int maxIndex = -1;
            int currMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOddArg=="even"&&currNum%2==0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
                else if(evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
            }
            return maxIndex;
        }
        static int IndexOfMinEvenOrOddEllement(int[] arr, string evenOrOddArg)
        {
            int minIndex = -1;
            int currMin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
            }
            return minIndex;
        }
        static int[] FirstEvenOrOddElements(int[] arr,int count,string evenOrOddArg)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (firstElArrIndex >= count)
                {
                    break;
                }
                int currNum = arr[i];
                if(evenOrOddArg=="even"&&currNum%2==0)
                {                
                    firstElArr[firstElArrIndex++] =currNum;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {       
                    firstElArr[firstElArrIndex++] = currNum;
                }
            }
            firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            return firstElArr;
        }
        static int[] LastEvenOrOddElements(int[] arr, int count, string evenOrOddArg)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (firstElArrIndex >= count)
                {
                    break;
                }

                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
            }
            firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            firstElArr = ReverseArray(firstElArr);
            return firstElArr;
        }
        static int[]ResizeArray(int[]originalArr,int count)
        {
            int[] modifiedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = originalArr[i];
            }
            return modifiedArray;
        }
        static int[]ReverseArray(int[]originalArray)
        { 
            int[] reversed = new int[originalArray.Length];
            for (int i = originalArray.Length-1; i >=0; i--)
            {
                reversed[reversed.Length - i - 1] = originalArray[i];
            }
            return reversed;
        }
        static void PrintArray(int[]arr)
        { Console.WriteLine($"[{String.Join(", ",arr)}]"); }
    }
}

using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());                   
           for (char ch = 'a'; ch < (int)'a'+n; ch++)               
           {                                                        
               for (char j = 'a'; j < (int)'a' + n; j++)            
               {                                                    
                   for (char k= 'a'; k < (int)'a' + n; k++)         
                   {                                                
                       Console.WriteLine($"{ch}{j}{k}");            
                   }                                                
               }                                                    
           }                                                        
           // for (char k = 'a'; k <(int)'a'+ n; k++)               
           // {                                                     
           //     Console.Write(k);                                 
           //     Console.WriteLine("");                            
           // }
        }
    }
}

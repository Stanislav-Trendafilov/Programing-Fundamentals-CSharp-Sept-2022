using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_").ToArray();
                Song song = new Song();
                song.TypeSong = input[0];
                song.Name = input[1];
                song.Time = input[2];

                songs.Add(song);
            }
            string command = Console.ReadLine();
            for (int i = 0; i < songs.Count; i++)
            {
                if(command==songs[i].TypeSong)
                {
                    Console.WriteLine($"{songs[i].Name}");
                }   
                else if(command == "all")
                { Console.WriteLine($"{songs[i].Name}"); }
            }
        }
    }
    public class Song
    {
        //public Song(string typeList,string name,string time)
        //{
        //    TypeSong = typeList;
        //    Name = name;
        //    time = Time;
        //}
      
        public string TypeSong { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}


using System;

namespace lectire13_1
{
    class Song
    {
        string songName;
        string autor;
        string year;
        string minutes;

        public object GetSongData()
        {
            Song song = new Song();
            Console.WriteLine("Song name?");
            song.songName = Console.ReadLine();
            Console.WriteLine("Autor?");
            song.autor = Console.ReadLine();
            Console.WriteLine("Song year?");
            song.year = Console.ReadLine();
            Console.WriteLine("Minutes?");
            song.minutes = Console.ReadLine();
            object info = new { song.autor, song.minutes, song.year };
            return info;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            object info = song.GetSongData();
            Console.WriteLine(info);
            Console.ReadKey();
        }
    }
}

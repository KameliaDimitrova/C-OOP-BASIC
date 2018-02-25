using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Online_Radio_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(';')
                    .ToList();

                if (input.Count == 3)
                {
                    var duration = input[2].Split(':', StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (duration.Count >=1&&duration.Count<=2&&int.TryParse(duration[0],out var minutes))
                    {
                        try
                        {
                            var seconds = 0;
                            if (duration.Count == 2)
                            {
                                if (!int.TryParse(duration[1], out seconds))
                                {
                                    Console.WriteLine("Invalid song length.");
                                    break;
                                }
                            }
                            Song song = new Song(input[0], input[1], minutes,seconds);
                            songs.Add(song);
                            Console.WriteLine(AddSong());
                        }
                        catch (ArgumentException argEx)
                        {
                            Console.WriteLine(argEx.Message);
                        }
                    }
                    else
                        Console.WriteLine("Invalid song length.");
                }
                else
                    Console.WriteLine("Invalid song.");
            }
            var totalSongsDurationInSeconds = TimeSpan.FromSeconds(songs.Sum(x => x.Minutes * 60) + songs.Sum(x => x.Seconds));
            var totalFormatedDuration =
                string.Format(
                    $"{totalSongsDurationInSeconds.Hours}h {totalSongsDurationInSeconds.Minutes}m {totalSongsDurationInSeconds.Seconds}s");

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {totalFormatedDuration}");
        }

        private static string AddSong()
        {
            return "Song added.";
        }
        
    }
}

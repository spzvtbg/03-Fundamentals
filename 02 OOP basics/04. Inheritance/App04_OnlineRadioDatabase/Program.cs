using System;

public class Program
{
    public static void Main()
    {
        var playlist = new RadioDb();
        var songs = int.Parse(Console.ReadLine());

        for (int count = 0; count < songs; count++)
        {
            var line = Console.ReadLine().Split(';');

            var artist = line[0];
            var title = line[1];

            var duration = line[2].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            var minutes = default(int);
            var seconds = default(int);

            if (!int.TryParse(duration[0], out minutes) || !int.TryParse(duration[1], out seconds))
            {
                Console.WriteLine("Invalid song length.");
                continue;
            }
           

            try
            {
                playlist.AddNew(new Song(artist, title, minutes, seconds));
                Console.WriteLine("Song added.");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        Console.WriteLine("Songs added: " + playlist.SongsAdded);
        Console.WriteLine($"Playlist length: {playlist.PlayListLength.Hours}h {playlist.PlayListLength.Minutes}m {playlist.PlayListLength.Seconds}s");
    }
}

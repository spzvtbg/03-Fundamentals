using System;
using System.Collections.Generic;

public class RadioDb
{
    private ICollection<Song> songs;

    public RadioDb()
    {
        this.songs = new List<Song>();
    }

    public int SongsAdded
    {
        get
        {
            return this.songs.Count;
        }
    }

    public TimeSpan PlayListLength
    {
        get
        {
            var totalTime = new TimeSpan(0, 0, 0);

            foreach (var song in this.songs)
            {
                totalTime = totalTime.Add(song.SongLength);
            }

            return totalTime;
        }
    }

    public void AddNew(Song song)
    {
        this.songs.Add(song);
    }
}

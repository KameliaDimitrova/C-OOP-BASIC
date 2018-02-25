using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

public class Song : Validator
{
    private string artistName;

    public string ArtistName
    {
        get { return artistName; }
        private set
        {
            ValidateArtistName(value);
            artistName = value;
        }
    }

    private string songName;

    public string SongName
    {
        get { return songName; }
        private set
        {
            ValidateSongName(value);
            songName = value;
        }
    }

    private int minutes;

    public int Minutes      
    {
        get { return minutes; }
        private set
        {
            ValidateMinutes(value);
            minutes = value;
        }
    }

    private int seconds;

    public int Seconds
    {
        get { return seconds; }
        private set
        {
            ValidateSeconds(value);
            seconds = value;
        }
    }

    public Song(string artistName, string songName, int minutes,int seconds)
    {
        ValidateSongDuration(minutes,seconds);
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }
}
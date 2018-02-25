using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


public class Validator
{
    protected void ValidateArtistName(string artistName)
    {
        if (artistName.Length < 3 || artistName.Length > 20)
        {
            throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
        }
    }

    protected void ValidateSongName(string songName)
    {
        if (songName.Length < 3 || songName.Length > 30)
        {
            throw new ArgumentException("Song name should be between 3 and 30 symbols.");
        }
    }

    protected void ValidateSongDuration(int minutes, int seconds)
    {
        if (minutes * 60 + seconds < 0 || minutes * 60 + seconds > 899) //14 minutes:59 seconds
        {
            throw new ArgumentException("Invalid song length.");
        }
    }

    protected void ValidateMinutes(int minutes)
    {
        if (minutes < 0 || minutes > 14)
        {
            throw new ArgumentException("Song minutes should be between 0 and 14.");
        }
    }

    protected void ValidateSeconds(int seconds)
    {
        if (seconds < 0 || seconds > 59)
        {
            throw new ArgumentException("Song seconds should be between 0 and 59.");
        }
    }
}




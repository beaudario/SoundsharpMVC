using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundsharpMVC.Models
{
    public static class DataProvider
    {
        public static List<Track> GenerateDefaultTracks()
        {
            List<Track> trackList = new List<Track>();
            Track t1 = new Track();
            t1.Name = "Yellow";
            t1.Artist = "Coldplay";
            t1.AlbumSource = "Parachutes";
            t1.Length = new Time(0, 4, 29);
            t1.Style = Category.Pop;

            Track t2 = new Track();
            t2.Name = "Shiver";
            t2.Artist = "Coldplay";
            t2.AlbumSource = "Parachutes";
            t2.Length = new Time(0, 4, 59);
            t2.Style = Category.Pop;

            Track t3 = new Track(0, "Maneater");
            t3.Artist = "Nelly Futado";
            t3.AlbumSource = "Loose";
            t3.Style = Category.Pop;
            t3.Length = new Time(281);

            Track t4 = new Track(4, "Guitar", "Prince");
            t4.Style = Category.Pop;
            t4.Length = new Time(3, 72);

            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            trackList.Add(t4);

            return trackList;
        }
    }
}
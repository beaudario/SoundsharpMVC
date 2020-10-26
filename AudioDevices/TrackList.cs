using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    class TrackList
    {
        private List<Track> tracks;

        public TrackList()
        {
            this.tracks = new List<Track>();
        }

        public TrackList(List<Track> tracks)
        {
            this.tracks = tracks;
        }

        public void Add(Track t)
        {
            tracks.Add(t);
        }

        public void Remove(Track t)
        {
            tracks.Remove(t);
        }

        public void Clear()
        {
            tracks.Clear();
        }

        public List<Track> GetAllTracks()
        {
            return tracks;
        }

        public List<Track> Shuffle()
        {
            List<Track> temp = new List<Track>();

            foreach(var track in tracks)
            {
                temp.Add(track);
            }

            List<Track> shuffled = new List<Track>();

            Random r = new Random();

            while(temp.Count > 0)
            {
                int random = r.Next(temp.Count);
                shuffled.Add(temp[random]);
                temp.RemoveAt(random);
            }

            return shuffled;
        }

        public int Count
        {
            get { return tracks.Count; }
        }

        public Time TotalTime
        {
            get
            {
                int seconds = 0;

                foreach(var track in tracks)
                {
                    seconds += track.GetLengthInSeconds();
                }

                return new Time(seconds);
            }
        }
    }
}
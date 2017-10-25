using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO43_2
{

    class CD
    {
        #region PROPERTIES 
        public string Name { get; set; }
        public string Artist { get; set; }
        private List<Track> tracklist;
        #endregion
        #region CONSTRUCTORS
        public CD(string name, string artist)
        {
            Name = name;
            Artist = artist;
            tracklist = new List<Track>();
        }
        #endregion
        #region METHODS
        public void AddTrack(Track x)
        {
            tracklist.Add(x);
        }
        public override string ToString()
        {
            string retval = String.Format("CD data: \n-name: {0} \n-artist: {1} \n-tracks: ", Name, Artist);
            foreach (Track track in tracklist)
            {
                retval += String.Format("\n -{0}, {1}", track.TrackName, track.TrackTime);
            }
            return retval;
        }
        #endregion
    }
    class Track
    {
        #region PROPERTIES 
        public string TrackName { get; set; }
        public string TrackTime { get; set; }
        #endregion
        #region CONSTRUCTORS 
        public Track(string trackname, string tracktime)
        {
            TrackName = trackname;
            TrackTime = tracktime;
        }
        #endregion
    }
}

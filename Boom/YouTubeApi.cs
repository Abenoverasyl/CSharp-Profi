using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class YouTubeApi
    {

        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of Video objects

                throw new Exception("Oops some low level YouTube error.");
            }
            catch (Exception ex)
            {
                //Log

                throw new YouTubeException("Could not fetch the video from Youtube.", ex);
            }
            return new List<Video>();
        }
    }
}

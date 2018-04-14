using System;
using System.Threading;

namespace Events
{
    //Creatinng video tag that derives frim EventArgs 
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoader
    {
        // 1 - Define a delegate 
        // 2 - Define an event based on that dekegate
        // 3 - Raise the event 

        //after video was encoded
        // This is the same thing!
        
        /*
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public event VideoEncodedEventHandler VideoEncoding;
        */
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoding;
        
        public void Encode(Video video)
        {
            // pass our video in function so we can access the properties 
            OnVideoEncoding(video);

            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

            // pass our video in function so we can access the properties 
            OnVideoEncoded(video);
        }

        // To raise an event we have to have a method 
        protected virtual void OnVideoEncoded(Video video)
        {
            Console.WriteLine("Wideo was Encoded");

            if (VideoEncoded != null) VideoEncoded(this, new VideoEventArgs {Video = video});
        }

        protected virtual void OnVideoEncoding(Video video)
        {
            if (VideoEncoding != null)
            {
                Console.WriteLine("Video Is in process of encoding");

                VideoEncoding(this, new VideoEventArgs {Video = video});
            }
        }
    }
}
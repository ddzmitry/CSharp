using System;

namespace Events
{
    public class Messanger
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine(" Video was finished encoding {0} SMS server is sending message ", e.Video.Title);
        }
    }
}
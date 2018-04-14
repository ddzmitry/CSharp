using System;
using System.Threading;

namespace Events
{
    public class PreProcessor
    {
        public void OnVideoEncoding(object source, VideoEventArgs e)
        {
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine("Process video {1} is At {0} %", i,e.Video.Title);
                Thread.Sleep(10);
                Console.Clear();
            }

        }
    }
}
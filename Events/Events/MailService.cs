using System;

namespace Events
{
    public class MailService
    {

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Male servise is sending an email...about.{0}",e.Video.Title);
        }
    }
}
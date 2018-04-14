using System;

namespace Events
{
    public class MailService
    {

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail servise tells {0} is done incoding is sending an email...", e.Video.Title);
        }
    }
}
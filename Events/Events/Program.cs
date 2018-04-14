using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var video = new Video(){Title = "Home Alone"};
            var encoder = new VideoEncoader(); //publisher
            var mailService = new MailService(); //subscriber 
            var messageService = new Messanger();

            // VideoEncoding subscriber 
            var preProcessor = new PreProcessor();

            //registering subscriptpion on event
            
            //encodING event
            encoder.VideoEncoding += preProcessor.OnVideoEncoding;

            //EncodeED event 
            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;
            encoder.VideoEncoded += Dorefactor;
            encoder.Encode(video);


        }

        public static void Dorefactor(object source ,VideoEventArgs e)
        {
            Console.WriteLine("Refactor is done and video {0} is ready",e.Video.Title);
        }
        
}


}

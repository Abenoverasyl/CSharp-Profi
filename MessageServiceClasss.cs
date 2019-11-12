using System;
using System.Collections.Generic;
using System.Text;

namespace tutorials
{
    class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending an message..." + args.Video.Title);
        }
    }
}

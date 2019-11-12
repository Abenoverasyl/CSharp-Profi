using System;
using System.Collections.Generic;
using System.Text;

namespace tutorials
{
    class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}

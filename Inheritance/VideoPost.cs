using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance
{
    class VideoPost : Post
    {
        //member Fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        //porperties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, string videoURL, bool isPublic, int length)
        {
            this.PostID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.VideoURL = videoURL;
            this.IsPublic = isPublic;
            this.Length = length;
        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }

        }
        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}s");
                GC.Collect();
            }
            else
                Stop();
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {currDuration}s");
                currDuration = 0;
                timer.Dispose();
            }
        }
        public override string ToString()
        {
            return String.Format($"{PostID} - {Title} - {VideoURL} - {Length} by {SendByUserName}");
        }
    }
}

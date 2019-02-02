using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Post
    {
        private static int currentPostID;

        protected int PostID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            PostID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Dustin Cummings";
        }
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.PostID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
        }
        public int GetNextID()
        {
            return ++currentPostID;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{PostID} - {Title} - by {SendByUserName}");
        }
    }
}

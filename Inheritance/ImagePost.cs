using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ImagePost:Post
    {
        public string ImageURL { get; set; }

        public ImagePost() {}

        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            this.PostID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format($"{PostID} - {Title} - {ImageURL} by {SendByUserName}");
        }
    }
}

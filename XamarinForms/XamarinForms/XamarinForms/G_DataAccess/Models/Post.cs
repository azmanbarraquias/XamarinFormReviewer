using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.G_DataAccess.Models
{
    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
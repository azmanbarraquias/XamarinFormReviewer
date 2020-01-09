using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.E_Navigation._Exercies.Domain
{
    public class Activity
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public string ImageURL
        {
            get { return string.Format(@"https://i.picsum.photos/id/{0}/300/300.jpg", UserId * 5); }
        }
    }
}

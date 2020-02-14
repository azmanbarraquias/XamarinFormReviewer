using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.E_Navigation._Exercies.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
      
        public string ImageURL
        {
            get { return $"https://i.picsum.photos/id/{Id * 5}/300/300.jpg"; }
        }
    }
}

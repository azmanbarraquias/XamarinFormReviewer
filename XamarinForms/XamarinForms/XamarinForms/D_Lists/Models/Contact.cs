using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.D_Lists.Models
{
    public enum Status {Online, Offline, Busy, Away };

    public class Contact
    {  
        public string Name { get; set; }

        public Status Status { get; set; }

        public string ImageURL { get; set; }
    }
    
}

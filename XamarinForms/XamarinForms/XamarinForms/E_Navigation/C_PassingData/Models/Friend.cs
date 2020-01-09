using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.E_Navigation.C_PassingData.Models
{
    public enum Status { Online, Offline, Busy, Away };

    public class Friend
    {
        public string Name { get; set; }

        public Status Status { get; set; }

        public string ImageURL { get; set; }
    }

}

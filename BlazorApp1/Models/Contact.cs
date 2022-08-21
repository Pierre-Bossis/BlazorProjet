using System;

namespace BlazorApp1.Models
{
    [Serializable]
    public class Contact
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }
    }
}

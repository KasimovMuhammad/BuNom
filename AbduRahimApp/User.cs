
using System;
namespace AbduRahimApp
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public User(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}

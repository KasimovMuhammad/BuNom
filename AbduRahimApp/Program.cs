using System;
namespace AbduRahimApp
{
    class Program
    {
        static void Main() 
        {
            User user = new User("Xabibulla", "Xolmatov");
            user.Gender = (Gender)5;
            Console.WriteLine(user.Gender);
        }
    }
}
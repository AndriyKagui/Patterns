using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Door mainDoor = new Security();
            mainDoor.Open();
            Console.ReadKey();
        }
    }

    class Door
    {
        public virtual void Open()
        {
            Console.WriteLine("Welcome home");
        }
    }

    class Security : Door
    {
        Door door;
        public override void Open()
        {
            Console.WriteLine("Enter password: ");
            var pass = Console.ReadLine();
            if(pass == "my_super_secret_password")
            {
                base.Open();
            }
            else
            {
                Console.WriteLine("Wrong password. we are comming for you!");
            }
        }
    }
}

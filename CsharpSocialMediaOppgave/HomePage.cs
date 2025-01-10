using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CsharpSocialMediaOppgave
{
    internal class HomePage
    {
        Application app = new Application();
        public void IntroScreen()
        {
            Console.WriteLine("Weclome to CoolAppDemo! Please create an account to continue!!!");
            app.CreateUser();

        }
        public void HomeScreen()
        {
            bool running = true;
            Console.WriteLine("Welcome to CoolAppDemo, what do you wanna do?");
            Console.WriteLine("1: Add Friends");
            Console.WriteLine("2: View All Friends");
            Console.WriteLine("3: View Profile");
            Console.WriteLine("4: Delete Friends");
            while (running)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        app.Print();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            }
        }
        }
}

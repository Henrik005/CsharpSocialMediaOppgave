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
        private Application homeApp = new Application();
        private User homeUser = new User();
       
       public void Run(HomePage home)
        {
            homeApp.CreateUser();
            home.HomeScreen();
        }
        public void HomeScreen()
        {
            
            string userName = homeApp.users.Last()._name;
            bool running = true;
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine($"Welcome to CoolAppDemo {userName}, what do you wanna do?");
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
                        homeUser.AddFriend(homeApp);
                        Console.Clear();
                        Thread.Sleep(500);
                        Console.WriteLine("Friend Added! c:");
                        Thread.Sleep(1000);
                        HomeScreen();
                        break;
                    case "2":
                        Console.WriteLine("Here are your friends! Press any key to return");
                        homeUser.ViewAllFriends();
                        Console.ReadKey();
                        Console.Clear();
                        HomeScreen();
                        break;
                    case "3":
                        homeUser.ProfilePage(homeApp);
                        Console.WriteLine("Press any key to return! c:");
                        Console.ReadKey();
                        Console.Clear();
                        Thread.Sleep(500);
                        HomeScreen();
                        break;
                    case "4":
                        homeUser.RemoveFriend();
                        Console.Clear();
                        Thread.Sleep(500);
                        Console.WriteLine("Good riddance.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        HomeScreen();
                        break;
                }
            }
        }
        }
}

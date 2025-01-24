using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpSocialMediaOppgave
{
    internal class Application
    {
        
        
           public List<User> users = new List<User>
        {
            new ("Kronki",1234,"Kronki@gmail.com",7766,"I like to kronk and i like to jonk" ),
            new ("Lonki", 4321, "Lonki.konki@gmail.com",2288, "I am the lonkest of lonks"),
            new ("Snarfling", 2233, "SnarfTheBarf@gmail.com", 9988, "Don't ever talk to me, for any reason")
        };

        

       
        public void CreateUser()
        {

            Console.WriteLine("Welcome to CoolAppDemo! Please log in to continue!");
            
            Console.WriteLine("What is your name?");
            var input1 = Console.ReadLine();
            Console.WriteLine("What is your password?");
            var input2 = Console.ReadLine();
            int inp2 = Convert.ToInt32(input2);
            Console.WriteLine("What is your gmail?");
            var input3 = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            var input4 = Console.ReadLine();
            int inp4 = Convert.ToInt32(input4);
            Console.WriteLine("Tell us a little about you:");
            var input5 = Console.ReadLine();
            users.Add(new User(input1, inp2, input3, inp4, input5));
            Thread.Sleep(1000);
            



        }
       
    }
}

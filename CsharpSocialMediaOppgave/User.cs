using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CsharpSocialMediaOppgave
{
    internal class User
    {
        public List<User> myFriends = new List<User> { };

        public string _name {  get; private set; }
        public int _password { get; private set; }
        public string _email { get; private set; }
        public int _phone { get; private set; }
        public string _about { get; private set; }
        
        public User(string name, int password, string email, int phone, string about)
        {
            _name = name;
            _password = password;
            _email = email;
            _phone = phone;
            _about = about;
        }
        public User()
        {
            
        }
        public void AddFriend(Application thisApp)
        {
            
            Console.WriteLine("Please write the name of the friend you would like to add! You can even add yourself, if you're wierd.");
            var input = Console.ReadLine();
            foreach(User user in thisApp.users) 
            { 
                if (input == user._name) 
                { 
                    //friend._friends.Add(user); 
                    myFriends.Add(user);
                }
            }
        }
        public void RemoveFriend()
        {
            Console.WriteLine("To delete a friend? Please write the name of the friend you would like to remove!");
            var input = Console.ReadLine();
            int deleteFriend = myFriends.RemoveAll(user => user._name == input);




        }
        public void ViewAllFriends()
        {
            foreach(User user in myFriends) 
            {
                Console.WriteLine("----------");
                Console.WriteLine($"{user._name}");
            }
        }
        public void UserInfo()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"NAME: {_name}");
            Console.WriteLine($"GMAIL: {_email}");
            Console.WriteLine($" About this person: {_about}");
        }
        public void ProfilePage(Application thisApp)
        {
            Console.WriteLine("Please write the name of the profile you would like to view! c:");
            var input = Console.ReadLine();
            foreach (User user in thisApp.users)
            {
                if(input == user._name)
                {
                    user.UserInfo();
                }
            }
        }
    }
}

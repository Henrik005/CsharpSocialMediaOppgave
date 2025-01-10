using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSocialMediaOppgave
{
    internal class User
    {
        public string _name {  get; private set; }
        public int _password { get; private set; }
        public string _email { get; private set; }
        public int _phone { get; private set; }
        public string _about { get; private set; }
        public User (string name, int password, string email, int phone, string about)
        {
            _name = name;
            _password = password;
            _email = email;
            _phone = phone;
            _about = about;
        }
        private void AddFriend()
        {
            Console.WriteLine("Please write the name of the friend you would like to add!");

        }
        private void RemoveFriend()
        {

        }
        public void UserInfo()
        {
            Console.WriteLine($"NAME: {_name}");
            Console.WriteLine($"GMAIL: {_email}");
            Console.WriteLine($" About this person: {_about}");
        }
    }
}

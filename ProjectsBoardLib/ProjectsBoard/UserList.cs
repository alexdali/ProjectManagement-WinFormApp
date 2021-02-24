using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsBoard
{
    public class UserList
    {
        //init new list of users
        private List<User> users = new List<User>();

        // for add user to list
        public void AddUser(string userName)
        {
            if (users.Exists(x => x.Name == userName))
            {
                Console.WriteLine($"User with {userName} already exist");
            }

            users.Add(new User(userName));
        }

        // for remove user from list
        public void RemoveUser(string userName)
        {
            var user = users.Find(x => x.Name == userName);

            if (user != null)
            {
                users.Remove(user);
            }
            else
            {
                Console.WriteLine($"User with {userName} not exist");
            }

        }

        //get array of user's name
        public string[] GetArrayUserName()
        {
            string[] userNameArray = new string[users.Count];    //= users.Select(user => user.Name).ToArray();
            int i = 0;
            foreach(User user in users)
            {
                userNameArray[i] = user.Name;
                i++;
            }

            return userNameArray;
        }
    }
}

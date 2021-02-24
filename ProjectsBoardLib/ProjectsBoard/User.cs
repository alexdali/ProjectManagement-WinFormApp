using System;
using System.Collections.Generic;

namespace ProjectsBoard
{
    //private List<User> list = new List<User>();
    public class User
    {
        public User(string userName)
        {
            this.Name = userName;
        }

        //string name;

        public string Name { get; set; }
    }
}

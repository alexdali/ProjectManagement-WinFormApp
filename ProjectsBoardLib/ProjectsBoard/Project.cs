using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsBoard
{
    public class Project
    {
        public Project(string titleProject)
        {
            TitleProject = titleProject;
            Status = TaskStatus.Open;
        }

        //string titleTask;
        public string TitleProject { get; private set; }

        //public DateTime CreatedTime { get; private set; }

        //public TaskStatus Status { get; private set; }

        //must in Interface IAssignable
        //private List<User> UsersOfTask = new List<User>();

        public void ChangeTitle(string newTitle)
        {
            this.TitleProject = newTitle;
        }
    }
}

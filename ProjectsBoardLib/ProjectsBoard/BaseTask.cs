using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsBoard
{
    public abstract class BaseTask
    {
        public BaseTask(string titleTask)
        {
            TitleTask = titleTask;
            CreatedTime = DateTime.Now;
            Status = TaskStatus.Open;
        }

        //string titleTask;
        public string TitleTask { get; private set; }

        public DateTime CreatedTime { get; private set; }

        public TaskStatus Status { get; private set; }

        //must in Interface IAssignable
        //private List<User> UsersOfTask = new List<User>();

        public void ChangeStatus(TaskStatus newStatus)
        {
            this.Status = newStatus;
        }
    }
}

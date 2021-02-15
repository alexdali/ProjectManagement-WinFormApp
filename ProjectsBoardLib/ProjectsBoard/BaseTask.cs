using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsBoard
{
    class BaseTask
    {
        public BaseTask(string titleTask)
        {
            TitleTask = titleTask;
        }

        public string TitleTask { get; set; }
    }
}

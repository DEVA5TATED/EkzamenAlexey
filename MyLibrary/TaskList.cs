using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class TaskList
    {
        private string _name;
        private List<Task> _tasks;

        public TaskList(string name, List<Task> list)
        {
            this._name = name;
            this._tasks = list;
        }

        public string GetName()
        {
            return _name;
        }
        public List<Task> GetTasks()
        {
            return _tasks;
        }
    }
}

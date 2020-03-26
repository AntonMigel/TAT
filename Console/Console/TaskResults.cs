using System;
using System.Collections.Generic;
using System.Text;

namespace StudentEvent
{
   
        struct TaskResults
        {

            public string Name;
            public string Surname;
            public string Answer;
            public TaskResults(string name, string surname, string task)
            {
                Name = name;
                Surname = surname;
                Answer = task;
            }
        }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentEvent
{
    class Student : ITaskPerformer
    {
        private string _surname;
        private string _name;

        public delegate void StudentHandler(Student student,string str);
        public event StudentHandler Handler;
        public string Surname { get; set; }
        public string Name { get; set; }
        public Student(string name, string surname) 
        {
            Name = name;
            Surname = surname;
        }
        public void DoTask() 
        {
            string result = RandomString.getRandomString();
            Handler?.Invoke(this, result);
        }

    }
}

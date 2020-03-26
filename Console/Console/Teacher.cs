using System;
using System.Collections.Generic;
using System.Text;

namespace StudentEvent
{
    class Teacher
    {
        public List<Student> Group { get; set; }
        public List<Student> ListOfReadyStudents { get; set; }
        public List<TaskResults> TaskResults { get; set; }

        public Teacher()
        {
            Group = new List<Student>();
            ListOfReadyStudents = new List<Student>();
            TaskResults = new List<TaskResults>();
        }

        public void AddStudentInGroup(Student student)
        {
            if (Group.Contains(student) == false)
            {
                Group.Add(student);
                student.Handler += acceptTheWork;
            }
        }
        public void acceptTheWork(Student student, string task)
        {
            if (ListOfReadyStudents.Contains(student) == false)
            {
                TaskResults.Add(new TaskResults(student.Name, student.Surname, task));

                if (Group.Count == TaskResults.Count)
                {
                    foreach (TaskResults result in TaskResults)
                    {
                        Console.WriteLine(result.Name + "  " + result.Surname + "   " + result.Answer);
                    }
                }
            }

        }
    }
}

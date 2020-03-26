using System;
using System.Collections.Generic;

namespace StudentEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countStudent = 10;
            var group = new List<Student>();
         
            for (int i = 0; i < countStudent; i++)
            {
                group.Add(new Student("Vasya"+(i+1).ToString(), "Pupkin"+(i+1).ToString()));
            }

            Teacher teacher = new Teacher();
            foreach (Student student in group)
            {
                teacher.AddStudentInGroup(student);
            }

            foreach (Student student in group)
            {
                student.DoTask();
            }
        }
    }
}

using System.Collections.Generic;

namespace WebAppNet.Models
{
    public class Class
    {
        public Class(int id, List<Student> students, Teacher teacher)
        {
            Id = id;
            Students = students;
            Teacher = teacher;
        }

        public int Id { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        
    }
}
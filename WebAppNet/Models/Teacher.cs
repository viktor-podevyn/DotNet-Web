namespace net_on_the_web.Models
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(int id, string name, int classId, string subject) : base(id, name, classId)
        {
            Subject = subject;
        }
    }
}
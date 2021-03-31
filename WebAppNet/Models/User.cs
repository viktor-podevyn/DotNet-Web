namespace net_on_the_web.Models
{
    public class Person
    {
        public Person (int id, string name, int classId)
        {
            Id = id;
            Name = name;
            ClassId = classId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
    }
}
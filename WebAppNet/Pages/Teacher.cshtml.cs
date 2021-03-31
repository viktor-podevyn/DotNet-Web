using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppNet.Pages
{
    public class TeachersModel : PageModel
    {
        public List<Teacher> Teachers { get; set; }

        public void OnGet()
        {
            var teacherId = 1;
            var classId = 1;    
            
            var koen = new Teacher(teacherId++, "Koen", classId++, "PHP");
            var tim = new Teacher(teacherId++, "Tim", classId++, "JavaScript");
            var sicco = new Teacher(teacherId++, "Sicco", classId++, ".NET");

            Teachers = new List<Teacher>{koen, tim, sicco};
        }
    }
}
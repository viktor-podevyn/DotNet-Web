using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppNet.Models;

namespace WebAppNet.Pages
{
    public class ClassModel : PageModel
    {
        public Class Class { get; set; }
        
        public void OnGet()
        {
            var Viktor = new Student(1, "Viktor", 1);
            var Mark = new Student(2, "Mark", 1);
            var students = new List<Student> {Viktor, Mark};

            var sicco = new Teacher(1, "Sicco", 1, ".NET");

            Class = new Class(1, students, sicco);
        }
    }
}
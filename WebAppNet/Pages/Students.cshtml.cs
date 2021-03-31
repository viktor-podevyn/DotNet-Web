using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppNet.Pages
{
    public class AllStudentsModel : PageModel
    {
        public List<Student> Students;
        
        public void OnGet()
        {
            var id = 1;
            
            var Viktor = new Student(id++, "Viktor", 1);
            var Mark = new Student(id++, "Mark", 1);
            var Alexandra = new Student(id++, "Alexandra", 1);
            var Micha = new Student(id++, "Micha", 1);
            var Paul = new Student(id++, "Paul", 1);

            Students = new List<Student> {Viktor, Mark, Alexandra, Micha, Paul};
        }
    }
}
using EF02.Domain;
using EF02.InfraStructure;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ITI02();

            #region Add
            
            //context.Add(new Instructor { Name = "ahmed nassar", Salary = 10000, Address = " cair", Bouns = 3, HourRate = 3 });
            //var dept = new Department { Name = "CS", HiringDate = new DateOnly(), Inst_id = 5 };
            //context.Add(dept);
            //context.Add(new Topic { Name = "EF Core" });
            //context.Add(new Course { Duration = 3, Name = "EF", Description = "entity framwork core", top_id = 2, });
            //context.Add(new Course { Duration = 4, Name = "ASP.NET", Description = "ASP.NET Core", top_id = 2, });
            //context.Add(new Instructor { Name = "Ahmed nasr", Address = "beni suif", Bouns = 2, HourRate = 4, Salary = 10000 });
            //context.Add(new Department { Name = "CS", HiringDate = new DateOnly(), Inst_id = 1 });
            //context.Add(new Student { Address = "Cairo", Age = 21, Fname = "Mohamed", Lname = "Gamal", dept_id = 1 });
            //context.Add(new Course_Inst { CourseID = 3, InstructorID = 1 });
            //context.Add(new Stud_Course { CourseID = 4, StudentID = 2 });
            #endregion

            #region Read
            //var res = context.students.Where(s => s.Fname == "Mohamed");
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Fname = {item.Fname} : Lname = {item.Lname} : Age = {item.Age} ");
            //}
            #endregion

            #region update
            //var cursor = context.Courses.FirstOrDefault(c => c.Name == "ASP.NET");

            //cursor.Duration = 5; // Update 
            #endregion

            #region Delete
            //var inst = context.Instructors.FirstOrDefault(i => i.ID ==2);
            //context.Remove(inst); // delete 
            #endregion





            context.SaveChanges();





        }
    }
}

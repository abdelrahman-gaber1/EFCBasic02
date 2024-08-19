
namespace EFCBasic02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
            
            dbContext.Set<Student>();
            dbContext.Set<Course>();
            dbContext.Set<Department>();
            dbContext.Set<Topic>();
            dbContext.Set<Instructor>();
            dbContext.Set<Stud_Course>();
            dbContext.Set<Course_Ins>();

            Student std1 = new Student()
            {
                Age = 22,
                FName = "Abdo",
                LName = "Gaber",
                Address = "Giza",
                //Department
            };

            Student std2 = new Student()
            {
                Age = 25,
                FName = "Ahmed",
                LName = "Ali",
                Address = "Giza",
                //Department = dept1,
            };
            dbContext.Set<Student>().Add(std1);
            dbContext.Add(std2);

            Course course1 = new Course()
            {
                CourseId = 1,
                Description = "cpp course",
                Name="C++",
                Duration = DateTime.Now.AddMonths(4) ,
                //topic = topic1,
            };

            dbContext.Add(course1);
            Department dept1 = new Department()
            {
                Name = "Compuer Scince",
                HiringDate = DateTime.Now,
                Students = new List<Student>() { std1 , std2 },
                //Instructors
                //Instructor
            };
            dbContext.Add(dept1);
            Topic topic1 = new Topic()
            {
                Name = "programing language",
                Courses = new List<Course>() { course1 },
            };
            dbContext.Add(topic1);
            Instructor instructor1 = new Instructor()
            {
                Name = "aaa",
                Address = "aaaaaaaaa",
                Bouns = 1000,
                HourRate = 10,
                Salary = 4000,
                Dept = dept1,
                Department = dept1,
            };
            dbContext.Add(instructor1);
            
            dbContext.SaveChanges();

            var stud1 = dbContext.Students.Where(E => E.StudentId == 1);
            var stud2 = dbContext.Students.Where(E => E.StudentId == 2);

            std1.Age = 30;
            dbContext.Update(stud1);
            dbContext.Remove(stud2);
            dbContext.SaveChanges();
        }
    }
}

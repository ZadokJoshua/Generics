using SchoolDataStore.Entities;
using SchoolDataStore.Repo;

var studentInSchool = new MasterCRUD<Student>();
studentInSchool.Create(new Student { Id = "1", Name = "James" });
studentInSchool.Create(new Student { Id = "2", Name = "Sam"});
studentInSchool.Create(new Student { Id = "3", Name = "Edem" });
studentInSchool.Read();

var teahersInSchool = new MasterCRUD<Teacher>();
teahersInSchool.Create(new Teacher { Id = "1", Name = "Abdul", CourseName = "Biology"});
teahersInSchool.Create(new Teacher { Id = "2", Name = "Samuel", CourseName = "Physics" });
teahersInSchool.Read();

Console.Write("You want to delete what teachers record: ");
var elementNum = Convert.ToInt32(Console.ReadLine());
try
{
    teahersInSchool.Delete(elementNum - 1);
}
catch (Exception e)
{

    Console.WriteLine(e.Message); ;
}
teahersInSchool.Read();
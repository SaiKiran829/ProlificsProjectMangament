using System;
using PPM.Main.PPM.Domain;
using PPM.Main.PPM.Model;
namespace PPM.Main.PPM.UI
{
    class UI{
    public void view(){
        Console.WriteLine("Hello Prolifics employee");
        Console.WriteLine("");
        Console.Write("Enter 1 for adding project               ");
        Console.WriteLine("Enter 2 for viewing all projects");
        Console.WriteLine("");
        Console.Write("Enter 3 for adding Employee              ");
        Console.WriteLine("Enter 4 for viewing all Employees");
        Console.WriteLine("");
        Console.Write("Enter 5 for adding Role                  ");
        Console.WriteLine("Enter 6 for viewing all Roles");
        Console.WriteLine("");
        Console.WriteLine("Enter x to exit application");
        ProjectManagement obj = new ProjectManagement();
        EmpManagement obj1 = new EmpManagement();
        RoleManagement obj2 = new RoleManagement();

        Console.WriteLine("");
        var read = Console.ReadLine();
        while (true)
        {
            switch (read)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter the name of project");
                    var add = Console.ReadLine();
                    var newProject = new Project(add);
                    obj.AddingProjects(newProject);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Added Successfully!");
                    Console.WriteLine("");
                    break;
                case "2":
                    obj.ShowProject();
                    break;
                case "3":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter the name of employee");
                    var add1 = Console.ReadLine();
                    var newEmp = new Employee(add1);
                    obj1.AddEmp(newEmp);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Added Successfully!");
                    Console.WriteLine("");
                    break;
                case "4":
                    obj1.ShowEmp();
                    break;
                case "5":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter the name of Role");
                    var add2 = Console.ReadLine();
                    var newRole = new Role(add2);
                    obj2.RoleAdd(newRole);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Added Successfully!");
                    Console.WriteLine("");
                    break;
                case "6":
                    obj2.displayRole();
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }

            Console.WriteLine("Select operation");
            read = Console.ReadLine();
    }
       
        }}
}

using System;
using PPM.Main.PPM.Model;
namespace PPM.Main.PPM.Domain
{
    public class ProjectManagement
{
    List<Project> Projects = new List<Project>();
    
    //Method for adding projects
    public void AddingProjects(Project project)
    {
        Projects.Add(project);
    }
    
    public void displayProject(Project project)
    {
        Console.WriteLine("[" + project.ProjectName + "]");
    }
    
    //Method to view all projects
    public void ShowProject()
    {
        foreach (var e in Projects)
        {
            displayProject(e);
        }
    }
}
public class EmpManagement
{
    List<Employee> empList = new List<Employee>();

    //Method for adding new employee
    public void AddEmp(Employee emp)
    {
        empList.Add(emp);
    }

    public void displayEmp(Employee emp)
    {
        Console.WriteLine("[" + emp.Empname + "]");
    }
    
    //Method for viewing all employees
    public void ShowEmp()
    {
        foreach (var e in empList)
        {
            displayEmp(e);
        }
    }
}
public class RoleManagement
{
    public List<Role> RoleList = new List<Role>();

    //Method for adding roles
    public void RoleAdd(Role role)
    {
        RoleList.Add(role);
    }

    //Method for viewing all roles
    public void displayRole()
    {
        foreach (var e in RoleList)
        {
            Console.WriteLine(e.RoleName);
        }
    }
}
}

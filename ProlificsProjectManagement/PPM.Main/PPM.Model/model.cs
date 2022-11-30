using System;

namespace PPM.Main.PPM.Model
{
    
    public class Project
{
    public string ProjectName { get; set; }

    public Project(string projectname)
    {
        ProjectName = projectname;
    }
}

public class Employee
{
    public string Empname { get; set; }

    public Employee(string empname)
    {
        Empname = empname;
    }
}
public class Role
{
    public string RoleName { get; set; }

    public Role(string roleName)
    {
        RoleName = roleName;
    }
}
    
}
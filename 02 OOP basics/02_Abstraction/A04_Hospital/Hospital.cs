using System.Collections.Generic;

public class Hospital
{
    public Hospital()
    {
        this.Doctors = new List<Doctor>();
        this.Departments = new List<Department>();
    }

    public ICollection<Doctor> Doctors { get; private set; }

    public ICollection<Department> Departments { get; private set; }

}

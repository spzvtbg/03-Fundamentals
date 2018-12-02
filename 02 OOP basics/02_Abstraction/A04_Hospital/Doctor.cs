using System.Collections.Generic;

public class Doctor
{
    private ICollection<string> patients;

    public Doctor()
    {
        patients = new List<string>();
    }


}
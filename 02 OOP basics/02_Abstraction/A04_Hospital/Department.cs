public class Department
{
    private const int bets = 3;
    private const int rooms = 20;

    private int bet = default(int);
    private int room = -1;
    private string name;

    private string[,] patients;

    public Department()
    {
        this.patients = new string[bets, rooms];
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length > 1 && value.Length < 100)
            {
                this.name = value;
            }
        }
    }

    public void AddPatient(string name)
    {
        if (bet++ % 3 == 0)
        {
            room++;
        }

        if (room >= 20)
        {
            return;
        }

        this.patients[room, bet % 3] = name;
    }
}
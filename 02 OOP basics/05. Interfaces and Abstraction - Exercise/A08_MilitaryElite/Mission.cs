using System;

public class Mission 
{
    public Mission(params string[] parameters)
    {
        this.Name = parameters[0];
        this.SetIsCompleted(parameters[1]);
    }

    public string Name { get; private set; }

    public string IsCompleted { get; private set; }

    public void Complete()
    {
        this.IsCompleted = "finished";
    }

    public override string ToString()
    {
        return $"Code Name: {this.Name} State: {this.IsCompleted}";
    }

    private void SetIsCompleted(string value)
    {
        if (value.ToLower() == "finished")
        {
            this.IsCompleted = "finished";
        }
        else if (value.ToLower() == "inprogress")
        {
            this.IsCompleted = "inProgress";
        }
        else
        {
            throw new Exception();
        }
    }
}

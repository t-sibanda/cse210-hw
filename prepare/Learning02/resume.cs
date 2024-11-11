public class Resume
{
    private string _name;
    private List<Job> _jobs = new List<Job>();

    public Resume(string name)
    {
        this._name = name;
    }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public void AddJob(Job job)
    {
        this._jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {this.Name}");
        foreach (Job job in this._jobs)
        {
            job.Display();
        }
    }
}
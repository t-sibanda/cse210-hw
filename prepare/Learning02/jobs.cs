public class Job
{
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        this._jobTitle = jobTitle;
        this._company = company;
        this._startYear = startYear;
        this._endYear = endYear;
    }

    public string JobTitle
    {
        get { return this._jobTitle; }
        set { this._jobTitle = value; }
    }

    public string Company
    {
        get { return this._company; }
        set { this._company = value; }
    }

    public int StartYear
    {
        get { return this._startYear; }
        set { this._startYear = value; }
    }

    public int EndYear
    {
        get { return this._endYear; }
        set { this._endYear = value; }
    }

    public void Display()
    {
        Console.WriteLine($"{this.JobTitle} ({this.Company}) {this.StartYear}-{this.EndYear}");
    }
}
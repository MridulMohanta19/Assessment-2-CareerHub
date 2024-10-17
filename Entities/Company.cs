public class Company
{
    public int CompanyID { get; set; }
    public string CompanyName { get; set; }
    public string Location { get; set; }

    private List<JobListing> jobListings = new List<JobListing>();

    // Method to post a job
    public void PostJob(string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType)
    {
        var job = new JobListing
        {
            JobID = jobListings.Count + 1,  // Simulate JobID auto increment
            CompanyID = this.CompanyID,
            JobTitle = jobTitle,
            JobDescription = jobDescription,
            JobLocation = jobLocation,
            Salary = salary,
            JobType = jobType,
            PostedDate = DateTime.Now
        };

        jobListings.Add(job);
        Console.WriteLine($"Job '{jobTitle}' posted by {CompanyName}.");
    }

    // Method to retrieve all jobs posted by the company
    public List<JobListing> GetJobs()
    {
        return jobListings;
    }
}

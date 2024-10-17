public class JobListing
{
    public int JobID { get; set; }
    public int CompanyID { get; set; }
    public string JobTitle { get; set; }
    public string JobDescription { get; set; }
    public string JobLocation { get; set; }
    public decimal Salary { get; set; }
    public string JobType { get; set; }
    public DateTime PostedDate { get; set; }

    private List<JobApplication> applications = new List<JobApplication>();

    // apply for a job
    public void Apply(int applicantID, string coverLetter)
    {
        var application = new JobApplication
        {
            JobID = this.JobID,
            ApplicantID = applicantID,
            CoverLetter = coverLetter,
            ApplicationDate = DateTime.Now
        };

        applications.Add(application);
        Console.WriteLine($"Applicant {applicantID} applied for Job {JobID}.");
    }

    // list of applicants who applied 
    public List<JobApplication> GetApplicants()
    {
        return applications;
    }
}

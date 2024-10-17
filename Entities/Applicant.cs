public class Applicant
{
    public int ApplicantID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Resume { get; set; }

    private List<JobApplication> jobApplications = new List<JobApplication>();

    // create the applicant's profile
    public void CreateProfile(string email, string firstName, string lastName, string phone)
    {
        if (!IsValidEmail(email))
        {
            throw new InvalidEmailFormatException("Email format is invalid");
        }

        this.Email = email;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Phone = phone;

        Console.WriteLine($"Profile created for {firstName} {lastName}.");
    }

    // apply for a specific job
    public void ApplyForJob(JobListing job, string coverLetter)
    {
        job.Apply(this.ApplicantID, coverLetter);

        var jobApplication = new JobApplication
        {
            JobID = job.JobID,
            ApplicantID = this.ApplicantID,
            CoverLetter = coverLetter,
            ApplicationDate = DateTime.Now
        };

        jobApplications.Add(jobApplication);
        Console.WriteLine($"{FirstName} {LastName} applied for job '{job.JobTitle}' with cover letter: {coverLetter}");
    }

    // validate email format
    private bool IsValidEmail(string email)
    {
        return email.Contains("@");  // Simplified email validation
    }
}

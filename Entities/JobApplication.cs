﻿public class JobApplication
{
    public int ApplicationID { get; set; }
    public int JobID { get; set; }
    public int ApplicantID { get; set; }
    public DateTime ApplicationDate { get; set; }
    public string CoverLetter { get; set; }

    // You can add any specific logic for the application if needed, but right now it's just a data class.
}

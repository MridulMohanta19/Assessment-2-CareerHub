Create database CareerHub
go

use CareerHub 
go

Create Table Companies(
    CompanyID INT PRIMARY KEY IDENTITY(1,1),
    CompanyName NVARCHAR(100),
    Location NVARCHAR(100)	
	);

Create Table Jobs(
	JobID INT PRIMARY KEY IDENTITY(1,1),
    JobTitle NVARCHAR(100),
    JobDescription NVARCHAR(MAX),
    JobLocation NVARCHAR(100),
    Salary DECIMAL(18, 2),
    JobType NVARCHAR(50),
    PostedDate DATETIME,
	CompanyID INT FOREIGN KEY REFERENCES Companies(CompanyID)
	);

Create Table Applicants(
	ApplicantID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
    Resume NVARCHAR(MAX)
	);

Create Table Applications(
	ApplicationID INT PRIMARY KEY IDENTITY(1,1),
    JobID INT FOREIGN KEY REFERENCES Jobs(JobID),
    ApplicantID INT FOREIGN KEY REFERENCES Applicants(ApplicantID),
    ApplicationDate DATETIME,
    CoverLetter NVARCHAR(MAX)
	);

	Select * from Companies

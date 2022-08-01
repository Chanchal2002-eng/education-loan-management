create DataBase EducationLoan

create Table Student
(
	StudentId int primary Key,
	FirstName varchar(50),
	LastName varchar(50),
	FatherName varchar(50),
	ContactNo varchar(50),
	Email varchar(50),
	Age int,
	Gender varchar(50), 
)

create Table FinancialDetails
(
	AccountNo Bigint,
	AccountType varchar(50),
	BankIFSCcode varchar(50),
	BankName varchar(50),
	StudentId int,
	Primary key(AccountNo),
	Foreign key(StudentId) references Student(StudentId)
)

create Table LoanTrack
(
	TrackId int primary key,
	LoanStatus varchar(50),
	StudentId int NOT NULL
	Foreign Key(StudentId) references Student(StudentId)
)

create Table Bank
(
	MICRCode int,
	BankName varchar(50),
	IFSCcode varchar(50),
	OtherBankDetails  varchar(50),
	primary key(MICRCode)
)

create Table University
(
	UniversityName varchar(50),
	UniversityCode varchar(50) primary key,
	StudentId int not null
	Foreign Key(StudentId) references Student(StudentId)
)

create Table LoanIssuranceAuthority
(
	AuthorityId int,
	AuthorityName varchar(50),
	Designation varchar(50),
	Password varchar(50),
	Primary Key(AuthorityId)
)

create Table Payment(
	PaymentId Varchar(50),
	PaymentAmount int,
	LoanCode varchar(50),
	StudentId int
	primary key(PaymentId),
	Foreign key(StudentId) references Student(StudentId)
)

create Table KYCDetails(
	PANID Varchar(50),
	AadhaarCard BIGINT primary key,
	EducationQualification varchar(50),
	StudentId int not null
	Foreign Key(StudentId) references Student(StudentId)
)

ALTER TABLE Student ADD Password VARCHAR(50)

CREATE TABLE Course
(
	CourseId INT PRIMARY KEY,
	CourseName VARCHAR(50),
	Durartion INT,
	StudentId INT NOT NULL
	FOREIGN KEY(StudentId) REFERENCES Student(StudentId)
)

CREATE TABLE Schools (
    Id int NOT NULL,
    Name NVARCHAR(MAX),
    Address NVARCHAR(MAX),
	PRIMARY KEY (Id),
	Users INT NULL
);

CREATE TABLE Users (
    Id int NOT NULL,
    FirstName NVARCHAR(MAX),
    LastName NVARCHAR(MAX),
    Age int NOT NULL,
	SchoolId int,
	PRIMARY KEY (Id),
	FOREIGN KEY (SchoolId) REFERENCES Schools(Id)
);


USE People
GO

INSERT INTO Users (Id, FirstName, LastName, Age, SchoolId) 
VALUES (6, 'Alex', 'Small', 25, 5)
GO 

DELETE FROM Users WHERE id = 1

SELECT * FROM Users

SELECT * FROM Schools
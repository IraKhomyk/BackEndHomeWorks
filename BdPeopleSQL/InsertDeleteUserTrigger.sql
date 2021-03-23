CREATE TRIGGER InsertDeleteUsersTrigger
on Users
AFTER INSERT, DELETE
AS 
	DECLARE @SchoolId INT

	IF exists(SELECT * FROM INSERTED)
	BEGIN
		SELECT @SchoolId = INSERTED.SchoolId
		FROM INSERTED
		UPDATE Schools SET Users = Users + 1 WHERE Schools.Id = @SchoolId
	END

	IF exists(SELECT * FROM DELETED)
	BEGIN
		SELECT @SchoolId = DELETED.SchoolId
		FROM DELETED
		UPDATE Schools SET Users = Users - 1 WHERE Schools.Id = @SchoolId
	END
GO

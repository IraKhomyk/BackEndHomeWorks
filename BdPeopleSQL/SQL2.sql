insert into Users (Id, FirstName, LastName, Age, SchoolId) 
values (2, 'Ivan', 'Franko', 15, 2)
GO
select * from Users
GO

update Users set Age = 14 where Id < 16

delete from Users where Id <16

select * from Users inner join Schools on Users.SchoolId = Schools.Id

select * from Users left join Schools on Users.SchoolId = Schools.Id

select * from Users right join Schools on Users.SchoolId = Schools.Id

select * from Users full join Schools on Users.SchoolId = Schools.Id

select * from Users order by Age

select SchoolId, COUNT(*) as 'Count' from Users group by SchoolId having COUNT(*) < 2

Begin TRANSACTION
update Users set Age = 14 where Id = 1
update Users set Age = 14 where Id = 2
Rollback
update Users set Age = 15 where Id = 3
Commit



CREATE DATABASE STUDENTMANAGE
GO
USE STUDENTMANAGE
GO

CREATE TABLE Astudent
(
	id nvarchar(10) primary key,
	idClass nvarchar(10) not null, 
	name nvarchar(30) not null,
	dateOfbirth date not null,
	telephone varchar(10) not null,
	email varchar(10) not null,

	--1 la nam, 0 la nu--
	male int not null, 

	mathPoint float,
	physicalPoint float,
	chemicalPoint float,

	foreign key (idClass) references dbo.Aclass(id), 
)
GO
alter table dbo.Astudent drop constraint a

CREATE TABLE Aclass
(
	id nvarchar(10) primary key,
	name nvarchar(10) not null,
	numberOfStudents int not null,
)
GO

CREATE PROC insertClass

	@id nvarchar(10),
	@name nvarchar(10),
	@numberOfStudents int

AS
BEGIN
	insert into dbo.Aclass
	(
		id,
		name,
		numberOfStudents
	)
	values
	(
		@id,
		@name,
		@numberOfStudents
	)
END
GO

CREATE PROC insertStudent
	@id nvarchar(10) ,
	@idClass nvarchar(10) , 
	@name nvarchar(30) ,
	@dateOfbirth date ,
	@telephone varchar(10) ,
	@email varchar(10) ,

	--1 la nam, 0 la nu--
	@male int , 

	@mathPoint float,
	@physicalPoint float,
	@chemicalPoint float

AS
BEGIN
	insert into dbo.Astudents
	(
		id,
		idClass, 
		name,
		dateOfbirth,
		telephone,
		email,

		--1 la nam, 0 la nu--
		male , 

		mathPoint ,
		physicalPoint ,
		chemicalPoint
	)
	values
	(
		@id ,
		@idClass , 
		@name  ,
		@dateOfbirth ,
		@telephone ,
		@email ,

		--1 la nam, 0 la nu--
		@male , 

		@mathPoint ,
		@physicalPoint,
		@chemicalPoint
	)
END
GO

CREATE PROC deleteClass
	@id nvarchar(10)
AS
BEGIN
	delete dbo.Aclass where dbo.Aclass.id = @id
END
GO

CREATE PROC deleteStudent
	@id nvarchar(10)
AS
BEGIN
	delete dbo.Astudents where dbo.Astudents.id = @id
END
GO

CREATE PROC updateClass
	@id nvarchar(10),
	@number int
AS
BEGIN
	update dbo.Aclass set numberOfStudents = @number where id = @id
END
GO

CREATE PROC updateStudents
	@id nvarchar(10),
	@idClass nvarchar(10)
AS
BEGIN
	update dbo.Astudents set idClass = @idClass where id = @id
END
GO

select* from dbo.Aclass


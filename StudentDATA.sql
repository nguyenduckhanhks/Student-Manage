CREATE DATABASE STUDENT
GO
USE STUDENT
GO

CREATE TABLE students
(
	id nvarchar(10) primary key,
	idClass nvarchar(10) not null unique, 
	name nvarchar(30) not null,
	dateOfbirth date not null,
	telephone varchar(10) not null,
	email varchar(10) not null,

	--1 la nam, 0 la nu--
	male int not null, 

	mathPoint float,
	physicalPoint float,
	chemicalPoint float,

	foreign key (idClass) references dbo.class(id), 
)
GO

CREATE TABLE class
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
	insert into dbo.class
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
	insert into dbo.students
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
	delete dbo.class where dbo.class.id = @id
END
GO

CREATE PROC deleteStudent
	@id nvarchar(10)
AS
BEGIN
	delete dbo.students where dbo.students.id = @id
END
GO

CREATE PROC updateClass
	@id nvarchar(10),
	@number int
AS
BEGIN
	update dbo.class set numberOfStudents = @number where id = @id
END
GO

CREATE PROC updateStudents
	@id nvarchar(10),
	@idClass nvarchar(10)
AS
BEGIN
	update dbo.students set idClass = @idClass where id = @id
END
GO

select* from dbo.students


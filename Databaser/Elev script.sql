--use master
--drop database xH1Database

--create database xH1Database
--go
use xH1Database
drop table if exists Student
go
drop table if exists Team
go


create table Team
(
   Id int identity(10, 10) constraint Team_Id_PK primary key,
   TeamName varchar(20)
)

create table Student
(
   Id int identity (1000,1) constraint Student_Id_PK primary key,
   FName varchar(10),
   LName varchar(10) Not Null,
   Addr varchar(50),
   Internship bit,
   SparetimeJob varchar(20),
   ShoeNumber decimal(5,2),
   Salary float,
   TeamId int constraint Student_TeamId_FK 
		      foreign key references Team(Id)
)

insert into Team values('Data')
insert into Team values('Specialpatrulje')
insert into Team values('TEC''s humbuggere')
insert into Team values('Ånsvage elever')

insert into Student 
   values('Elias','Kouly','Jacobsvej 7', 0, 
           'NO Shit', 43.5, 1234.50, 10)
insert into Student values('Oliver','Laursen','Juelsmindevej 7', 0, 'Tiger slave', 40.0, 1900.00, 20)
insert into Student values('Carl-Emil','Olsen','Tunøvej 59', 0, 'Hardcore Gamer', 48.5, 8000, 30)
insert into Student values('Oskar','Urban','TætvedØsterbrovej 7', 1, 'CEO', 44.5, 3465.50, 40)
insert into Student values('Emil','Lundqvist','GrandtofteParken 7', 0, 'Sofa', 42.5, 22222.50, 30)
insert into Student values('Julius','Schwaner','Kagså 117', 1, 'Supporter', 42.5, 13234.50, 10)
insert into Student values('Subarna','Grg','Thorsgade 7', 0, 'Manager', 42.0, 12734.50, 20)
insert into Student values('Mark','Peddersen','Titangade 7', 0, 'Robber', 42, 71234.50, 30)
insert into Student values('Joshi','Tonakia','Jacobs Boulevard 7', 0, 'NO Shit', 42, 91234.50, 40)
insert into Student values('Aksel','Fabricius','Danmark 7 tv', 1, 'Pusher', 45.5, 1000000.50, 40)
insert into Student values('Noah','Tågehorn','Rusland 17', 1, 'Skinneskidtskraber', 39, 123477.50, 10)
insert into Student values('Marko','Peddersen','Ballerup Boulevard', 0, 'Tagrenderense', 49, 77777, 20)
insert into Student values( null,'Rasmussen','Ballerup Boulevard', 0, 'Tagrenderense', 49, 77777, 30)
insert into Student values( null, 'Nullsen','Null Boulevard', 0, 'I am a NUll', 49, 77777, 40)



select * from Student
--select * from Student where FName = 'Elias'
--select * from Student where ShoeNumber = 42.5
--select * from Student where FName is null

select * from Team
--select * from Student where TeamId = 30

select * from Student, Team 
where Team.Id = Student.TeamId



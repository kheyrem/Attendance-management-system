
CREATE DATABASE AttendancyPortal;
USE AttendancyPortal;



 
 -- user table

CREATE TABLE Users
(
 userName varchar(50) primary key,
 userPass varchar(50) unique
 )

insert into Users
values('admin', 'ali123')

truncate table Class
where userName = 'admin'
select * from Users
 

--class table

create table Class(
classID int  identity(10,2) primary key,
className varchar(50) not null
)

select * from Class

delete Student where Class_id = 54

select className from Class where className = 'CA191'
select classID from Class where classID = '12'
 

insert into Class(className)
VALUES('CA191'),('CA192'),('CA193')


SELECT className FROM Class

delete FROM  Class where className = 'CA194'
 



 -- student table

 CREATE TABLE Student
 (
 Std_id int identity(1020,1) primary key,
 Std_Name varchar(100) not null,
 Gender varchar(10) not null,
 Class_id int foreign key 
 references Class(classID)
)

insert into Student(Std_Name, Gender, Class_id)
values('Shaakir Mohmaed Ali', 'male', 10), 
('Saacid Axmed Ali', 'male', 10), 
('Shukri Gedi Ali', 'female', 10),
('Hasan Nur Mustaf', 'male', 10), 
('Nur Ali Shakir', 'male', 10), 


('Nur Mohmaed Ali', 'male', 12), 
('Zakariye Axmed Ali', 'male', 12), 
('Farxiyo Barre Ali', 'female', 12),
('Yasin Nur Mustaf', 'male', 12), 
('Nur Axmed Shakir', 'male', 12), 

('liiban Mohmaed Ali', 'male', 14), 
('Abdulahi Axmed Ali', 'male', 14), 
('Abshiro Barre Ali', 'female', 14),
('Mustaf Nur Abshir', 'male', 14), 
('Mahad Axmed Shakir', 'male', 14)


select * from Student
 



Create Table Lectuarer
(
LectuareID int identity(500,1) constraint lec_pk primary key,
Lectuare_Name varchar(100) not null,
Gender varchar(10) not null,
 
)

delete from Lectuarer where LectuareID = '503'

select * from Lectuarer
 

 

insert into Lectuarer(Lectuare_Name, Gender)
values('Naqib Nur Ali', 'male'), 
('Cumar Cabas Ali', 'male' ), 
('Cisman Khalf Ali', 'male')

 
 









create table passcode 
(
Passcode int constraint pass_pk primary key identity(1000,1),
lecturer_Id int constraint lect_id_fk references Lectuarer(LectuareID)
)

select lecturer_Id from Passcode where lecturer_Id = '505'

insert into passcode (lecturer_Id)
values(500), (501), (502) 
 
 

 

CREATE TABLE AllCourses
(
Course_ID VARCHAR(10) PRIMARY KEY,
Course_Name varchar(50) not null,

)

INSERT INTO AllCourses
VALUES('CA500', 'Oracle'),
('CA501', 'SAD'),
('CA502', 'Data Structure'),
('CA503', 'MIS'),
('CA504', 'C#'),
('CA505', 'Netowrk')


 select Course_ID from AllCourses where Course_ID = 'CA505'

CREATE TABLE Course
(
Course_ID  varchar(10) Foreign key
references AllCourses(Course_ID),
Class_id int 
references Class(classID),
LectuareID int references Lectuarer(LectuareID)
)  

select * from Class


INSERT INTO Course 
VALUES('CA500', 10, 500),
('CA501', 10, 500),
('CA502', 12, 501),
('CA503', 12, 501),
('CA504', 14, 502),
('CA505', 14, 502)


 



 


--Attendace Table
 
 

 
CREATE TABLE Attendance
(
AttendanceID int identity(1,1) primary key,
student_ID  int 
references Student(std_id),
Class_id int 
references Class(classID),
Course_ID  varchar(10) 
references AllCourses(Course_ID),
AttDATE DATE DEFAULT getdate(),
StatusAttd varchar(10)
)

 







 




 


				




 
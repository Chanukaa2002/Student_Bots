create database StudentBots;

create table Principle 
(
	Principle_Id varchar(10) primary key,
	Password varchar(20) not null,
);

insert into Principle(Principle_Id,Password)
values('P001','admin123');


create table Teacher
(
	Teacher_Id varchar(10) primary key,
	Password varchar(20) not null,
	Teacher_Name varchar(100) ,
	Class varchar(4) ,
	Gender varchar(1),
	Nationality varchar(20) ,
	Age int ,
	Principle_Id varchar(10) foreign key references Principle(Principle_Id)
);

create table Student
(
	Index_No varchar(10) primary key,
	Student_Name varchar(100) ,
	Gender varchar(1),
	Admission_Date Date default getDate(),
	DOB date,
	Gardion_Name varchar(100),
	Addresss varchar(200),
	img_Path varchar(max),
	Grade varchar(5),
	Teacher_Id varchar(10) foreign key references Teacher(Teacher_Id)
);
ALTER TABLE Student
DROP COLUMN img_Path;

alter table Student Add img_Path varchar(max);
select * from Student;

create table Letter
(
	Letter_Id varchar(10) primary key,
	Letter_Name varchar(50),
	Student_Index varchar(10) foreign key references Student(Index_No),
	Principle_Id varchar(10) foreign key references Principle(Principle_Id)
);

create table Subject
(
	Subject_Id varchar(10) primary key,
	Subject_Name varchar(75)
);

select * from Subject
create table Std_Sub 
(
	Student_Index varchar(10) foreign key references Student(Index_No),
	Subject_Id varchar(10) foreign key references Subject(Subject_Id),
	marks float,
	primary key(Student_Index,Subject_Id)
	
);

select Index_No,Student_Name,AvgMark,Subject_Id,marks from Student inner join Std_Sub on Student.Index_No = Std_Sub.Student_Index;

select s.Index_No,s.Student_Name,AVG(ss.Marks) AS Avg_marks,
SUM(CASE WHEN ss.Subject_Id = 'S001' THEN ss.Marks ELSE 0 END) AS Sinhala,
SUM(CASE WHEN ss.Subject_Id = 'S002' THEN ss.Marks ELSE 0 END) AS Buddist,
SUM(CASE WHEN ss.Subject_Id = 'S003' THEN ss.Marks ELSE 0 END) AS Science, 
SUM(CASE WHEN ss.Subject_Id = 'S004' THEN ss.Marks ELSE 0 END) AS Maths,
SUM(CASE WHEN ss.Subject_Id = 'S005' THEN ss.Marks ELSE 0 END) AS History,
SUM(CASE WHEN ss.Subject_Id = 'S006' THEN ss.Marks ELSE 0 END) AS English,
SUM(CASE WHEN ss.Subject_Id = 'S007' THEN ss.Marks ELSE 0 END) AS Op1,
SUM(CASE WHEN ss.Subject_Id = 'S008' THEN ss.Marks ELSE 0 END) AS Op2,
SUM(CASE WHEN ss.Subject_Id = 'S009' THEN ss.Marks ELSE 0 END) AS Op3  FROM 
                Student s
            JOIN 
                std_sub ss ON s.Index_No = ss.Student_Index
            GROUP BY 
                s.Index_No, s.Student_name;  
                
                
                
                Insert into Student(AvgMark) values(70) where Index_No = 'S001'
                
                
                
                
            
create database NormalForms;

use NormalForms;


--1NF
CREATE TABLE StudentCoursesUnnormalized (
    StudentID INT,
    StudentName VARCHAR(100),
    CourseID INT,
    CourseName VARCHAR(100),
    Instructor VARCHAR(100),
    InstructorEmail VARCHAR(100)
);

INSERT INTO StudentCoursesUnnormalized VALUES
(1, 'Alice', 101, 'Math', 'Prof. Smith', 'smith@example.com'),
(1, 'Alice', 102, 'History', 'Prof. Johnson', 'johnson@example.com'),
(2, 'Bob', 101, 'Math', 'Prof. Smith', 'smith@example.com'),
(2, 'Bob', 103, 'Physics', 'Prof. Anderson', 'anderson@example.com');



--2NF
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(100)
);

INSERT INTO Students (StudentID, StudentName)
SELECT DISTINCT StudentID, StudentName
FROM StudentCoursesUnnormalized;

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100),
    Instructor VARCHAR(100),
    InstructorEmail VARCHAR(100)
);

INSERT INTO Courses (CourseID, CourseName, Instructor, InstructorEmail)
SELECT DISTINCT CourseID, CourseName, Instructor, InstructorEmail FROM StudentCoursesUnnormalized;



--3NF
CREATE TABLE StudentEnrollments (
    StudentID INT,
    CourseID INT,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

INSERT INTO StudentEnrollments (StudentID, CourseID)
SELECT StudentID, CourseID
FROM StudentCoursesUnnormalized;

CREATE TABLE Instructors (
    InstructorName VARCHAR(100) PRIMARY KEY,
    InstructorEmail VARCHAR(100)
);

INSERT INTO Instructors (InstructorName, InstructorEmail)
SELECT DISTINCT Instructor, InstructorEmail
FROM Courses;

ALTER TABLE Courses
DROP COLUMN Instructor,InstructorEmail;

ALTER TABLE Courses
ADD InstructorName VARCHAR(100),
FOREIGN KEY (InstructorName) REFERENCES Instructors(InstructorName);

--1NF
select * from StudentCoursesUnnormalized;

--2NF
select * from Students;
Select * from Courses;

--3NF
Select * from StudentEnrollments;
Select * from Instructors;
Select * from Courses;

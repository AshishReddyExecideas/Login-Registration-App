create database EmployeeDetails;

use EmployeeDetails;

CREATE TABLE Employee (eid INT PRIMARY KEY,name VARCHAR(255),emailid VARCHAR(255),mobile VARCHAR(15),hired_date DATE);

ALTER TABLE Employee ALTER COLUMN eid INT IDEN(12,1);

--ALTER TABLE Employee ADD eid INT IDENTITY(1,1);

CREATE TABLE Team (tid INT PRIMARY KEY,name VARCHAR(255),teamdescription VARCHAR(255));

CREATE TABLE Project (pid INT PRIMARY KEY,name VARCHAR(255),start_date DATE,expected_end_date DATE,actual_end_date DATE);

ALTER TABLE Employee ADD tid int, FOREIGN KEY(tid) REFERENCES Team(tid); 

CREATE TABLE Employee_Project(eid int,pid int,PRIMARY KEY(eid,pid),FOREIGN KEY(eid) REFERENCES Employee(eid), FOREIGN KEY(pid) REFERENCES Project(pid));

INSERT INTO Team (tid, name, teamdescription)VALUES(1, 'Development Team', 'Responsible for software development.'),(2, 'Testing Team', 'Handles the bugs and tests the product to report all the bugs.');
INSERT INTO Employee (eid, name, emailid, mobile, hired_date, tid) VALUES(1, 'Ashish Reddy', 'ashish@gmail.com', '123-456-7890', '2023-08-01', 1),(2, 'Sujith Reddy', 'sujith@gmail.com', '987-654-3210', '2023-08-21', 2);
INSERT INTO Project (pid, name, start_date, expected_end_date, actual_end_date) VALUES(1, 'School Website', '2023-03-01', '2023-05-01', '2023-04-28'),(2, 'Enterprise Metro Design', '2023-04-15', '2023-08-31', NULL);
INSERT INTO Employee_Project (eid, pid) VALUES(1, 1),(1, 2),(2, 2); 


INSERT INTO Team (tid, name, teamdescription)VALUES(3, 'Business Analyst Team', 'Responsible for handling business related stuff.'),(4, 'SQL Team', 'Handles all the database related work and storage is handled by this team.');
INSERT INTO Employee (eid, name, emailid, mobile, hired_date, tid) VALUES(3, 'Ganesh', 'ganesh@gmail.com', '456783459', '2023-09-02', 4),(4, 'Dilip Reddy', 'dilip@gmail.com', '98765', '2023-08-11', 3);
INSERT INTO Project (pid, name, start_date, expected_end_date, actual_end_date) VALUES(3, 'Medical Project', '2023-04-15', '2023-06-01', '2023-06-08'),(4, 'Campus Project', '2023-07-07', '2023-09-05', NULL);
INSERT INTO Employee_Project (eid, pid) VALUES(1, 3),(2, 4),(3, 1),(4,2); 


INSERT INTO Team (tid, name, teamdescription)VALUES(5, 'Front End Team', 'Responsible for seeing and integrating how website looks.');
INSERT INTO Employee (eid, name, emailid, mobile, hired_date, tid) VALUES(5, 'Mukund', 'ganesh@gmail.com', '456783459', '2023-09-02', 4),(6, 'Nischinth Reddy', 'dilip@gmail.com', '98765', '2023-08-11', 5);
INSERT INTO Project (pid, name, start_date, expected_end_date, actual_end_date) VALUES(5, 'College Project', '2023-04-15', '2023-06-08', '2023-07-08'),(6, 'Hospital Project', '2023-08-03', '2023-09-05', '2023-09-05');
INSERT INTO Employee_Project (eid, pid) VALUES(2, 5),(2, 6),(5, 6),(4,5); 



select * from Employee;
select * from Team;
select * from Project;
select * from Employee_Project;

--1st Question Answers in SQL
select * from Employee where eid=3;
select * from Project where pid=4;
select * from Team where tid=1;

--2nd Question Answers in SQL
SELECT * FROM Project WHERE pid IN (SELECT pid FROM Employee_Project WHERE eid = 2 );
SELECT * FROM Employee WHERE eid IN (SELECT eid FROM Employee_Project WHERE pid = 1);
SELECT * FROM Employee WHERE Employee.tid=4;



--3rd Question
SELECT * FROM Employee,Team where eid=1;

SELECT *
FROM Employee
JOIN Team ON Employee.tid = Team.tid
LEFT JOIN Employee_Project ON Employee.eid = Employee_Project.eid
LEFT JOIN Project ON Employee_Project.pid = Project.pid
WHERE Employee.eid = 1;


SELECT * FROM Employee;



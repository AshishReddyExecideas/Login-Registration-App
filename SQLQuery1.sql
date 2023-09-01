CREATE DATABASE EmployeeDetails2;

use EmployeeDetails2;

CREATE TABLE Employee (eid INT IDENTITY(1,1) PRIMARY KEY,name VARCHAR(255),emailid VARCHAR(255),mobile VARCHAR(15),hired_date DATE);

--ALTER TABLE Employee ADD eid INT IDENTITY(12,1);

--ALTER TABLE Employee ADD eid INT IDENTITY(1,1);

CREATE TABLE Team (tid INT IDENTITY(1,1) PRIMARY KEY,name VARCHAR(255),teamdescription VARCHAR(255));

CREATE TABLE Project (pid INT IDENTITY(1,1) PRIMARY KEY,name VARCHAR(255),start_date DATE,expected_end_date DATE,actual_end_date DATE);

ALTER TABLE Employee ADD tid int, FOREIGN KEY(tid) REFERENCES Team(tid); 

CREATE TABLE Employee_Project(eid int,pid int,PRIMARY KEY(eid,pid),FOREIGN KEY(eid) REFERENCES Employee(eid), FOREIGN KEY(pid) REFERENCES Project(pid));

INSERT INTO Team ( name, teamdescription)VALUES('Development Team', 'Responsible for software development.'),('Testing Team', 'Handles the bugs and tests the product to report all the bugs.');
INSERT INTO Employee (name, emailid, mobile, hired_date, tid) VALUES('Ashish Reddy', 'ashish@gmail.com', '123-456-7890', '2023-08-01', 1),('Sujith Reddy', 'sujith@gmail.com', '987-654-3210', '2023-08-21', 2);
INSERT INTO Project (name, start_date, expected_end_date, actual_end_date) VALUES('School Website', '2023-03-01', '2023-05-01', '2023-04-28'),('Enterprise Metro Design', '2023-04-15', '2023-08-31', NULL);
INSERT INTO Employee_Project (eid, pid) VALUES(1, 1),(1, 2),(2, 2); 


INSERT INTO Team (name, teamdescription)VALUES('Business Analyst Team', 'Responsible for handling business related stuff.'),('SQL Team', 'Handles all the database related work and storage is handled by this team.');
INSERT INTO Employee (name, emailid, mobile, hired_date, tid) VALUES('Ganesh', 'ganesh@gmail.com', '456783459', '2023-09-02', 4),('Dilip Reddy', 'dilip@gmail.com', '98765', '2023-08-11', 3);
INSERT INTO Project (name, start_date, expected_end_date, actual_end_date) VALUES('Medical Project', '2023-04-15', '2023-06-01', '2023-06-08'),('Campus Project', '2023-07-07', '2023-09-05', NULL);
INSERT INTO Employee_Project (eid, pid) VALUES(1, 3),(2, 4),(3, 1),(4,2); 


INSERT INTO Team (name, teamdescription)VALUES('Front End Team', 'Responsible for seeing and integrating how website looks.');
INSERT INTO Employee (name, emailid, mobile, hired_date, tid) VALUES('Mukund', 'mukund@gmail.com', '456783459', '2023-09-02', 4),('Nischinth Reddy', 'dilip@gmail.com', '98765', '2023-08-11', 5);
INSERT INTO Project (name, start_date, expected_end_date, actual_end_date) VALUES('College Project', '2023-04-15', '2023-06-08', '2023-07-08'),('Hospital Project', '2023-08-03', '2023-09-05', '2023-09-05');
INSERT INTO Employee_Project (eid, pid) VALUES(2, 5),(2, 6),(5, 6),(4,5); 



select * from Employee;
select * from Team;
select * from Project;
select * from Employee_Project;


use EmployeeDetails;


create table Employee(Eid int primary key,Ename varchar(20),emailid varchar(20),mobile varchar(10),hireddate date);

create table Team(Tid int primary key,Tname varchar(20),description varchar(50));

create table Project(Pid int primary key,Pname varchar(20),startdate date,expectedenddate date,actualenddate date );

ALTER TABLE Employee ADD team_id INT;
ALTER TABLE Employee ADD FOREIGN KEY (team_id) REFERENCES Team(Tid);


CREATE TABLE Employee_Project (id INT PRIMARY KEY,employee_id INT,project_id INT,FOREIGN KEY (employee_id) REFERENCES Employee(Eid),FOREIGN KEY (project_id) REFERENCES Project(Pid));


drop database EmployeeDetails;

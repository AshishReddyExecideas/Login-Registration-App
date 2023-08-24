CREATE DATABASE StudentDB;

USE StudentDB;


CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL,
    RollNumber NVARCHAR(20) NOT NULL,
    Branch NVARCHAR(50) NOT NULL
);

CREATE DATABASE empdb;

USE empdb;

create table Employees(Empid int,EmpName varchar(20),Password varchar(20));

select * from Employees;

insert into Employees(Empid,EmpName,Password) values(1,'Ashish','123456');
insert into Employees(Empid,EmpName,Password) values(2,'Sujith','098765');
insert into Employees(Empid,EmpName,Password) values(3,'Ganesh','234567654');

select * from Employees;

create database TestToys;
use TestToys;

Create table Registration(ID int identity(1,1) Primary Key,UserName Varchar(50),Password Varchar(100),Email Varchar(100),IsActive int);

select * from Registration;

create database TransactionDB;

use TransactionDB;




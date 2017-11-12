create database SampleDB

create table tblemp(eid int,Ename char(100),salary money default 12000,city char(100),Branch char(100),primary key (eid,city))
select *from tblemp
Sp_help
alter table tblemp drop column  salry
alter table tblemp add salry int 
create table tbl1(eid int primary key,ename varchar(max))
create table tbl12(salary money ,Deid int primary key  foreign key REFERENCES tbl1(eid))
alter table tbl12 drop constraint [PK__tbl12__7E18A761BD4DBE67]
alter table tbl12 drop constraint [FK__tbl12__Deid__278EDA44]


create table Depdetails (Did int,Dname varchar(100),Location char(100))
--alter table Depdetails constraint  did primary key
create table Empdetails(eid int primary key foreign key REFERENCES Depdetails(Did),Ename varchar(max),salary money)  

--joins 
use joins
 
 --joins in 3 tables
  --we joined right the result is NULL from the left side, when there is no match.
 select c.firstname,c.city,o.totalamount,p.productname from customer as c 
 right join [dbo].[OrderItem] as o on (c.id=o.id) 
 right join [dbo].[Product1] as p on c.id=p.ID;
 - --we joined left the result is NULL from the right side, when there is no match.

 select c.country,o.quantity,p.package,os.totalamount from customer as c
 left join [dbo].[OrderItem] as os on c.id=os.id
 left join [dbo].[Order_Iteam_Details] as o on os.id=c.ID
 left join [dbo].[Product1] as p on c.id=p.id;

 --natural joins
 select C.FirstName,C.CITY,O.UNITPRICE,O.QUANTITY FROM Customer AS C ,[dbo].[Order_Iteam_Details] AS O



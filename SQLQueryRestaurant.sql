create database Restaurant

go 
use Restaurant

go
drop table if exists tblOrders

go
create table tblOrders(
	OrderID int identity(1,1) not null primary key,
	MenuItem nvarchar(15),
	Date datetime 
)
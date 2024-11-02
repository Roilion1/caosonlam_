
create database sale
go
use sale
--DROP TABLE customer;
create table customer(
	id int ,
	name nvarchar(255),
	age int,
	gender VARCHAR(10),
	image VARBINARY(MAX),
)
go
insert into customer values (1, 'Nguyen Van A', 25,'Nam', NULL) 
insert into customer values (2, 'Nguyen Van B', 20,'Nam', NULL)

select* from customer

DELETE FROM customer WHERE id IN (1, 2)
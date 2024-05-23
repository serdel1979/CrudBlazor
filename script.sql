create database blazordb

use blazordb;

create table films(
id int primary key identity(1,1) not null,
director nvarchar(100),
release date not null,
titulo nvarchar(100) not null);


select * from films;

insert into films(director,release,titulo)
values('pacha',GETDATE(),'la momia');

delete films where id = 1
create database Prueba
go
use Prueba
go

create table Ciudad(
id int primary key not null identity(1,1)
,nombre varchar(50) not null
,poblacion int not null
,activo bit default 1
)

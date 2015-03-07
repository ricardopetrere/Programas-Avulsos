--create database Banco2
--go
--use Banco2
--go

create table Configuracao
(
	cfg_cod int primary key,
	cfg_tcpip_ip varchar(100),
	cfg_tcpip_prt int
)
insert into Configuracao(cfg_cod,cfg_tcpip_ip,cfg_tcpip_prt)values(1,'localhost',5500)
--drop table Configuracao
--select * from Configuracao
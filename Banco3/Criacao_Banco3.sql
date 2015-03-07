--create database Banco3
--go
--use Banco3
--go
create table Terminal
(
	Trm_Idt int primary key,
	Trm_Nom varchar(255),
	Trm_Dmn varchar(255),
	Trm_Tip int,
	Pfe_Cod1 varchar(255),
	Pfe_Cod2 varchar(255),
	Pfe_Cod3 varchar(255),
	Pfe_Cod4 varchar(255),
	Pfe_Cod5 varchar(255),
	Pfe_Cod6 varchar(255),
	Pfe_Cod7 varchar(255),
	Pfe_Cod8 varchar(255)
)
create table Periferico
(
	Pfe_Cod varchar(255) primary key,
	Pfe_Nom varchar(255),
	Pfe_Tip int,
	Pfe_Tip_Com int,
	Pfe_IP varchar(255),
	Pfe_Prt int,
	Pfe_Baud_Rate int,
	Pfe_Data_Bits int,
	Pfe_Par int,
	Pfe_Stop_Bits int,
)
create table TerminalPeriferico
(
	Trm_Idt int,
	Pfe_Cod varchar(255)
)
--create table Texto
--(
--	Tex_Num int primary key,
--	Tex_Tex varchar(1000),
--	Tex_Ref int
--)

--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1000,'[BASE]',0)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1001,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1002,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1003,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1004,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1005,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1006,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1007,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1008,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1009,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1010,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1011,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1012,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1013,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1014,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1015,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1016,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1017,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1018,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1019,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1020,'[BASE]',1000)
--insert into Texto(Tex_Num,Tex_Tex,Tex_Ref)values(1021,'[BASE]',1000)
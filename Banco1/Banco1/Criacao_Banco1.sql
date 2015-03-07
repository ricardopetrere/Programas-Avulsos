--create database Banco1
--go
--use Banco1
--go

create table Pessoa(
pes_cod int not null identity(1,1),
pes_nom varchar(80),
pes_ida int,
end_cod int
)
create table Estado(
est_cod int not null identity(1,1),
est_nom varchar(50)
)
create table Cidade(
cid_cod int not null identity(1,1),
cid_nom varchar(100),
est_cod int
)
create table Endereco(
end_cod int not null identity(1,1),
end_rua varchar(100),
end_num int,
end_cpl varchar(50),
end_bro varchar(50),
end_cep varchar(9),
cid_cod int
)
create table Texto(
tex_cod int not null identity(1,1),
tex_tex varchar(200),
)
go

alter table Pessoa add constraint PK_Pessoa primary key (pes_cod)
alter table Estado add constraint PK_Estado primary key (est_cod)
alter table Cidade add constraint PK_Cidade primary key (cid_cod)
alter table Endereco add constraint PK_Endereco primary key (end_cod)
alter table Texto add constraint PK_Texto primary key (tex_cod)

alter table Pessoa add constraint FK_Pessoa_Endereco foreign key (end_cod) references Endereco (end_cod)
alter table Endereco add constraint FK_Endereco_Cidade foreign key (cid_cod) references Cidade (cid_cod)
alter table Cidade add constraint FK_Cidade_Estado foreign key (est_cod) references Estado (est_cod)
go

if exists (select * from sys.procedures where name = 'spInserePessoaEndereco')
	drop procedure spInserePessoaEndereco
go
-- =============================================
-- Author:		Ricardo Petrére
-- Create date: 18/06/2014
-- Description:	Insere a pessoa, assim como seu endereço associado
-- =============================================
create procedure spInserePessoaEndereco @Pes_cod int output,@Pes_nom varchar(80),@Pes_ida int,@End_rua varchar(100)
	,@End_num int,@End_cpl varchar(50),@End_bro varchar(50),@End_cep varchar(9),@Cid_cod int,@Msg int output
as
	set @Msg = 0

	--Validação de existência da cidade informada
	if not exists(select * from Cidade where cid_cod = @Cid_cod)
	begin
		set @Msg=14
		set @Pes_cod = -1
		goto Fim
	end

	insert into Endereco(end_rua,end_num,end_cpl,end_bro,end_cep,cid_cod)
	values
	(@End_rua,@End_num,@End_cpl,@End_bro,@End_cep,@Cid_cod)
	
	declare @end_cod int = @@identity
	
	insert into Pessoa(pes_nom,pes_ida,end_cod)
	values
	(@Pes_nom,@Pes_ida,@end_cod)
	if(@@ROWCOUNT<>0)
	begin
		set @Msg = 13
		set @Pes_cod = @@IDENTITY
	end
	else
	begin
		set @Msg = 14
		set @Pes_cod = -1
	end
	Fim:
go

insert into Texto(tex_tex) values ('Cadastro de Pessoa')--1
insert into Texto(tex_tex) values ('Nome')--2
insert into Texto(tex_tex) values ('Idade')--3
insert into Texto(tex_tex) values ('Rua')--4
insert into Texto(tex_tex) values ('Número')--5
insert into Texto(tex_tex) values ('Complemento')--6
insert into Texto(tex_tex) values ('Bairro')--7
insert into Texto(tex_tex) values ('CEP')--8
insert into Texto(tex_tex) values ('Cidade')--9
insert into Texto(tex_tex) values ('Estado')--10
insert into Texto(tex_tex) values ('Salvar')--11
insert into Texto(tex_tex) values ('Cancelar')--12
insert into Texto(tex_tex) values ('Cadastro efetuado com sucesso!|Informação')--13
insert into Texto(tex_tex) values ('Falha no cadastro.|Erro')--14
insert into Texto(tex_tex) values ('Endereço')--15


insert into Estado(est_nom) values ('São Paulo')--1

insert into Cidade(cid_nom,est_cod) values ('São Bernardo do Campo',1)
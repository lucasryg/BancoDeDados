--Usar o banco de dados
use Gufi_Tarde;

insert into TipoUsuario(TituloTipoUsuario)
values ('Adminstrador'),('Comum'); 

insert into TipoEvento (TituloTipoEvento)
values ('C#'),('React'),('SQL');

insert into Usuario (NomeUsuario,Email,Senha,Genero,DataNascimento,IdTipoUsuario)
values ('Administrador','adm@adm.com','adm123','Não informado','06/02/2020','1'),
	   ('Carol','caro@email.com','carol123','Feminino','06/02/2020','2'),
	   ('Saulo','saulo@email.com','saulo123','Masculino','06/02/2020','2');
	   
insert Evento(NomeEvento, DataEvento, Descricao, AcessoLivre, IdInstituicao, IdTipoEvento)
values ('Introdução ao C#','07/02/2020','Conceitos sobre os pulares da programação orientada a objeto',1,1,1),
('Ciclo de vida','07/02/2020','Como utilizar o ciclo de vida dcom Reacts',0,1,2),
('Optimização de banco de dados','07/02/2020','Aplicação de índices clisterizados e não clusterizados',1,1,3);

insert into Presenca (IdUsuario, IdEvento, Situacao)
values (2,1,'Agendado'),(2,1,'Confirmada'),(2,1,'Não compareceu');

insert into Instituicao (CNPJ, NomeFantasia, Edereco) 
values ('111111111111','Escola SENAI de informática','Alameda Barão de limeria, 538');


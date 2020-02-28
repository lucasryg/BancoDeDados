-- Define o banco de dados que será utilizado
USE T_Peoples;

-- Insere dois funcionários
INSERT INTO Funcionarios (Nome, Sobrenome) 
VALUES	('Catarina', 'Strada')
		,('Tadeu', 'Vitelli');

insert into TipoUsuario (Titulo) 
values ('Adminstrador'),('Funcionarios');

update TipoUsuario set Titulo =  'Administrador' where IdTipoUsuario = 1 

insert into Usuarios(IdFuncionario,IdTipoUsuario) 
values (1,2),(2,2);




-- Atualiza o valor da coluna DataNascimento
UPDATE Funcionarios SET DataNascimento = '1993-03-17';
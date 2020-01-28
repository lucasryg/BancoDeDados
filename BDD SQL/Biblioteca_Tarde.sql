--Usar a Biblioteca 
USE Biblioteca_Tarde;

CREATE TABLE Generos(
	IdGenero INT PRIMARY KEY IDENTITY,
	Nome     VARCHAR(200)
	);

CREATE TABLE Livros(
	IdLivros  INT PRIMARY KEY IDENTITY,
	Titulo    VARCHAR(255),
	IdAutor   INT FOREIGN KEY REFERENCES Autores (IdAutor),
	IdGeneros INT FOREIGN KEY REFERENCES Generos (IdGenero)
	);

SELECT * FROM Generos;	 
SELECT * FROM Autores;	 
SELECT * FROM Livros;	 

--Alterar adicinar uma nova coluna
ALTER TABLE Generos
ADD Descricao VARCHAR(255);

--Alterar tipo de dado 
ALTER TABLE Generos
ALTER COLUMN Descricao CHAR(100);

--Alterar excluir coluna
ALTER TABLE Generos 
DROP COLUMN Descricao;

--Para excluir uma tabela
DROP TABLE Generos

--Excluir banco de dados
DROP DATABASE Biblioteca_Tarde;

create database teste_tarde;

use teste_tarde;

create table Teste1 (
	IdAlo int primary key identity,
	Nome varchar(120)
);

create table Teste2 (
	IdHelo int primary key identity,
	Nome varchar(120)
);

insert into Teste1 (Nome)
values ('Joao'),('Gustavo');


insert into Teste2 (Nome)
values ('Fabio'),('Yasmin');

select	Teste1, Teste2
row_number(16) over		


select len('Desenvolvimento');

substring ( alomae,
select substring ('SenaiDesenvolvimento',6,15);

select replicate ('Dev ',2); 

SELECT LTRIM('Five spaces are at the beginning of this string.');

SELECT STUFF('Carol E ',8,0,' Saulo' );

SELECT RTRIM('Estou no') + SPACE(2) +  LTRIM('senai') ; 

=
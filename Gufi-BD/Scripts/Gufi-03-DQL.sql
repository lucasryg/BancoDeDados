--Usar o banco de dados
use Gufi_Tarde;

--Listar todos os usuários cadastrados
select Usuario.NomeUsuario,Usuario.Email, Usuario.DataNascimento, Usuario.Genero, TipoUsuario.TituloTipoUsuario
from Usuario 
inner join TipoUsuario on Usuario.IdUsuario = TipoUsuario.IdTipoUsuario;

--Listar todas as instituições cadastradas 
select CNPJ, NomeFantasia, Edereco	
from Instituicao;

--Listar todos os tipos de eventos
select TituloTipoEvento from TipoEvento;

--Listar todos os eventos 

select Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento, Evento.AcessoLivre, Evento.Descricao, Instituicao.CNPJ, Instituicao.Edereco, Instituicao.NomeFantasia
from Evento
inner join TipoEvento on Evento.IdTipoEvento = TipoEvento.IdTipoEvento
inner join Instituicao on Instituicao.IdInstituicao = Evento.IdInstituicao;

--Listar todos os eventos(publico)

select Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento, Evento.AcessoLivre, Evento.Descricao, Instituicao.CNPJ, Instituicao.Edereco, Instituicao.NomeFantasia
from Evento
inner join TipoEvento on Evento.IdTipoEvento = TipoEvento.IdTipoEvento
inner join Instituicao on Instituicao.IdInstituicao = Evento.IdInstituicao
where AcessoLivre = 1;

--Listar todos os eventos que um determinado usuario participa 

select Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento, Evento.AcessoLivre, Evento.Descricao, Instituicao.NomeFantasia, Instituicao.Edereco, Instituicao.CNPJ, Usuario.NomeUsuario, Usuario.DataNascimento,Usuario.Email,Usuario.Senha, Usuario.Genero
from Presenca
inner join Evento on Evento.IdEvento = Presenca.IdEvento
inner join Instituicao on Evento.IdInstituicao = Instituicao.IdInstituicao
inner join Usuario on Usuario.IdUsuario = Presenca.IdUsuario
inner join TipoEvento on Evento.IdTipoEvento = TipoEvento.IdTipoEvento;

--Publico e Privado

select Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento,case when Evento.AcessoLivre = 1 then 'Publico' else 'Privado' end, Evento.Descricao, Instituicao.NomeFantasia, Instituicao.Edereco, Instituicao.CNPJ, Usuario.NomeUsuario, Usuario.DataNascimento,Usuario.Email,Usuario.Senha, Usuario.Genero
from Presenca
inner join Evento on Evento.IdEvento = Presenca.IdEvento
inner join Instituicao on Evento.IdInstituicao = Instituicao.IdInstituicao
inner join Usuario on Usuario.IdUsuario = Presenca.IdUsuario
inner join TipoEvento on Evento.IdTipoEvento = TipoEvento.IdTipoEvento;

--Usuario confirmado.
select Evento.NomeEvento, TipoEvento.TituloTipoEvento, Evento.DataEvento,case when Evento.AcessoLivre = 1 then 'Publico' else 'Privado' end, Evento.Descricao, Instituicao.NomeFantasia, Instituicao.Edereco, Instituicao.CNPJ, Usuario.NomeUsuario, Usuario.DataNascimento,Usuario.Email,Usuario.Senha, Usuario.Genero
from Presenca
inner join Evento on Evento.IdEvento = Presenca.IdEvento
inner join Instituicao on Evento.IdInstituicao = Instituicao.IdInstituicao
inner join Usuario on Usuario.IdUsuario = Presenca.IdUsuario
inner join TipoEvento on Evento.IdTipoEvento = TipoEvento.IdTipoEvento
where Situacao like 'Confirmada%';

--Idade

select Usuario.NomeUsuario,Usuario.Email, datediff (Year, Usuario.DataNascimento,GETDATE()) as DataNascimento, Usuario.Genero
from Usuario 

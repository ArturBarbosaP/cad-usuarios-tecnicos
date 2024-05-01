create database OS_03;
use OS_03;

create table usuario
(
id int unsigned auto_increment not null primary key,
nome varchar(80) not null,
email varchar(80) not null,
telefone varchar(18) not null,
setor int default null,
senha varchar(50) not null
);

/*
select * from usuario;

insert into usuario values
(null, "Maria Esther da Costa", "maria-dacosta83@atrix.com.br", "(21) 2856-2377", 2, "123456"),
(null, "Lucas Mateus Martins", "lucas_mateus_martins@trone.com.br", "(79) 99828-4624", 1, "123456"),
(null, "Jéssica Rayssa Bianca Viana", "jessica_rayssa_viana@accardoso.com.br", "(93) 3743-2975", 3, "123456");
*/

create table setor
(
id int unsigned auto_increment not null primary key,
descricao varchar(100) default null
);

/*
select * from setor;

insert into setor values
(null, "PROFESSOR"),
(null, "ADMIN"),
(null, "DIRETOR");
*/

create table tecnico
(
id int unsigned auto_increment not null primary key,
nome varchar(80) not null,
especialidade int default null,
email varchar(100) not null,
senha varchar(50) not null
);

/*
select * from tecnico;

insert into tecnico values
(null, "Stella Letícia Novaes", 1, "stella-novaes81@recnev.com.br", "123456"),
(null, "Marcos Vinicius Thales Oliver Alves", 2, "marcos_alves@grupoannaprado.com.br", "123456"),
(null, "Mateus Nicolas Murilo da Luz", 3, "mateus-daluz78@p4ed.com", "123456");
*/

create table especialidade
(
id int unsigned auto_increment not null primary key,
descricao varchar(100) not null
);

/*
select * from especialidade;

insert into especialidade values
(null, "PROFESSOR"),
(null, "ADMIN"),
(null, "DIRETOR");
*/

create table os(
id int unsigned auto_increment not null primary key,
descricao varchar(250) default null,
status_os varchar(50) default null,
tecnico_id int default null,
usuario_id int default null
);

/*
select * from os;

insert into os values
(null, "Desc 1", "Ativo", 1, 1),
(null, "Desc 2", "Ativo", 2, 2),
(null, "Desc 3", "Ativo", 3, 3);
*/
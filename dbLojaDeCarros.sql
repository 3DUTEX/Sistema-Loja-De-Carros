create database dbLojaDeCarros;

use dbLojaDeCarros;

-- EXEC 1
create table loginFunc(
cdg_loginFunc int primary key auto_increment,
nm_usuario varchar(40) not null,
no_senha varchar(40) not null
);

-- EXEC 3
create table Cliente(
cdg_cliente int primary key auto_increment,
dt_nasc date not null,
nm_nome varchar(40) not null,
nm_sobrenome varchar(40) not null,
cdg_loginFunc int,
CONSTRAINT FOREIGN KEY (cdg_loginFunc) REFERENCES loginFunc(cdg_loginFunc),
cdg_endereco int,
CONSTRAINT FOREIGN KEY (cdg_endereco) REFERENCES Endereco(cdg_endereco)
);

-- EXEC 2
create table Endereco(
cdg_endereco int primary key auto_increment,
nm_logradouro varchar(50) not null,
no_casa varchar(40) not null,
ds_complemento varchar(40),
nm_bairro varchar(40) not null,
nm_cidade varchar(40) not null
);

-- EXEC 4
create table Veiculo(
cdg_veiculo int primary key auto_increment,
nm_modelo varchar(40) not null,
nm_fabricante varchar(40) not null,
nm_cor varchar(40) not null,
nm_placa varchar(20) not null,
imagem varchar(100) not null,
ds_veiculo varchar(100) not null,
cdg_loginFunc int,
FOREIGN KEY (cdg_loginFunc) REFERENCES loginFunc(cdg_loginFunc)
);

INSERT INTO loginfunc (nm_usuario, no_senha)
VALUES ('ADMIN', '123456');

SELECT * FROM loginfunc;

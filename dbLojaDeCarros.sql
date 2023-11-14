create database dbLojaDeCarros;

use dbLojaDeCarros;

-- EXEC 1
create table loginFunc(
cdg_loginFunc int primary key auto_increment,
nm_usuario varchar(40) not null,
no_senha varchar(40) not null
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

-- EXEC 3
create table Cliente(
cdg_cliente int primary key auto_increment,
dt_nasc date not null,
nm_cliente varchar(40) not null,
nm_sobrenome varchar(40) not null,
cdg_loginFunc int,
CONSTRAINT FOREIGN KEY (cdg_loginFunc) REFERENCES loginFunc(cdg_loginFunc),
cdg_endereco int,
CONSTRAINT FOREIGN KEY (cdg_endereco) REFERENCES Endereco(cdg_endereco)
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
CONSTRAINT FOREIGN KEY (cdg_loginFunc) REFERENCES loginFunc(cdg_loginFunc)
);

INSERT INTO loginfunc (nm_usuario, no_senha)
VALUES ('ADMIN', '123456');

-- EXEC 5
CREATE VIEW vw_dadosCli AS
SELECT 
	cliente.cdg_cliente,
	cliente.nm_cliente,
    cliente.nm_sobrenome,
    cliente.dt_nasc,
    endereco.nm_logradouro,
    endereco.no_casa,
    endereco.nm_bairro,
    endereco.nm_cidade,
    loginfunc.nm_usuario
FROM endereco INNER JOIN cliente
ON endereco.cdg_endereco = cliente.cdg_endereco
INNER JOIN loginFunc
ON cliente.cdg_loginFunc = loginfunc.cdg_loginFunc;


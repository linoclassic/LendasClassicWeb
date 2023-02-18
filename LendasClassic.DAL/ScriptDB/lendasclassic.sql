
Create Database lendasclassic;

USE lendasclassic;

CREATE TABLE [dbo].[tpusuario]
(
  idTpUsuario INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
  descricaoTpUsuario varchar(13) NOT NULL
) ;


INSERT INTO [tpUsuario] VALUES('ADMINISTRADOR');
INSERT INTO [tpUsuario] VALUES('OUTROS');


CREATE TABLE [dbo].[clienteweb] 
(
  idCliente INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
  nomeCliente varchar(100) NOT NULL,
  emailCliente varchar(100) NOT NULL,
  senhaCliente varchar(45) NOT NULL,
  telefoneCliente varchar(14) NOT NULL,
  enderecoCliente varchar(100) NOT NULL,
  bairroCliente varchar(100) NOT NULL,
  cidadeCliente varchar(100) NOT NULL,
  estadoCliente varchar(100) NOT NULL,
  numeroCliente varchar(100) NOT NULL,
  cpfCliente varchar(14) NOT NULL,
  statusCliente varchar(20) NOT NULL,
  dataCadCliente date NOT NULL,
  fkTpUsuario int NOT NULL,
  FOREIGN KEY (fkTpUsuario) REFERENCES [tpUsuario](idTpUsuario)
);


--INSERT INTO `clienteweb` (`idCliente`, `nomeCliente`, `emailCliente`, `senhaCliente`, `telefoneCliente`, `enderecoCliente`, `bairroCliente`, `cidadeCliente`, `estadoCliente`, `numeroCliente`, `cpfCliente`, `statusCliente`, `dataCadCliente`, `fkTpUsuario`) VALUES
--(1, 'Mefistófeles Petrova', 'mefistofeles@gmail.com', '1234', '(11)98765-0000', 'Rua do Diabo', 'Catacumbas do Além', 'Vallhala', 'SP', '666', '852.654.965-89', 'ATIVO', '2022-02-17', 2),
--(2, 'Eric Cerqueira', 'eric@gmail.com', '1234', '(11)95882-3482', 'Av Raimundo Paradeira', 'Vila Rosária', 'São Miguel Paulista', 'SP', '286', '412.403.258-78', 'ATIVO', '2022-02-17', 1);

INSERT INTO clienteweb (nomeCliente, emailCliente, senhaCliente, telefoneCliente, enderecoCliente, bairroCliente, cidadeCliente, estadoCliente, numeroCliente, cpfCliente, statusCliente, dataCadCliente, fkTpUsuario)
VALUES
('Mefistófeles Petrova', 'mefistofeles@gmail.com', '1234', '(11)98765-0000', 'Rua do Diabo', 'Catacumbas do Além', 'Vallhala', 'SP', '666', '852.654.965-89', 'ATIVO', '2022-02-17', 2),
('Eric Cerqueira', 'eric@gmail.com', '1234', '(11)95882-3482', 'Av Raimundo Paradeira', 'Vila Rosária', 'São Miguel Paulista', 'SP', '286', '412.403.258-78', 'ATIVO', '2022-02-17', 1);




CREATE TABLE [dbo].[reserva] (
  idReserva int PRIMARY KEY IDENTITY (1,1) NOT NULL,
  numeroClienteReserva varchar(45) NOT NULL,
  dataReserva datetime NOT NULL,
  horaReserva time NOT NULL,
  statusReserva varchar(45) NOT NULL,
  fkIdCliente int NOT NULL

   FOREIGN KEY (fkIdCliente) REFERENCES [clienteweb](idCliente)
);

INSERT INTO [dbo].[reserva] ([numeroClienteReserva], [dataReserva], [horaReserva], [statusReserva], [fkIdCliente])
VALUES ('(11)95882-3482', '2022-10-05', '12:00:00', 'ATIVA', 2);



SELECT * FROM clienteweb;


SELECT idCliente, nomeCliente, emailCliente, senhaCliente, telefoneCliente, enderecoCliente, bairroCliente, cidadeCliente, estadoCliente, numeroCliente, cpfCliente, statusCliente, descricaoTpUsuario FROM clienteweb JOIN tpUsuario ON fkTpUsuario=idTpUsuario;

UPDATE clienteweb SET nomeCliente ='Victor Lino', emailCliente = 'victor@gmail.com', senhaCliente = 'victor123', telefoneCliente = '(11)98761-9876', enderecoCliente = 'Rua Matarás', bairroCliente = 'Crepioca', cidadeCliente = 'São Paulo', estadoCliente = 'SP', numeroCliente = '34', cpfCliente = '455.456.752-04', statusCliente = 'ATIVO', dataCadCliente = '2022-02-17', fkTpUsuario = 1 WHERE idCliente= 2;


SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

CREATE DATABASE lendasclassic;

USE lendasclassic;

CREATE TABLE [tpUsuario]
(
	[idTpUsuario] INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[descricaoTpUsuario] varchar(13) NOT NULL
);

INSERT INTO [tpUsuario] VALUES('Administrador');
INSERT INTO [tpUsuario] VALUES('Outros');
 
CREATE TABLE [clientee] (
  [idCliente`] int primary key identity (1,1) NOT NULL,
  [nomeCliente] varchar(100) NOT NULL,
  [planoCliente] varchar(50) NOT NULL,
  [sexoCliente] varchar(50) NOT NULL,
  [cpfCliente] varchar(14) NOT NULL,
  [emailCliente] varchar(100) NOT NULL,
  [enderecoCliente] varchar(100) NOT NULL,
  [cepCliente] varchar(9) NOT NULL,
  [bairroCLiente] varchar(100) NOT NULL,
  [celularCliente] varchar(15) NOT NULL,
  [telefoneCliente] varchar(14) NOT NULL,
  [statusCliente] varchar(20) NOT NULL,
  [dataCadCliente] date NOT NULL,
  [senhaCliente] varchar(45) NOT NULL
);

INSERT INTO `clientee` (`idCliente`, `nomeCliente`, `planoCliente`, `sexoCliente`, `cpfCliente`, `emailCliente`, `enderecoCliente`, `cepCliente`, `bairroCLiente`, `celularCliente`, `telefoneCliente`, `statusCliente`, `dataCadCliente`, `senhaCliente`) VALUES
(1, 'ERIC CERQUEIRA', '12 MESES', 'MASCULINO', '412.403.258-78', 'ERICSCERQUEIRAA@GMAIL.COM', 'AV. RAIMUNDO PARADERA', '08021-450', 'VILA ROSÁRIA', '11 95882-3482', '2297-0404', 'ATIVO', '2022-02-06', '1234ERIC'),
(2, 'LARISSA BARAUNA', '6 MESES', 'FEMININO', '576.100.105-53', 'lari123@gmail.com', 'Rua Helena Arnim', '32145-852', 'Limoeiro', '(11)95953-7506', '(11)2258-8522', 'INATIVO', '2022-02-09', 'lari1234');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarioo`
--

CREATE TABLE `funcionarioo` (
  `idFuncionario` int(11) NOT NULL,
  `nomeFuncionario` varchar(100) NOT NULL,
  `emailFuncionario` varchar(100) NOT NULL,
  `senhaFuncionario` varchar(45) NOT NULL,
  `nivelFuncionario` varchar(12) NOT NULL,
  `statusFuncionario` varchar(20) NOT NULL,
  `dataCadFuncionario` date NOT NULL,
  `horarioTraFuncionario` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `funcionarioo`
--

INSERT INTO `funcionarioo` (`idFuncionario`, `nomeFuncionario`, `emailFuncionario`, `senhaFuncionario`, `nivelFuncionario`, `statusFuncionario`, `dataCadFuncionario`, `horarioTraFuncionario`) VALUES
(1, 'Eric Cerqueira', 'eric@gmail.com', 'eric1234', 'ADMINISTRADO', 'ATIVO', '2023-01-31', '08:00:00'),
(2, 'Viktor Lino', 'viktor@gmail.com', 'viktor1234', 'ADMINISTRADO', 'ATIVO', '2023-01-31', '08:00:00'),
(3, 'Jenny Petrova', 'jenny@gmail.com', 'jenny1234', 'OUTROS', 'ATIVO', '2023-01-31', '10:00:00'),
(4, 'Larissa Baraúna', 'larissa@gmail.com', 'larissa1234', 'OUTROS', 'ATIVO', '2023-01-31', '06:00:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `reservaa`
--

CREATE TABLE `reservaa` (
  `idReserva` int(11) NOT NULL,
  `nomeReserva` varchar(45) NOT NULL,
  `sobrenomeReserva` varchar(45) NOT NULL,
  `emailReserva` varchar(45) NOT NULL,
  `celularReserva` varchar(45) NOT NULL,
  `localizacaoReserva` varchar(45) NOT NULL,
  `obsReserva` text NOT NULL,
  `dataReserva` date NOT NULL,
  `horaReserva` time NOT NULL,
  `statusReserva` varchar(45) NOT NULL,
  `idFuncionario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `reservaa`
--

INSERT INTO `reservaa` (`idReserva`, `nomeReserva`, `sobrenomeReserva`, `emailReserva`, `celularReserva`, `localizacaoReserva`, `obsReserva`, `dataReserva`, `horaReserva`, `statusReserva`, `idFuncionario`) VALUES
(1, 'VICTOR', 'LINO', 'victorlino@gmail.com', '11 94002-8922', 'SP', 'NENHUMA', '2023-08-18', '12:00:00', 'ATIVA', 4),
(2, 'LEONARDO', 'ADALIDI', 'leoadalidi@gmail.com', '11 96589-4587', 'SP', 'COM ACOMPANHANTE', '2023-07-10', '16:00:00', 'ATIVA', 2),
(3, 'STEFANI', 'CARDOSO', 'stefanicardoso@gmail.com', '11 92589-7852', 'SP', 'NENHUMA', '2023-07-13', '18:00:00', 'ATIVA', 1),
(4, 'VIVIANE', 'FERREIA', 'vivivi@gmail.com', '11 92563-1254', 'SP', 'DIFICIENTE VISUAL', '2023-08-18', '12:00:00', 'ATIVA', 3);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientee`
--
ALTER TABLE `clientee`
  ADD PRIMARY KEY (`idCliente`);

--
-- Índices para tabela `funcionarioo`
--
ALTER TABLE `funcionarioo`
  ADD PRIMARY KEY (`idFuncionario`);

--
-- Índices para tabela `reservaa`
--
ALTER TABLE `reservaa`
  ADD PRIMARY KEY (`idReserva`),
  ADD KEY `IdFuncionario` (`idFuncionario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientee`
--
ALTER TABLE `clientee`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `funcionarioo`
--
ALTER TABLE `funcionarioo`
  MODIFY `idFuncionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `reservaa`
--
ALTER TABLE `reservaa`
  MODIFY `idReserva` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `reservaa`
--
ALTER TABLE `reservaa`
  ADD CONSTRAINT `IdFuncionario` FOREIGN KEY (`idFuncionario`) REFERENCES `funcionarioo` (`idFuncionario`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 07-Jul-2023 às 23:31
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 7.4.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dppsc`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro`
--

CREATE TABLE `cadastro` (
  `idcadastro` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `curso` varchar(50) NOT NULL,
  `telefone` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `datanascimento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadastro`
--

INSERT INTO `cadastro` (`idcadastro`, `nome`, `curso`, `telefone`, `email`, `senha`, `datanascimento`) VALUES
(1, 'Daniela Cristina dos Santos', 'Secretaria', '13989898987', 'daniela.cristina21@unifesp.br', 'dc21', '1979-01-21'),
(2, 'Maria Fernanda Petroli Frutuoso', 'Nutrição', '11 989989898', 'fernanda.frutuoso@unifesp.br', 'mafe06', '1974-08-06'),
(3, 'Gisele Aparecida Bovolenta', 'Serviço Social', '13 9812331456', 'gisele.bovolenta@unifesp.br', 'gb12', '1981-11-12'),
(4, 'Jaqueline Kalmus', 'Psicologia', '13 981112222', 'jaqueline.kalmus@unifesp.br', 'jk19', '1972-02-19'),
(5, 'Carine Savalli Redigolo', 'Estatística', '13912348888', 'carine.redigolo@unifesp.br', 'csr19', '1980-07-19'),
(7, 'Luiz Henrique Passador', 'Eixo IS', '13 999878877', 'luiz.passador@unifesp.br', 'lhp03', '1970-11-03'),
(10, 'Marcelo Domingues Roman', 'Psicologia', '13 981112222', 'marcelo.roman@unifesp.br', 'mdr19', '1970-11-19');

-- --------------------------------------------------------

--
-- Estrutura da tabela `faleconosco`
--

CREATE TABLE `faleconosco` (
  `Idfaleconosco` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `telefone` varchar(50) NOT NULL,
  `mensagem` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `faleconosco`
--

INSERT INTO `faleconosco` (`Idfaleconosco`, `nome`, `email`, `telefone`, `mensagem`) VALUES
(1, 'Renata', 'renata.abreu@gmail.com', '13989393939', 'Olá, bom dia! Gostaria de saber se vão realizar outro evento de Território e Saúde? Obrigada. Renata'),
(2, 'Henrique', 'henrique.braga@gmail.com', '13912349877', 'Olá, boa tarde! A Profa. Raiane não faz mais parte deste departamento?'),
(3, 'Felipe Vargas', 'felipe.vargas@gmail.com', '139812345677', 'Oi boa tarde... gostaria de agendar uma visita ao campus. Como devo proceder?');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro`
--
ALTER TABLE `cadastro`
  ADD PRIMARY KEY (`idcadastro`);

--
-- Índices para tabela `faleconosco`
--
ALTER TABLE `faleconosco`
  ADD PRIMARY KEY (`Idfaleconosco`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro`
--
ALTER TABLE `cadastro`
  MODIFY `idcadastro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `faleconosco`
--
ALTER TABLE `faleconosco`
  MODIFY `Idfaleconosco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

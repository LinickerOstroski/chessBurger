
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Copiando estrutura para procedure chessburger.consultaLogin
DELIMITER //
CREATE PROCEDURE `consultaLogin`(usuario varchar(100), senha varchar(100))
BEGIN
Select * from usuarios where usuarios.nome = usuario and usuarios.senha = senha;
END//
DELIMITER ;

-- Copiando estrutura para tabela chessburger.lanche
CREATE TABLE IF NOT EXISTS `lanche` (
  `idLanche` int(11) NOT NULL AUTO_INCREMENT,
  `nomeLanche` varchar(45) NOT NULL,
  `ingredientes` varchar(255) NOT NULL,
  `precoLanche` float NOT NULL,
  PRIMARY KEY (`idLanche`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela chessburger.lanche: ~2 rows (aproximadamente)
INSERT INTO `lanche` (`idLanche`, `nomeLanche`, `ingredientes`, `precoLanche`) VALUES
	(7, 'Hambúrguer', 'carne, queijo, pão, alface, ketchup,tomate', 14.99),
	(8, 'Fritas', 'batatas fritas', 12.5);

-- Copiando estrutura para tabela chessburger.pedido
CREATE TABLE IF NOT EXISTS `pedido` (
  `idPedido` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCliente` varchar(45) NOT NULL,
  `idLanche` int(11) DEFAULT NULL,
  PRIMARY KEY (`idPedido`),
  KEY `idLanche` (`idLanche`),
  CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`idLanche`) REFERENCES `lanche` (`idLanche`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela chessburger.pedido: ~3 rows (aproximadamente)
INSERT INTO `pedido` (`idPedido`, `nomeCliente`, `idLanche`) VALUES
	(41, 'Torres', 8),
	(54, 'Bispo', 7),
	(55, 'Rei', 8);

-- Copiando estrutura para procedure chessburger.sp_alteraLanche
DELIMITER //
CREATE PROCEDURE `sp_alteraLanche`(idLanches int, nomeLanche varchar(45),ingredientes varchar(255),precoLanche float)
BEGIN
UPDATE `lanche`
SET
`nomeLanche` = nomeLanche,
`ingredientes` = ingredientes,
`precoLanche` = precoLanche
WHERE `idLanche` = idLanches;

END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_insereLanche
DELIMITER //
CREATE PROCEDURE `sp_insereLanche`(nomeLanche varchar(45),ingredientes varchar(255),precoLanche float)
BEGIN
INSERT INTO `lanche`
(
`nomeLanche`,
`ingredientes`,
`precoLanche`)
VALUES
(
nomeLanche,
ingredientes,
precoLanche);

END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_inserePedido
DELIMITER //
CREATE PROCEDURE `sp_inserePedido`(nomeCliente varchar(45), idLanche int)
BEGIN
INSERT INTO pedido
(
`nomeCliente`,
`idLanche`)
VALUES
(
nomeCliente,
idLanche);
END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_lanche
DELIMITER //
CREATE PROCEDURE `sp_lanche`(nomeLanche varchar(45),ingredientes varchar(255),precoLanche float)
BEGIN
INSERT INTO `lanche`
(
`nomeLanche`,
`ingredientes`,
`precoLanche`)
VALUES
(
nomeLanche,
ingredientes,
precoLanche);

END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_listaGenero
DELIMITER //
CREATE PROCEDURE `sp_listaGenero`()
BEGIN
	Select * from lanche;
END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_listaLanches
DELIMITER //
CREATE PROCEDURE `sp_listaLanches`()
BEGIN
	Select * from lanche;
END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_listaLanchesTodo
DELIMITER //
CREATE PROCEDURE `sp_listaLanchesTodo`()
BEGIN
	SELECT idLanche,nomeLanche,precoLanche FROM lanche;
    
END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_listaPedidos
DELIMITER //
CREATE PROCEDURE `sp_listaPedidos`()
BEGIN
	SELECT idPedido,nomeCliente,lanche.nomeLanche 
    FROM pedido
    INNER JOIN lanche on pedido.idLanche = lanche.idLanche;
END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_removeLanche
DELIMITER //
CREATE PROCEDURE `sp_removeLanche`(idLanches int)
BEGIN
	delete from lanche where idLanche = idLanches;
END//
DELIMITER ;

-- Copiando estrutura para procedure chessburger.sp_removePedido
DELIMITER //
CREATE PROCEDURE `sp_removePedido`(idPedidos int)
BEGIN
	delete from pedido where idPedido = idPedidos;
END//
DELIMITER ;

-- Copiando estrutura para tabela chessburger.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(24) NOT NULL,
  `senha` varchar(244) NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela chessburger.usuarios: ~0 rows (aproximadamente)
INSERT INTO `usuarios` (`idUsuario`, `nome`, `senha`) VALUES
	(1, 'adm', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

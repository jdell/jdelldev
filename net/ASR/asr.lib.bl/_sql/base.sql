
-- Descripcion = Creamos la tabla Customer
DROP TABLE IF EXISTS `_upgrades_`;
CREATE TABLE  `_upgrades_` (
  `VersionBD` int(10) unsigned NOT NULL,
  `Usuario` varchar(45) NOT NULL,
  `Maquina` varchar(45) NOT NULL,
  `Inicio` datetime NOT NULL,
  `Final` datetime NOT NULL,
  `Descripcion` varchar(4500) NOT NULL,
  PRIMARY KEY (`VersionBD`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `_upgrades_` VALUES('0', 'ASR', 'LOCALHOST', now(), now(), 'Init App DB');
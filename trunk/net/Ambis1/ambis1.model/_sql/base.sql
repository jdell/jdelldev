
-- Descripcion = Creamos la tabla Customer
DROP TABLE IF EXISTS `_Upgrades_`;
CREATE TABLE  `_Upgrades_` (
  `VersionBD` int(10) unsigned NOT NULL,
  `Usuario` varchar(45) NOT NULL,
  `Maquina` varchar(45) NOT NULL,
  `Inicio` datetime NOT NULL,
  `Final` datetime NOT NULL,
  `Descripcion` varchar(4500) NOT NULL,
  PRIMARY KEY (`VersionBD`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `_Upgrades_` VALUES('0', 'DPTC', 'LOCALHOST', now(), now(), 'Init App DB');
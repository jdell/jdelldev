
-- Descripcion = Creacion de Tabla EstadoEvento
/* Para deshacer los cambios
DROP TABLE `gesclinica`.`estadoevento`;

 */

CREATE TABLE `gesclinica`.`estadoevento` (
  `id_estadoevento` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `descripcion_estadoevento` VARCHAR(45) NOT NULL,
  `color_estadoevento` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_estadoevento`)
)
ENGINE = InnoDB;


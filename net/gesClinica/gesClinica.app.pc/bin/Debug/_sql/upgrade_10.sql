
-- Descripcion = Creacion de Tabla TipoTerapia
/* Para deshacer los cambios
DROP TABLE `gesclinica`.`tipoterapia`;

 */
CREATE TABLE `gesclinica`.`tipoterapia` (
  `id_tipoterapia` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `descripcion_tipoterapia` VARCHAR(45) NOT NULL,
  `cobrable_tipoterapia` BIT NOT NULL,
  `codigo_tipoterapia` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_tipoterapia`)
)
ENGINE = InnoDB;



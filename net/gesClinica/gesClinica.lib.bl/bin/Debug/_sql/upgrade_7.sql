
-- Descripcion = Creacion de Tabla Terceros
/* Para deshacer los cambios
DROP TABLE `gesclinica`.`tercero`;

 */

CREATE TABLE `gesclinica`.`tercero` (
  `id_tercero` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `nif_tercero` VARCHAR(45) NOT NULL,
  `codigo_subcuenta` VARCHAR(45) NOT NULL,
  `nombre_tercero` VARCHAR(450) NOT NULL,
  `sigla_tercero` VARCHAR(45) NOT NULL,
  `domicilio_tercero` VARCHAR(450) NOT NULL,
  `numero_tercero` VARCHAR(45) NOT NULL,
  `escalera_tercero` VARCHAR(45) NOT NULL,
  `piso_tercero` VARCHAR(45) NOT NULL,
  `puerta_tercero` VARCHAR(45) NOT NULL,
  `poblacion_tercero` VARCHAR(45) NOT NULL,
  `provincia_tercero` VARCHAR(45) NOT NULL,
  `cp_tercero` VARCHAR(45) NOT NULL,
  `telefono1_tercero` VARCHAR(45) NOT NULL,
  `telefono2_tercero` VARCHAR(45) NOT NULL,
  `fax1_tercero` VARCHAR(45) NOT NULL,
  `fax2_tercero` VARCHAR(45) NOT NULL,
  `persona_tercero` VARCHAR(45) NOT NULL,
  `actividad_tercero` VARCHAR(45) NOT NULL,
  `nacionalidad_tercero` VARCHAR(45) NOT NULL,
  `recargo_tercero` BIT NOT NULL,
  `fechaAlta_tercero` DATETIME NOT NULL,
  `formaPago_tercero` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_tercero`)
)
ENGINE = InnoDB;

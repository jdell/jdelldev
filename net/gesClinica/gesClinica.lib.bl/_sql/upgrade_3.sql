
-- Descripcion = Posibilidad de guardar valores por defecto
/* Para deshacer los cambios
drop table configuracion

 */

CREATE TABLE `gesclinica`.`configuracion` (
  `id_configuracion` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `parent_configuracion` INTEGER UNSIGNED,
  `class_configuracion` VARCHAR(450) NOT NULL,
  `keyvalue_configuracion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_configuracion`)
)
ENGINE = InnoDB;

ALTER TABLE `gesclinica`.`configuracion` ADD CONSTRAINT `FK_configuracion_1` FOREIGN KEY `FK_configuracion_1` (`parent_configuracion`)
    REFERENCES `configuracion` (`id_configuracion`)
    ON DELETE CASCADE
    ON UPDATE RESTRICT;


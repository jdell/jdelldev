
-- Descripcion = Creamos la tabla Service
/* Para deshacer los cambios
DROP TABLE `service`;
 */
CREATE TABLE `service` (
  `id_service` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `description_service` VARCHAR(450) NOT NULL,
  `price_service` FLOAT NOT NULL,
  PRIMARY KEY (`id_service`)
)
ENGINE = InnoDB;

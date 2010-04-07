
-- Descripcion = Creamos la tabla Activity
/* Para deshacer los cambios

drop TABLE `activity`;
 */

CREATE TABLE `activity` (
  `id_activity` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `description_activity` VARCHAR(45) NOT NULL,
  `income_activity` BIT NOT NULL,
  PRIMARY KEY (`id_activity`)
)
ENGINE = InnoDB;


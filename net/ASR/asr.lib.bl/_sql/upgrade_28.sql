
-- Descripcion = Creamos la tabla Serie
/* Para deshacer los cambios

drop TABLE `serie`;
 */

CREATE TABLE `serie` (
  `id_serie` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `description_serie` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_serie`)
)
ENGINE = InnoDB;


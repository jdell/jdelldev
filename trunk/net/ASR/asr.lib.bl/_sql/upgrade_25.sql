
-- Descripcion = Creamos la tabla Payable
/* Para deshacer los cambios

drop TABLE `payable`;
 */

CREATE TABLE `payable` (
  `id_payable` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `description_payable` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_payable`)
)
ENGINE = InnoDB;


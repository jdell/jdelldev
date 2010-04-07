
-- Descripcion = Creamos la tabla Customer
/* Para deshacer los cambios

DROP TABLE `customer`;
 */

CREATE TABLE `customer` (
  `id_customer` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `name_customer` VARCHAR(45) NOT NULL,
  `phone_customer` VARCHAR(45) NOT NULL,
  `address_customer` VARCHAR(45) NOT NULL,
  `fax_customer` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_customer`)
)
ENGINE = InnoDB;
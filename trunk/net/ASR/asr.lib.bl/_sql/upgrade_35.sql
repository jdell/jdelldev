-- Descripcion = Creamos la tabla Payment
/* Para deshacer los cambios

DROP TABLE payment;
 */

CREATE TABLE payment (
  `id_payment` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `date_payment` DATETIME NOT NULL,
  `id_invoice` INTEGER UNSIGNED NOT NULL,
  `amount_payment` FLOAT NOT NULL,
  PRIMARY KEY (`id_payment`)
)
ENGINE = InnoDB;

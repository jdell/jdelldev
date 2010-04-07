
-- Descripcion = Creamos la tabla Invoice
/* Para deshacer los cambios
DROP TABLE `invoice`;
 */
CREATE TABLE `invoice` (
  `id_invoice` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `date_invoice` DATETIME NOT NULL,
  `id_client` INTEGER UNSIGNED NOT NULL,
  `comment_invoice` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_invoice`)
)
ENGINE = InnoDB;
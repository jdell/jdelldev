
-- Descripcion = Creamos la tabla InvoiceDetail
/* Para deshacer los cambios
DROP TABLE `invoicedetail`;
 */
CREATE TABLE `invoicedetail` (
  `id_invoicedetail` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_invoice` INTEGER UNSIGNED NOT NULL,
  `id_service` INTEGER UNSIGNED NOT NULL,
  `description_invoicedetail` VARCHAR(450) NOT NULL,
  `price_invoicedetail` FLOAT NOT NULL,
  `amount_invoicedetail` INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY (`id_invoicedetail`)
)
ENGINE = InnoDB;


-- Descripcion = Modificamos la tabla InvoiceDetail
/* Para deshacer los cambios

ALTER TABLE `invoicedetail` DROP COLUMN `stateFee_invoiceDetail`;

 */

ALTER TABLE `invoicedetail` ADD COLUMN `stateFee_invoicedetail` FLOAT NOT NULL AFTER `amount_invoicedetail`;



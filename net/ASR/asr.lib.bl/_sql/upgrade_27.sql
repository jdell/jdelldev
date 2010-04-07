
-- Descripcion = Modificamos la tabla Invoice
/* Para deshacer los cambios

ALTER TABLE `invoice` DROP COLUMN `pending_invoice`;

 */

ALTER TABLE `invoice` ADD COLUMN `pending_invoice` BIT NOT NULL AFTER `id_payable`;



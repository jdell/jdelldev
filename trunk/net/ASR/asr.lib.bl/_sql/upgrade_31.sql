
-- Descripcion = Modificamos la tabla Invoice
/* Para deshacer los cambios

ALTER TABLE `invoice` DROP COLUMN `income_invoice`;

 */

ALTER TABLE `invoice` ADD COLUMN `income_invoice` BIT NOT NULL AFTER `number_invoice`;

UPDATE `invoice` SET income_invoice=1;



-- Descripcion = Modificamos la tabla Invoice
/* Para deshacer los cambios

ALTER TABLE `invoice` DROP COLUMN `id_payable`;

 */

ALTER TABLE `invoice` ADD COLUMN `id_payable` INTEGER UNSIGNED NOT NULL AFTER `comment_invoice`;



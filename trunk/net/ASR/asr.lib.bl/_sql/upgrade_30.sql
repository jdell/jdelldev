
-- Descripcion = Modificamos la tabla Invoice
/* Para deshacer los cambios

ALTER TABLE `invoice` DROP COLUMN `number_invoice`;
ALTER TABLE `invoice` DROP COLUMN `id_serie`;

 */

ALTER TABLE `invoice` ADD COLUMN `number_invoice` INTEGER UNSIGNED NOT NULL AFTER `pending_invoice`,
ADD COLUMN `id_serie` INTEGER UNSIGNED NOT NULL AFTER `number_invoice`;



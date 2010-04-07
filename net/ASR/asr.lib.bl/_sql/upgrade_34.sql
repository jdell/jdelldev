-- Descripcion = Modificamos la tabla Invoice
/* Para deshacer los cambios

ALTER TABLE `invoice` MODIFY COLUMN `id_payable` INTEGER UNSIGNED DEFAULT NOT NULL;
ALTER TABLE `invoice` MODIFY COLUMN `id_serie` INTEGER UNSIGNED DEFAULT NOT NULL;
 */

ALTER TABLE `invoice` MODIFY COLUMN `id_payable` INTEGER UNSIGNED DEFAULT NULL,
 MODIFY COLUMN `id_serie` INTEGER UNSIGNED DEFAULT NULL;

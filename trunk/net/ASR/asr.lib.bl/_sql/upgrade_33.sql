-- Descripcion = Modificamos la tabla Invoice
/* Para deshacer los cambios

ALTER TABLE `invoice` MODIFY COLUMN `id_client` INTEGER UNSIGNED DEFAULT NOT NULL;

 */

ALTER TABLE `invoice` MODIFY COLUMN `id_client` INTEGER UNSIGNED DEFAULT NULL;

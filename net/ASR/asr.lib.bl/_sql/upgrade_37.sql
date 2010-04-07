-- Descripcion = Modificamos la tabla Activity (ready for the web)
/* Para deshacer los cambios

ALTER TABLE `activity` DROP COLUMN `id_client`;


 */

  ALTER TABLE `activity` ADD COLUMN `id_client` INTEGER UNSIGNED NOT NULL AFTER `income_activity`;

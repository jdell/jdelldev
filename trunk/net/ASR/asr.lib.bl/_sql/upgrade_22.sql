
-- Descripcion = Modificamos la tabla Client
/* Para deshacer los cambios

ALTER TABLE `client` DROP COLUMN `photo_client`;

 */

ALTER TABLE `client` ADD COLUMN `photo_client` LONGBLOB AFTER `companyName_client`;



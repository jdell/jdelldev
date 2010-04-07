
-- Descripcion = Modificamos la tabla Client
/* Para deshacer los cambios

ALTER TABLE `client` DROP COLUMN `dateOfBirth_client`;
 */

ALTER TABLE `client` ADD COLUMN `dateOfBirth_client` DATETIME NULL AFTER `comments_client`;




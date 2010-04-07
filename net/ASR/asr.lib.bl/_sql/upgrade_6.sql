
-- Descripcion = Modificamos la tabla Client
/* Para deshacer los cambios

ALTER TABLE `client` DROP COLUMN `creditScore_client`;
 */

ALTER TABLE `client` ADD COLUMN `creditScore_client` FLOAT NULL AFTER `dateOfBirth_client`;




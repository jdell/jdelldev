
-- Descripcion = Modificamos la tabla Client
/* Para deshacer los cambios

ALTER TABLE `client` DROP COLUMN `companyName_client`;
 */

ALTER TABLE `client` ADD COLUMN `companyName_client` VARCHAR(45) NOT NULL AFTER `creditScore_client`;


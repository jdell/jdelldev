
-- Descripcion = Modificamos la tabla Service
/* Para deshacer los cambios

ALTER TABLE `service` DROP COLUMN `income_service`;

 */

ALTER TABLE `service` ADD COLUMN `income_service` BIT NOT NULL AFTER `stateFee_service`;

UPDATE `service` SET income_service=1;




-- Descripcion = Modificamos la tabla Service
/* Para deshacer los cambios

ALTER TABLE `service` DROP COLUMN `stateFee_service`;

 */

ALTER TABLE `service` ADD COLUMN `stateFee_service` FLOAT NOT NULL AFTER `price_service`;



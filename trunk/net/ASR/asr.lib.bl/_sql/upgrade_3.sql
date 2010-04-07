
-- Descripcion = Modificamos la tabla Customer
/* Para deshacer los cambios

ALTER TABLE `customer` DROP COLUMN `city_customer`,
 DROP COLUMN `state_customer`,
 DROP COLUMN `zipcode_customer`,
 DROP COLUMN `active_customer`;

 */

ALTER TABLE `customer` ADD COLUMN `city_customer` VARCHAR(45) NOT NULL AFTER `fax_customer`,
 ADD COLUMN `state_customer` VARCHAR(45) NOT NULL AFTER `city_customer`,
 ADD COLUMN `zipcode_customer` VARCHAR(45) NOT NULL AFTER `state_customer`,
 ADD COLUMN `active_customer` VARCHAR(45) NOT NULL AFTER `zipcode_customer`;


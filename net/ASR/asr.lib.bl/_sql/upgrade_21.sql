
-- Descripcion = Modificamos la tabla Staff
/* Para deshacer los cambios

ALTER TABLE `task` DROP COLUMN `phone_staff`,
 DROP COLUMN `id_staff`;

 */

ALTER TABLE `staff` ADD COLUMN `phone_staff` VARCHAR(45) NOT NULL AFTER `name_staff`;



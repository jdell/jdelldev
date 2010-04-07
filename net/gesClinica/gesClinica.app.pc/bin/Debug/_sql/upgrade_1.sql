
-- Descripcion = Colores por terapeuta
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`empleado` DROP COLUMN `color1_empleado`,
 DROP COLUMN `color2_empleado`;
 */

ALTER TABLE `gesclinica`.`empleado` 
 ADD COLUMN `color1_empleado` VARCHAR(45) NOT NULL AFTER `versololomio_empleado`,
 ADD COLUMN `color2_empleado` VARCHAR(45) NOT NULL AFTER `color1_empleado`;

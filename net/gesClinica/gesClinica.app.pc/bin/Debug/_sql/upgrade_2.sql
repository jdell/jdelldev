
-- Descripcion = Colores por sala
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`sala` DROP COLUMN `color_sala`;

 */

ALTER TABLE `gesclinica`.`sala` ADD COLUMN `color_sala` VARCHAR(45) NOT NULL AFTER `activo_sala`;

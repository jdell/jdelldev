-- Descripcion = Modificamos la tabla Employment
/* Para deshacer los cambios

ALTER TABLE `asr`.`employment` DROP COLUMN `turn_employment`;

 */

ALTER TABLE `asr`.`employment` ADD COLUMN `turn_employment` VARCHAR(45) NOT NULL AFTER `gap_employment`;


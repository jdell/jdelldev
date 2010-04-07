
-- Descripcion = Aumentado los caracteres que caben en las observaciones del paciente.
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`paciente` MODIFY COLUMN `observaciones_paciente` VARCHAR(450) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL;

 */

ALTER TABLE `gesclinica`.`paciente` MODIFY COLUMN `observaciones_paciente` VARCHAR(4500) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL;
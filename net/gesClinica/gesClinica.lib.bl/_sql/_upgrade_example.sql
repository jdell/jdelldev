
-- Descripcion = Pruebas...bla bla..bla
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`estadocivil` DROP COLUMN `prueba_estadocita`;
 */
ALTER TABLE `gesclinica`.`estadocivil` ADD COLUMN `prueba_estadocita` VARCHAR(45) NOT NULL AFTER `descripcion_estadocivil`;

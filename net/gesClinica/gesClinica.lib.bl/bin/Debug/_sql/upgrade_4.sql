
-- Descripcion = Posibilidad de permitir estados de cita nulos si son telef�nicas
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`cita` MODIFY COLUMN `id_estadocita` INTEGER UNSIGNED NOT NULL;


 */

ALTER TABLE `gesclinica`.`cita` MODIFY COLUMN `id_estadocita` INTEGER UNSIGNED NULL;

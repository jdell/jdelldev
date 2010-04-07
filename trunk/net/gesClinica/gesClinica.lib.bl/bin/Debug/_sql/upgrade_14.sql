
-- Descripcion = Modificacion de la Tabla EstadoCita
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`estadocita` DROP COLUMN `avion_estadocita`;

 */
    ALTER TABLE `gesclinica`.`estadocita` ADD COLUMN `avion_estadocita` BIT NOT NULL AFTER `generarecibo_estadocita`;
	UPDATE `gesclinica`.`estadocita` SET avion_estadocita = 0;
	
	



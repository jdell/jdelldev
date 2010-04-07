
-- Descripcion = Modificacion de Tabla TipoTerapia = Campo color
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`tipoterapia` DROP COLUMN `color_tipoterapia`;

 */
    ALTER TABLE `gesclinica`.`tipoterapia` ADD COLUMN `color_tipoterapia` VARCHAR(45) NOT NULL AFTER `codigo_tipoterapia`;



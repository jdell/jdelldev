
-- Descripcion = Modificacion de Tabla Terapia = Campo 
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`terapia` DROP COLUMN `id_tipoterapia`;

 */
ALTER TABLE `gesclinica`.`terapia` ADD COLUMN `id_tipoterapia` INTEGER UNSIGNED NOT NULL AFTER `codigo_subcuenta`;



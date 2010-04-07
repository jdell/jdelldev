
-- Descripcion = Modificacion de Tabla Evento. Campo id_estadoevento
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`evento` DROP COLUMN `id_estadoevento`;


 */

ALTER TABLE `gesclinica`.`evento` ADD COLUMN `id_estadoevento` INTEGER UNSIGNED AFTER `id_sala`;



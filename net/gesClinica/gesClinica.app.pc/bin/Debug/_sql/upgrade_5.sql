
-- Descripcion = Posibilidad de permitir marcar las formas de pago que deben ser facturadas.
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`formapago` DROP COLUMN `facturar_formapago`;

 */

ALTER TABLE `gesclinica`.`formapago` ADD COLUMN `facturar_formapago` BIT NOT NULL AFTER `descripcion_formapago`;

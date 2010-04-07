
-- Descripcion = Modificacion de la Tabla Empresa [columna ContabilizarFactura].
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`empresa` DROP COLUMN `contabilizarfactura_empresa`;



 */
ALTER TABLE `gesclinica`.`empresa` ADD COLUMN `contabilizarfactura_empresa` BIT NOT NULL AFTER `otrosdatos_empresa`;
UPDATE `gesclinica`.`empresa` SET contabilizarfactura_empresa = 1;
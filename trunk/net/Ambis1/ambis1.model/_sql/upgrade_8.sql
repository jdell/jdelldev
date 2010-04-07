
-- Descripcion = ALTER TABLE `membership`
/* Para deshacer los cambios
ALTER TABLE `membership`
  DROP `paid_membership`;
 */
ALTER TABLE `membership` ADD `paid_membership` BOOL NOT NULL DEFAULT '0';
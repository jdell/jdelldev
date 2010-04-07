
-- Descripcion = Alter table Member
/* Para deshacer los cambios

 ALTER TABLE `member` CHANGE `number_member` `ssn_member` VARCHAR( 15 ) NOT NULL ;
 */
 ALTER TABLE `member` CHANGE `ssn_member` `number_member` INT( 15 ) NOT NULL ;
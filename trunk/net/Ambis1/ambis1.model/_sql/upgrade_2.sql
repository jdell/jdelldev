
-- Descripcion = Alter table Member
/* Para deshacer los cambios

ALTER TABLE `member`
  DROP `comments_member`,
  DROP `emergencycontactName_member`,
  DROP `emergencycontactPhone_member`,
  DROP `emergencycontactRelationship_member`;
 */
 ALTER TABLE `member` ADD `comments_member` VARCHAR( 1000 ) NOT NULL ,
ADD `emergencycontactName_member` VARCHAR( 50 ) NOT NULL ,
ADD `emergencycontactPhone_member` VARCHAR( 50 ) NOT NULL ,
ADD `emergencycontactRelationship_member` VARCHAR( 50 ) NOT NULL ;
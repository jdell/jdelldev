
-- Descripcion = LTER TABLE `typeofmembership`
/* Para deshacer los cambios
ALTER TABLE `typeofmembership`
  DROP `teamprice_typeofmembership`,
  DROP `familyprice_typeofmembership`;
 */
 ALTER TABLE `typeofmembership` ADD `teamprice_typeofmembership` FLOAT NOT NULL ,
ADD `familyprice_typeofmembership` FLOAT NOT NULL ;
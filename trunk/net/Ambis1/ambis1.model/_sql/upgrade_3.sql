
-- Descripcion = Add table Cage
/* Para deshacer los cambios

 DROP TABLE `cage`  
 */
 CREATE TABLE `cage` (
`id_cage` TINYINT NOT NULL AUTO_INCREMENT ,
`description_cage` VARCHAR( 50 ) NOT NULL ,
PRIMARY KEY ( `id_cage` )
) ENGINE = MYISAM 
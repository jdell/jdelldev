
-- Descripcion = Add table Reservation
/* Para deshacer los cambios

 DROP TABLE `reservation`  
 */
 CREATE TABLE `reservation` (
`id_reservation` INT NOT NULL AUTO_INCREMENT,
`dateAndTime_reservation` DATETIME NOT NULL ,
`duration_reservation` DATETIME NOT NULL ,
`id_member` INT NOT NULL ,
`id_cage` INT NOT NULL,
PRIMARY KEY ( `id_reservation` )
) ENGINE = MYISAM 

-- Descripcion = Creamos la tabla Staff
/* Para deshacer los cambios
DROP TABLE `staff`;
 */
CREATE TABLE `staff` (
  `id_staff` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `name_staff` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_staff`)
)
ENGINE = InnoDB;

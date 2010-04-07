
-- Descripcion = Creamos la tabla Skill
/* Para deshacer los cambios
drop TABLE `skill`;
 */
CREATE TABLE `skill` (
  `id_skill` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `description_skill` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_skill`)
)
ENGINE = InnoDB;


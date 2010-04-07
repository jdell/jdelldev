
-- Descripcion = Creamos la tabla Task
/* Para deshacer los cambios

DROP TABLE `task`;
 */

CREATE TABLE `task` (
  `id_task` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `description_task` VARCHAR(450) NOT NULL,
  `completed_task` BIT NOT NULL,
  `priority_task` BIT NOT NULL,
  PRIMARY KEY (`id_task`)
)
ENGINE = InnoDB;
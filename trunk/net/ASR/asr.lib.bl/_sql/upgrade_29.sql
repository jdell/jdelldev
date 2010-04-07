
-- Descripcion = Creamos la tabla Counter
/* Para deshacer los cambios

drop TABLE `counter`;
 */

CREATE TABLE `counter` (
  `id_counter` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `year_counter` INTEGER UNSIGNED NOT NULL,
  `id_serie` INTEGER UNSIGNED NOT NULL,
  `number_counter` INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY (`id_counter`)
)
ENGINE = InnoDB;


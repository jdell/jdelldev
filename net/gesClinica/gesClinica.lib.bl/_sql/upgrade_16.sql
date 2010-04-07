
-- Descripcion = Creacion de la Tabla Relacion Terapia-Terapia.
/* Para deshacer los cambios
DROP TABLE `gesclinica`.`r_terapia_terapia`;


 */
CREATE TABLE `gesclinica`.`r_terapia_terapia` (
  `idfirst_terapia` INTEGER UNSIGNED NOT NULL,
  `idsecond_terapia` INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY (`idfirst_terapia`, `idsecond_terapia`)
)
ENGINE = InnoDB;

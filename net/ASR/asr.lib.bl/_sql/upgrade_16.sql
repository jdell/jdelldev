
-- Descripcion = Creamos la tabla SkillScore
/* Para deshacer los cambios

drop TABLE `skillscore`;
 */

CREATE TABLE `skillscore` (
  `id_skillscore` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_skill` INTEGER UNSIGNED NOT NULL,
  `id_client` INTEGER UNSIGNED NOT NULL,
  `score_skillscore` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_skillscore`)
)
ENGINE = InnoDB;


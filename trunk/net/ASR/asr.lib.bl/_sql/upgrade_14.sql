
-- Descripcion = Creamos la tabla Message
/* Para deshacer los cambios
drop TABLE `message`;
 */
CREATE TABLE `message` (
  `id_message` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `date_message` DATETIME NOT NULL,
  `from_message` VARCHAR(45) NOT NULL,
  `of_message` VARCHAR(45) NOT NULL,
  `phone_message` VARCHAR(45) NOT NULL,
  `text_message` VARCHAR(450) NOT NULL,
  `id_staff` INTEGER UNSIGNED NOT NULL,
  `telephoned_message` BIT NOT NULL,
  `calledToSeeYou_message` BIT NOT NULL,
  `wantsToSeeYou_message` BIT NOT NULL,
  `pleaseCall_message` BIT NOT NULL,
  `willCallAgain_message` BIT NOT NULL,
  `returnedYourCall_message` BIT NOT NULL,
  `urgent_message` BIT NOT NULL,
  `visitedYourOffice_message` BIT NOT NULL,
  `checked_message` BIT NOT NULL,
  PRIMARY KEY (`id_message`)
)
ENGINE = InnoDB;


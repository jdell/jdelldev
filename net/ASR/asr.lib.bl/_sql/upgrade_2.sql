
-- Descripcion = Creamos la tabla Client
/* Para deshacer los cambios

DROP TABLE `client`;
 */

CREATE TABLE `client` (
  `id_client` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `firstName_client` VARCHAR(45) NOT NULL,
  `lastName_client` VARCHAR(45) NOT NULL,
  `middleName_client` VARCHAR(45) NOT NULL,
  `homeAddress_client` VARCHAR(150) NOT NULL,
  `homeCity_client` VARCHAR(45) NOT NULL,
  `homeState_client` VARCHAR(45) NOT NULL,
  `homeZipCode_client` VARCHAR(45) NOT NULL,
  `preferredFirstName_client` VARCHAR(45) NOT NULL,
  `ssn_client` VARCHAR(45) NOT NULL,
  `mailingAddress_client` VARCHAR(150) NOT NULL,
  `mailingCity_client` VARCHAR(45) NOT NULL,
  `mailingState_client` VARCHAR(45) NOT NULL,
  `mailingZipCode_client` VARCHAR(45) NOT NULL,
  `homePhoneNumber_client` VARCHAR(45) NOT NULL,
  `cellPhoneNumber_client` VARCHAR(45) NOT NULL,
  `additionalContactPhone_client` VARCHAR(45) NOT NULL,
  `emailAddress_client` VARCHAR(150) NOT NULL,
  `emergencyContact_client` VARCHAR(450) NOT NULL,
  `inactive_client` BIT NOT NULL,
  `comments_client` VARCHAR(4500) NOT NULL,
  PRIMARY KEY (`id_client`)
)
ENGINE = InnoDB;

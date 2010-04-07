
-- Descripcion = Creamos la tabla relacion Customer-Client: Employment
/* Para deshacer los cambios

DROP TABLE `employment`;

 */

CREATE TABLE `employment` (
  `id_employment` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_customer` INTEGER UNSIGNED NOT NULL,
  `id_client` VARCHAR(45) NOT NULL,
  `startDate_employment` DATETIME NOT NULL,
  `endDate_employment` DATETIME NULL,
  `startPay_employment` DATETIME NOT NULL,
  `endPay_employment` DATETIME NULL,
  `baseSalary_employment` FLOAT NOT NULL,
  `bonus_employment` FLOAT NOT NULL,
  `additionalCompensation_employment` VARCHAR(45) NOT NULL,
  `positionHeld_employment` VARCHAR(45) NOT NULL,
  `primaryResponsibilities_employment` VARCHAR(45) NOT NULL,
  `reasonForLeaving_employment` VARCHAR(45) NOT NULL,
  `provideNotice_employment` BOOLEAN NOT NULL,
  `contactTitle_employment` VARCHAR(45) NOT NULL,
  `phoneNumber_employment` VARCHAR(45) NOT NULL,
  `relationShip_employment` VARCHAR(45) NOT NULL,
  `mayContact_employment` BOOLEAN NOT NULL,
  `reasonIfNot_employment` VARCHAR(45) NOT NULL,
  `gap_employment` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_employment`)
)
ENGINE = InnoDB;



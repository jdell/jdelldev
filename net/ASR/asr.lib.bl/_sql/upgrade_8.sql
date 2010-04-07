
-- Descripcion = Creamos la tabla AccountRecord
/* Para deshacer los cambios
DROP TABLE `accountrecord`;
 */
 
CREATE TABLE `accountrecord` (
  `id_accountrecord` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  `date_accountrecord` VARCHAR(45) NOT NULL,
  `description_accountrecord` VARCHAR(45) NOT NULL,
  `amount_accountrecord` FLOAT NOT NULL,
  `reference_accountrecord` VARCHAR(45) NOT NULL,
  `incoming_accountrecord` BIT NOT NULL,
  `id_client` INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY (`id_accountrecord`),
  CONSTRAINT `FK_CLIENT` FOREIGN KEY `FK_CLIENT` (`id_client`)
    REFERENCES `client` (`id_client`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT
)
ENGINE = InnoDB;
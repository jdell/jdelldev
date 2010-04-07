-- Descripcion = Modificamos la tablas Activity, Client, AccountRecord (ready for the web)
/* Para deshacer los cambios

ALTER TABLE `activity` DROP COLUMN `external_activity`;
ALTER TABLE `client` DROP COLUMN `external_client`;
ALTER TABLE `accountrecord` DROP COLUMN `external_accountrecord`;

ALTER TABLE `client` DROP COLUMN `username_client`,
 DROP COLUMN `password_client`;

 */

ALTER TABLE `activity` ADD COLUMN `external_activity` INTEGER UNSIGNED AFTER `id_activity`;
ALTER TABLE `client` ADD COLUMN `external_client` INTEGER UNSIGNED AFTER `id_client`;
ALTER TABLE `accountrecord` ADD COLUMN `external_accountrecord` INTEGER UNSIGNED AFTER `id_accountrecord`;

ALTER TABLE `client` ADD COLUMN `username_client` VARCHAR(45) NOT NULL AFTER `photo_client`,
 ADD COLUMN `password_client` VARCHAR(45) NOT NULL AFTER `username_client`;
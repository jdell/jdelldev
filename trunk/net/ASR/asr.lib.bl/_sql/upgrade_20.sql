
-- Descripcion = Modificamos la tabla Task
/* Para deshacer los cambios

ALTER TABLE `task` DROP COLUMN `date_task`,
 DROP COLUMN `id_staff`;

 */

ALTER TABLE `task` ADD COLUMN `date_task` DATETIME NOT NULL AFTER `priority_task`,
 ADD COLUMN `id_staff` INTEGER UNSIGNED AFTER `date_task`;
 
 UPDATE `task` set `date_task` = now();



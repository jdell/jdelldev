
-- Descripcion = Modificacion de la Tabla Paciente. Notas de Agenda.
/* Para deshacer los cambios
ALTER TABLE `gesclinica`.`paciente` DROP COLUMN `notasagenda_paciente`;


 */
    ALTER TABLE `gesclinica`.`paciente` ADD COLUMN `notasagenda_paciente` VARCHAR(4500) NOT NULL AFTER `codigo_subcuenta`;
	UPDATE `gesclinica`.`paciente` SET notasagenda_paciente = '';

-- Descripcion = Insercion de datos en Tabla TipoTerapia
/* Para deshacer los cambios
delete from `gesclinica`.`tipoterapia`;
UPDATE terapia set id_tipoterapia=NULL;

 */
    INSERT INTO tipoterapia (descripcion_tipoterapia, cobrable_tipoterapia, codigo_tipoterapia, color_tipoterapia) VALUES('Normal', 1, 'NORMAL', 'PaleGreen');
	UPDATE terapia set id_tipoterapia=LAST_INSERT_ID();
	INSERT INTO tipoterapia (descripcion_tipoterapia, cobrable_tipoterapia, codigo_tipoterapia, color_tipoterapia) VALUES('Normal + MC', 1, 'NORMAL_MC', 'PaleGreen');
	INSERT INTO tipoterapia (descripcion_tipoterapia, cobrable_tipoterapia, codigo_tipoterapia, color_tipoterapia) VALUES('MC', 1, 'MC', 'PaleGreen');
	INSERT INTO tipoterapia (descripcion_tipoterapia, cobrable_tipoterapia, codigo_tipoterapia, color_tipoterapia) VALUES('Visitador Medico', 0, 'VISITADOR', 'PaleGreen');
	INSERT INTO tipoterapia (descripcion_tipoterapia, cobrable_tipoterapia, codigo_tipoterapia, color_tipoterapia) VALUES('Llamada Telefonica', 0, 'LLAMADA_TELEFONICA', 'PaleGreen');
	
	



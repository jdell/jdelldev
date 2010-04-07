-- ----------------------------------------------------------------------
-- MySQL Migration Toolkit
-- SQL Create Script
-- ----------------------------------------------------------------------

SET FOREIGN_KEY_CHECKS = 0;

CREATE DATABASE IF NOT EXISTS `gesclinica`
  CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `gesclinica`;
-- -------------------------------------
-- Tables

DROP TABLE IF EXISTS `gesclinica`.`_upgrades_`;
CREATE TABLE `gesclinica`.`_upgrades_` (
  `VersionBD` INT(10) unsigned NOT NULL,
  `Usuario` VARCHAR(45) NOT NULL,
  `Maquina` VARCHAR(45) NOT NULL,
  `Inicio` DATETIME NOT NULL,
  `Final` DATETIME NOT NULL,
  `Descripcion` VARCHAR(4500) NOT NULL,
  PRIMARY KEY (`VersionBD`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`anexo`;
CREATE TABLE `gesclinica`.`anexo` (
  `id_anexo` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_cita` INT(10) unsigned NOT NULL,
  `fecha_anexo` DATETIME NOT NULL,
  `titulo_anexo` VARCHAR(450) NOT NULL,
  `descripcion_anexo` VARCHAR(450) NOT NULL,
  `info_anexo` LONGBLOB NOT NULL,
  `content_anexo` LONGBLOB NOT NULL,
  PRIMARY KEY (`id_anexo`),
  INDEX `FK_anexo_cita` (`id_cita`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`apunte`;
CREATE TABLE `gesclinica`.`apunte` (
  `id_apunte` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_asiento` INT(10) unsigned NOT NULL,
  `subcuenta_apunte` VARCHAR(45) NOT NULL,
  `contrapartida_apunte` VARCHAR(45) NULL,
  `concepto_apunte` VARCHAR(450) NOT NULL,
  `debe_apunte` FLOAT NOT NULL,
  `haber_apunte` FLOAT NOT NULL,
  `referencia_apunte` VARCHAR(45) NOT NULL,
  `numerofactura_apunte` INT(10) unsigned NOT NULL,
  `fecha_apunte` DATETIME NOT NULL,
  `punteado_apunte` BIT NOT NULL,
  `consolidado_apunte` BIT NOT NULL,
  PRIMARY KEY (`id_apunte`),
  INDEX `FK_apunte_asiento` (`id_asiento`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`asiento`;
CREATE TABLE `gesclinica`.`asiento` (
  `id_asiento` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `numero_asiento` INT(10) unsigned NOT NULL,
  `fecha_asiento` DATETIME NOT NULL,
  `observaciones_asiento` VARCHAR(450) NOT NULL,
  `id_ejercicio` INT(10) unsigned NOT NULL,
  `tipo_asiento` VARCHAR(45) NOT NULL,
  `numerofactura_asiento` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_asiento`),
  INDEX `FK_asiento_ejercicio` (`id_ejercicio`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`cita`;
CREATE TABLE `gesclinica`.`cita` (
  `id_cita` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_sala` INT(10) unsigned NULL,
  `id_terapia` INT(10) unsigned NULL,
  `id_paciente` INT(10) unsigned NOT NULL,
  `id_empleado` INT(10) unsigned NOT NULL,
  `fecha_cita` DATETIME NOT NULL,
  `id_estadocita` INT(10) unsigned NULL,
  `duracion_cita` INT(10) unsigned NOT NULL,
  `sintomas_cita` VARCHAR(8000) NOT NULL,
  `diagnostico_cita` VARCHAR(8000) NOT NULL,
  `tratamiento_cita` VARCHAR(8000) NOT NULL,
  `presencial_cita` BIT NOT NULL,
  `notas_cita` VARCHAR(450) NOT NULL,
  `programada_cita` BIT NOT NULL,
  `facturada_cita` BIT NOT NULL,
  PRIMARY KEY (`id_cita`),
  INDEX `FK_cita_sala` (`id_sala`),
  INDEX `FK_cita_terapia` (`id_terapia`),
  INDEX `FK_cita_estadocita` (`id_estadocita`),
  INDEX `FK_cita_empleado` (`id_empleado`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`componente`;
CREATE TABLE `gesclinica`.`componente` (
  `id_componente` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_componente` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_componente`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`configuracion`;
CREATE TABLE `gesclinica`.`configuracion` (
  `id_configuracion` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `parent_configuracion` INT(10) unsigned NULL,
  `class_configuracion` VARCHAR(450) NOT NULL,
  `keyvalue_configuracion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_configuracion`),
  INDEX `FK_configuracion_1` (`parent_configuracion`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`descuento`;
CREATE TABLE `gesclinica`.`descuento` (
  `id_paciente` INT(10) unsigned NOT NULL,
  `id_empleado` INT(10) unsigned NOT NULL,
  `discount_descuento` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_paciente`, `id_empleado`),
  INDEX `FK_descuento_empleado` (`id_empleado`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`documento`;
CREATE TABLE `gesclinica`.`documento` (
  `id_documento` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_documento` DATETIME NOT NULL,
  `titulo_documento` VARCHAR(45) NOT NULL,
  `descripcion_documento` VARCHAR(450) NOT NULL,
  `info_documento` LONGBLOB NOT NULL,
  `content_documento` LONGBLOB NOT NULL,
  `id_tipodocumento` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_documento`),
  INDEX `FK_documento_tipodocumento` (`id_tipodocumento`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`ejercicio`;
CREATE TABLE `gesclinica`.`ejercicio` (
  `id_ejercicio` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `fechaInicial_ejercicio` DATETIME NOT NULL,
  `fechaFinal_ejercicio` DATETIME NOT NULL,
  `ultimoAsiento_ejercicio` INT(10) unsigned NOT NULL,
  `descripcion_ejercicio` VARCHAR(45) NOT NULL,
  `ultimaFacturaEmitida_ejercicio` INT(10) unsigned NOT NULL,
  `ultimaFacturaRecibida_ejercicio` INT(10) unsigned NOT NULL,
  `id_empresa` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_ejercicio`),
  INDEX `FK_ejercicio_empresa` (`id_empresa`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`empleado`;
CREATE TABLE `gesclinica`.`empleado` (
  `id_empleado` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre_empleado` VARCHAR(45) NOT NULL,
  `apellido1_empleado` VARCHAR(45) NOT NULL,
  `apellido2_empleado` VARCHAR(45) NOT NULL,
  `administrativo_empleado` BIT NOT NULL,
  `terapeuta_empleado` BIT NOT NULL,
  `comision_empleado` INT(10) unsigned NOT NULL,
  `login_empleado` VARCHAR(45) NOT NULL,
  `activo_empleado` BIT NOT NULL,
  `gerente_empleado` BIT NOT NULL,
  `id_empresa` INT(10) unsigned NOT NULL,
  `firma_empleado` VARCHAR(45) NOT NULL,
  `versololomio_empleado` BIT NOT NULL,
  `color1_empleado` VARCHAR(45) NOT NULL,
  `color2_empleado` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_empleado`),
  INDEX `FK_empleado_empresa` (`id_empresa`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`empresa`;
CREATE TABLE `gesclinica`.`empresa` (
  `id_empresa` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `razonsocial_empresa` VARCHAR(450) NOT NULL,
  `facturaformato_empresa` VARCHAR(45) NOT NULL,
  `facturacliente_empresa` VARCHAR(450) NOT NULL,
  `facturaiva_empresa` INT(10) unsigned NOT NULL,
  `facturaconcepto_empresa` VARCHAR(450) NOT NULL,
  `cif_empresa` VARCHAR(45) NOT NULL,
  `direccion_empresa` VARCHAR(450) NOT NULL,
  `otrosdatos_empresa` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_empresa`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`estadocita`;
CREATE TABLE `gesclinica`.`estadocita` (
  `id_estadocita` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_estadocita` VARCHAR(45) NOT NULL,
  `color_estadocita` VARCHAR(45) NOT NULL,
  `generarecibo_estadocita` BIT NOT NULL,
  `avion_estadocita` BIT NOT NULL,
  PRIMARY KEY (`id_estadocita`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`estadocivil`;
CREATE TABLE `gesclinica`.`estadocivil` (
  `id_estadocivil` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_estadocivil` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_estadocivil`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`estadoevento`;
CREATE TABLE `gesclinica`.`estadoevento` (
  `id_estadoevento` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_estadoevento` VARCHAR(45) NOT NULL,
  `color_estadoevento` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_estadoevento`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`evento`;
CREATE TABLE `gesclinica`.`evento` (
  `id_evento` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_evento` VARCHAR(450) NOT NULL,
  `fecha_evento` DATETIME NOT NULL,
  `duracion_evento` INT(10) unsigned NOT NULL,
  `id_empleado` INT(10) unsigned NOT NULL,
  `publico_evento` BIT NOT NULL,
  `id_sala` INT(10) unsigned NULL,
  `id_estadoevento` INT(10) unsigned NULL,
  PRIMARY KEY (`id_evento`),
  INDEX `FK_evento_empleado` (`id_empleado`),
  INDEX `FK_evento_sala` (`id_sala`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`extpaciente`;
CREATE TABLE `gesclinica`.`extpaciente` (
  `id_extpaciente` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_paciente` INT(10) unsigned NOT NULL,
  `reglaDuracion_extpaciente` INT(10) unsigned NOT NULL,
  `reglaFrecuencia_extpaciente` INT(10) unsigned NOT NULL,
  `menarquia_extpaciente` INT(10) unsigned NOT NULL,
  `menopausia_extpaciente` INT(10) unsigned NOT NULL,
  `dispareunemia_extpaciente` VARCHAR(45) NOT NULL,
  `dismenorrea_extpaciente` VARCHAR(45) NOT NULL,
  `sindromepremenstrual_extpaciente` VARCHAR(45) NOT NULL,
  `molestiaspelvicas_extpaciente` VARCHAR(450) NOT NULL,
  `gestaciones_extpaciente` INT(10) unsigned NOT NULL,
  `abortos_extpaciente` INT(10) unsigned NOT NULL,
  `vivos_extpaciente` INT(10) unsigned NOT NULL,
  `partos_extpaciente` INT(10) unsigned NOT NULL,
  `cesareas_extpaciente` INT(10) unsigned NOT NULL,
  `hormonas_extpaciente` VARCHAR(450) NOT NULL,
  `anticonceptivos_extpaciente` VARCHAR(45) NOT NULL,
  `observaciones_extpaciente` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_extpaciente`),
  INDEX `FK_extpaciente_paciente` (`id_paciente`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`factura`;
CREATE TABLE `gesclinica`.`factura` (
  `id_factura` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_factura` DATETIME NOT NULL,
  `id_operacion` INT(10) unsigned NOT NULL,
  `numero_factura` INT(10) unsigned NOT NULL,
  `serie_factura` VARCHAR(45) NOT NULL,
  `observaciones_factura` VARCHAR(450) NOT NULL,
  `iva_factura` INT(10) unsigned NOT NULL,
  `descuento_factura` INT(10) unsigned NOT NULL,
  `importe_factura` FLOAT NOT NULL,
  `concepto_factura` VARCHAR(450) NOT NULL,
  `cliente_factura` VARCHAR(450) NOT NULL,
  `contabilizada_factura` BIT NOT NULL,
  PRIMARY KEY (`id_factura`),
  INDEX `FK_factura_operacion` (`id_operacion`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`festivo`;
CREATE TABLE `gesclinica`.`festivo` (
  `id_festivo` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_festivo` DATETIME NOT NULL,
  `id_tipofestivo` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_festivo`),
  INDEX `FK_festivo_tipofestivo` (`id_tipofestivo`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`formapago`;
CREATE TABLE `gesclinica`.`formapago` (
  `id_formapago` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_formapago` VARCHAR(45) NOT NULL,
  `facturar_formapago` BIT NOT NULL,
  PRIMARY KEY (`id_formapago`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`indicacion`;
CREATE TABLE `gesclinica`.`indicacion` (
  `id_indicacion` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_indicacion` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_indicacion`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`laboratorio`;
CREATE TABLE `gesclinica`.`laboratorio` (
  `id_laboratorio` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre_laboratorio` VARCHAR(45) NOT NULL,
  `direccion_laboratorio` VARCHAR(45) NOT NULL,
  `localidad_laboratorio` VARCHAR(45) NOT NULL,
  `cp_laboratorio` VARCHAR(45) NOT NULL,
  `provincia_laboratorio` VARCHAR(45) NOT NULL,
  `telefono1_laboratorio` VARCHAR(45) NOT NULL,
  `telefono2_laboratorio` VARCHAR(45) NOT NULL,
  `telefono3_laboratorio` VARCHAR(45) NOT NULL,
  `fax_laboratorio` VARCHAR(45) NOT NULL,
  `mail_laboratorio` VARCHAR(45) NOT NULL,
  `web_laboratorio` VARCHAR(45) NOT NULL,
  `observaciones_laboratorio` VARCHAR(450) NOT NULL,
  `visitadornombre_laboratorio` VARCHAR(45) NOT NULL,
  `visitadorapellido1_laboratorio` VARCHAR(45) NOT NULL,
  `visitadorapellido2_laboratorio` VARCHAR(45) NOT NULL,
  `visitadortelefono1_laboratorio` VARCHAR(45) NOT NULL,
  `visitadortelefono2_laboratorio` VARCHAR(45) NOT NULL,
  `visitadortelefono3_laboratorio` VARCHAR(45) NOT NULL,
  `visitadorfax_laboratorio` VARCHAR(45) NOT NULL,
  `visitadormail_laboratorio` VARCHAR(45) NOT NULL,
  `visitadorobservaciones_laboratorio` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_laboratorio`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`operacion`;
CREATE TABLE `gesclinica`.`operacion` (
  `id_operacion` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_cita` INT(10) unsigned NULL,
  `tipo_operacion` VARCHAR(45) NULL,
  `fecha_operacion` DATETIME NOT NULL,
  `debe_operacion` FLOAT NOT NULL,
  `haber_operacion` FLOAT NOT NULL,
  `facturado_operacion` BIT NOT NULL,
  `facturaAntigua_operacion` VARCHAR(45) NOT NULL,
  `id_empleado` INT(10) unsigned NULL,
  `observaciones_operacion` VARCHAR(450) NOT NULL,
  `id_paciente` INT(10) unsigned NULL,
  PRIMARY KEY (`id_operacion`),
  INDEX `FK_operacion_cita` (`id_cita`),
  INDEX `FK_operacion_empleado` (`id_empleado`),
  INDEX `FK_operacion_paciente` (`id_paciente`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`paciente`;
CREATE TABLE `gesclinica`.`paciente` (
  `id_paciente` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre_paciente` VARCHAR(45) NULL,
  `apellido1_paciente` VARCHAR(45) NULL,
  `apellido2_paciente` VARCHAR(45) NULL,
  `id_estadocivil` INT(10) unsigned NULL,
  `id_tarifa` INT(10) unsigned NULL,
  `mujer_paciente` BIT NULL,
  `direccion_paciente` VARCHAR(45) NULL,
  `localidad_paciente` VARCHAR(45) NULL,
  `cp_paciente` VARCHAR(45) NULL,
  `telefono1_paciente` VARCHAR(45) NULL,
  `telefono2_paciente` VARCHAR(45) NULL,
  `telefono3_paciente` VARCHAR(45) NULL,
  `fechaNacimiento_paciente` DATETIME NULL,
  `nif_paciente` VARCHAR(45) NULL,
  `hijos_paciente` INT(10) unsigned NULL,
  `profesion_paciente` VARCHAR(45) NULL,
  `provincia_paciente` VARCHAR(45) NULL,
  `fechaAlta_paciente` DATETIME NULL,
  `observaciones_paciente` VARCHAR(4500) NULL,
  `foto_paciente` LONGBLOB NULL,
  `recomendadopor_paciente` VARCHAR(45) NULL,
  `muyimportante_paciente` VARCHAR(4500) NULL,
  `codigo_subcuenta` VARCHAR(45) NOT NULL,
  `notasagenda_paciente` VARCHAR(4500) NOT NULL,
  PRIMARY KEY (`id_paciente`),
  INDEX `FK_paciente_estadocivil` (`id_estadocivil`),
  INDEX `FK_paciente_tarifa` (`id_tarifa`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`pago`;
CREATE TABLE `gesclinica`.`pago` (
  `id_pago` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_operacion` INT(10) unsigned NOT NULL,
  `fecha_pago` DATETIME NOT NULL,
  `importe_pago` FLOAT NOT NULL,
  `id_formapago` INT(10) unsigned NOT NULL,
  `observaciones_pago` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_pago`),
  INDEX `FK_pago_formapago` (`id_formapago`),
  INDEX `FK_pago_operacion` (`id_operacion`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`producto`;
CREATE TABLE `gesclinica`.`producto` (
  `id_producto` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_producto` VARCHAR(450) NOT NULL,
  `id_laboratorio` INT(10) unsigned NOT NULL,
  `posologia_producto` VARCHAR(450) NOT NULL,
  `documento_producto` VARCHAR(8000) NOT NULL,
  `activo_producto` BIT NOT NULL,
  `precio_producto` FLOAT NOT NULL,
  `unidades_producto` INT(10) unsigned NOT NULL,
  `id_tipounidad` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_producto`),
  INDEX `FK_producto_laboratorio` (`id_laboratorio`),
  INDEX `FK_producto_tipounidad` (`id_tipounidad`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`productodetalle`;
CREATE TABLE `gesclinica`.`productodetalle` (
  `id_producto` INT(10) unsigned NOT NULL,
  `id_componente` INT(10) unsigned NOT NULL,
  `dosis_productodetalle` VARCHAR(45) NOT NULL,
  `id_productodetalle` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_productodetalle`),
  INDEX `FK_productodetalle_producto` (`id_producto`),
  INDEX `FK_productodetalle_componente` (`id_componente`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`r_empleado_terapia`;
CREATE TABLE `gesclinica`.`r_empleado_terapia` (
  `id_empleado` INT(10) unsigned zerofill NOT NULL,
  `id_terapia` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_terapia`, `id_empleado`),
  INDEX `FK_r_empleado_terapia_empleado` (`id_empleado`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`r_producto_contraindicacion`;
CREATE TABLE `gesclinica`.`r_producto_contraindicacion` (
  `id_producto` INT(10) unsigned NOT NULL,
  `id_indicacion` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_producto`, `id_indicacion`),
  INDEX `FK_r_producto_contraindicacion_` (`id_indicacion`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`r_producto_indicacion`;
CREATE TABLE `gesclinica`.`r_producto_indicacion` (
  `id_producto` INT(10) unsigned NOT NULL,
  `id_indicacion` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_producto`, `id_indicacion`),
  INDEX `FK_r_producto_indicacion_indica` (`id_indicacion`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`receta`;
CREATE TABLE `gesclinica`.`receta` (
  `id_receta` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_cita` VARCHAR(45) NOT NULL,
  `observaciones_receta` VARCHAR(16000) NOT NULL,
  PRIMARY KEY (`id_receta`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`recetadetalle`;
CREATE TABLE `gesclinica`.`recetadetalle` (
  `id_recetadetalle` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_receta` INT(10) unsigned NOT NULL,
  `id_producto` INT(10) unsigned NOT NULL,
  `posologia_recetadetalle` VARCHAR(450) NOT NULL,
  `cantidad_recetadetalle` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_recetadetalle`),
  INDEX `FK_recetadetalle_receta` (`id_receta`),
  INDEX `FK_recetadetalle_producto` (`id_producto`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`relacion`;
CREATE TABLE `gesclinica`.`relacion` (
  `id_relacion` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `nuevo_relacion` VARCHAR(45) NULL,
  `antiguo_relacion` VARCHAR(45) NULL,
  `tipo_relacion` VARCHAR(450) NULL,
  PRIMARY KEY (`id_relacion`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`sala`;
CREATE TABLE `gesclinica`.`sala` (
  `id_sala` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_sala` VARCHAR(45) NOT NULL,
  `activo_sala` BIT NOT NULL,
  `color_sala` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_sala`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`sintoma`;
CREATE TABLE `gesclinica`.`sintoma` (
  `id_sintoma` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_sintoma` VARCHAR(450) NOT NULL,
  `id_tiposintoma` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_sintoma`),
  INDEX `FK_sintoma_tiposintoma` (`id_tiposintoma`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`subcuenta`;
CREATE TABLE `gesclinica`.`subcuenta` (
  `codigo_subcuenta` VARCHAR(45) NOT NULL,
  `descripcion_subcuenta` VARCHAR(450) NOT NULL,
  `haber_subcuenta` BIT NOT NULL,
  `bloqueada_subcuenta` BIT NOT NULL,
  `contrapartida_subcuenta` VARCHAR(45) NULL,
  PRIMARY KEY (`codigo_subcuenta`),
  INDEX `FK_subcuenta_subcuenta` (`contrapartida_subcuenta`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tabla`;
CREATE TABLE `gesclinica`.`tabla` (
  `id_tabla` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_tabla` VARCHAR(45) NULL,
  PRIMARY KEY (`id_tabla`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tarifa`;
CREATE TABLE `gesclinica`.`tarifa` (
  `id_tarifa` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_tarifa` VARCHAR(45) NOT NULL,
  `descuento_tarifa` INT(10) unsigned NOT NULL,
  `activo_tarifa` BIT NOT NULL,
  PRIMARY KEY (`id_tarifa`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`terapia`;
CREATE TABLE `gesclinica`.`terapia` (
  `id_terapia` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_terapia` VARCHAR(45) NOT NULL,
  `precio_terapia` FLOAT NOT NULL,
  `duracion_terapia` INT(10) unsigned NOT NULL,
  `activo_terapia` BIT NOT NULL,
  `codigo_subcuenta` VARCHAR(45) NULL,
  `id_tipoterapia` INT(10) unsigned NOT NULL,
  PRIMARY KEY (`id_terapia`),
  INDEX `FK_terapia_subcuenta` (`codigo_subcuenta`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tercero`;
CREATE TABLE `gesclinica`.`tercero` (
  `id_tercero` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `nif_tercero` VARCHAR(45) NOT NULL,
  `codigo_subcuenta` VARCHAR(45) NOT NULL,
  `nombre_tercero` VARCHAR(450) NOT NULL,
  `sigla_tercero` VARCHAR(45) NOT NULL,
  `domicilio_tercero` VARCHAR(450) NOT NULL,
  `numero_tercero` VARCHAR(45) NOT NULL,
  `escalera_tercero` VARCHAR(45) NOT NULL,
  `piso_tercero` VARCHAR(45) NOT NULL,
  `puerta_tercero` VARCHAR(45) NOT NULL,
  `poblacion_tercero` VARCHAR(45) NOT NULL,
  `provincia_tercero` VARCHAR(45) NOT NULL,
  `cp_tercero` VARCHAR(45) NOT NULL,
  `telefono1_tercero` VARCHAR(45) NOT NULL,
  `telefono2_tercero` VARCHAR(45) NOT NULL,
  `fax1_tercero` VARCHAR(45) NOT NULL,
  `fax2_tercero` VARCHAR(45) NOT NULL,
  `persona_tercero` VARCHAR(45) NOT NULL,
  `actividad_tercero` VARCHAR(45) NOT NULL,
  `nacionalidad_tercero` VARCHAR(45) NOT NULL,
  `recargo_tercero` BIT NOT NULL,
  `fechaAlta_tercero` DATETIME NOT NULL,
  `formaPago_tercero` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id_tercero`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tipodocumento`;
CREATE TABLE `gesclinica`.`tipodocumento` (
  `id_tipodocumento` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_tipodocumento` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_tipodocumento`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tipofestivo`;
CREATE TABLE `gesclinica`.`tipofestivo` (
  `id_tipofestivo` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `color_tipofestivo` VARCHAR(45) NOT NULL,
  `descripcion_tipofestivo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_tipofestivo`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tipooperacion`;
CREATE TABLE `gesclinica`.`tipooperacion` (
  `id_tipooperacion` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_tipooperacion` VARCHAR(45) NOT NULL,
  `facturable_tipooperacion` BIT NOT NULL,
  PRIMARY KEY (`id_tipooperacion`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tiposintoma`;
CREATE TABLE `gesclinica`.`tiposintoma` (
  `id_tiposintoma` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_tiposintoma` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_tiposintoma`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tipoterapia`;
CREATE TABLE `gesclinica`.`tipoterapia` (
  `id_tipoterapia` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_tipoterapia` VARCHAR(45) NOT NULL,
  `cobrable_tipoterapia` BIT NOT NULL,
  `codigo_tipoterapia` VARCHAR(45) NOT NULL,
  `color_tipoterapia` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_tipoterapia`)
)
ENGINE = INNODB;

DROP TABLE IF EXISTS `gesclinica`.`tipounidad`;
CREATE TABLE `gesclinica`.`tipounidad` (
  `id_tipounidad` INT(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion_tipounidad` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_tipounidad`)
)
ENGINE = INNODB;



-- -------------------------------------
-- Routines

DROP PROCEDURE IF EXISTS `gesclinica`.`sp_doGetAllAmortizaciones`;
CREATE DEFINER=`gesclinica`@`%` PROCEDURE `sp_doGetAllAmortizaciones`(id_ejercicio INTEGER)
BEGIN
        SELECT ap.*
FROM apunte ap
LEFT JOIN asiento asi ON ap.id_asiento = asi.id_asiento
WHERE 
(((ap.subcuenta_apunte) Like '68%')
AND
((asi.id_ejercicio)=id_ejercicio))

ORDER BY ap.fecha_apunte, asi.numero_asiento, ap.numerofactura_apunte;

END

DROP PROCEDURE IF EXISTS `gesclinica`.`sp_doGetAllFacturasEmitidas`;
CREATE DEFINER=`gesclinica`@`%` PROCEDURE `sp_doGetAllFacturasEmitidas`(id_ejercicio INTEGER)
BEGIN
    SELECT ap.*
FROM apunte ap
LEFT JOIN asiento asi ON ap.id_asiento = asi.id_asiento
WHERE
(((ap.subcuenta_apunte) Like '705%' Or (ap.subcuenta_apunte) Like '759%' Or (ap.subcuenta_apunte) Like '778%')
AND
((ap.contrapartida_apunte) Like '43%') AND ((asi.id_ejercicio)=id_ejercicio))
OR
(((asi.id_ejercicio)=id_ejercicio) AND (asi.tipo_asiento='FACTURA_EMITIDA') AND ((ap.subcuenta_apunte) Like '705%' Or (ap.subcuenta_apunte) Like '759%' Or (ap.subcuenta_apunte) Like '778%') )
ORDER BY ap.fecha_apunte, asi.numero_asiento, ap.numerofactura_apunte;

END

DROP PROCEDURE IF EXISTS `gesclinica`.`sp_doGetAllFacturasRecibidas`;
CREATE DEFINER=`gesclinica`@`%` PROCEDURE `sp_doGetAllFacturasRecibidas`(id_ejercicio INTEGER)
BEGIN
   SELECT ap.*
FROM apunte ap
LEFT JOIN asiento asi ON ap.id_asiento = asi.id_asiento
WHERE
(((ap.subcuenta_apunte) Like '6%')
AND
((ap.subcuenta_apunte) not Like '68%')
AND
((ap.debe_apunte) Is Not Null) 
AND
((asi.id_ejercicio)=id_ejercicio))

ORDER BY ap.fecha_apunte, asi.numero_asiento, ap.numerofactura_apunte;


END



SET FOREIGN_KEY_CHECKS = 1;

-- ----------------------------------------------------------------------
-- EOF


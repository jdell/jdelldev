
-- Descripcion = ALTER TABLE `typeofmembership`
/* Para deshacer los cambios
ALTER TABLE `typeofmembership` CHANGE `individualprice_typeofmembership` `price_typeofmembership` FLOAT NOT NULL DEFAULT '0'
 */
ALTER TABLE `typeofmembership` CHANGE `price_typeofmembership` `individualprice_typeofmembership` FLOAT NOT NULL DEFAULT '0'
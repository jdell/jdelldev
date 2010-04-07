
-- Descripcion = Modificamos la tabla AccountRecord
/* Para deshacer los cambios

  alter table accountrecord drop column id_activity
 */

  alter table accountrecord add column id_activity integer not null;


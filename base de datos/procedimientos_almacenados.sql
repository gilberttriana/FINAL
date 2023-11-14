use biblioteca;
/* Procedimientos para Autor */

delimiter //
DROP PROCEDURE if exists insertar_autor //
create procedure insertar_autor(in codigo bigint(20),in nombre varchar(50), in 
	pais bigint(20))
	begin
		if codigo=0 then
			insert into autor values(null, nombre, pais);
		else
			update autor set nombre_autor = nombre, cod_pais = pais where 
			cod_autor = codigo;
		end if;
end //
 use bibliotecario;
 delimiter //
DROP PROCEDURE if exists seleccionar_autores //
create procedure seleccionar_autores()
begin
	select a.cod_autor as Codigo, a.nombre_autor as Autor, b.nombre_pais as Pais 
    from autor a inner join pais b on a.cod_pais = b.cod_pais order by 
	a.nombre_autor;
end //
delimiter ;

delimiter //
DROP PROCEDURE if exists seleccionar_paises //
create procedure seleccionar_paises()
begin
	select * from pais order by nombre_pais;
end //

delimiter ;

delimiter //
DROP PROCEDURE if exists ver_autor //
create procedure ver_autor(in autor bigint(20))
begin
	select * from autor where cod_autor=autor;
end//

delimiter ;
delimiter //
DROP PROCEDURE if exists borrar_autor //
create procedure borrar_autor(in autor bigint(20))
begin
	delete from autor where cod_autor=autor ;
end //
Delimiter ;

/* Procedimientos para Editorial */

delimiter //
DROP PROCEDURE if exists insertar_editorial //
create procedure insertar_editorial(in codigo bigint(20),in nombre varchar(50), in 
	pais bigint(20))
	begin
		if codigo=0 then
			insert into editorial values(null, nombre, pais);
		else
			update editorial set nombre_editorial = nombre, cod_pais = pais where 
			cod_editorial = codigo;
		end if;
end //

delimiter //
DROP PROCEDURE if exists seleccionar_editorial //
create procedure seleccionar_editorial()
begin
	select a.cod_editorial as codigo, a.nombre_editorial as Editorial, b.nombre_pais as 
	Pais from editorial a inner join pais b on a.cod_pais = b.cod_pais order by 
	a.nombre_editorial;
end //
delimiter ;

delimiter //
DROP PROCEDURE if exists seleccionar_paises_editorial //
create procedure seleccionar_paises_editorial()
begin
	select * from pais order by nombre_pais;
end //

delimiter ;

delimiter //
DROP PROCEDURE if exists ver_editorial //
create procedure ver_editorial(in editorial bigint(20))
begin
	select * from editorial where cod_editorial = editorial;
end//
 delimiter ;
 
 delimiter //
DROP PROCEDURE if exists borrar_editorial //
create procedure borrar_editorial(in editorial bigint(20))
begin
	delete from editorial where cod_editorial = editorial ;
end //
Delimiter ;


/* Procedimientos para Libros */
use biblioteca;
drop procedure if exists insertar_libro;
drop procedure if exists insertar_libro;
delimiter //
create procedure insertar_libro(in cod_libro bigint, in titulo varchar(50), in cod_editorial bigint, in fecha_pub date,in ejemplares int,in n_pag int, in idioma varchar(25),in edicion int)
begin
if codigo=0 then
	insert into libro values(cod_libro,titulo,cod_editorial,fecha_pub,ejemplares,n_pag,idioma,edicion);
else
	update libro set cod_libro=cod_libro, titulo=titulo, cod_editorial=cod_editorial, fecha_pub=fecha_pub,ejemplares=ejemplares.n_pag=n_pag,idioma=idioma,edicion=edicion where 
	cod_libro=codigo;
end if;
end//
delimiter ;

drop procedure if exists seleccionar_libro;
delimiter //
create procedure seleccionar_libro()
begin
select cod_libro,titulo,cod_editorial,fecha_pub,ejemplares,n_pag,idioma,edicion 
from libro order by cod_libro;
end//
delimiter ;

drop procedure if exists ver_libro;
delimiter //
create procedure ver_libro(in libro bigint)
begin
select * from libro where cod_libro=libro;
end//
delimiter ;

drop procedure if exists borrar_libro;
delimiter //
create procedure borrar_libro(in libro bigint)
begin
delete from libro where cod_libro=libro;
end//
delimiter ;

/* Procedimientos para Usuarios */
DROP PROCEDURE if exists insertar_usuario;
delimiter //
create procedure insertar_usuario(in codigo bigint(20), in Nombres varchar(50), 
	in Apellidos varchar(50), in tel varchar(8), in dir varchar(100), in Fecha_nac date,
    in sex varchar(1), in Estado_civil varchar(1), in Centro_estudio varchar(50))
	begin
		if codigo=0 then
			insert into usuario values(null, Nombres, Apellidos, tel, dir, Fecha_nac, sex, Estado_civil, Centro_estudio);
		else
			update usuario 
            set nombres = Nombres, 
				apellidos = Apellidos,
                telefono = tel,
                direccion = dir,
                fecha_nac = Fecha_nac,
                sexo = sex,
                estado_civil = Estado_civil,
                centro_estudio = Centro_estudio
			where 
			cod_ident = codigo;
		end if;
end //

DROP PROCEDURE if exists seleccionar_usuarios//
create procedure seleccionar_usuarios()
begin
	select cod_ident as Codigo, nombres as Nombres, apellidos as Apellidos, telefono as Teléfono, direccion as Dirección, 
		   fecha_nac as 'Fecha Nac', sexo as Sexo, estado_civil as 'Estado civ', centro_estudio as 'Centro Estudio' 
	from usuario 
	order by 
	nombres;
end //

DROP PROCEDURE if exists ver_usuario//
create procedure ver_usuario(in codigo_usuario bigint(20))
begin
	select * from usuario where cod_ident = codigo_usuario;
end//

DROP PROCEDURE if exists borrar_usuario//
create procedure borrar_usuario(in codigo_usuario bigint(20))
begin
	delete from usuario where cod_ident = codigo_usuario;
end //
Delimiter ;

-- Procedimientos para el bibliotecario

drop procedure if exists insertar_bibliotecario;
delimiter //
create procedure insertar_bibliotecario(in codigo bigint,in nombre varchar(50), in apellidos varchar(50),
in direccion varchar(50),in cargo varchar(50))
begin
if codigo=0 then
	insert into bibliotecario values(null,nombre, apellidos, direccion, cargo);
else
	update bibliotecario set nombres=nombre, apellidos=apellidos, direccion=direccion, cargo=cargo where 
	cod_bibliotecario=codigo;
end if;
end//
delimiter ;

drop procedure if exists seleccionar_bibliotecario;
delimiter //
create procedure seleccionar_bibliotecario()
begin
select cod_bibliotecario as codigo, nombres, apellidos, direccion, cargo
from bibliotecario order by nombres;
end//
delimiter ;
delimiter //
drop procedure if exists actualizar_bibliotecario//
create procedure actualizar_bibliotecario(in codigo bigint(20), in n varchar(50), in a varchar(50), in d varchar(100), in c varchar(50))
begin
	update bibliotecario set nombres = n, apellidos = a, direccion = d, cargo = c where cod_bibliotecario = codigo;
end
//
delimiter ;
drop procedure if exists ver_bibliotecario;
delimiter //
create procedure ver_bibliotecario(in bibliotecario bigint)
begin
select * from bibliotecario where cod_bibliotecario = bibliotecario;
end//
delimiter ;
drop procedure if exists borrar_bibliotecario;

delimiter //
create procedure borrar_bibliotecario(in bibliotecario bigint)
begin
delete from bibliotecario where cod_bibliotecario = bibliotecario;
end//
Delimiter ;


-- --------------- LOGIN ---------------------------------------
delimiter //
drop procedure if exists consultar_login//
create procedure consultar_login(in pusuario varchar(20),in pclave
varchar(100))
begin
select * from login where usuario=pusuario and clave=md5(pclave);
end
//
insert into login value(null,"Admin",md5("1234"));
-- ------------------- REPORTES -----------------------------------
/*  Libros por pais */

Delimiter //
DROP PROCEDURE if exists libros_por_pais//
CREATE PROCEDURE libros_por_pais(in country varchar(100))
begin
	SELECT l.titulo, e.nombre_editorial, p.nombre_pais from libro l 
    INNER JOIN editorial e on l.cod_editorial = e.cod_editorial
    INNER JOIN pais p on e.cod_pais = p.cod_pais
    WHERE p.nombre_pais like concat("%", country, "%");
end //
DELIMITER ;

/* Préstamos realizados en un rango de fecha  */
Delimiter //
DROP PROCEDURE if exists cantidad_prestamos//
CREATE PROCEDURE cantidad_prestamos(in primera_fecha date, in segunda_fecha date)
begin	
	SELECT COUNT(*) as 'Prestamos' FROM prestamo
	where fecha_ent between primera_fecha and segunda_fecha 
    and entregado = 'no';
end //
DELIMITER ;

/* Préstamos vencidos  */
Delimiter //
DROP PROCEDURE if exists prestamos_vencidos//
CREATE PROCEDURE prestamos_vencidos()
begin	
	SELECT l.cod_libro as Codigo, l.titulo as Titulo, p.fecha_ent as 'Fecha Entrega', 
    concat('VENCIDO') as Estado
	FROM prestamo p 
	INNER JOIN libro l on p.cod_libro = l.cod_libro
	WHERE p.fecha_ent < curdate() AND entregado = 'no';
end //
DELIMITER ;

/* Usuarios con multa  */
Delimiter //
DROP PROCEDURE if exists usuarios_con_multa//
CREATE PROCEDURE usuarios_con_multa()
begin	
	SELECT u.nombres as Nombres, u.apellidos as Apellidos, u.centro_estudio as 'Centro estudio',
	p.multa as Multa
	from usuario u 
	INNER JOIN  prestamo p on u.cod_ident = p.cod_ident
	WHERE p.multa > 0;
end //
DELIMITER ;

delimiter //
drop procedure if exists consultar_libroXeditorial//
create procedure consultar_libroXeditorial(in e varchar(50))
begin
	select l.titulo, l.ejemplares, a.nombre_editorial, p.nombre_autor
    from libro l inner join editorial a on a.cod_editorial = l.cod_editorial
		inner join autor p on p.cod_autor = l.cod_autor 
    where a.nombre_editorial like concat(e,'%');
end
//

delimiter ;

/*prestamos*/
delimiter //
drop procedure if exists hacer_prestamo//
CREATE PROCEDURE hacer_prestamo(
  IN cl BIGINT,
  IN fp VARCHAR(45),
  IN fe VARCHAR(45),
  IN ci BIGINT,
  IN tp VARCHAR(10),
  IN cb BIGINT,
  IN e VARCHAR(2),
  IN m FLOAT
)
BEGIN
  DECLARE EXIT HANDLER FOR SQLEXCEPTION
  BEGIN
    -- En caso de error, hacer un rollback
    ROLLBACK;
  END;

  -- Iniciar la transacción
  START TRANSACTION;

  -- Realizar operaciones dentro de la transacción
  INSERT INTO prestamo VALUES (NULL, cl, fp, fe, ci, tp, cb, e, m);

  -- Decrementar las existencias
  UPDATE libro SET ejemplares = ejemplares - 1 where cod_libro = cl;

  -- Si todo está bien, confirmar la transacción
  COMMIT;
END //
delimiter ;

delimiter //
drop procedure if exists actualizar_prestamo//
create procedure actualizar_prestamo(in codigo bigint(20), in cl bigint(20))
begin
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
  BEGIN
    -- En caso de error, hacer un rollback
    ROLLBACK;
  END;

  -- Iniciar la transacción
  START TRANSACTION;

  -- Realizar operaciones dentro de la transacción
  update prestamo set entregado = 'Si' where cod_prestamo = codigo;

  -- Decrementar las existencias
  UPDATE libro SET ejemplares = ejemplares + 1 where cod_libro = cl;

  -- Si todo está bien, confirmar la transacción
  COMMIT;
end
//

/*multas*/


/* stock*/
drop procedure if exists ver_stock//
create procedure ver_stock()
begin
	SELECT
    l.titulo AS Titulo_libro,
    l.ejemplares AS Ejemplares_libro,
    e.nombre_editorial AS Nombre_editorial,
    COUNT(p.cod_prestamo) AS prestamos,
    SUM(CASE WHEN p.entregado = 'Si' THEN 1 ELSE 0 END) AS Entregado,
    SUM(CASE WHEN p.entregado = 'No' THEN 1 ELSE 0 END) AS Pendiente
	FROM libro l
	LEFT JOIN editorial e ON l.cod_editorial = e.cod_editorial
	LEFT JOIN prestamo p ON l.cod_libro = p.cod_libro
	GROUP BY l.titulo, l.ejemplares, e.nombre_editorial;
end
//
-- procedimientos para la inserccion de prestamos

drop procedure if exists insertar_prestamo;
delimiter //
create procedure insertar_prestamo(in codigo bigint,in cod_libro bigint, in fecha_pres date, in fecha_ent date,
in cod_id bigint, in tipo varchar(50), in cod_bib bigint, in entregado varchar(50), in multa float)
begin
if codigo=0 then
	insert into prestamo values(null,cod_libro, fecha_pres, fecha_ent, cod_id, tipo, cod_bib, entregado, multa);
else
	update prestamo set cod_libro=cod_libro, fecha_pres=fecha_pres, fecha_ent=fecha_ent, code_ident=cod_id, 
    tipo_prestamo=tipo, cod_bibliotecario=cod_lib, entregado=entregado, multa=multa
    where cod_bibliotecario=codigo;
end if;
end//


delimiter ;

drop procedure if exists seleccionar_prestamo;
delimiter //
create procedure seleccionar_prestamo()
begin
select p.cod_prestamo as codigo, p.cod_libro as codigo_libro, l.titulo as Titulo, p.fecha_pres, p.fecha_ent, p.cod_ident as codigo_usuario, u.nombres as nombre_usuario,
p.tipo_prestamo, p.cod_bibliotecario, b.nombres as bibliotecario, p.entregado, p.multa
from prestamo p inner join libro l on p.cod_libro = l.cod_libro
inner join usuario u on p.cod_ident = u.cod_ident  
inner join bibliotecario b on p.cod_bibliotecario = b.cod_bibliotecario order by p.cod_prestamo;
end//

delimiter //
create procedure ver_prestamo(in prestamo bigint)
begin
select * from prestamo where cod_prestamo = prestamo;
end//

delimiter //
create procedure borrar_prestamo(in prestamo bigint)
begin
delete from prestamo where cod_prestamo = prestamo;
end//
Delimiter ;


drop procedure if exists prestamoRfechas;
delimiter //
create procedure prestamoRfechas(in date1 date , in date2 date )
begin
	SELECT p.cod_prestamo, l.titulo as Libro, p.fecha_pres, p.fecha_ent, u.nombres as Usuario,
		p.tipo_prestamo, b.nombres as Bibliotecario, p.entregado, p.multa
    FROM prestamo p inner join libro l on p.cod_libro = l.cod_libro
		inner join usuario u on p.cod_ident = u.cod_ident
		inner join bibliotecario b on p.cod_bibliotecario = b.cod_bibliotecario
    WHERE fecha_pres >= date1 AND fecha_ent <= date2;
end
//
delimiter ;


/* otros */



DELIMITER //
CREATE PROCEDURE librostitulos(in filtro varchar(50))
begin
select titulo from libro where titulo=filtro;
end//
delimiter ;

DELIMITER //
CREATE PROCEDURE AutoresporNombre(in filtro varchar(50))
begin
select nombre_autor from autor where nombre_autor=filtro ;
end//
delimiter ; 

DELIMITER //
CREATE PROCEDURE editorialPorNombre(in filtro varchar(50))
begin
select nombre_editorial from editorial where nombre_editorial = filtro;
end//
delimiter ;  

drop procedure if exists idiomalibro; 
DELIMITER //
CREATE PROCEDURE idiomaLibro(in filtro varchar(25))
begin
select idioma from libro where idioma = filtro;
end//
delimiter ;  
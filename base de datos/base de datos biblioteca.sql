
drop database if exists biblioteca;
create database biblioteca;
use biblioteca;

create table pais(
cod_pais bigint(20) not null auto_increment,
nombre_pais varchar(100),
constraint paispk primary key(cod_pais)
);


create table autor(
cod_autor bigint(20) not null auto_increment,
nombre_autor varchar(50),
cod_pais bigint(20),
constraint autorpk primary key(cod_autor),
constraint autorfk foreign key(cod_pais) references pais(cod_pais) on
update cascade on delete cascade
);


create table editorial(
cod_editorial bigint(20) not null auto_increment,
nombre_editorial varchar(50),
cod_pais bigint(20),
constraint editorialpk primary key(cod_editorial),
constraint editorialfk foreign key(cod_pais) references pais(cod_pais) on
update cascade on delete cascade
);


create table usuario(
cod_ident bigint(20) not null auto_increment,
nombres varchar(50),
apellidos varchar(50),
telefono varchar(8),
direccion varchar(100),
fecha_nac date,
sexo varchar(1),
estado_civil varchar(1),
centro_estudio varchar(50),
constraint usuariopk primary key(cod_ident)
);

alter table libro drop column cod_autor;
create table libro(
cod_libro bigint(20) not null auto_increment,
titulo varchar(50),
cod_editorial bigint(20),
fecha_pub date,
ejemplares int,
n_pag int,
idioma varchar(25),
edicion int,
cod_autor bigint(20),
constraint libropk primary key(cod_libro),
constraint librofk foreign key(cod_editorial) references
editorial(cod_editorial) on update cascade on delete cascade
);


create table relacion_libro_autor(
cod_libro bigint(20),
cod_autor bigint(20),
constraint relacionfk1 foreign key(cod_libro) references libro(cod_libro)
on
update cascade on delete cascade, constraint relacionfk2 foreign
key(cod_autor)
references autor(cod_autor) on update cascade on delete cascade
);


create table bibliotecario(
cod_bibliotecario bigint(20) not null auto_increment,
nombres varchar(50),
apellidos varchar(50),
direccion varchar(100),
cargo varchar(50),constraint bibliotecariopk primary
key(cod_bibliotecario)
);


create table prestamo(
cod_prestamo bigint(20) not null auto_increment,
cod_libro bigint(20),
fecha_pres date,
fecha_ent date,
cod_ident bigint(20),
tipo_prestamo varchar(10),
cod_bibliotecario bigint(20),
entregado varchar(2),
multa float,
constraint prestamopk primary key(cod_prestamo),
constraint prestamofk1 foreign key(cod_libro) references
libro(cod_libro) on
update cascade on delete cascade, constraint prestamofk2 foreign
key(cod_ident)
references usuario(cod_ident) on update cascade on delete
cascade,constraint
prestamofk3 foreign key(cod_bibliotecario) references
bibliotecario(cod_bibliotecario) on update cascade on delete cascade
);

create table login(
id int auto_increment not null,
usuario varchar(20),
clave varchar(100),
constraint loginpk primary key(id)
);



insert into login value(null,"Admin",md5("1234"));

insert into pais values(null,'NICARAGUA');
insert into pais values(null,'EL SALVADOR');
insert into pais values(null,'COSTA RICA');
use biblioteca;
select * from libro;
drop database Tienda
go
create database Tienda
go
use Tienda
go
create schema factura
go

create table factura.cliente (
	idCliente int primary key not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50),
)



create table factura.producto(
	idProducto int primary key not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
)


create table factura.Venta(
	idVenta int primary key not null,
	fechaVenta date,
	precio int,
	cantidad int,
	idCliente int foreign key references factura.cliente(idCliente),
	idProducto int foreign key references factura.producto(idProducto)

	
)
----------------procedimiento alamacenado

-----------------consultar---buscar-agregar-actualizar-eliminar-------------TABLA-CLIENTES--
create procedure agregarCliente(
@idCliente int,
@nombre varchar(25),
@apellido varchar(25),
@direccion varchar(50)
)
AS
BEGIN
INSERT INTO factura.cliente (idCliente,nombre,apellido,direccion)values
(@idCliente,@nombre,@apellido,@direccion);
END

exec agregarCliente  1,'Ken','Gomez','SAN FRANCISCO'

create procedure consultarCliente
AS
BEGIN 
SELECT idCliente,nombre,apellido,direccion from factura.cliente
end

create procedure buscarCliente(@nombre varchar(25))
AS
BEGIN
SELECT nombre,apellido,direccion from factura.cliente
where nombre=@nombre
end
exec consultarCliente

create procedure ActualizarCliente(
@idCliente int,
@nombre varchar(25),
@apellido varchar(25),
@direccion varchar(25)
)
as 
begin
update factura.cliente
set nombre=@nombre , apellido=@apellido, direccion=@direccion
where idCliente=@idCliente
end
exec ActualizarCliente 1,'Ken','Mejia','Fatima'

create procedure eliminarCliente(@nombre varchar(25))
AS
BEGIN
DELETE FROM factura.cliente where nombre =@nombre
end
exec eliminarCliente 'Ken'



-----------------------consultar---buscar-agregar-actualizar-eliminar------------TABLA-PRODUCTOS
create procedure agregarProducto(
@idProducto int,
@nombreProducto varchar(40),
@descripcion varchar(50)
)
AS 
BEGIN
INSERT INTO factura.producto(idProducto,nombreProducto,descripcion) values
(@idProducto,@nombreProducto,@descripcion);
END
exec agregarProducto 1,'Coca','Gaseosa'

create procedure  consultarProducto
AS
BEGIN
SELECT idProducto,nombreProducto,descripcion from factura.producto
END

create procedure buscarProducto(@nombreProducto varchar(25))
AS
BEGIN
SELECT idProducto,nombreProducto,descripcion from factura.producto
where nombreProducto=@nombreProducto
end
exec consultarProducto

create procedure ActualizarProducto(
@idProducto int,
@nombreProducto varchar(40),
@descripcion varchar(50)
)
as 
begin
update factura.producto
set nombreProducto=@nombreProducto , descripcion=@descripcion
where idProducto=@idProducto
end
exec ActualizarProducto 1,'Pepsi','gaseosa'

create procedure eliminarProducto(@nombreProducto varchar(40))
AS
BEGIN
DELETE FROM factura.producto where nombreProducto =@nombreProducto
end
exec eliminarProducto 'Pepsi'
---------------------consultar---buscar-agregar-actualizar-eliminar-------------------TABLA-TIENDA
create procedure AgregarVenta(
@idVenta int,
@fechaVenta date,
@precio int,
@cantidad int,
@idCliente int,
@idProducto int 

)
AS 
BEGIN
INSERT INTO factura.Venta(idVenta,fechaVenta,precio,cantidad,cantidad,idCliente,idProducto) values
(@idVenta,@fechaVenta,@precio,@cantidad,@idCliente,@idProducto);
END
exec AgregarVenta 1,'2020-10-07',50,3,1,1

create procedure  consultarVenta
AS
BEGIN
SELECT c.nombre, c.apellido,P.nombreProducto,idVenta,fechaVenta,precio,cantidad from factura.Venta v
inner join factura.cliente c
on v.idCliente=c.idCliente
inner join factura.producto P
on v.idProducto=P.idProducto
END

create procedure buscarVenta(@idVenta int)
AS
BEGIN
SELECT c.nombre,c.apellido,P.nombreProducto,idVenta,fechaVenta,precio,cantidad from factura.Venta v
inner join factura.cliente c
on v.idCliente=c.idCliente
inner join factura.producto P
on v.idProducto=P.idProducto

where v.idCliente=c.idCliente
end
exec consultarVenta

create procedure ActualizarVenta(
@idVenta int,
@fechaVenta date,
@precio int,
@cantidad int,
@idCliente int,
@idProducto int 

)
as 
begin
update factura.Venta
set fechaVenta=@fechaVenta , precio=@precio, cantidad=@cantidad,idCliente=@idCliente,idProducto=@idProducto
where idVenta=@idVenta
end
exec ActualizarVenta 1,'2020-07-07',70,4,1,1

create procedure eliminarVenta(@idVenta int)
AS
BEGIN
DELETE FROM factura.Venta where idVenta =@idVenta
end
exec eliminarVenta 1

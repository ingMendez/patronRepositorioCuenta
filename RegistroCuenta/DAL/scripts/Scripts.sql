CREATE DATABASE CuentaDb
	GO
	USE CuentaDb
	GO

	CREATE TABLE Cuentas(
	
	CuentaId int primary key,
	Descripcion varchar(30),
	TipoId int,
   	Monto float
	
	);
		CREATE TABLE Presupuesto(
		PresupuestoId int primary key,
		Fecha dateTime,
		Descripcion varchar(60),
		Monto float 
		);

		CREATE TABLE PresupuestoDetalle(
		   Id int primary key,
		   PresupuestoId int,
		   CuentaId int,
		   Valor float
		   );

		CREATE TABLE TipoCuenta(
		 TipoId int primary key,
		 Descripcion varchar
		);
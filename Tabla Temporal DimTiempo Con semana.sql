

	IF OBJECT_ID(N'tempdb..##Dim_Tiempo',N'U') IS NOT NULL      
		DROP TABLE ##Dim_Tiempo;

	create table ##Dim_Tiempo
	(
		FechaSK int not null,
		Fecha date not null,
		Año smallint not null,
		Semestre smallint not null,
		Trimestre smallint not null,
		Mes smallint not null,
		Semana smallint not null,
		Dia smallint not null,
		DiaSemana smallint not null,
		NSemestre char(7) not null,
		NTrimestre char(7) not null,
		NMes char(15) not null,
		NMes3L char(6) not null,
		NSemana char(10) not null,
		NDia char(6) not null,
		NDiaSemana char(10) not null
		constraint PK_DIM_TIEMPO PRIMARY KEY CLUSTERED(Fecha asc)
	)

	/*Script de carga*/

	DECLARE @FechaDesde as smalldatetime, @FechaHasta as smalldatetime
	DECLARE @FechaAAAAMMDD int
	DECLARE @Año as smallint, @Semestre char(2), @Trimestre char(2), @Mes smallint
	DECLARE @Semana smallint, @Dia smallint, @DiaSemana smallint
	DECLARE @NSemestre char(7), @NTrimestre char(7), @NMes char(18)
	DECLARE @NMes3l char(6)
	DECLARE @NSemana char(10), @NDia char(6), @NDiaSemana char(10)
	--Set inicial por si no coincide con los del servidor
	SET DATEFORMAT dmy
	SET DATEFIRST 1

	--RAngo de fechas a generar: del 01/01/2012 al 31/12/Año actual+4
	SELECT @FechaDesde = CAST('20120101' AS smalldatetime)
	SELECT @FechaHasta = CAST(CAST(YEAR(GETDATE())+4 AS CHAR(4)) + '1231' AS smalldatetime)

	WHILE (@FechaDesde <= @FechaHasta) BEGIN
	SELECT @FechaAAAAMMDD = YEAR(@FechaDesde)*10000+
	MONTH(@FechaDesde)*100+
	DATEPART(dd, @FechaDesde)
	SELECT @Año = DATEPART(yy, @FechaDesde)
	SELECT @Trimestre = DATEPART(qq, @FechaDesde)
	SELECT @Semestre = CASE
	WHEN @Trimestre <= 2 THEN 1
	ELSE 2
	END
	SELECT @Mes = DATEPART(m, @FechaDesde)
	SELECT @Semana = DATEPART(wk, @FechaDesde)
	SELECT @Dia = RIGHT('0' + DATEPART(dd, @FechaDesde),2)
	SELECT @DiaSemana = DATEPART(DW, @FechaDesde)
	SELECT @NMes = DATENAME(mm, @FechaDesde) + '/' + RIGHT(@Año, 2)
	SELECT @NMes3l = LEFT(@NMes, 3) + '/' + RIGHT(@Año, 2)
	SELECT @NSemestre = 'S' + CAST(@Semestre as CHAR(1)) + '/' + RIGHT(@Año, 2)
	SELECT @NTrimestre = 'T' + CAST(@Trimestre as CHAR(1)) + '/' + RIGHT(@Año, 2)
	SELECT @NSemana = 'Sem ' +CAST(@Semana AS CHAR(2)) + '/' + RIGHT(RTRIM(CAST(@Año as CHAR(4))),2)
	SELECT @NDia = CAST(@Dia as CHAR(2)) + ' ' + RTRIM(@NMes)
	SELECT @NDiaSemana = DATENAME(dw, @FechaDesde)
	INSERT INTO ##Dim_Tiempo
	(
		FechaSK,
		Fecha,
		Año,
		Semestre,
		Trimestre,
		Mes,
		Semana,
		Dia,
		DiaSemana,
		NSemestre,
		NTrimestre,
		NMes,
		NMes3L,
		NSemana,
		NDia,
		NDiaSemana
	) 
	VALUES(
			@FechaAAAAMMDD,
			@FechaDesde,
			@Año,
			@Semestre,
			@Trimestre,
			@Mes,
			@Semana,
			@Dia,
			@DiaSemana,
			@NSemestre,
			@NTrimestre,
			@NMes,
			@NMes3l,
			@NSemana,
			@NDia,
			@NDiaSemana
	 )

	--Incremento del bucle
	SELECT @FechaDesde = DATEADD(DAY, 1, @FechaDesde)
	END

	--SELECT * FROM ##Dim_Tiempo WHERE Año = 2019 AND Semana = 52;

	--SELECT TOP 5 * FROM ##Dim_Tiempo WHERE Año = 2019 AND Mes = 12;


	UPDATE DimTiempo SET Semana = AUX.Semana
	FROM DimTiempo DM 
	JOIN (SELECT DMTEMP.Fecha, DMTEMP.Semana FROM ##Dim_Tiempo DMTEMP) AUX ON AUX.Fecha = DM.IdFechaVenta



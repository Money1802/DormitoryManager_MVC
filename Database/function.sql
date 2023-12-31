USE [QLKTX]
GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__DICHVU__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


------------------------------------------
CREATE	FUNCTION	[dbo].[FUNC__DICHVU__GetNextID]()
RETURNS	VARCHAR(10)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MADICHVU, 4, LEN(MADICHVU) - 3)))
	FROM DICHVU
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 7 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 7 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(10)
	SET @RESULT = 'DVU' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__HOADON__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


------------------------------------------
CREATE	FUNCTION	[dbo].[FUNC__HOADON__GetNextID]()
RETURNS	VARCHAR(15)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MAHOADON, 7, LEN(MAHOADON) - 6)))
	FROM HOADON
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 9 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 9 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(15)
	SET @RESULT = 'HOADON' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__HOADON__TongTienDichVu]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------------------------------------
CREATE	FUNCTION	[dbo].[FUNC__HOADON__TongTienDichVu] (@MAPHG	VARCHAR(10),
												  @THANG	INT,
												  @NAM	INT)
RETURNS INT
AS
BEGIN
	DECLARE @TOTAL INT
	
	SELECT @TOTAL = SUM(dv.GIADICHVU)
	FROM DICHVU_PHONG dp, DICHVU dv
	WHERE dp.MAPHG = @MAPHG
		AND dv.MADICHVU = dp.MADICHVU
		AND dv.TENDICHVU <> N'Tiền điện'
		AND dv.TENDICHVU <> N'Tiền nước'


	IF (@TOTAL IS NULL)
		SET @TOTAL = 0
		
	RETURN @TOTAL
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__HOADON__TongTienDien]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-------------------------------------------------------------
CREATE FUNCTION	[dbo].[FUNC__HOADON__TongTienDien](@MAPHG VARCHAR(10), 
											   @THANG	INT, @NAM INT)
RETURNS INT
AS
BEGIN

	RETURN(
		SELECT hdn.GIADIEN*dbo.FUNC__HOADON_DIENNUOC__SoDienTieuThu(@MAPHG, @THANG, @NAM)
		FROM HOADON hd, HOADON_DIENNUOC hdn
		WHERE hd.MAPHG = @MAPHG
			AND hd.NAM = @NAM
			AND hd.THANG = @THANG
			AND hdn.MAHOADON = hd.MAHOADON)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__HOADON__TongTienNuoc]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-------------------------------------------------------
CREATE FUNCTION	[dbo].[FUNC__HOADON__TongTienNuoc](@MAPHG VARCHAR(10), 
											   @THANG	INT, @NAM INT)
RETURNS INT
AS
BEGIN

	RETURN(
		SELECT hdn.GIANUOC*dbo.FUNC__HOADON_DIENNUOC__SoNuocTieuThu(@MAPHG, @THANG, @NAM)
		FROM HOADON hd, HOADON_DIENNUOC hdn
		WHERE hd.MAPHG = @MAPHG
			AND hd.NAM = @NAM
			AND hd.THANG = @THANG
			AND hdn.MAHOADON = hd.MAHOADON)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__HOADON_DIENNUOC__SoDienTieuThu]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-------------------------------------------------------
CREATE FUNCTION	[dbo].[FUNC__HOADON_DIENNUOC__SoDienTieuThu](@MAPHG VARCHAR(10),
														 @THANG INT, @NAM INT)
RETURNS INT
AS
BEGIN
	DECLARE @THANGTRUOC	INT
	DECLARE @NAMTRUOC INT
	
	IF (@THANG - 1 = 0)
		BEGIN
			SET @THANGTRUOC = 12
			SET @NAMTRUOC = @NAM - 1
		END
	ELSE
		BEGIN
			SET @THANGTRUOC = @THANG - 1
			SET @NAMTRUOC = @NAM
		END
	
	
	DECLARE @SODIENTHANGNAY INT
	SELECT @SODIENTHANGNAY = hdn.SODIEN
	FROM PHONG p, HOADON hd, HOADON_DIENNUOC hdn
	WHERE hd.MAPHG = @MAPHG
		AND hd.NAM = @NAM
		AND hd.THANG = @THANG
		AND hdn.MAHOADON = hd.MAHOADON
	
	IF @SODIENTHANGNAY IS NULL
		RETURN CAST(N'Chưa nhập thông tin điện nước của tháng ' + 
		CONVERT(VARCHAR, @THANG) + N' năm ' + CONVERT(VARCHAR, @NAM)
		 + ' !' AS INT)
	
	
	DECLARE @SODIENTHANGTRUOC INT
	SELECT @SODIENTHANGTRUOC = hdn.SODIEN
	FROM HOADON hd, HOADON_DIENNUOC hdn
	WHERE hd.MAPHG = @MAPHG
		AND hd.THANG = @THANGTRUOC
		AND hd.NAM = @NAMTRUOC
		AND hdn.MAHOADON = hd.MAHOADON
		
		
	IF @SODIENTHANGTRUOC IS NULL
		SET @SODIENTHANGTRUOC = 0
		
	
	RETURN @SODIENTHANGNAY - @SODIENTHANGTRUOC
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__HOADON_DIENNUOC__SoNuocTieuThu]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


---------------------------------------------------------------------
CREATE FUNCTION	[dbo].[FUNC__HOADON_DIENNUOC__SoNuocTieuThu](@MAPHG VARCHAR(10),
														 @THANG INT, @NAM INT)
RETURNS INT
AS
BEGIN
	
	DECLARE @SONUOCTHANGNAY INT
	SELECT @SONUOCTHANGNAY = hdn.SONUOC
	FROM PHONG p, HOADON hd, HOADON_DIENNUOC hdn
	WHERE hd.MAPHG = @MAPHG
		AND hd.NAM = @NAM
		AND hd.THANG = @THANG
		AND hdn.MAHOADON = hd.MAHOADON
	
	IF @SONUOCTHANGNAY IS NULL
		RETURN CAST(N'Chưa nhập thông tin điện nước của tháng ' + 
		CONVERT(VARCHAR, @THANG) + N' năm ' + CONVERT(VARCHAR, @NAM)
		 + ' !' AS INT)
	
	-----------------------------------------------------------------
	DECLARE @THANGTRUOC	INT
	DECLARE @NAMTRUOC INT
	
	IF (@THANG - 1 = 0)
		BEGIN
			SET @THANGTRUOC = 12
			SET @NAMTRUOC = @NAM - 1
		END
	ELSE
		BEGIN
			SET @THANGTRUOC = @THANG - 1
			SET @NAMTRUOC = @NAM
		END
	
	
	DECLARE @SONUOCTHANGTRUOC INT
	SELECT @SONUOCTHANGTRUOC = hdn.SONUOC
	FROM HOADON hd, HOADON_DIENNUOC hdn
	WHERE hd.MAPHG = @MAPHG
		AND hd.THANG = @THANGTRUOC
		AND hd.NAM = @NAMTRUOC
		AND hdn.MAHOADON = hd.MAHOADON
		
		
	IF @SONUOCTHANGTRUOC IS NULL
		SET @SONUOCTHANGTRUOC = 0
		
	
	RETURN @SONUOCTHANGNAY - @SONUOCTHANGTRUOC
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__HOPDONG__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


------------------------------------------
CREATE FUNCTION	[dbo].[FUNC__HOPDONG__GetNextID]()
RETURNS	VARCHAR(10)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MAHOPDONG, 3, LEN(MAHOPDONG) - 2)))
	FROM HOPDONG
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 8 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 8 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(10)
	SET @RESULT = 'HD' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__KHACH__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


------------------------------------------
CREATE	FUNCTION	[dbo].[FUNC__KHACH__GetNextID]()
RETURNS	VARCHAR(10)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MAKHACH, 6, LEN(MAKHACH) - 5)))
	FROM KHACH
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 5 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 5 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(10)
	SET @RESULT = 'KHACH' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__KHU__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


------------------------------------------
CREATE	FUNCTION	[dbo].[FUNC__KHU__GetNextID]()
RETURNS	VARCHAR(10)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MAKHU, 4, LEN(MAKHU) - 3)))
	FROM KHU
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 7 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 7 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(10)
	SET @RESULT = 'KHU' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__LOAIPHONG__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE	FUNCTION	[dbo].[FUNC__LOAIPHONG__GetNextID]()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MALOAIPHG, 10, LEN(MALOAIPHG) - 9)))
	FROM LOAIPHONG
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 6 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 6 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(15)
	SET @RESULT = 'LOAIPHONG' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END
GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__PHONG__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE	FUNCTION	[dbo].[FUNC__PHONG__GetNextID]()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MAPHG, 4, LEN(MAPHG) - 3)))
	FROM PHONG
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 7 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 7 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(10)
	SET @RESULT = 'PHG' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__PHONG__IsReferenced]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



---------------------------------------------------------------
CREATE FUNCTION	[dbo].[FUNC__PHONG__IsReferenced](@MAPHG VARCHAR(10))
RETURNS BIT
AS
BEGIN
	DECLARE @RESULT BIT
	DECLARE @COUNT INT
	SET @COUNT = 0
	
	
	SET @COUNT = @COUNT + (SELECT COUNT(MAPHG)
							FROM HOPDONG
							WHERE MAPHG = @MAPHG)
	
	SET @COUNT = @COUNT + (SELECT COUNT(MAPHG)
							FROM HOADON
							WHERE MAPHG = @MAPHG)
							
	SET @COUNT = @COUNT + (SELECT COUNT(MAPHG)
							FROM THIETBI_PHONG
							WHERE MAPHG = @MAPHG)
							
	SET @COUNT = @COUNT + (SELECT COUNT(MAPHG)
							FROM DICHVU_PHONG
							WHERE MAPHG = @MAPHG
								AND MADICHVU <> 'DVU0000001'
								AND MADICHVU <> 'DVU0000002')
	
	IF @COUNT > 0
		SET @RESULT = 'True'
	ELSE
		SET @RESULT = 'False'
	
	
	RETURN @RESULT
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__TANG__GetNextFloorName]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-------------------------------------
CREATE	FUNCTION	[dbo].[FUNC__TANG__GetNextFloorName](@MAKHU VARCHAR(10))
RETURNS NVARCHAR(15)
AS
BEGIN
	DECLARE @COUNT INT
	
	SELECT @COUNT = COUNT(MATANG)	--	Đếm số tầng của Khu hiện tại
	FROM TANG
	WHERE MAKHU = @MAKHU
	
	
	----------------------------------------------------------------
	DECLARE @RESULT NVARCHAR(15)
	
	IF @COUNT = 0					--	Khu chưa có tầng
		SET @RESULT = N'Tầng 1'
	ELSE
	BEGIN
		DECLARE @MAXFLOOR INT
		
		SELECT @MAXFLOOR = MAX(CONVERT(INT, SUBSTRING(TENTANG, 6, LEN(TENTANG) - 5)))
		FROM TANG
		WHERE MAKHU = @MAKHU
		
		SET @RESULT = N'Tầng ' + CONVERT(VARCHAR, @MAXFLOOR + 1)
	END
	
	
	RETURN @RESULT
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__TANG__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE	FUNCTION	[dbo].[FUNC__TANG__GetNextID]()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MATANG, 5, LEN(MAKHU) - 4)))
	FROM TANG
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 6 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 6 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(10)
	SET @RESULT = 'TANG' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__THIETBI__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


------------------------------------------
CREATE	FUNCTION	[dbo].[FUNC__THIETBI__GetNextID]()
RETURNS	VARCHAR(10)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MATBI, 4, LEN(MATBI) - 3)))
	FROM THIETBI
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 7 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 7 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(10)
	SET @RESULT = 'TBI' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO
/****** Object:  UserDefinedFunction [dbo].[FUNC__VIPHAM__GetNextID]    Script Date: 21/12/2022 11:41:51 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


------------------------------------------
CREATE	FUNCTION	[dbo].[FUNC__VIPHAM__GetNextID]()
RETURNS	VARCHAR(10)
AS
BEGIN
	DECLARE @MAXID INT

	SELECT @MAXID = CONVERT(INT, MAX(SUBSTRING(MAVIPHAM, 7, LEN(MAVIPHAM) - 6)))
	FROM VIPHAM
	
	---------------------------------
	IF (@MAXID IS NULL)
		SET @MAXID = '0'
	
	
	DECLARE @DISTANCE INT
	IF (LEN(@MAXID + 1) > LEN(@MAXID))	--	Trường hợp chữ số cuối cùng của đơn vị
		SET @DISTANCE = 4 - (LEN(@MAXID) + 1)
	ELSE
		SET @DISTANCE = 4 - LEN(@MAXID)
	
	---------------------------------
	DECLARE @RESULT VARCHAR(10)
	SET @RESULT = 'VIPHAM' + REPLICATE('0', @DISTANCE) + CONVERT(VARCHAR, @MAXID + 1)
	
	RETURN @RESULT + CONVERT(VARCHAR, @MAXID + 1)
END

GO

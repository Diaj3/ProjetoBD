use p6g7;

--------------------- GESTOR --------------------------------------------------------------------------------------------------
-- CHECK THE SCHEDULE OF AN EMPLOYEE AS THE HOTEL MANAGER --
SELECT Work_shift
FROM MANAGEMENT.HOTEL AS ho
JOIN MANAGEMENT.EMPLOYEE AS ep
ON ho.Hotel_id = ep.Hotel_id
JOIN MANAGEMENT.HAS as has
ON ep.Staff_id = has.Staff_id
WHERE ep.Staff_id = 3265485596;

-- LOGIN PROCEDURE --
CREATE PROCEDURE MANAGEMENT.LOGIN_MANAGER
@hotel_id varchar(10),
@password varchar(30),
@successLogin INT OUTPUT
AS
BEGIN
	SELECT @successLogin = Count(*)
	FROM MANAGEMENT.HOTEL hotel 
	WHERE hotel.Hotel_id = @hotel_id 
	AND hotel.[password] = @password

	RETURN @successLogin -- 0 If it fails, 1 if it passes
END
GO
-- DELETING AN EMPLOYEE ---
-----------------------------------------------------------------------------

-------------------------EMPLOYEE -----------------------------------------------------------------------------------------------

----- Verificar tipo de Employee -----
CREATE FUNCTION MANAGEMENT.get_type_of_employee(@staff_id Char(10)) 
RETURNS INT
BEGIN
IF EXISTS(SELECT * FROM MANAGEMENT.CLEANER WHERE MANAGEMENT.CLEANER.Cleaner_id = @staff_id)
BEGIN
	RETURN 1
END
IF EXISTS(SELECT * FROM MANAGEMENT.RECEPTIONIST WHERE MANAGEMENT.RECEPTIONIST.Receptionist_id = @staff_id)
BEGIN	
	RETURN 2
END
IF EXISTS(SELECT * FROM MANAGEMENT.BARTENDER WHERE MANAGEMENT.BARTENDER.Bartender_id = @staff_id)
BEGIN
	RETURN 3
END
IF EXISTS(SELECT * FROM MANAGEMENT.CHEF WHERE MANAGEMENT.CHEF.Chef_id = @staff_id)
BEGIN
	RETURN 4
END
	RETURN 0 -- Caso de erro
END

------------------------cleaner---------------------------------------------
--- Getting the cleaner info -----
CREATE FUNCTION MANAGEMENT.get_cleaner_information(@staff_id Char(10))
RETURNS TABLE
AS 
RETURN
	SELECT
		Work_shift,
		RoomNum
FROM 
	HAS has,
	ROOM_SERVICE rs
WHERE 
	has.Staff_id = @staff_id AND rs.Cleaner_id = @staff_id

---- Deleting Cleaner ------
CREATE PROCEDURE [MANAGEMENT].[DELETE_CLEANER]
	@cleanerId char(10),
	@outputResult INT OUTPUT
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM MANAGEMENT.ROOM_SERVICE WHERE MANAGEMENT.ROOM_SERVICE.Cleaner_id = @cleanerId
			DELETE FROM MANAGEMENT.CLEANER WHERE MANAGEMENT.CLEANER.Cleaner_id = @cleanerId
			DELETE FROM MANAGEMENT.HAS WHERE MANAGEMENT.HAS.Staff_id = @cleanerId
			COMMIT
			
			SET @outputResult = 0
		END TRY
		BEGIN CATCH
			ROLLBACK;
			SET @outputResult = 1
		END CATCH
	DELETE FROM MANAGEMENT.EMPLOYEE WHERE MANAGEMENT.EMPLOYEE.Staff_id = @cleanerId
	RETURN @outputResult
END

-----------------------receptionist-------------------------------------------

-- Getting receptionist info --
ALTER FUNCTION MANAGEMENT.get_receptionist_information(@staff_id Char(10))
RETURNS TABLE
AS 
RETURN
	SELECT
		BookingNum,
		Work_shift
FROM 
	BOOKING bk INNER JOIN RECEPTIONIST r ON bk.Receptionist_id = r.Receptionist_id
	INNER JOIN EMPLOYEE e ON r.Receptionist_id = e.Staff_id,
	HAS has
WHERE 
	e.Staff_id = @staff_id AND has.Staff_id = @staff_id

SELECT * FROM MANAGEMENT.get_receptionist_information(3322263668)

CREATE PROCEDURE [MANAGEMENT].[DELETE_RECEPTIONIST]
	@receptionistId char(10),
	@outputResult INT OUTPUT
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE MANAGEMENT.BOOKING SET Receptionist_id = 7993251489
			IF @receptionistId = 7993251489 
				BEGIN
					RETURN 
				END
			DELETE FROM MANAGEMENT.RECEPTIONIST WHERE MANAGEMENT.RECEPTIONIST.Receptionist_id = @receptionistId
			DELETE FROM MANAGEMENT.HAS WHERE MANAGEMENT.HAS.Staff_id = @receptionistId
			COMMIT
			
			SET @outputResult = 0
		END TRY
		BEGIN CATCH
			ROLLBACK;
			SET @outputResult = 1
		END CATCH
	DELETE FROM MANAGEMENT.EMPLOYEE WHERE MANAGEMENT.EMPLOYEE.Staff_id = @receptionistId
	RETURN @outputResult
END
--------------------------chef------------------------------------------------

CREATE FUNCTION MANAGEMENT.get_chef_information(@staff_id Char(10))
RETURNS TABLE
AS
RETURN
	SELECT DISTINCT
		Meal_name,
		Meal_price,
		Work_shift
FROM
	MEAL m INNER JOIN CHEF c ON m.Chef_id = c.Chef_id
	INNER JOIN EMPLOYEE e ON c.Chef_id = e.Staff_id,
	HAS has
WHERE
	e.Staff_id = @staff_id AND has.Staff_id = @staff_id



CREATE PROCEDURE [MANAGEMENT].[DELETE_CHEF]
	@chefId char(10),
	@outputResult INT OUTPUT
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM MANAGEMENT.MEALS WHERE MANAGEMENT.MEALS.Chef_id = @chefId
			DELETE FROM MANAGEMENT.CHEF WHERE MANAGEMENT.CHEF.Chef_id = @chefId
			DELETE FROM MANAGEMENT.HAS WHERE MANAGEMENT.HAS.Staff_id = @chefId
			COMMIT
			
			SET @outputResult = 0
		END TRY
		BEGIN CATCH
			ROLLBACK;
			SET @outputResult = 1
		END CATCH
	DELETE FROM MANAGEMENT.EMPLOYEE WHERE MANAGEMENT.EMPLOYEE.Staff_id = @chefId
	RETURN @outputResult
END
-------------------------bartender-------------------------------------------

CREATE FUNCTION MANAGEMENT.get_bartender_information(@staff_id Char(10))
RETURNS TABLE
AS
RETURN
	SELECT DISTINCT
		Drink_name,
		Drink_price,
		Work_shift
FROM
	DRINK d INNER JOIN BARTENDER b ON b.Bartender_id = d.Bartender_id
	INNER JOIN EMPLOYEE e ON b.Bartender_id = e.Staff_id,
	HAS has
WHERE
	e.Staff_id = @staff_id AND has.Staff_id = @staff_id

CREATE PROCEDURE [MANAGEMENT].[DELETE_BARTENDER]
	@bartenderId char(10),
	@outputResult INT OUTPUT
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM MANAGEMENT.DRINKS WHERE MANAGEMENT.DRINKS.Bartender_id = @bartenderId
			DELETE FROM MANAGEMENT.BARTENDER WHERE MANAGEMENT.BARTENDER.Bartender_id = @bartenderId
			DELETE FROM MANAGEMENT.HAS WHERE MANAGEMENT.HAS.Staff_id = @bartenderId
			COMMIT
			
			SET @outputResult = 0
		END TRY
		BEGIN CATCH
			ROLLBACK;
			SET @outputResult = 1
		END CATCH
	DELETE FROM MANAGEMENT.EMPLOYEE WHERE MANAGEMENT.EMPLOYEE.Staff_id = @bartenderId
	RETURN @outputResult
END


SELECT C.Cleaner_id, RS.RoomNum, H.Work_shift, E.* FROM MANAGEMENT.CLEANER C 
INNER JOIN MANAGEMENT.ROOM_SERVICE RS ON C.Cleaner_id = RS.Cleaner_id 
INNER JOIN MANAGEMENT.EMPLOYEE E ON C.Cleaner_id = E.Staff_id
INNER JOIN MANAGEMENT.HAS H ON H.Staff_id = E.Staff_id

SELECT M.Meal_name, M.Meal_price, C.*, E.*, H.Work_shift FROM MANAGEMENT.CHEF C 
    INNER JOIN MANAGEMENT.EMPLOYEE E ON C.Chef_id = E.Staff_id
	INNER JOIN MANAGEMENT.MEAL M ON M.Chef_id = C.Chef_id
	INNER JOIN MANAGEMENT.HAS H ON H.Staff_id = C.Chef_id
   
SELECT D.Drink_name, D.Drink_price, B.*, E.*, H.Work_shift FROM MANAGEMENT.BARTENDER B 
    INNER JOIN MANAGEMENT.EMPLOYEE E ON B.Bartender_id = E.Staff_id
	INNER JOIN MANAGEMENT.DRINK D ON D.Bartender_id = B.Bartender_id
	INNER JOIN MANAGEMENT.HAS H ON H.Staff_id = B.Bartender_id

SELECT B.BookingNum, R.*, E.*, H.Work_shift FROM MANAGEMENT.RECEPTIONIST R
	INNER JOIN MANAGEMENT.EMPLOYEE E ON R.Receptionist_id = E.Staff_id
	INNER JOIN MANAGEMENT.BOOKING B ON B.Receptionist_id = R.Receptionist_id
	INNER JOIN MANAGEMENT.HAS H ON H.Staff_id = R.Receptionist_id
-------------------------------- COSTUMER -----------------------------------------------------------------------------------
ALTER FUNCTION MANAGEMENT.get_booking_info(@NIF Char(10))
RETURNS TABLE
AS 
RETURN
	SELECT
		BookingNum,
		convert(varchar, b.Checkin_time, 120) as Checkin_time,
		convert(varchar, b.Checkout_time, 120) as Checkout_time
FROM
	BOOKING b INNER JOIN ACCOUNT_RECORD acc 
	ON b.Account_record_id = acc.Account_record_id
	INNER JOIN CUSTOMER c ON acc.NIF = c.NIF
WHERE c.NIF = @NIF

SELECT * FROM MANAGEMENT.get_booking_info(390443066)

-- DESCRIPTION OF DRINKS AND MEALS --
ALTER FUNCTION MANAGEMENT.drinksNmeals (@UserNif CHAR(9))
RETURNS TABLE
AS
RETURN
	SELECT
		Meal_name,
		Meal_price,
		Drink_name,
		Drink_price,
		RoomNum,
		RoomPrice
	FROM
		ROOM_TYPE rt INNER JOIN ROOM r
		ON rt.RoomNum = r.RoomNum

CREATE PROCEDURE [MANAGEMENT].[INSERT_CUSTOMER]
	(@NIF				CHAR(9),
	@Fname			VARCHAR(20),
	@Lname			VARCHAR(20),
	@PhoneNum		INT,
	@Address		VARCHAR(50),
	@Pass			VARCHAR(30))
AS
BEGIN
	INSERT INTO MANAGEMENT.CUSTOMER(NIF,Fname,Lname,PhoneNum,Address,Pass) VALUES (@NIF, @Fname, @Lname, @PhoneNum, @Address, @Pass)
END

ALTER PROCEDURE [MANAGEMENT].[INSERT_ACCOUNT_RECORD]
	(@NIF	CHAR(9),
	 @Account_record_id INT)
AS
BEGIN
	INSERT INTO MANAGEMENT.ACCOUNT_RECORD(NIF,Account_record_id,Date) VALUES (@NIF, @Account_record_id, GetDate())
END

CREATE PROCEDURE [MANAGEMENT].[INSERT_BOOKING]
	(@Account_record_id INT,
	 @Checkin_time DATE,
	 @Checkout_time DATE,
	 @BookingNum INT, 
	 @Receptionist_id CHAR(10))
AS
BEGIN
	INSERT INTO MANAGEMENT.BOOKING(Account_record_id,BookingNum,Receptionist_id,Checkin_time,Checkout_time) VALUES (@Account_record_id,@BookingNum,@Receptionist_id,@Checkin_time,@Checkout_time)
END


IF NOT EXISTS ( SELECT 1 FROM Users WHERE FirstName = 'John' AND LastName = 'Smith' )
BEGIN
    INSERT INTO Users (FirstName, LastName) VALUES ('John', 'Smith')
END
-----------------------------------------------------------------------

ALTER FUNCTION MANAGEMENT.description_list (@UserNif CHAR(9)) RETURNS TABLE
AS
BEGIN
	DECLARE @price as INT;
	DECLARE @roomNum as INT;
	DECLARE @description as VARCHAR;

	SELECT @price = rt.RoomPrice, @roomNum = rm.RoomNum
	FROM MANAGEMENT.CUSTOMER AS co
	JOIN MANAGEMENT.ACCOUNT_RECORD AS ac ON co.NIF = ac.NIF
	JOIN MANAGEMENT.BOOKING AS bo ON ac.Account_record_id = bo.Account_record_id 
	JOIN MANAGEMENT.IS_ASSIGNED AS ia ON bo.BookingNum = ia.BookingNum 
	JOIN MANAGEMENT.ROOM AS rm ON ia.RoomNum = rm.RoomNum 
	JOIN MANAGEMENT.ROOM_TYPE AS rt ON rm.RoomType = rt.RoomType
	WHERE co.NIF = @UserNif
	SET @description = @roomNum + @price;

	RETURN @description
END
GO
SELECT MANAGEMENT.description_list(359578462)


 -- UPDATE CHECKOUT_TIME --
CREATE FUNCTION MANAGEMENT.update_booking (@new_checkout_date DATETIME2) RETURNS INT
AS
BEGIN

UPDATE MANAGEMENT.BOOKING
SET Checkout_time = @new_checkout_date -- Valor inserido pelo Customer
WHERE MANAGEMENT.BOOKING.Account_record_id = 0004; -- Como ir buscar este valor do utilizador?? --
END
GO


SELECT * FROM MANAGEMENT.CLEANER cl
INNER JOIN MANAGEMENT.ROOM_SERVICE rs
ON cl.Cleaner_id = rs.Cleaner_id
WHERE cl.Cleaner_id = 3265485596

SELECT * from MANAGEMENT.ROOM_SERVICE where ROOM_SERVICE.Cleaner_id = 3265485596


SELECT * from MANAGEMENT.get_cleaner_information

SELECT * FROM MANAGEMENT.get_receptionist_information(5856225901)

SELECT * FROM MANAGEMENT.get_chef_information(7924268842)

SELECT D.*, M.*, R.* FROM MANAGEMENT.CUSTOMER C 
INNER JOIN MANAGEMENT.ACCOUNT_RECORD AC ON C.NIF = AC.NIF
INNER JOIN MANAGEMENT.DRINK D ON D.Account_record_id = AC.Account_record_id
INNER JOIN MANAGEMENT.MEAL M ON M.Account_record_id = AC.Account_record_id
INNER JOIN MANAGEMENT.BOOKING B ON B.Account_record_id = AC.Account_record_id
INNER JOIN MANAGEMENT.IS_ASSIGNED A ON A.BookingNum = B.BookingNum
INNER JOIN MANAGEMENT.ROOM R ON R.RoomNum = A.RoomNum
INNER JOIN MANAGEMENT.ROOM_TYPE RT ON RT.RoomType = R.RoomType
WHERE C.NIF = 596312599;

GO
ALTER PROCEDURE MANAGEMENT.GET_GASTOS @NIF char(9)
AS
	DECLARE @auxTable TABLE(Drink_name varchar(20), Drink_price int, Meal_name varchar(20), Meal_price int, RoomNum int, Checkin_time datetime2, Checkout_time datetime2, Room_price int, Total_room_price int, Total_meal_price int, Total_drink_price int)
	INSERT INTO @auxTable (Drink_name, Drink_price, Meal_name, Meal_price, RoomNum, Checkin_time, Checkout_time, Room_price) 
	SELECT D.Drink_name, D.Drink_price, M.Meal_name, M.Meal_price, R.RoomNum, B.Checkin_time, B.Checkout_time, RT.RoomPrice FROM MANAGEMENT.CUSTOMER C 
	INNER JOIN MANAGEMENT.ACCOUNT_RECORD AC ON C.NIF = AC.NIF
	INNER JOIN MANAGEMENT.DRINK D ON D.Account_record_id = AC.Account_record_id
	INNER JOIN MANAGEMENT.MEAL M ON M.Account_record_id = AC.Account_record_id
	INNER JOIN MANAGEMENT.BOOKING B ON B.Account_record_id = AC.Account_record_id
	INNER JOIN MANAGEMENT.IS_ASSIGNED A ON A.BookingNum = B.BookingNum
	INNER JOIN MANAGEMENT.ROOM R ON R.RoomNum = A.RoomNum
	INNER JOIN MANAGEMENT.ROOM_TYPE RT ON RT.RoomType = R.RoomType
	WHERE C.NIF = 195175302

	INSERT INTO @auxTable (Total_meal_price) SELECT SUM(Meal_price) FROM @auxTable
	INSERT INTO @auxTable (Total_drink_price) SELECT SUM(Drink_price) FROM @auxTable

	DECLARE @NR_DAYS INT;

	DECLARE @Checkin_time datetime2;
	DECLARE @Checkout_time datetime2;
	
	SELECT TOP 1 @Checkin_time = Checkin_time, @Checkout_time = Checkout_time FROM @auxTable
	
	SELECT @NR_DAYS = DATEDIFF(day, @Checkin_time, @Checkout_time)
	PRINT @NR_DAYS
	INSERT INTO @auxTable (Total_room_price) SELECT @NR_DAYS * Room_price FROM @auxTable

	SELECT * FROM @auxTable
GO

CREATE FUNCTION MANAGEMENT.CUSTOMER_DATA(@NIF char(9)) 
RETURNS TABLE
AS 
	RETURN 
		SELECT D.Drink_name, D.Drink_price, M.Meal_name, M.Meal_price, 
		R.RoomNum, B.Checkin_time, B.Checkout_time, RT.RoomPrice 
		
		FROM MANAGEMENT.CUSTOMER C 
		INNER JOIN MANAGEMENT.ACCOUNT_RECORD AC ON C.NIF = AC.NIF
		INNER JOIN MANAGEMENT.DRINK D ON D.Account_record_id = AC.Account_record_id
		INNER JOIN MANAGEMENT.MEAL M ON M.Account_record_id = AC.Account_record_id
		INNER JOIN MANAGEMENT.BOOKING B ON B.Account_record_id = AC.Account_record_id
		INNER JOIN MANAGEMENT.IS_ASSIGNED A ON A.BookingNum = B.BookingNum
		INNER JOIN MANAGEMENT.ROOM R ON R.RoomNum = A.RoomNum
		INNER JOIN MANAGEMENT.ROOM_TYPE RT ON RT.RoomType = R.RoomType
		WHERE C.NIF = @NIF
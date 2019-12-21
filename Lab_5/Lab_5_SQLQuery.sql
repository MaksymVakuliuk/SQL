USE Gifts_for_children_of_employees

--Добавление нового пользователя
GO
CREATE PROCEDURE add_the_new_user @login AS VarChar(20), @password AS Varchar(20) AS
BEGIN
 EXEC sp_addlogin @login, @password, 'Gifts_for_children_of_employees'
 EXEC sp_adduser @login, @login
END

EXEC add_the_new_user 'test', '123456' 

DROP PROCEDURE add_the_new_user

--Удаление пользователя
GO
CREATE PROCEDURE drop_the_new_user @login AS VarChar(20) AS
BEGIN
 EXEC sp_droplogin @login 
 EXEC sp_dropuser @login
END

EXEC drop_the_new_user 'test'

DROP PROCEDURE drop_the_new_user

--Добавление нового разрешения на выбраную таблицу у выбраного пользователя
GO
CREATE PROCEDURE grant_user_right @login AS VarChar(20), @right AS VarChar(20),  @table AS Varchar(20) AS
BEGIN
	DECLARE @SQLString NVarChar(250)
	SET @SQLString =  'GRANT ' + @right + ' ON ' + @table + ' TO ' + @login
	EXECUTE sp_executesql @SQLString
END

DROP PROCEDURE grant_user_right

EXEC grant_user_right 'test', 'select', 'Employeers'
--Удаление нового разрешения на выбраную таблицу у выбраного пользоватиеля
GO
CREATE PROCEDURE deny_user_right @login AS VarChar(20), @right AS VarChar(20),  @table AS Varchar(20) AS
BEGIN
	DECLARE @SQLString NVarChar(250)
	SET @SQLString =  'DENY ' + @right + ' ON ' + @table + ' TO ' + @login
	EXECUTE sp_executesql @SQLString
END		

EXEC deny_user_right 'test', 'select', 'Employeers'
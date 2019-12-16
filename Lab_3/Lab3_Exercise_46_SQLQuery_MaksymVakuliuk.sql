/*
	46.	По правилам оформлення машинописних текстів перед знаками .,!?:; 
	пробіли не ставляться, але обов’язково ставляться після цих знаків. 
	Поставити пробілів яких не вистачає. Підрахувати кількість виправлень.
*/

USE DB_Books

DECLARE @punctuation_marks NVarChar(24) 
DECLARE @Text NVarChar(1024)
DECLARE @ChangesChar int 
DECLARE @i int
DECLARE @j int

SET @i = 1
SET @j = 0
SET @ChangesChar = 0
SET @punctuation_marks = ' .,!?:;/'
SET @Text = 'SDFGSDdfg , dfg .. d/f. fgdfg, df?? fdg .Текст предназначеный?  для  исправления ! Набор    :разных ,слов и . знаков;припенания.'

PRINT @TEXT

WHILE @i <= LEN(@punctuation_marks)
BEGIN
	SET @j = 1
	WHILE @j > 0
	BEGIN
		SET @j = CHARINDEX(' ' + SUBSTRING(@punctuation_marks, @i, 1), @Text, @j)
		IF @j > 0
		BEGIN
			SET @ChangesChar = @ChangesChar + 1
			SET @Text = SUBSTRING(@Text, 1, @j-1) + SUBSTRING(@Text, @j+1, LEN(@Text))
		END
	END
	SET @i = @i + 1 
END

SET @i = 2
WHILE @i <= LEN(@punctuation_marks)
BEGIN
	SET @j = 1
	WHILE @j > 0 and @j < LEN(@Text) 
	BEGIN
		SET @j = CHARINDEX(SUBSTRING(@punctuation_marks, @i, 1), @Text, @j)
		IF @j = 0 BREAK
		IF @j > 1 AND SUBSTRING(@Text,@j+1, 1) != ' ' 
		BEGIN
			SET @ChangesChar = @ChangesChar + 1
			SET @Text = SUBSTRING(@Text, 1, @j) + ' ' + SUBSTRING(@Text, @j+1, LEN(@TExt))
		END ELSE begin 
		set @j = @j + 1
		end
	END
	SET @i = @i + 1
END
PRINT @Text
SELECT @Text, @ChangesChar
/*
	46.	�� �������� ���������� ������������ ������ ����� ������� .,!?:; 
	������ �� ����������, ��� ���������� ���������� ���� ��� �����. 
	��������� ������ ���� �� �������. ϳ��������� ������� ����������.
*/

USE DB_Books

DECLARE @punctuation_marks NVarChar(7) 
DECLARE @Text NVarChar(1024)
DECLARE @ChangesChar int 
DECLARE @i int
DECLARE @j int

SET @i = 1
SET @j = 0
SET @ChangesChar = 0
SET @punctuation_marks = ' .,!?:;'
SET @Text = '����� ��������������?  ���  ����������� ! �����    :������ ,���� � . ������;����������.'

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
		IF @j > 1 AND SUBSTRING(@Text,@j+1, 1) <> ' '
		BEGIN
			SET @ChangesChar = @ChangesChar + 1
			SET @Text = SUBSTRING(@Text, 1, @j) + ' ' + SUBSTRING(@Text, @j+1, LEN(@TExt))
		END BREAK;
	END
	SET @i = @i + 1 
END
SELECT @Text, @ChangesChar
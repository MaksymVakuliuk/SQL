/*
	51.	�������� � ������� ����� ������ ���� �� � �� - ����.
*/

USE DB_Books
 
DECLARE @Text NVarChar(1024)
SET @Text = '����� ��������������?  ���  ����������� ! �����    :������ ,���� � . ������;����������.'

PRINT @Text
SET @Text = REPLACE(REPLACE(@Text, '�', '��'), '�', '��')

 PRINT @Text
/*
	61) �������� � ������� Books ����� ������, ������ ������ ��������� ���� ��������� ��� (���� Code_book),
		������������� ����������� �� ������� �� ������������� ���� � �������,
		������ �������� ����� (���� Title_book) �������� ������. �������. ���������. 
*/

USE DB_Books

DECLARE
	@Code_book INT,
	@Title_book char(40)

SET @Code_book = (SELECT MAX(Code_book) FROM Books)+1
SEt @Title_book = '�����. �������. ���������'
INSERT INTO Books
(Code_book, Title_book)
VALUES 
(@Code_book, @Title_book)
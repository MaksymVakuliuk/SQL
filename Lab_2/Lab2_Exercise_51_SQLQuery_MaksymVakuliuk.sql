/*
	51) ������� ������ ���� (���� Title_book), � ������� ���������� ������� (���� Pages)
		������ �������� ���������� ������� ���� ���� � �������. 
*/

USE DB_Books

SELECT Title_book FROM Books
WHERE Pages < (SELECT AVG(Pages) FROM Books)
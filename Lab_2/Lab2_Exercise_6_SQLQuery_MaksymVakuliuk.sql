/*
	6) ������� �� ������� Books  �������� ���� � ���������� ������� (���� Title_book � Pages),
	   � �� ������� Authors ������� ��� ���������������� ������ ����� (���� Name_ author). 
*/

USE DB_Books

SELECT Books.Title_book, Books.Pages, Authors.Name_authors FROM Books, Authors
WHERE Books.Code_author = Authors.Code_author
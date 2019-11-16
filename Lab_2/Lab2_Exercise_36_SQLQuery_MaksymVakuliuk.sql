/*
36)	������� ������� ��������� (������������ ���� Cost)
	� ������� ���������� ����������� ���� (������������ ���� Amount) � ����� ��������,
	��� ������� ����� �������� ������� (������� �� ���� Name_author). 
*/

USE DB_Books

SELECT AVG(Purchases.Cost) AS '������� ���������', AVG(Purchases.Amount) AS '������� ���������� ����������' FROM Books 
INNER JOIN Purchases
ON Books.Code_book = Purchases.Code_book
INNER JOIN Authors
ON Authors.Code_author = Books.Code_author
WHERE Authors.Name_authors = '������'
--WHERE Authors.Name_authors = '����� �������'
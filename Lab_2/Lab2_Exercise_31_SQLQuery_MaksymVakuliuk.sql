/*
31) ������� ��������� ��������� ������ ����������� ���� (������������ ���� Amount � Cost)
		� �������� ����� (���� Title_book) � ������ ��������.
*/

USE DB_Books

SELECT Books.Title_book, Purchases.Cost , Purchases.Amount, 
Purchases.Amount*Purchases.Cost AS '����� ������'  
FROM  Purchases INNER JOIN Books
ON Purchases.Code_book = Books.Code_book
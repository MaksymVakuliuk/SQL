/*
	36.	�������� ��������� ������ �� ����� ������� ������������� (������� Deliveries)
	� ������ Name_delivery, Name_company.
*/

USE DB_Books

DECLARE MyCursor CURSOR FOR (SELECT Name_delivery, Name_company FROM Deliveries)
/*
41)	������� ����� ����� �������� ���� (������������ ���� Cost) � ��������� ��������� � ���� � ��������� Sum_cost,
		����������� ���� ���� (������� �� ���� Name_company).
*/


USE DB_Books

SELECT SUM(Purchases.Cost) AS 'Sum_cost' FROM Purchases INNER JOIN Deliveries
ON Deliveries.Code_delivery = Deliveries.Code_delivery 
WHERE Deliveries.Name_company LIKE '��� ���'
--'Glovo%'
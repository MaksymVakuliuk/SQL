/*
	�������� �������� ������� � ������ TEMP � ������ ���� ����, ���������� �����,
	�� � ��������� �� ����������� �1�. �������� � �� ��� ������ � ������ � ������� ��������� �� �����.
*/

USE DB_Books

CREATE TABLE "TEMP" ("Integer" Int, "String" NVarchar(20), "Bit" Bit DEFAULT 1)

INSERT INTO "TEMP" ("Integer", "String", "Bit")
VALUES
(2, 'First', 0), 
(6, 'Second', 1)
SELECT * FROM "TEMP"

DROP TABLE "TEMP"
/*
	16) ������� ������ �������� ���� (���� Title_book) � ���������� ������� (���� Pages) �� ������� Books,
		� ������� ����� � ��������� ������������ � �������� 200 � 300 (������� �� ���� Pages).
*/

USE DB_Books
SELECT Title_book, Pages FROM Books
WHERE Pages BETWEEN 200 AND 300
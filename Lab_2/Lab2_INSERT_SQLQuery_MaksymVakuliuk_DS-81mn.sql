USE DB_Books

INSERT INTO Authors
(Code_author, Name_authors, Birthday)
VALUES
('1','����� �������','31.07.1965'),
('2','����� ������','16.10.1854'),
('3','������ ���������','25.08.1652')

INSERT INTO Publishing_house
(Code_publish, Publish, City)
VALUES
('1','�-��-��-��-��-��-��','����'),
('2','������','�����-���������'),
('3','���������','������')

INSERT INTO Books
(Code_book, Title_book, Code_author, Pages, Code_publish )
VALUES
('1', '���в ������ � Բ���������� ��̲��', '1', '320', '1'),
('2', '���в ������ � ������ ʲ�����', '1', '352', '1'),
('3', '���в ������ � ����� ��������', '1', '384', '1'),
('4', '���в ������ � ����� �����', '1', '672', '1'),
('5', '���в ������ � ����� ��Ͳ���', '1', '816', '1'),
('6', '���в ������ � ��ϲ�������� �����', '1', '576', '1'),
('7', '���в ������ � ��������Ͳ ��˲�²�', '1', '640', '1'),
('8', '���в ������ �  �������� ����', '1', '352', '1'),
('9', '������� ������� ����', '2', '320', '2'),
('10', '��������', '3', '352', '3'),
('11', '����', '3', '400', '3'),
('12', '���� �� ������', '3', '320', '3')

INSERT INTO Deliveries
(Code_delivery, Name_delivery, Name_company, Address, Phone, INN)
VALUES
('1', 'Glovo', 'Glovo incorporate', 'Kiev', '380938633054', '5454545454')

INSERT INTO Purchases
(Code_book, Date_order, Code_delivery, Type_purchase, Cost, Amount, Code_purchase)
VALUES
('', '', '', '', '', '', '')
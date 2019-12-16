USE Gifts_for_children_of_employees

INSERT INTO Employeers
(LastName, FirstName, Patronymic, Position, Department, Hiring_date)
VALUES
('Иван', 'Иванович', 'Иванов', 'Директор', 'управления', '1997-05-11'),
('Віктор', 'Гармашов', 'Васильович', 'проект менеджер', 'продаж', '2000-07-07'),
('Дініс', 'Грачевкий', 'Олексійович', 'проект менеджер', 'реклами', '2015-04-08')


INSERT INTO ChildrenOfEmployeers
(Employee_ID, FirstName, Date_of_birth)
VALUES
('1', 'Ігорь', '1999-05-19'),
('3', 'Артур', '2002-07-07'),
('2', 'Леня', '2001-06-03')

INSERT INTO Gifts
(Child_ID, Gift_value, Date_of_issue, Number_of_issue)
VALUES
('1','200','2016-04-03','7464'),
('2','300','2016-04-04','6852')

INSERT INTO Employeers
(LastName, FirstName, Patronymic, Position, Department, Hiring_date)
VALUES
('ivan', 'ivanovich', 'Ivanov', 'Директор', 'управления', '1997-05-11')


INSERT INTO ChildrenOfEmployeers
(Employee_ID, FirstName, Date_of_birth)
VALUES
('2', 'Леня', '2001-06-03')

INSERT INTO Gifts
(Child_ID, Gift_value)
VALUES
('3','300')
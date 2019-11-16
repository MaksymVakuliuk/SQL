/*
26)  Вывести список издательств (поле Publish) из таблицы Publishing_house, в которых выпущены книги,
названия которых (поле Title_book) начинаются со слова ‘Труды’ и город издания (поле City) – ‘Новосибирск’.
*/

USE DB_Books

SELECT Publish FROM Publishing_house INNER JOIN Books
ON Books.Code_publish = Publishing_house.Code_publish
WHERE Books.Title_book LIKE 'Труды%' AND Publishing_house.City = 'Новосибирск'

/*
46) Вывести список авторов (поле Name_author), книги которых были выпущены в издательствах ‘Мир’, ‘Питер Софт’,
	‘Наука’ (условие по полю Publish). 
*/

USE DB_Books

SELECT DISTINCT Authors.Name_authors FROM Books INNER JOIN Authors
ON Books.Code_author = Authors.Code_author
INNER JOIN Publishing_house
ON Books.Code_publish = Publishing_house.Code_publish
WHERE Publishing_house.Publish in ('Мир', 'Питер Софт', 'Наука')
--WHERE Publishing_house.Publish in ('А-БА-БА-ГА-ЛА-МА-ГА', 'Азбука', 'Наука')
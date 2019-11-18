/*
	36.	—творити динам≥чний курсор по даним таблиц≥ постачальник≥в (таблиц€ Deliveries)
	з пол€ми Name_delivery, Name_company.
*/

USE DB_Books

DECLARE MyCursor CURSOR FOR (SELECT Name_delivery, Name_company FROM Deliveries)
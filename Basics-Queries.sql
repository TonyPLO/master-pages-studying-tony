--CREATE TABLE UFC_Fighters(
--id int,
--Name varchar(255),
--Height int,
--Birthday Date
--);

--INSERT INTO UFC_Fighters(Name, Height)
--VALUES ('mike tyson', 196);

INSERT INTO UFC_Fighters 
VALUES (1488,'mike nuse', 587,'2001-09-11');

--UPDATE UFC_Fighters
--SET id = 911, Birthday= '0001-10-11'
--WHERE Height = 289;

delete from UFC_Fighters WHERE Height = 196




select Name,Height from UFC_Fighters;

select *from UFC_Fighters;

select *from UFC_Fighters WHERE Height > 200;

select *from UFC_Fighters WHERE Name LIKE 'g%'
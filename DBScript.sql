CREATE TABLE TempBOSS(
id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
LAST_NAME VARCHAR(30),
FIRST_NAME VARCHAR(30),
Last_Name_RU VARCHAR(30),
First_Name_RU VARCHAR(30),
Middle_Name_RU VARCHAR(30),
WWID VARCHAR(8),
Business_Phone VARCHAR(12),
Business_Mobile VARCHAR(13),
PositionName VARCHAR(30),
POSITIONNAMERU VARCHAR(30),
EMPLOYEETYPE VARCHAR(50),
NetworkAccount VARCHAR(30)
);

INSERT INTO TempBOSS(LAST_NAME, FIRST_NAME, Last_Name_RU, First_Name_RU, Middle_Name_RU,WWID, Business_Phone, Business_Mobile, PositionName, POSITIONNAMERU, EMPLOYEETYPE, NetworkAccount)
VALUES ('Alexandr', 'Kulik', 'Александр', 'Васильевич', 'Кулик', '86759803', '+79687548129', '+78986058473','Employee on civil contact', 'Оператор телефона', 'Постоянно', 'alex.kulik@ghm.ru');

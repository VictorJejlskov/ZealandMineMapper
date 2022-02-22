DROP TABLE [dbo].[Leasing];
DROP TABLE [dbo].[Student];
DROP TABLE [dbo].[Room];
DROP TABLE [dbo].[Dormitory];

CREATE TABLE Dormitory(
     Dormitory_No  int  NOT NULL PRIMARY KEY,
     Name      VARCHAR(30)     NOT NULL,
     Address   VARCHAR(50)  NOT NULL
);

CREATE TABLE Room(
	 Room_No   int    NOT NULL,
     Dormitory_No  int    NOT NULL,
     Types     CHAR(1)   DEFAULT 'S',
     Price     FLOAT,
	CONSTRAINT checkType 
	CHECK (Types IN ('D','T','S') OR Types IS NULL),
	CONSTRAINT checkPrice 
	CHECK (price BETWEEN 0 AND 9999),

	FOREIGN KEY (Dormitory_No) REFERENCES Dormitory (Dormitory_No)
	ON UPDATE CASCADE ON DELETE NO ACTION,
	Primary KEY (Room_No, Dormitory_No)

);

CREATE TABLE Student (
     Student_No  int  NOT NULL PRIMARY KEY,
     Name      VARCHAR(30)      NOT NULL,
     Address   VARCHAR(50)   NOT NULL
);

CREATE TABLE Leasing(
     Leasing_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	 Dormitory_No  int   NOT NULL,
     Student_No  int   NOT NULL,
     Date_From DATE  NOT NULL,
     Date_To   DATE  NOT NULL,
     Room_No   int   NOT NULL,
     FOREIGN KEY(Student_No) REFERENCES Student(Student_No),
	 FOREIGN KEY(Room_No, Dormitory_No) REFERENCES Room(Room_No, Dormitory_No)
     on delete cascade
);

		
--ALTER TABLE Leasing 
--	ADD CONSTRAINT incorrect_dates
--       CHECK ((Date_To > Date_From) AND (Date_From >= '2019-01-01'));


INSERT INTO Dormitory   VALUES (1,'Musicon Kollegiet','Rabalderstræde  7 , Stuen 4000 Roskilde');
INSERT INTO Dormitory   VALUES (2,'Idun Kollegiet','Universitetsparken 3, Roskilde');
INSERT INTO Dormitory   VALUES (3,'Duebrødre Kollegiet','Kildehusvej 2 A, Roskilde');

INSERT INTO Room   VALUES (1,1,'D',200);
INSERT INTO Room   VALUES (2,1,'D',200);
INSERT INTO Room   VALUES (3,1,'D',200);
INSERT INTO Room   VALUES (4,1,'D',200);
INSERT INTO Room   VALUES (5,1,'S',150);
INSERT INTO Room   VALUES (6,1,'S',150);
INSERT INTO Room   VALUES (1,2,'S',150);
INSERT INTO Room   VALUES (2,2,'T',220);
INSERT INTO Room   VALUES (3,2,'T',220);
INSERT INTO Room   VALUES (4,2,'T',220);
INSERT INTO Room   VALUES (5,2,'D',230);
INSERT INTO Room   VALUES (6,2,'D',230);
INSERT INTO Room   VALUES (1,3,'D',230);
INSERT INTO Room   VALUES (2,3,'D',230);
INSERT INTO Room   VALUES (3,3,'S',180);
INSERT INTO Room   VALUES (4,3,'S',180);
INSERT INTO Room   VALUES (5,3,'T',300);
INSERT INTO Room   VALUES (6,3,'T',300);

INSERT INTO Student  VALUES( 1,'Eva','Paradisvej 3, 1111 Bispeborg');
INSERT INTO Student  VALUES( 2,'Adam','Paradisvej 7, 1111 Bispeborg');
INSERT INTO Student  VALUES( 3,'Goeg','Sunset Blvd. 8, 2222 Hjemby');
INSERT INTO Student  VALUES( 4,'Gokke', ' Sunset Blvd. 8, 2222 Hjemby');
INSERT INTO Student  VALUES( 5,'Fy','Klovnevej 87, 3333 Lilleby');
INSERT INTO Student  VALUES( 6,'Bi','Bredgade 198, 3333 Lilleby');
INSERT INTO Student  VALUES( 7,'Romeo','Kaerlighedstunellen 1, 4444 Borgerslev');
INSERT INTO Student  VALUES( 8,'Julie','Kaerlighedstuen 2,4444 Borgerslev');
INSERT INTO Student  VALUES( 9,'Godzilla','Dommervænget 16A, 4000 Roskilde');
INSERT INTO Student  VALUES(10,'KingKong','Hyrdevænget 38, 4000 Roskilde');
INSERT INTO Student  VALUES(11,'KongHans','Algade 10, 4000 Roskilde');
INSERT INTO Student  VALUES(12,'Hans'    ,'Vikingevej 45, 4000 Roskilde');
INSERT INTO Student  VALUES(13,'Poul'    ,'Domkirkevej 12, 4000 Roskilde');
INSERT INTO Student VALUES(14,'Erik'    ,'Hestetorvet 8, 4000 Roskilde');
INSERT INTO Student  VALUES(15,'Ulla'    ,'Stændertorvet 4, 4000 Roskilde');
INSERT INTO Student VALUES(16,'Yrsa'    ,'Sdr. Ringvej 21, 4000 Roskilde');
INSERT INTO Student VALUES(17,'Yvonne'  ,'Østre Ringvej 12, 4000 Roskilde');
INSERT INTO Student VALUES(18,'Tim'     ,'Ringstedgade 33, 4000 Roskilde');
INSERT INTO Student VALUES(19,'Sten'    ,'Ringstedvej 23, 4000 Roskilde');
INSERT INTO Student VALUES(20,'Erland','Skovbovængets alle 3,4000 Roskilde');
INSERT INTO Student VALUES(21,'Erwin'   ,'Ternevej 17, 4000 Roskilde');
INSERT INTO Student VALUES(22,'Åge'     ,'Solsortevej 9, 4000 Roskilde');
INSERT INTO Student VALUES(23,'Åse','Gyvelvej 45, 4000 Roskilde');
INSERT INTO Student VALUES(24,'Frede','Københavnsvej 25, 4000 Roskilde');
INSERT INTO Student VALUES(25,'Palle','Sct Ohlsgade 10, 4000 Roskilde');
INSERT INTO Student VALUES(26,'Jørn','Dronning Amaliesvej 22,4000 Roskilde');
INSERT INTO Student VALUES(27,'Stefan' ,'Lærkevej 65, 4000 Roskilde');
INSERT INTO Student VALUES(28,'John' ,'By03ken 56, 4000 Roskilde');
INSERT INTO Student VALUES(29,'Dana' ,'Byageren 12, 4000 Roskilde');
INSERT INTO Student VALUES(30,'Arn' ,'Vindingevej 23, 4000 Roskilde');
INSERT INTO Student  VALUES(31,'Adam','Hyrdevænget 24, 4000 Roskilde');
INSERT INTO Student  VALUES(32,'Patrick','Algade 11, 4000 Roskilde');
INSERT INTO Student  VALUES(33,'David'    ,'Vikingevej 78, 4000 Roskilde');
INSERT INTO Student  VALUES(34,'Simon'    ,'Domkirkevej 09, 4000 Roskilde');
INSERT INTO Student VALUES(35,'Ulrik'    ,'Hestetorvet 18, 4000 Roskilde');
INSERT INTO Student  VALUES(36,'Anna'    ,'Stændertorvet 4, 4000 Roskilde');
INSERT INTO Student VALUES(37,'Martin' ,'Sdr. Ringgade 21, 4000 Roskilde');
INSERT INTO Student VALUES(38,'Digna'  ,' Ringvej 32, 4000 Roskilde');
INSERT INTO Student VALUES(39,'Timoty' ,'Ringstedgade 83, 4000 Roskilde');
INSERT INTO Student VALUES(40,'Stine'    ,'Ringstedvej 13, 4000 Roskilde');
INSERT INTO Student VALUES(41,'Kevin','Skovbovængets alle 13,4000 Roskilde');
INSERT INTO Student VALUES(42,'Sophus'   ,'Ternevej 47, 4000 Roskilde');
INSERT INTO Student VALUES(43,'Annis' ,'Solsortevej 19, 4000 Roskilde');
INSERT INTO Student VALUES(44,'Dulce','Gyvelvej 13, 4000 Roskilde');
INSERT INTO Student VALUES(45,'Frederik','Københavnsvej 24, 4000 Roskilde');
INSERT INTO Student VALUES(46,'Kalle','Sct Ohlsgade 40, 4000 Roskilde');
INSERT INTO Student VALUES(47,'Jean','Dronning Amaliesvej 23,4000 Roskilde');
INSERT INTO Student VALUES(48,'Stefanie' ,'Lærkevej 85, 4000 Roskilde');
INSERT INTO Student VALUES(49,'Johny' ,'By03ken 66, 4000 Roskilde');
INSERT INTO Student VALUES(50,'Dania' ,'Byageren 32, 4000 Roskilde');
INSERT INTO Student VALUES(51,'Arnold' ,'Vindingevej 83, 4000 Roskilde');

INSERT INTO Leasing VALUES(1, 3,'2019-01-01','2019-06-30',01);
INSERT INTO Leasing VALUES(1, 3,'2019-07-01','2019-12-31',01);
INSERT INTO Leasing VALUES(2, 3,'2020-01-01','2020-06-30',01);
INSERT INTO Leasing VALUES(3, 3,'2020-07-01','2020-12-31',01);
INSERT INTO Leasing VALUES(1, 2,'2019-01-01','2019-06-30',02);
INSERT INTO Leasing VALUES(1, 2,'2019-07-01','2019-12-31',02);
INSERT INTO Leasing VALUES(2, 2,' 2020-01-01','2020-06-30',02);
INSERT INTO Leasing VALUES(3, 2,'2020-07-01','2020-12-31',02);
INSERT INTO Leasing VALUES(1, 4,'2019-01-01','2019-06-30',03);
INSERT INTO Leasing VALUES(1, 4,'2019-07-01','2019-12-31',03);
INSERT INTO Leasing VALUES(2, 4,'2020-01-01','2020-06-30',03);
INSERT INTO Leasing VALUES(3, 4,'2020-07-01','2020-12-31',03);
INSERT INTO Leasing VALUES(1, 1,'2019-01-01','2019-06-30',04);
INSERT INTO Leasing VALUES(1, 1,'2019-07-01','2019-12-31',04);
INSERT INTO Leasing VALUES(2, 1,'2020-01-01','2020-06-30',04);
INSERT INTO Leasing VALUES(3, 1,'2020-07-01','2020-12-31',04);
INSERT INTO Leasing VALUES(1, 5,'2019-01-01','2019-06-30',05);
INSERT INTO Leasing VALUES(1, 5,'2019-07-01','2019-12-31',05);
INSERT INTO Leasing VALUES(2, 5,'2020-01-01','2020-06-30',05);
INSERT INTO Leasing VALUES(3, 5,'2020-07-01','2020-12-31',05);
INSERT INTO Leasing VALUES(1, 6,'2019-01-01','2019-06-30',06);
INSERT INTO Leasing VALUES(1, 6,'2019-07-01','2019-12-31',06);
INSERT INTO Leasing VALUES(2, 6,'2020-01-01','2020-06-30',06);
INSERT INTO Leasing VALUES(3, 6,'2020-07-01','2020-12-31',06);
INSERT INTO Leasing VALUES(2, 7,'2019-01-01','2019-06-30',01);
INSERT INTO Leasing VALUES(2, 7,'2019-07-01','2019-12-31',01);
INSERT INTO Leasing VALUES(3, 7,'2020-01-01','2020-06-30',01);
INSERT INTO Leasing VALUES(1, 7,'2020-07-01','2020-12-31',01);
INSERT INTO Leasing VALUES(2, 8,'2019-01-01','2019-06-30',02);
INSERT INTO Leasing VALUES(2, 8,'2019-07-01','2019-12-31',02);
INSERT INTO Leasing VALUES(3, 8,'2020-01-01','2020-06-30',02);
INSERT INTO Leasing VALUES(1, 8,'2020-07-01','2020-12-31',02);
INSERT INTO Leasing VALUES(2, 9,'2019-01-01','2019-06-30',03);
INSERT INTO Leasing VALUES(2, 9,'2019-07-01','2019-12-31',03);
INSERT INTO Leasing VALUES(3, 9,'2020-01-01','2020-06-30',03);
INSERT INTO Leasing VALUES(1, 9,'2020-07-01','2020-12-31',03);
INSERT INTO Leasing VALUES(2, 10,'2019-01-01','2019-06-30',04);
INSERT INTO Leasing VALUES(2, 10,'2019-07-01','2019-12-31',04);
INSERT INTO Leasing VALUES(3, 10,'2020-01-01','2020-06-30',04);
INSERT INTO Leasing VALUES(1, 10,'2020-07-01','2020-12-31',04);
INSERT INTO Leasing VALUES(2, 11,'2019-01-01','2019-06-30',05);
INSERT INTO Leasing VALUES(2, 11,'2019-07-01','2019-12-31',05);
INSERT INTO Leasing VALUES(3, 11,'2020-01-01','2020-06-30',05);
INSERT INTO Leasing VALUES(1, 11,'2020-07-01','2020-12-31',05);
INSERT INTO Leasing VALUES(2, 12,'2019-01-01','2019-06-30',06);
INSERT INTO Leasing VALUES(2, 12,'2019-07-01','2019-12-31',06);
INSERT INTO Leasing VALUES(3, 12,'2020-01-01','2020-06-30',06);
INSERT INTO Leasing VALUES(1, 12,'2020-07-01','2020-12-31',06);
INSERT INTO Leasing VALUES(3, 13,'2019-01-01','2019-06-30',01);
INSERT INTO Leasing VALUES(3, 13,'2019-07-01','2019-12-31',01);
INSERT INTO Leasing VALUES(1, 13,'2020-01-01','2020-06-30',01);
INSERT INTO Leasing VALUES(2, 13,'2020-07-01','2020-12-31',01);
INSERT INTO Leasing VALUES(3, 14,'2019-01-01','2019-06-30',02);
INSERT INTO Leasing VALUES(3, 14,'2019-07-01','2019-12-31',02);
INSERT INTO Leasing VALUES(1, 14,'2020-01-01','2020-06-30',02);
INSERT INTO Leasing VALUES(2, 14,'2020-07-01','2020-12-31',02);
INSERT INTO Leasing VALUES(3, 15,'2019-01-01','2019-06-30',04);
INSERT INTO Leasing VALUES(3, 15,'2019-07-01','2019-12-31',04);
INSERT INTO Leasing VALUES(1, 15,'2020-01-01','2020-06-30',04);
INSERT INTO Leasing VALUES(2, 15,'2020-07-01','2020-12-31',04);
INSERT INTO Leasing VALUES(3, 16,'2019-01-01','2019-06-30',05);
INSERT INTO Leasing VALUES(3, 16,'2019-07-01','2019-12-31',05);
INSERT INTO Leasing VALUES(1, 16,'2020-01-01','2020-06-30',05);
INSERT INTO Leasing VALUES(2, 16,'2020-07-01','2020-12-31',05);
INSERT INTO Leasing VALUES(3, 17,'2019-01-01','2019-06-30',06);
INSERT INTO Leasing VALUES(3, 17,'2019-07-01','2019-12-31',06);
INSERT INTO Leasing VALUES(1, 17,'2020-01-01','2020-06-30',06);
INSERT INTO Leasing VALUES(2, 17,'2020-07-01','2020-12-31',06);
INSERT INTO Leasing VALUES(3, 18,'2019-01-01','2019-06-30',03);
INSERT INTO Leasing VALUES(3, 18,'2019-07-01','2019-12-31',03);
INSERT INTO Leasing VALUES(1, 18,'2020-01-01','2020-06-30',03);
INSERT INTO Leasing VALUES(2, 18,'2020-07-01','2020-12-31',03);






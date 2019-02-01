USE master;
go
BEGIN
    IF OBJECT_ID('tblConge') IS NOT NULL
        DROP TABLE tblConge;
    ELSE IF OBJECT_ID('Personnel') IS NOT NULL
		DROP TABLE Personnel;
    ELSE IF OBJECT_ID('tblusers') IS NOT NULL
		DROP TABLE tblusers;
END
GO

BEGIN
    IF EXISTS (SELECT name FROM sys.databases WHERE name = 'CongeDB')
        DROP DATABASE CongeDB;
END

CREATE DATABASE CongeDB;
GO
USE CongeDB;
GO
--BEGIN
--IF OBJECT_ID('tblUSERS') IS NOT NULL 
--    DROP TABLE tblusers 
--END
 

CREATE TABLE tblusers (
    iduser INT IDENTITY (1, 1),
    username VARCHAR (15),
    pass VARCHAR (15) NOT NULL 
	CONSTRAINT PK_Users PRIMARY KEY (iduser, username, pass)
	);

INSERT INTO tblUSERS (UserName, Pass) VALUES ('admin', 'admin');
INSERT INTO tblUSERS (UserName, Pass) VALUES ('Abde', 'Abde');

--select * from tblusers
CREATE TABLE Personnel (
    Matricule INT PRIMARY KEY,
    Nom_Prenom VARCHAR (60) NOT NULL,
    CIN_Perso VARCHAR (15) NOT NULL,
    Genre_Perso VARCHAR (10),
    AnneeNaissance_Perso DATEtime,
    LieuNaissance_Perso VARCHAR (350),
    Situtation_Familiale VARCHAR (20),
    Nombre_Enfants INT,
    Diplome VARCHAR (300),
    Date_Recrutement DATEtime,
    Adresse_Perso VARCHAR (300),
	ServiceDeTravail VARCHAR (300),
    Tele_Portable VARCHAR (11));

--select* from Personnel where Code_Service=1 
INSERT INTO Personnel (Matricule, Nom_Prenom, CIN_Perso, Genre_Perso, AnneeNaissance_Perso, LieuNaissance_Perso, Situtation_Familiale, Nombre_Enfants, Diplome, Date_Recrutement, Adresse_Perso, Tele_Portable)
VALUES               (54825, 'Mr Unknown ', 'JM2017', 'Femme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place' , '654'),
(101010, 'Mr Unknown ', 'JM2017', 'Femme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place' , '44444444'),
(101011, 'Mr Unknown ', 'JM2017', 'Homme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place' , '544'),
(101012, 'Mr Unknown ', 'JM2017', 'Femme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',   '45645'),
(101013, 'Mr Unknown ', 'JM2017', 'Homme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',   '5666645'),
(101014, 'Mr Unknown ', 'JM2017', 'Femme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',   '456'),
(101015, 'Mr Unknown ', 'JM2017', 'Homme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',   '4564569'),
(101016, 'Mr Unknown ', 'JM2017', 'Femme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',   '776465'),
(101017, 'Mr Unknown ', 'JM2017', 'Homme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',   '6544'),
(101018, 'Mr Unknown ', 'JM2017', 'Femme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',  '88654'),
(101019, 'Mr Unknown ', 'JM2017', 'Homme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',  '2131235'),
(101020, 'Mr Unknown ', 'JM2017', 'Homme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place', '6464567'),
(101021, 'Mr Unknown ', 'JM2017', 'Femme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',   '687687687'),
(101022, 'Mr Unknown ', 'JM2017', 'Homme', '1989-01-23', 'Some Where', 'CELIBATAIRE', 0, 'Diplôme technique supérieur', '2013-02-01', 'The Other Place',   '78786286');

--select * from Personnel join Situtation on Personnel.Matricule=Situtation.Matricule
CREATE TABLE tblConge (
    Num_Conge INT IDENTITY (1, 1) PRIMARY KEY,
    Matricule INT FOREIGN KEY REFERENCES Personnel (Matricule) ON DELETE SET NULL ,
    Duree_Conge INT CHECK (Duree_Conge >= 1),
    Debut_Conge DATE NOT NULL,
    Reprise_De_Service DATE NOT NULL,
    TypeConge VARCHAR (100) );
    --CONSTRAINT CHK_Date CHECK (DATEDIFF(day, Debut_Conge, Reprise_De_Service) >= 1));

--select * from tblConge
INSERT  INTO tblConge (Matricule, Debut_Conge, Reprise_De_Service, Duree_Conge)
VALUES               (101010, '2017-11-13', '2017-11-25', 4),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12'),
(101015, '2016-07-04', '2016-07-25', '12');





-- INSERT INTO tblConge (Matricule, Debut_Conge,Fin_Conge, Reprise_De_Service, Duree_Conge, Code_TypeConge)
--  VALUES (101015, '2017-03-18', '2017-03-17','2017-03-17', '12', '1');
--select * from tblConge
-- INSERT INTO tblConge (Matricule, Debut_Conge,Fin_Conge, Reprise_De_Service, Duree_Conge, Code_TypeConge)
--  VALUES (101015, '2017-03-20', '2017-03-22','2017-03-22', '12', '1');
--select * from tblConge
--SELECT IDENT_CURRENT('tblConge') --8998
--select * from tblConge
/*
* Le premier déclencheur est utilisé pour insérer le nom en majuscules
*Le second déclencheur est utilisée pour vérifier les dates s'ils sont logiques
*/
--go
go
CREATE TRIGGER ToUpperCase
ON Personnel
for INSERT, UPDATE
AS
BEGIN
  UPDATE Personnel SET Nom_Prenom = UPPER(Nom_Prenom)
	WHERE Matricule = (SELECT Matricule FROM inserted)
END

--go
--create trigger setDuree
--on tblConge 
--for insert,update
--as
--begin
-- 		declare @startDate Date,@endDate date,@duree int
--		select @startDate=(select Debut_Conge from inserted),@endDate=(select Reprise_De_Service from inserted)
--		set @duree=(DATEDIFF(DAY,@startDate,@endDate))
--				update tblConge set Duree_Conge=@duree where Num_Conge=(select Num_Conge from inserted)	 
--end

--go
--CREATE TRIGGER DateCheck
--ON tblConge
--for insert, UPDATE
--AS
--BEGIN
--	DECLARE @start AS date,
--			  @end AS date,
--			  @restart AS date
--	SET @start= (SELECT Debut_Conge FROM inserted)
--	SET @end = (SELECT Fin_Conge FROM inserted)
--	SET @restart= (SELECT Reprise_De_Service FROM inserted)
--	IF DATEDIFF(day, @start,@end)<=0
--		BEGIN
--			ROLLBACK
--			print'INSERTION OU UPDATE ECHEOU'
--		END
--END
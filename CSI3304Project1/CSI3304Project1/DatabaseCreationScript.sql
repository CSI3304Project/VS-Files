USE ImageBaseDataBase;
CREATE TABLE tblUser
(	userUsername varchar(20) NOT NULL,
	userPassword varchar(50) NOT NULL,
	userFirstName varchar(30) NOT NULL,
	userLastName varchar(30) NOT NULL,
	userEmail varchar(64) NOT NULL,
	userType varchar(10) NOT NULL,
	PRIMARY KEY (userUsername)
);

INSERT INTO tblUser
VALUES 	('aaronmoore', 'aaronmoore', 'Aaron', 'Moore', 'aaronmoore@imagebase.com', 'admin'),
		('cameronpilapil', 'cameronpilapil', 'Cameron', 'Pilapil', 'cameronpilapil@imagebase.com', 'admin'),
		('jacksmith', 'jacksmith', 'Jack', 'Smith', 'jacksmith@imagebase.com', 'moderator'),
		('matthewjenkins', 'mattherjenkins', 'Matthew', 'Jenkins', 'matthewjenkins@provider.com', 'provider'),
		('kellymichaels', 'kellymichaels', 'Kelly', 'Michaels', 'kellymichaels@consumer.com', 'consumer');
		
CREATE TABLE tblImage
(
	imgImageID int NOT  NULL,
	imgImageName varchar(30) NOT NULL,
	imgUploadDate varchar(10) NOT NULL,
	imgProvider varchar(20) NOT NULL,
	imgStatus varchar(12) NOT NULL,
	imgImageFile blob NULL,
	PRIMARY KEY (imgImageID)
);

INSERT INTO tblImage(imgImageID, imgImageName, imgUploadDate, imgProvider, imgStatus)
VALUES 	(0001, 'cat', '10/10/2014', 'matthewjenkins', 'approved'),
		(0001, 'dog', '10/10/2014', 'matthewjenkins', 'unmoderated'),
		(0001, 'bird', '10/10/2014', 'matthewjenkins', 'rejected');

CREATE TABLE tblDownloads
(
	dnldImageID int NOT NULL,
	dnldUsername varchar(20) NOT NULL,
	dnldDownloadTime datetime NOT NULL,
	FOREIGN KEY (dnldImageID) REFERENCES tblImage(imgImageID),
	FOREIGN KEY (dnldUsername) REFERENCES tblUser(userUsername)
);

CREATE TABLE tblTags
(
	tagTagName varchar(20),
	PRIMARY KEY (tagTagName)
);

INSERT INTO tblTags
VALUES	('animal'),
		('cat'),
		('dog'),
		('bird'),
		('fun'),
		('fur'),
		('feathers');
	
CREATE TABLE tblImageTags
(
	imgtagImageID int NOT NULL,
	imgtagTagName varchar(20) NOT NULL,
	FOREIGN KEY (imgtagTagName) REFERENCES tblTags(tagTagName),
	FOREIGN KEY (imgtagImageID) REFERENCES tblImage(imgImageID)
);

INSERT INTO tblImageTags
VALUES	(0001, 'animal'),
		(0001, 'cat'),
		(0001, 'fun'),
		(0001, 'fur'),
		(0002, 'animal'),
		(0002, 'dog'),
		(0002, 'fun'),
		(0002, 'fur'),
		(0003, 'animal'),
		(0003, 'bird'),
		(0003, 'fun'),
		(0003, 'feathers');
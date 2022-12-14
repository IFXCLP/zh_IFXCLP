create table [dbo].[Posztok] (
[posztID] int NOT NULL PRIMARY KEY,
[poszt] nvarchar(15) not null,
)

create table [dbo].[Nemzetisegek] (
[nemzetisegID] int NOT NULL PRIMARY KEY,
[nemzetiseg] nvarchar(15),
)

create table [dbo].[Jatekosok] (
[ID] int NOT NULL PRIMARY KEY Identity (1,1),

[nemzetisegID] int NOT NULL FOREIGN KEY references Nemzetisegek(nemzetisegID),
[posztID] int NOT NULL FOREIGN KEY references Posztok(posztID),
[sarga] int NOT NULL,
)


insert into Posztok (posztID,poszt) values(1,'védő ')
insert into Posztok (posztID,poszt) values(2,'kapus')
insert into Posztok (posztID,poszt) values(3,'középpályás')
insert into Posztok (posztID,poszt) values(4,'támadó')



insert into Nemzetisegek (nemzetisegID,nemzetiseg) values(1,'Franciaország')
insert into Nemzetisegek (nemzetisegID,nemzetiseg) values(2,'Brazília')
insert into Nemzetisegek (nemzetisegID,nemzetiseg) values(3,'Anglia')
insert into Nemzetisegek (nemzetisegID,nemzetiseg) values(4,'Olaszország')
insert into Nemzetisegek (nemzetisegID,nemzetiseg) values(5,'Spanyolország')
insert into Nemzetisegek (nemzetisegID,nemzetiseg) values(6,'Magyarország')
insert into Nemzetisegek (nemzetisegID,nemzetiseg) values(7,'Argentína')
insert into Nemzetisegek (nemzetisegID,nemzetiseg) values(8,'Portugália')


insert into Jatekosok (nemzetisegID,posztID,sarga) values(6,'4','2')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(5,'3','0')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(5,'2','3')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(3,'1','1')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(7,'4','0')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(1,'4','2')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(2,'1','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(6,'4','1')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(3,'2','3')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(1,'3','3')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(8,'4','3')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(6,'4','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(7,'4','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(1,'1','1')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(2,'2','2')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(5,'2','3')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(3,'3','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(3,'4','0')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(1,'2','0')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(3,'2','0')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(7,'2','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(6,'4','2')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(4,'2','0')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(1,'2','0')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(1,'4','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(8,'1','1')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(3,'3','3')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(2,'1','0')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(5,'4','1')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(2,'1','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(2,'1','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(7,'2','3')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(8,'2','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(2,'2','4')
insert into Jatekosok (nemzetisegID,posztID,sarga) values(2,'1','4')
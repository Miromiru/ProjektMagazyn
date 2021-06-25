CREATE database MagazynDB;

use MagazynDB;
CREATE TABLE paczka (
    nrPaczki varchar(4) NOT NULL PRIMARY KEY,
    nazwaPaczki varchar(25) NOT NULL,
    wielkoscPaczki int,
	skad varchar(25),
	dokad varchar(25),
	stan varchar(25),
	czasOdebrania date,
	czasWyslania date,
	czasZamowienia date
);

use MagazynDB;	
INSERT INTO paczka (nrPaczki, nazwaPaczki, wielkoscPaczki,skad, stan, czasOdebrania)
VALUES ('2137', 'Kamień', 7, 'Sanok', 'Odebrana', '2021-06-10');
INSERT INTO paczka (nrPaczki, nazwaPaczki, wielkoscPaczki,dokad, stan, czasWyslania)
VALUES ('1234', 'Bruk', 3, 'Rzeszów', 'Wysłana', '2021-06-13');
INSERT INTO paczka (nrPaczki, nazwaPaczki, wielkoscPaczki,skad, stan, czasZamowienia )
VALUES ('1555', 'Paleta', 10, 'Stalowa Wola', 'Zamówiona', '2021-06-18' );

use MagazynDB;
select * from paczka;
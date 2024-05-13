-- liquibase formatted sql

-- changeset samuel-pospisil:0001
-- tables
-- Table: Bankovni_ucet
CREATE TABLE Bankovni_ucet (
    cislo varchar(16)  NOT NULL,
    kod_banky varchar(4)  NOT NULL,
    CONSTRAINT Bankovni_ucet_pk PRIMARY KEY  (cislo)
);

-- Table: Emisni_trida
CREATE TABLE Emisni_trida (
    emisni_trida char(1)  NOT NULL,
    CONSTRAINT Emisni_trida_pk PRIMARY KEY  (emisni_trida)
);

-- Table: Firma
CREATE TABLE Firma (
    nazev nvarchar(30)  NOT NULL,
    ico nvarchar(8)  NOT NULL,
    adresa nvarchar(40)  NOT NULL,
    CONSTRAINT Firma_pk PRIMARY KEY  (ico)
);

-- Table: Hmotnost_hodnoty
CREATE TABLE Hmotnost_hodnoty (
    nazev float(24)  NOT NULL,
    CONSTRAINT Hmotnost_hodnoty_pk PRIMARY KEY  (nazev)
);

-- Table: Platba
CREATE TABLE Platba (
    id int  NOT NULL IDENTITY(1, 1),
    spz varchar(8)  NOT NULL,
    datum datetime  NOT NULL,
    castka money  NOT NULL,
    cislo_karty varchar(19)  NULL,
    cislo_uctu varchar(16)  NULL,
    CONSTRAINT Platba_pk PRIMARY KEY  (id)
);

-- Table: Platebni_karta
CREATE TABLE Platebni_karta (
    cislo varchar(19)  NOT NULL,
    platnost date  NOT NULL,
    vlastnik varchar(40)  NOT NULL,
    CONSTRAINT cislo PRIMARY KEY  (cislo)
);

-- Table: Typ_vozidla
CREATE TABLE Typ_vozidla (
    typ nvarchar(10)  NOT NULL,
    CONSTRAINT Typ_vozidla_pk PRIMARY KEY  (typ)
);

-- Table: Vozidlo
CREATE TABLE Vozidlo (
    spz varchar(8)  NOT NULL,
    firma_ico nvarchar(8)  NOT NULL,
    hmotnost real  NOT NULL,
    typ_vozidla nvarchar(10)  NOT NULL,
    emisni_trida char(1)  NOT NULL,
    km_sazba smallmoney  NOT NULL,
    CONSTRAINT Vozidlo_pk PRIMARY KEY  (spz)
);

-- foreign keys
-- Reference: Platba_Bankovni_ucet (table: Platba)
ALTER TABLE Platba ADD CONSTRAINT Platba_Bankovni_ucet
    FOREIGN KEY (cislo_uctu)
    REFERENCES Bankovni_ucet (cislo);

-- Reference: Platba_Karta (table: Platba)
ALTER TABLE Platba ADD CONSTRAINT Platba_Karta
    FOREIGN KEY (cislo_karty)
    REFERENCES Platebni_karta (cislo);

-- Reference: Platba_Vozidlo (table: Platba)
ALTER TABLE Platba ADD CONSTRAINT Platba_Vozidlo
    FOREIGN KEY (spz)
    REFERENCES Vozidlo (spz);

-- Reference: Vozidlo_Emisni_trida (table: Vozidlo)
ALTER TABLE Vozidlo ADD CONSTRAINT Vozidlo_Emisni_trida
    FOREIGN KEY (emisni_trida)
    REFERENCES Emisni_trida (emisni_trida)
    ON UPDATE  CASCADE;

-- Reference: Vozidlo_Firma (table: Vozidlo)
ALTER TABLE Vozidlo ADD CONSTRAINT Vozidlo_Firma
    FOREIGN KEY (firma_ico)
    REFERENCES Firma (ico)
    ON UPDATE  CASCADE;

-- Reference: Vozidlo_Hmotnost_hodnoty (table: Vozidlo)
ALTER TABLE Vozidlo ADD CONSTRAINT Vozidlo_Hmotnost_hodnoty
    FOREIGN KEY (hmotnost)
    REFERENCES Hmotnost_hodnoty (nazev)
    ON UPDATE  CASCADE;

-- Reference: Vozidlo_Typ_vozidla (table: Vozidlo)
ALTER TABLE Vozidlo ADD CONSTRAINT Vozidlo_Typ_vozidla
    FOREIGN KEY (typ_vozidla)
    REFERENCES Typ_vozidla (typ)
    ON UPDATE  CASCADE;



-- changeset samuel-pospisil:0002
-- insert triggers
CREATE TRIGGER tr_vozidlo
ON Vozidlo
INSTEAD OF INSERT AS
BEGIN
    INSERT INTO Typ_vozidla (typ)
    SELECT DISTINCT typ_vozidla FROM inserted WHERE typ_vozidla NOT IN (SELECT typ FROM Typ_vozidla)

    INSERT INTO Hmotnost_hodnoty (nazev)
    SELECT DISTINCT hmotnost FROM inserted WHERE hmotnost NOT IN (SELECT nazev FROM Hmotnost_hodnoty)

    INSERT INTO Emisni_trida (emisni_trida)
    SELECT DISTINCT emisni_trida FROM inserted WHERE emisni_trida NOT IN (SELECT emisni_trida FROM Emisni_trida)

	MERGE Vozidlo USING inserted
	ON (Vozidlo.spz = inserted.spz)
	WHEN MATCHED
		THEN UPDATE SET Vozidlo.firma_ico = inserted.firma_ico,
                        Vozidlo.hmotnost = inserted.hmotnost,
                        Vozidlo.typ_vozidla = inserted.typ_vozidla, 
                        Vozidlo.emisni_trida = inserted.emisni_trida,
                        Vozidlo.km_sazba = inserted.km_sazba
	WHEN NOT MATCHED BY TARGET
		THEN INSERT (spz, firma_ico, hmotnost, typ_vozidla, emisni_trida, km_sazba) 
		VALUES (inserted.spz, inserted.firma_ico, inserted.hmotnost, inserted.typ_vozidla, inserted.emisni_trida, inserted.km_sazba);
END

GO
CREATE TRIGGER tr_firma
ON Firma
INSTEAD OF INSERT AS
BEGIN
	MERGE Firma USING inserted
	ON (Firma.ico = inserted.ico)
	WHEN MATCHED
		THEN UPDATE SET Firma.nazev = inserted.nazev, Firma.adresa = inserted.adresa
	WHEN NOT MATCHED BY TARGET
		THEN INSERT (nazev, ico, adresa) VALUES (inserted.nazev, inserted.ico, inserted.adresa);
END

-- changeset samuel-pospisil:0003
-- insert triggers 
CREATE TRIGGER tr_platebni_karta
ON Platebni_karta
INSTEAD OF INSERT AS
BEGIN
	MERGE Platebni_karta USING inserted
	ON (Platebni_karta.cislo = inserted.cislo)
	WHEN NOT MATCHED BY TARGET
		THEN INSERT (cislo, platnost, vlastnik) VALUES (inserted.cislo, inserted.platnost, inserted.vlastnik);
END

GO
CREATE TRIGGER tr_bankovni_ucet
ON Bankovni_ucet
INSTEAD OF INSERT AS
BEGIN
	MERGE Bankovni_ucet USING inserted
	ON (Bankovni_ucet.cislo = inserted.cislo)
	WHEN NOT MATCHED BY TARGET
		THEN INSERT (cislo, kod_banky) VALUES (inserted.cislo, inserted.kod_banky);
END
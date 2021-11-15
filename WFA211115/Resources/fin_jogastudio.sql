-- CREATE DATABASE jogastudio;
-- USE jogastudio;

CREATE TABLE tagok(
id INT PRIMARY KEY IDENTITY,
nev VARCHAR(50),
mester BIT);

CREATE TABLE pozok(
id INT PRIMARY KEY IDENTITY,
nev VARCHAR(50));

CREATE TABLE beosztas(
id INT PRIMARY KEY IDENTITY,
idopont DATETIME,
instruktor INT FOREIGN KEY REFERENCES tagok(id),
diakok VARCHAR(50) NULL,
tananyag INT FOREIGN KEY REFERENCES pozok(id));

INSERT INTO tagok VALUES
('Austen Holcomb', 0),
('Ralphy Vega', 0),
('Lee Horton', 1),
('Kelan Fox', 0),
('Kye Dickerson', 0),
('Shyla Hicks', 1),
('Aston Betts', 0),
('Griffin Harding', 0),
('Johnathan Xiong', 0),
('Ema Salter', 1),
('Roxanne Abbott', 0),
('Cohen Delgado', 1),
('Anika Bernard', 1),
('Edgar Whitley', 0),
('Demi-Leigh Marquez', 0),
('Elana Luna', 0),
('Muhammed West', 1),
('Parker Coulson', 0),
('Olive Terrell', 0),
('Avneet Valenzuela', 0),
('Luther Lake', 0),
('Oluwatobiloba Franks', 1),
('Millie-Rose Humphries', 0);

INSERT INTO pozok VALUES
('Tadászana'),
('Vriksászana'),
('Szantólanászana'),
('Ustrászana'),
('Kasjapászana'),
('Savászana'),
('Márdzsárászana'),
('Vaszisthászana');

INSERT INTO beosztas VALUES 
('2020-06-11 16:00:00', 10, '2-7-11-17', 2);
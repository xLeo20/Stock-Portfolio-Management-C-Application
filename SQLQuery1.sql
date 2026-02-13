CREATE TABLE Actiuni (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Simbol NVARCHAR(10) NOT NULL,
    Denumire NVARCHAR(50) NOT NULL,
    Sector NVARCHAR(50) NOT NULL,
    PretCurent DECIMAL(18,2) NOT NULL,
    NumarActiuni INT NOT NULL,
    DataActualizare DATETIME NOT NULL
);

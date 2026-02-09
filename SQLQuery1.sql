CREATE TABLE Income (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Amount DECIMAL(10,2) NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    IncomeDate DATE NOT NULL,
    Description NVARCHAR(255),

    Date_Insert DATETIME NOT NULL DEFAULT GETDATE(),
    Date_Update DATETIME NULL,
    Date_Delete DATETIME NULL
);

CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    Date_Register DATETIME DEFAULT GETDATE()
);


select * from Users

select * from Income

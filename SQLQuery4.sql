CREATE TABLE Expense (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Amount DECIMAL(10,2) NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    ExpenseDate DATE NOT NULL,
    Description NVARCHAR(255),
    Status NVARCHAR(20) NOT NULL
        CHECK (Status IN ('Pending', 'Completed', 'Cancelled')),
    Date_Insert DATE DEFAULT GETDATE(),
    Date_Delete DATE NULL
);


SELECT * FROM Expense;


Select * from Users

select * from Income

SELECT MONTH(IncomeDate) AS Month, SUM(Amount) AS Total
FROM Income
WHERE Date_Delete IS NULL
GROUP BY MONTH(IncomeDate)
ORDER BY Month;

SELECT MONTH(ExpenseDate) AS Month, SUM(Amount) AS Total
FROM Expense
WHERE Date_Delete IS NULL
GROUP BY MONTH(ExpenseDate)
ORDER BY Month;

SELECT Id, Date_Delete FROM Expense;

SELECT Id, ExpenseDate FROM Expense;

UPDATE Expense
SET ExpenseDate = GETDATE()
WHERE ExpenseDate IS NULL;


CREATE TABLE Budget (
    Id INT IDENTITY(1,1) PRIMARY KEY,

    UserId INT NOT NULL,

    BudgetMonth INT NOT NULL
        CHECK (BudgetMonth BETWEEN 1 AND 12),

    BudgetYear INT NOT NULL,

    Amount DECIMAL(10,2) NOT NULL
        CHECK (Amount > 0),

    Date_Set DATE DEFAULT GETDATE(),

    CONSTRAINT UQ_User_Month_Year
        UNIQUE (UserId, BudgetMonth, BudgetYear)
);


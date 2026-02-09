SELECT TOP 5 *
FROM (
    SELECT 
        'Income' AS Type,
        Amount,
        Category,
        IncomeDate AS TranDate
    FROM Income
    WHERE Date_Delete IS NULL

    UNION ALL

    SELECT
        'Expense' AS Type,
        Amount,
        Category,
        ExpenseDate AS TranDate
    FROM Expense
    WHERE Date_Delete IS NULL
) AS T
ORDER BY TranDate DESC;


SELECT * FROM Income;
SELECT * FROM Expense;

SELECT IncomeDate, Amount FROM Income;


SELECT 
    DATENAME(MONTH, IncomeDate) AS MonthName,
    SUM(Amount) AS Total
FROM Income
WHERE Date_Delete IS NULL
GROUP BY DATENAME(MONTH, IncomeDate), MONTH(IncomeDate)
ORDER BY MONTH(IncomeDate);


SELECT 
    DATENAME(MONTH, ExpenseDate) AS MonthName,
    SUM(Amount) AS Total
FROM Expense
WHERE Date_Delete IS NULL
GROUP BY DATENAME(MONTH, ExpenseDate), MONTH(ExpenseDate)
ORDER BY MONTH(ExpenseDate);


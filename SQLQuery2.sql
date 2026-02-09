SELECT Category, SUM(Amount) AS TotalAmount
FROM Income
WHERE Date_Delete IS NULL
GROUP BY Category



SELECT Max(Salary)
FROM Employees
WHERE Salary < (SELECT Max(Salary) FROM Employees)


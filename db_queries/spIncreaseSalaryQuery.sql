CREATE PROCEDURE dbo.spIncreaseSalary
@EmployeeNo int, @percentage float
AS
BEGIN 
UPDATE Employees
SET Salary = Salary*(1 + (@percentage/100))
WHERE EmployeeNo=@EmployeeNo
END
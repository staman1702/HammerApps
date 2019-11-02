CREATE PROCEDURE dbo.spIncreaseSalary
@EmployeeNo int, @coeficient float
AS
BEGIN 
UPDATE Employees
SET Salary = Salary*@coeficient
WHERE EmployeeNo=@EmployeeNo
END
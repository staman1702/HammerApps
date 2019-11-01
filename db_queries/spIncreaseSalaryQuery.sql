create procedure dbo.spIncreaseSalary
@EmployeeNo int, @coeficient float
as
begin 
update Employees
set Salary = Salary*@coeficient
where EmployeeNo=@EmployeeNo
end
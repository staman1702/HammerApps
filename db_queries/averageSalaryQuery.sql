select Round(Avg(Salary),2)
from Employees join Departments
on Employees.DepartmentNo = Departments.DepartmentNo
where DepartmentLocation !='London'
create view vwDepartment 
as
select DepartmentNo as departmentNo, 
DepartmentName + ' ' + DepartmentLocation as departmentDescription
from Departments
go
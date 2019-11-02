SELECT Round(Avg(Salary),2)
FROM Employees join Departments
ON Employees.DepartmentNo = Departments.DepartmentNo
WHERE DepartmentLocation !='London'
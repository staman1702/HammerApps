CREATE VIEW vwDepartment 
AS
SELECT DepartmentNo AS departmentNo, 
DepartmentName + ' ' + DepartmentLocation AS departmentDescription
FROM Departments
GO
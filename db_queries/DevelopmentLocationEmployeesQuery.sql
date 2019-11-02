SELECT DepartmentLocation, 
COUNT(CASE DepartmentName WHEN 'Development' THEN 1 ELSE null END) AS DevelopmentEmployees
FROM Departments JOIN Employees
ON Employees.DepartmentNo = Departments.DepartmentNo
GROUP BY DepartmentLocation

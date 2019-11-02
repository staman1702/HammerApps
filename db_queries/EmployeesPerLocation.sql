    SELECT COUNT(EmployeeNo) as NumberOfEmployees, DepartmentLocation 
      FROM Employees JOIN Departments
	  ON Employees.EmployeeNo=Departments.DepartmentNo
     GROUP BY DepartmentLocation
	 HAVING COUNT(EmployeeNo) > 1
	 ORDER BY NumberOfEmployees DESC
	 
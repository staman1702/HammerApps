# HammerApps
Hammer - Candidate Project

* Create a new database "Company", add tables "Department" and "Employee"

* Create standard application with CRUD data entry/edit (Add New/Edit/Delete) forms for Departments and Employees and fill the tables with the data from page 1.
  Choosee technology between WinForms/WPF/Angular/React/Vue.JS/ASP.NET/JS . Choose pattern freely (monolith, client-server, MVC, MVVM,...)
  
* Make user authentication based on username/password defined in Logins table and additionally implement OATH2 authentication thru FaceBook

* Create Method which exports Employee table into text format like:

+----------+------------------+------------+------------+
|employeeNo|employeeName      |Salary      |DepartmentNo| 
+----------+------------------+------------+------------+
|1         |Fred Davies       |50 000      |    4       | 
+----------+------------------+------------+------------+
|2         |Bernard Katic     |50 000      |    3       | 
+----------+------------------+------------+------------+
|3         |Rich Davies       |30 000      |    5       | 
+----------+------------------+------------+------------+



* Create WEB API/REST web service with endpoints for GetDepartments and GetEmployees which returns these lists in JSON.

* Create queries (T-SQL or LINQ) to determine the answers to the following questions:

1. What is the average salary for a Development employee in any location except London?

2. Which locations have more than one employee? What are those locations and how many employees are in each (single query)

3. How many Development employees are in each location?
   Note: there is no requirement for  location to have Development employee, so Basel should be returned with 0 employees
   
4. Select the second highest salary


* Create view vwDepartment on Department table with the following fields

Column name                     Content                         Example

departmentNo             departmentNo                           3
departmentDescription    departmentName + departmentLocation    Development Osijek

* Create stored procedure which changes the salary for an employee. EmployeeNo and increase/descrease precentage are given parameters.

example: ti oncrease 10% for Fred Davies, No 1

spIncreaseSalary 1,10

* Optional: Create a trigger on Employee tables which writes the current date/tim in lastModify column after each update



* A customer Mr. Billich has sent you a bug repost. He complains that a certain field in the DB is not updated.
  Write a short reply in which you would apologize, ask for detailed information about it and promise a quick solution.

select Max(Salary)
from Employees
where Salary < (select Max(Salary) from Employees)


CREATE TRIGGER trg_UpdateLastModify
ON dbo.Employees
AFTER UPDATE, INSERT
AS
    UPDATE dbo.Employees
    SET LastModify = GETDATE()
    WHERE EmployeeNo IN (SELECT DISTINCT EmployeeNo FROM Inserted)
Use HammerAppMVCDatabase
go

create trigger trg_UpdateLastModify
on dbo.Employees
after UPDATE, INSERT
as
    UPDATE dbo.Employees
    set LastModify = GETDATE()
    where EmployeeNo IN (SELECT DISTINCT EmployeeNo FROM Inserted)
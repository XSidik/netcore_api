CREATE PROCEDURE GetEmployeeByName
    @name NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Employee
    WHERE Name = @name;
END;
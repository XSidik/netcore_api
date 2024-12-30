CREATE PROCEDURE GetEmployeeById
    @id INT
AS
BEGIN
    SELECT *
    FROM Employee
    WHERE idx = @id;
END;
CREATE PROCEDURE DeleteEmployee
    @id INT
AS
BEGIN
    DELETE FROM Employee
    WHERE idx = @id;
END;
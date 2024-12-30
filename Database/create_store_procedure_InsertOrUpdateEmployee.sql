CREATE PROCEDURE InsertOrUpdateEmployee    
    @idx INT,
    @name NVARCHAR(100),
    @age INT
AS
BEGIN
    IF @idx IS NOT NULL AND @idx != 0
    BEGIN
        UPDATE Employee
        SET name = @name, age = @age
        WHERE idx = @idx;
    END
    ELSE
    BEGIN
        INSERT INTO Employee (name, age)
        VALUES (@name, @age);
    END
END;
CREATE TABLE Employee (
    idx INT PRIMARY KEY IDENTITY(1,1), -- Auto-incremented primary key
    name NVARCHAR(100) NOT NULL,      -- Name with a maximum length of 100 characters
    age INT NOT NULL                  -- Age as an integer
);

﻿CREATE DATABASE TodoListDb;
GO

USE TodoListDb;
GO

CREATE TABLE TodoLists (
    Id INT PRIMARY KEY IDENTITY,
    Description NVARCHAR(200) NOT NULL,
    DueDate DATE NOT NULL,
    Situation NVARCHAR(100) NOT NULL,
);
GO
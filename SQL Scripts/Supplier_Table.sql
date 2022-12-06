IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Supplier_Table'))
BEGIN;
    DROP TABLE Supplier_Table;
END;
GO

CREATE TABLE [Supplier_Table] (
    [Supplier_ID] INTEGER NOT NULL IDENTITY(1, 1),
    [Supplier_Name] VARCHAR(255) NOT NULL,
    [Supplier_Phone] BIGINT NOT NULL,
    [Supplier_Notes] VARCHAR(500) NULL,
    [Supplier_Contact] VARCHAR(128) NULL,
    PRIMARY KEY ([Supplier_ID])
);
GO
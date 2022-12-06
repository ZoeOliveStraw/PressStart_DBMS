IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Product_Table'))
BEGIN;
    DROP TABLE [Product_Table];
END;
GO

CREATE TABLE [Product_Table] (
    [Product_ID] INTEGER NOT NULL IDENTITY(1, 1),
    [Product_Name] VARCHAR(255) NOT NULL,
    [Supplier_Phone] BIGINT NOT NULL,
    [Supplier_Notes] VARCHAR(500) NULL,
    [Supplier_Contact] VARCHAR(128) NULL,
    PRIMARY KEY ([Product_ID])
);
GO


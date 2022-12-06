IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Store_Table'))
BEGIN;
    DROP TABLE [Store_Table];
END;
GO

CREATE TABLE [Store_Table] (
    [Store_Table_ID] INTEGER NOT NULL IDENTITY(1, 1),
    [Store_Address] VARCHAR(255) NULL,
    [Store_Phone] BIGINT NOT NULL,
    PRIMARY KEY ([Store_Table_ID])
);
GO

INSERT INTO [Store_Table] (Store_Address, Store_Phone)
VALUES ('1500 Simcoe St North','9052565423');
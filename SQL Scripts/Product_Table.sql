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

INSERT INTO [Product_Table](Product_Name, Supplier_Phone, Supplier_Contact)
VALUES
	('God Hand', '9051231234', 'Larry'),
	('Viewtiful Joe', '9051231234', 'Gina'),
	('Devil May Cry', '9051231234', 'Crystal'),
	('Okami', '9051231234', 'Amaterasu'),
	('Metal Gear Solid', '9051231234', 'Meryl'),
	('Grabbed by the Ghoulies', '9051231234', 'Chopin'),
	('Sniper Elite', '9051231234', 'Bill'),
	('Call of Duty', '9051231234', 'Dino'),
	('Megaman', '9051231234', 'Meryl');
	
INSERT INTO [Product_Table](Product_Name, Supplier_Phone, Supplier_Contact)
VALUES
	('God Hand', '9051231234', 'Larry'),
	('Viewtiful Joe', '9051231234', 'Gina'),
	('Devil May Cry', '9051231234', 'Crystal'),
	('Okami', '9051231234', 'Amaterasu'),
	('Metal Gear Solid', '9051231234', 'Meryl'),
	('Grabbed by the Ghoulies', '9051231234', 'Chopin'),
	('Sniper Elite', '9051231234', 'Bill'),
	('Call of Duty', '9051231234', 'Dino'),
	('Megaman', '9051231234', 'Meryl');
	
INSERT INTO [Product_Table](Product_Name, Supplier_Phone, Supplier_Contact)
VALUES
	('Ms Pac Man', '9051231234', 'Heather'),
	('God of War', '9051231234', 'Kratos'),
	('Portal', '9051231234', 'Gaben'),
	('Portal 2', '9051231234', 'Gaben'),
	('Mass Effect', '9051231234', 'Sheppard'),
	('Baldurs Gate', '9051231234', 'Baldur'),
	('Final Fantasy', '9051231234', 'Cloud'),
	('God of War 2', '9051231234', 'Atreus'),
	('Megaman X', '9051231234', 'Dr Wily');
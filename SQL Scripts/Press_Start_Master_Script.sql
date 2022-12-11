-----------------------------
--DROP TABLE STATEMENTS
-----------------------------

--TRANSACTION ITEM TABLE

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Transaction_Item_Table'))
BEGIN;
    DROP TABLE [Transaction_Item_Table];
END;
GO

--REPAIR ORDER TABLE

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Repair_Order_Table'))
BEGIN;
    DROP TABLE [Repair_Order_Table];
END;
GO

--PRODUCT INSTANCE TABLE

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Product_Instance_Table'))
BEGIN;
    DROP TABLE [Product_Instance_Table];
END;
GO

--TRANSACTION TABLE 

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Transaction_Table'))
BEGIN;
    DROP TABLE [Transaction_Table];
END;
GO

--PRODUCT_TABLE
IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Product_Table'))
BEGIN;
    DROP TABLE Product_Table;
END;
GO


--CUSTOMER_TABLE

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Customer_Table'))
BEGIN;
    DROP TABLE [Customer_Table];
END;
GO


--STAFF_TABLE

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Staff_Table'))
BEGIN;
    DROP TABLE [Staff_Table];
END;
GO



--SUPPLIER_TABLE

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Supplier_Table'))
BEGIN;
    DROP TABLE Supplier_Table;
END;
GO

--STORE_TABLE

IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Store_Table'))
BEGIN;
    DROP TABLE [Store_Table];
END;
GO


-----------------------------
--PRODUCT TABLE TABLE SCRIPT 
-----------------------------

CREATE TABLE [Product_Table] (
    [Product_ID] INTEGER NOT NULL IDENTITY(1, 1),
    [Product_Name] VARCHAR(255) NOT NULL,
    [Supplier_Phone] BIGINT NOT NULL,
    [Supplier_Notes] VARCHAR(500) NULL,
    [Supplier_Contact] VARCHAR(128) NULL,
    PRIMARY KEY ([Product_ID])
);
GO

---------------------------
--CUSTOMER TABLE SCRIPT
---------------------------

CREATE TABLE [Customer_Table] (
    [Customer_ID] INTEGER NOT NULL IDENTITY(1, 1),
    [Customer_First_Name] VARCHAR(255) NULL,
    [Customer_Last_Name] VARCHAR(255) NULL,
    [Customer_Email] VARCHAR(255) NULL,
    [Customer_Mailing_List] VARCHAR(255) NULL,
    [Customer_Phone] BIGINT NULL,
    PRIMARY KEY ([Customer_ID])
);
GO

-----------------------
--STORE TABLE SCRIPT
-----------------------

CREATE TABLE [Store_Table] (
    [Store_Table_ID] INTEGER NOT NULL IDENTITY(1, 1),
    [Store_Address] VARCHAR(255) NULL,
    [Store_Phone] BIGINT NOT NULL,
    PRIMARY KEY ([Store_Table_ID])
);
GO

----------------------------
--SUPPLIER TABLE SCRIPT
----------------------------

CREATE TABLE [Supplier_Table] (
    [Supplier_ID] INTEGER NOT NULL IDENTITY(1, 1),
    [Supplier_Name] VARCHAR(255) NOT NULL,
    [Supplier_Phone] BIGINT NOT NULL,
    [Supplier_Notes] VARCHAR(500) NULL,
    [Supplier_Contact] VARCHAR(128) NULL,
    PRIMARY KEY ([Supplier_ID])
);
GO

-------------------------------
--STAFF TABLE SCRIPT
-------------------------------

CREATE TABLE [Staff_Table] (
    [Staff_ID] INTEGER NOT NULL IDENTITY(1, 1),
    [Staff_First_Name] VARCHAR(255) NOT NULL,
    [Staff_Last_Name] VARCHAR(255) NOT NULL,
	[Staff_Start_Date] DATE NOT NULL,
    [Staff_Email] VARCHAR(255) NULL,
    [Staff_Phone] BIGINT NULL,
	[Staff_Category] Char NOT NULL,
	[Staff_Store_ID] INT FOREIGN KEY REFERENCES Store_Table(Store_Table_ID),
    PRIMARY KEY ([Staff_ID])
);

GO

------------------------------
--REPAIR ORDERS TABLE SCRIPT
------------------------------

CREATE TABLE [Repair_Order_Table] (
    [Repair_Order_ID] INTEGER NOT NULL IDENTITY(1, 1),
	[Repair_Staff_ID] INT FOREIGN KEY REFERENCES Staff_Table(Staff_ID),
	[Repair_Customer_ID] INT FOREIGN KEY REFERENCES Customer_Table(Customer_ID),
	[Repair_Order_Date] DATE NOT NULL,
	[Repair_Order_Description] VARCHAR(2000) NOT NULL,
	[Repair_Order_Store_ID] INT FOREIGN KEY REFERENCES Store_Table(Store_Table_ID),
    PRIMARY KEY ([Repair_Order_ID])
);

GO



-----------------------------------
--PRODUCT INSTANCE TABLE SCRIPT
-----------------------------------

CREATE TABLE [Product_Instance_Table] (
    [Product_Instance_ID] INTEGER NOT NULL IDENTITY(1, 1),
	[Product_Instance_Product_ID] INT FOREIGN KEY REFERENCES Product_Table(Product_ID),
	[Product_Instance_Customer_ID_Seller] INT FOREIGN KEY REFERENCES Customer_Table(Customer_ID),
	[Product_Instance_Store_ID] INT FOREIGN KEY REFERENCES Store_Table(Store_Table_ID),
	[Product_Instance_Used] BIT NOT NULL,
	[Product_Instance_Price] MONEY NOT NULL,
	[Product_instance_Condition] INT,
    PRIMARY KEY ([Product_Instance_ID])
);

GO

-------------------------------
--TRANSACTION TABLE SCRIPT
-------------------------------

CREATE TABLE [Transaction_Table] (
    [Transaction_ID] INTEGER NOT NULL IDENTITY(1, 1),
	[Transaction_Customer_ID] INT FOREIGN KEY REFERENCES Customer_Table(Customer_ID),
	[Transaction_Store_ID] INT FOREIGN KEY REFERENCES Store_Table(Store_Table_ID),
	[Transaction_Date] DATE NOT NULL,
	[Transaction_Amount] MONEY NOT NULL,
    PRIMARY KEY ([Transaction_ID])
);

GO

-----------------------------
--TRANSACTION TABLE SCRIPT
-----------------------------

CREATE TABLE [Transaction_Item_Table] (
	[Transaction_Item_Transaction_ID] INT FOREIGN KEY REFERENCES Transaction_Table(Transaction_ID),
	[Transaction_Item_Product_Instance_ID] INT FOREIGN KEY REFERENCES Product_Instance_Table(Product_Instance_ID),
);

GO


-----------------------
--STORE TABLE DATA
-----------------------

INSERT INTO [Store_Table] (Store_Address, Store_Phone)
VALUES ('1500 Simcoe St North','9052565423');


-----------------------
--CUSTOMER TABLE DATA
-----------------------

INSERT INTO [Customer_Table] (Customer_First_Name,Customer_Last_Name,Customer_Email,Customer_Mailing_List,Customer_Phone)
VALUES
  ('Nero','Padilla','velit.pellentesque.ultricies@icloud.couk','Yes','1458586728'),
  ('Hyacinth','Rasmussen','dui.lectus.rutrum@google.org','No','1268482725'),
  ('Griffith','Valenzuela','amet.massa@outlook.edu','Yes','6868953658'),
  ('Nerea','Knight','nulla.integer@yahoo.edu','No','5632736451'),
  ('Cassidy','Curry','nullam.feugiat.placerat@google.couk','Yes','6284625282'),
  ('Nelle','Hodges','rutrum.fusce.dolor@icloud.net','Yes','2713291723'),
  ('Bert','Fuller','natoque.penatibus@protonmail.edu','No','5573259234'),
  ('Tasha','Cash','orci.sem@protonmail.net','No','4593622844'),
  ('Priscilla','Gardner','ac.feugiat@hotmail.ca','Yes','8567252424'),
  ('Justina','Boyd','aliquet.proin.velit@protonmail.net','Yes','9528346781');

INSERT INTO [Customer_Table] (Customer_First_Name,Customer_Last_Name,Customer_Email,Customer_Mailing_List,Customer_Phone)
VALUES
  ('Selma','Wiggins','molestie.arcu@aol.com','Yes','7314861721'),
  ('Hilary','Daniels','dictum@google.couk','No','6442667455'),
  ('Hall','Carrillo','nec.quam.curabitur@icloud.net','Yes','8688815377'),
  ('Sawyer','Sharp','ut.ipsum.ac@hotmail.net','No','8716642837'),
  ('Lacota','Dennis','risus.nulla@google.com','Yes','3227915832'),
  ('Hamilton','Serrano','cras.convallis.convallis@yahoo.ca','Yes','8561112578'),
  ('Hayley','Wyatt','mattis.semper@icloud.org','Yes','7826675827'),
  ('Alden','Boone','dui.augue@aol.net','Yes','8543953239'),
  ('Lane','Hubbard','maecenas@yahoo.org','Yes','5333255633'),
  ('Marvin','Estes','magna.duis@aol.ca','Yes','4379764767');

INSERT INTO [Customer_Table] (Customer_First_Name,Customer_Last_Name,Customer_Email,Customer_Mailing_List,Customer_Phone)
VALUES
  ('Evelyn','Sosa','dis.parturient.montes@outlook.edu','Yes','3599385389'),
  ('Caleb','Lucas','ligula@hotmail.ca','No','2954777266'),
  ('Melvin','Douglas','mauris.eu.elit@outlook.org','No','8336152525'),
  ('Isaiah','Jennings','felis.orci@hotmail.com','No','7772862339'),
  ('Carter','Frost','congue@aol.net','No','2925576728'),
  ('Brendan','Cook','ante.blandit@outlook.edu','No','1794253776'),
  ('Dalton','Gardner','sit@hotmail.com','No','5674443722'),
  ('Shelly','Foreman','hendrerit.consectetuer.cursus@outlook.couk','Yes','5185685488'),
  ('Kevin','Hays','metus@outlook.com','No','2777766385'),
  ('Cherokee','Christian','tellus.eu.augue@google.net','No','6423878673');

INSERT INTO [Customer_Table] (Customer_First_Name,Customer_Last_Name,Customer_Email,Customer_Mailing_List,Customer_Phone)
VALUES
  ('Emmanuel','Holt','vel.turpis@google.couk','Yes','3762238635'),
  ('Julie','Vega','interdum.ligula@outlook.org','Yes','9845259135'),
  ('Frances','Hardy','cras.eget@icloud.couk','Yes','9629988984'),
  ('Nyssa','Grant','donec.sollicitudin@google.ca','Yes','5819911447'),
  ('Patience','Brady','arcu.vestibulum@aol.org','No','1258266126'),
  ('Yuri','Allen','sit@icloud.couk','Yes','6897127485'),
  ('Isaiah','Bradford','ultricies.dignissim@protonmail.edu','Yes','2675798953'),
  ('Beatrice','Smith','ornare.sagittis@hotmail.org','No','7833386196'),
  ('Ina','Holmes','a@protonmail.couk','No','5323787281'),
  ('Brandon','Lara','amet.ante.vivamus@yahoo.com','No','9843269895');

INSERT INTO [Customer_Table] (Customer_First_Name,Customer_Last_Name,Customer_Email,Customer_Mailing_List,Customer_Phone)
VALUES
  ('Harlan','Barber','mollis@hotmail.org','No','7268514378'),
  ('Amy','Aguilar','dolor@yahoo.edu','No','9655734469'),
  ('Jelani','Wooten','non@protonmail.org','Yes','7862654865'),
  ('Willa','Snow','aliquet.nec@hotmail.com','Yes','3775553477'),
  ('Melyssa','Wallace','non.hendrerit@outlook.couk','Yes','9494736691'),
  ('Vernon','Osborn','arcu.vestibulum@yahoo.couk','No','8577653788'),
  ('Quon','Steele','viverra@protonmail.org','Yes','2693984893'),
  ('Eleanor','Mullins','eget@yahoo.org','No','5529466712'),
  ('May','Hooper','a@protonmail.net','No','6536696643'),
  ('Brooke','Ortiz','est@aol.net','Yes','6516537162');



  ---------------------
  --STAFF TABLE DATA
  ---------------------

  INSERT INTO [Staff_Table] (Staff_First_Name,Staff_Last_Name,Staff_Email,Staff_Phone, Staff_Start_Date, Staff_Category, Staff_Store_ID)
VALUES
  ('Adrian','Mandingo','adrian.mandingo@pressstart.ca','3752155917', '2017-10-12','M','1'),
  ('Amir','Gilmore','dolor.dolor@aol.com','4568282456', '2020-05-16','S','1'),
  ('Roary','Acevedo','neque.et@hotmail.org','3672914293', '2020-06-28','T','1'),
  ('Fatima','Lamb','aenean.massa@icloud.com','2467823345','2019-02-20','S','1'),
  ('Keane','Richmond','enim@google.ca','9314572433','2021-07-12','T','1');

  --------------------
  --PRODUCT TABLE DATA
  --------------------

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

-------------------------------
--PRODUCT INSTANCE TABLE DATA
-------------------------------

--Handful of new games
INSERT INTO [Product_Instance_Table]
            (
            Product_Instance_Product_ID, 
            Product_Instance_Store_ID, 
            Product_Instance_Used,
            Product_Instance_Price
            )
VALUES
    ('1','1','false','59.99'),
    ('2','1','false','49.99'),
    ('6','1','false','39.99'),
    ('4','1','false','59.99'),
    ('6','1','false','89.99'),
    ('3','1','false','69.99');
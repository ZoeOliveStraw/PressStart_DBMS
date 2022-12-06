IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Staff_Table'))
BEGIN;
    DROP TABLE [Staff_Table];
END;
GO

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

INSERT INTO [Staff_Table] (Staff_First_Name,Staff_Last_Name,Staff_Email,Staff_Phone, Staff_Start_Date, Staff_Category, Staff_Store_ID)
VALUES
  ('Adrian','Mandingo','adrian.mandingo@pressstart.ca','3752155917', '2017-10-12','M','1'),
  ('Amir','Gilmore','dolor.dolor@aol.com','4568282456', '2020-05-16','S','1'),
  ('Roary','Acevedo','neque.et@hotmail.org','3672914293', '2020-06-28','T','1'),
  ('Fatima','Lamb','aenean.massa@icloud.com','2467823345','2019-02-20','S','1'),
  ('Keane','Richmond','enim@google.ca','9314572433','2021-07-12','T','1');
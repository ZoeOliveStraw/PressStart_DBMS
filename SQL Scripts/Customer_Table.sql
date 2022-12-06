IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Customer_Table'))
BEGIN;
    DROP TABLE [Customer_Table];
END;
GO

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

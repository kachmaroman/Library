--1. �������� ���� ����� �������� ���� Library.
CREATE DATABASE LibraryDB  
ON							
(
	NAME = 'LibraryDB',																		   -- ������� ������ ��'� �� (�������. ��� �������� �� ��).
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.CCC\MSSQL\DATA\LibraryDB.mdf',   -- ������� ������� ����� ��'� ����� ��.
	SIZE = 10MB,																			   -- ������ ���������� ����� ����� ��.
	MAXSIZE = 100MB,																		   -- ������ ������������ ����� ����� ��.
	FILEGROWTH = 10MB																		   -- ������ ��������, �� ��� ���� ������������ ����� ����� ��.
)
LOG ON																						   -- ������ ��������� ������� ���� �����.
( 
	NAME = 'LogLibraryDB',																	   -- ������� ������ ��'� ������� ��.
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.CCC\MSSQL\DATA\LibraryDB.ldf',   -- ������� ������� ����� ��'� ������� ��.
	SIZE = 5MB,																				   -- ������ ���������� ����� ������� ��.
	MAXSIZE = 50MB,																			   -- ������ ������������ ����� ������� ��.
	FILEGROWTH = 5MB																		   -- ������ ��������, �� ��� ���� ������������ ����� ������� ��.
)               
COLLATE Cyrillic_General_CI_AS																   -- ������ ��������� ��� ���� ����� �� �������������

USE LibraryDB
GO

--2. �������� � ��� ����� �������
/*1) Categories (CategoryID, CategoryName)
  2) Edition (EditionID, EditionName)
  3) Authors (AutorID, FullName)
  4) Books (BookID, BookName, AuthorID, Edition, Qty)
  5) Readers (ReaderID, CategoryID, LName, FName, MName)
  6) Students (StudentID, [Group], FacultyID)
  7) Faculty (FacultyID, FacultyName)
  8) Degrees (DegreeID, DegreeName)
  9) Teachers (TeacherID, CathedraID, Degree) 
  10) Cathedra (CathedraID, CathedraName)
  11) OtherReaders (OtherID, Phone)
  12) RoomReading (RoomID, RoomName)
  13) Debtors (DebtorID, BookID, ReaderID, DateWith, DateTo)
  14) GiveBook (GivingID, BookID, ReaderID, DateTake, DateGive, DateRealGive)*/

CREATE TABLE [Categories]
(
	[CategoryID]   [int] NOT NULL,
	[CategoryName] [varchar](50) NOT NULL
)
GO

CREATE TABLE [Editions]
(
	[EditionID]   [int] NOT NULL,
	[EditionName] [nvarchar](100) NOT NULL
)
GO

CREATE TABLE [Authors]
(
	[AuthorID] [int] NOT NULL,
	[FullName]    [varchar](100) NOT NULL
)
GO

CREATE TABLE [Books]
(
	[BookID]    [int] NOT NULL,
	[BookName]  [nvarchar](100) NOT NULL,
	[AuthorID]  [int] NOT NULL,
	[EditionID] [int] NOT NULL,
	[Qty]	    [smallint] NOT NULL
)  
GO

CREATE TABLE [Readers]
(
	[ReaderID]   [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[LName]		 [nvarchar](20) NOT NULL,
	[FName]      [nvarchar](20) NOT NULL,
	[MName]      [nvarchar](20) NOT NULL,
	[ImageUrl]	 [nvarchar](max) NULL
)  
GO

CREATE TABLE [Students]
(
	[StudentID] [int] NOT NULL,
	[Group]		[nvarchar](15) NOT NULL,
	[FacultyID]	[int] NOT NULL
)  
GO

CREATE TABLE [Faculty]
(
	[FacultyID]   [int] NOT NULL,
	[FacultyName] [nvarchar](100) NOT NULL
)
GO

CREATE TABLE [Degrees]
(
	[DegreeID]   [int] NOT NULL,
	[DegreeName] [varchar](50) NOT NULL
)
GO

CREATE TABLE [Teachers]
(
	[TeacherID]  [int] NOT NULL,
	[CathedraID] [int] NOT NULL,
	[DegreeID]   [int] NOT NULL
)  
GO

CREATE TABLE [Cathedra]
(
	[CathedraID]   [int] NOT NULL,
	[CathedraName] [nvarchar](100) NOT NULL
)
GO

CREATE TABLE [OtherReaders]
(
	[OtherID] [int] NOT NULL,
	[Phone]   [char](18) NOT NULL
)  
GO

CREATE TABLE [RoomReading]
(
	[RoomID]   [int] NOT NULL,
	[RoomName] [nvarchar](100) NOT NULL
)  
GO

CREATE TABLE [Debtors]
(
	[DebtorID] [int] NOT NULL,
	[BookID]   [int] NOT NULL,
	[ReaderID] [int] NOT NULL,
	[DateWith] [date] NOT NULL,
	[DateTo]   [date] NOT NULL
)  
GO

CREATE TABLE [GiveBook]
(
	[GivingID] [int] NOT NULL,
	[BookID]   [int] NOT NULL,
	[ReaderID] [int] NOT NULL,
	[DateTake] [date] NOT NULL,
	[DateGive] [date] NOT NULL,
	[RoomID]   [int] NULL
)  
GO




--3. ���������� ��'���� �� ���������
/*1) Categories: CategoryID(PK)
  2) Editions: EditionID(PK), EditionName(UQ)
  3) Authors: AuthorID(PK)
  4) Books: BookID(PK), Edition(FK)
  5) Readers: ReaderID(PK), CategoryID(FK)
  6) Students: StudentID(FK, UQ)
  7) Faculty: FacultyID(PK), FacultyName(UQ)
  8) Degrees: DegreeID(PK)
  9) Teachers: TeacherID(FK, UQ)
  10) Cathedra: CathedraID(PK), CathedraName(UQ)
  11) OtherReaders: OtherID(FK, UQ), Phone(UQ)
  12) RoomReading: RoomID(PK), RoomName(UQ)
  13) Debtors: DebtorID(PK), BookID(FK), ReaderID(FK)
  14) GiveBook: GivingID(PK), BookID(FK), ReaderID(FK)*/
  
--������� Categories
ALTER TABLE Categories ADD
	CONSTRAINT PK_Categories PRIMARY KEY (CategoryID)
GO

--������� Readers
ALTER TABLE Readers ADD 
	CONSTRAINT PK_Readers PRIMARY KEY(ReaderID) 
GO

ALTER TABLE Readers ADD
	CONSTRAINT FK_Readers_Categories FOREIGN KEY (CategoryID)
	REFERENCES Categories(CategoryID)
	ON DELETE CASCADE
GO

--������� Editions
ALTER TABLE Editions ADD
	CONSTRAINT PK_Editions PRIMARY KEY (EditionID)
GO

ALTER TABLE Editions ADD
	CONSTRAINT UQ_Edition UNIQUE (EditionName)
GO

-- ������� Authors
ALTER TABLE Authors ADD
	CONSTRAINT PK_Authors PRIMARY KEY (AuthorID)
GO

ALTER TABLE Authors ADD
	CONSTRAINT UQ_Authors UNIQUE (FullName)
GO

--������� Books
ALTER TABLE Books ADD 
	CONSTRAINT PK_Books PRIMARY KEY(BookID) 
GO

ALTER TABLE Books ADD
	CONSTRAINT FK_Books_Editions FOREIGN KEY(EditionID)
	REFERENCES Editions(EditionID)
	ON DELETE CASCADE
GO

ALTER TABLE Books ADD
	CONSTRAINT FK_Books_Authors FOREIGN KEY(AuthorID)
	REFERENCES Authors(AuthorID)
	ON DELETE CASCADE
GO

-- ������� Faculty
ALTER TABLE Faculty ADD
	CONSTRAINT PK_Faculty PRIMARY KEY (FacultyID)
GO

ALTER TABLE Faculty ADD
	CONSTRAINT UQ_Faculty UNIQUE (FacultyName)
GO

--������� Students
ALTER TABLE Students ADD 
	CONSTRAINT UQ_Students UNIQUE(StudentID) 
GO

ALTER TABLE Students ADD 
	CONSTRAINT FK_Students_Readers FOREIGN KEY(StudentID)
	REFERENCES Readers(ReaderID)
	ON DELETE CASCADE 
GO

ALTER TABLE Students ADD 
	CONSTRAINT FK_Students_Faculty FOREIGN KEY(FacultyID)
	REFERENCES Faculty(FacultyID)
	ON DELETE CASCADE 
GO

-- ������� Cathedra
ALTER TABLE Cathedra ADD
	CONSTRAINT PK_Cathedra PRIMARY KEY (CathedraID)

ALTER TABLE Cathedra ADD
	CONSTRAINT UQ_Cathedra UNIQUE (CathedraName)
GO

-- ������� Degrees
ALTER TABLE [Degrees] ADD
	CONSTRAINT PK_Degrees PRIMARY KEY (DegreeID)
GO

ALTER TABLE [Degrees] ADD
	CONSTRAINT UQ_Degrees UNIQUE (DegreeName)
GO
--������� Teachers
ALTER TABLE Teachers ADD 
	CONSTRAINT UQ_Teacher UNIQUE(TeacherID) 
GO

ALTER TABLE Teachers ADD 
	CONSTRAINT FK_Teachers_Readers FOREIGN KEY(TeacherID)
	REFERENCES Readers(ReaderID)
	ON DELETE CASCADE 
GO

ALTER TABLE Teachers ADD 
	CONSTRAINT FK_Teachers_Cathedra FOREIGN KEY(CathedraID)
	REFERENCES Cathedra(CathedraID)
	ON DELETE CASCADE 
GO

ALTER TABLE Teachers ADD 
	CONSTRAINT FK_Teachers_Degrees FOREIGN KEY(DegreeID)
	REFERENCES [Degrees](DegreeID)
	ON DELETE CASCADE 
GO

--������� OtherReaders
ALTER TABLE OtherReaders ADD 
	CONSTRAINT UQ_OtherReaders_OtherID UNIQUE(OtherID) 
GO

ALTER TABLE OtherReaders ADD 
	CONSTRAINT UQ_OtherReaders_Phone UNIQUE(Phone) 
GO

ALTER TABLE OtherReaders ADD 
	CONSTRAINT FK_OtherReaders_Readers FOREIGN KEY(OtherID)
	REFERENCES Readers(ReaderID)
	ON DELETE CASCADE 
GO

--������� RoomReading
ALTER TABLE RoomReading ADD 
	CONSTRAINT PK_RoomReading PRIMARY KEY(RoomID) 
GO

ALTER TABLE RoomReading ADD 
	CONSTRAINT UQ_RoomReading UNIQUE(RoomName) 
GO

--������� Debtors
ALTER TABLE Debtors ADD 
	CONSTRAINT PK_Debtors PRIMARY KEY(DebtorID) 
GO

ALTER TABLE Debtors ADD 
	CONSTRAINT FK_Debtors_Books FOREIGN KEY(BookID)
	REFERENCES Books(BookID) 
	ON DELETE CASCADE 
GO

ALTER TABLE Debtors ADD 
	CONSTRAINT FK_Debtors_Readers FOREIGN KEY(ReaderID)
	REFERENCES Readers(ReaderID) 
	ON DELETE CASCADE 
GO

--������� GiveBook
ALTER TABLE GiveBook ADD 
	CONSTRAINT PK_GiveBook PRIMARY KEY(GivingID) 
GO

ALTER TABLE GiveBook ADD 
	CONSTRAINT FK_GiveBook_Roomreading FOREIGN KEY(RoomID)
	REFERENCES Roomreading(RoomID) 
	ON DELETE CASCADE 
GO

ALTER TABLE GiveBook ADD 
	CONSTRAINT FK_GiveBook_Readers FOREIGN KEY(ReaderID)
	REFERENCES Readers(ReaderID) 
	ON DELETE CASCADE 
GO

ALTER TABLE GiveBook ADD 
	CONSTRAINT FK_GiveBook_Books FOREIGN KEY(BookID)
	REFERENCES Books(BookID) 
	ON DELETE CASCADE 
GO




--4. ������ ���������
/*1) �������� ��������� �� ���������� ����� ������ ��������.
  2) �������� ���������, ����� ����� ������������� �������� ������ ����: ��������, ���������, ����� ������.
  3) �������� ���������, ����� ����� ������� ��������� �� ���� ���� ��'�����.
  4) �������� ��������� �� ��� ����� � �������� "���� �����" >= "���� ������"
  5) �������� ��������� �� ��� ����� � �������� "�����" < "������"*/

--1)
ALTER TABLE OtherReaders
ADD CONSTRAINT CN_OtherReaders_Phone
CHECK (Phone LIKE '[0-9][0-9][0-9] ([0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]')	 
GO

--2)
ALTER TABLE Categories
ADD CONSTRAINT CN_CAtegories_CategoryName
CHECK (CategoryName IN ('�������','��������', '������� �����'))	 
GO

--3)
ALTER TABLE Books
ADD CONSTRAINT CN_Books_Qty 
CHECK (Qty > 0)
GO

--4)
ALTER TABLE GiveBook
ADD CONSTRAINT CN_GiveBook_Date 
CHECK (DateGive >=  DateTake)
GO

--5)
ALTER TABLE Debtors
ADD CONSTRAINT CN_Debtors_Date 
CHECK (DateWith <  DateTo)
GO



-- 5. �������� ������� ��� ������� OtherReaders, Studetns, Teachers
-- ������ �� ������� � ��������� ����� � ������� Student
CREATE TRIGGER InsertUpdateForStudents
	ON dbo.Students
	FOR INSERT, UPDATE
AS
	IF EXISTS
	(
		SELECT StudentID, TeacherID
		FROM dbo.Students as S
		JOIN dbo.Teachers T
		ON S.StudentID = T.TeacherID
		WHERE S.StudentID = T.TeacherID 
	)
BEGIN
	RAISERROR('����� � ����� ID ��� ���� � ������� Teachers. 
�� ���������� �������� ��������� �� ��������!', 2, 16);
	ROLLBACK TRAN
END
	ELSE IF EXISTS
	(
		SELECT StudentID, OtherID
		FROM dbo.Students as S
		JOIN dbo.OtherReaders O
		ON s.StudentID = O.OtherID
		WHERE S.StudentID = O.OtherID
	)
BEGIN
	RAISERROR('����� � ����� ID ��� ���� � ������� OtherReaders. 
�� ���������� �������� �������� ������� �� ��������!', 2, 16);
	ROLLBACK TRAN
END

GO


-- ������ �� ������� � ��������� ����� � ������� OtherReaders
CREATE TRIGGER InsertUpdateForOtherReaders
	ON dbo.OtherReaders
	FOR INSERT, UPDATE
AS
	IF EXISTS
	(
		SELECT OtherID, StudentID
		FROM dbo.OtherReaders as O
		JOIN dbo.Students S
		ON O.OtherID = S.StudentID
		WHERE O.OtherID = S.StudentID
	)
BEGIN
	RAISERROR('����� � ����� ID ��� ���� � ������� Students. 
�� ���������� �������� �������� �� ������� �������!', 3, 17)
	ROLLBACK TRAN
END
	ELSE IF EXISTS
	(
		SELECT OtherID, TeacherID
		FROM dbo.OtherReaders as O
		JOIN dbo.Teachers T
		ON O.OtherID = T.TeacherID
		WHERE O.OtherID = T.TeacherID
	)
BEGIN
	RAISERROR('����� � ����� ID ��� ���� � ������� Teachers. 
�� ���������� �������� ��������� �� ������� �������!', 3, 17)
	ROLLBACK TRAN
END
GO


-- ������ �� ������� � ��������� ����� � ������� Teachers
CREATE TRIGGER InsertUpdateForTeachers
	ON dbo.Teachers
	FOR INSERT, UPDATE
AS
	IF EXISTS
	(
		SELECT TeacherID, StudentID
		FROM dbo.Teachers as T
		JOIN dbo.Students S
		ON T.TeacherID = S.StudentID
		WHERE T.TeacherID = S.StudentID
	)
BEGIN
	RAISERROR('����� � ����� ID ��� ���� � ������� Student. 
�� ���������� �������� �������� �� ����������!', 4, 18)
	ROLLBACK TRAN
END
	ELSE IF EXISTS
	(
		SELECT TeacherID, OtherID
		FROM dbo.Teachers as T
		JOIN dbo.OtherReaders O
		ON T.TeacherID = O.OtherID
		WHERE T.TeacherID = O.OtherID
	)
BEGIN
	RAISERROR('����� � ����� ID ��� ���� � ������� OtherReaders. 
�� ���������� �������� �������� ������ �� ����������!', 4, 18)
	ROLLBACK TRAN
END
GO




-- 6. ��������� ������� ������. 
INSERT DBO.Categories
VALUES (30313233, '������� �����'),
	   (50515253, '�������'),
	   (80818283, '��������')
GO

INSERT DBO.Readers (ReaderID, CategoryID, FName, LName, MName)
VALUES (32323, 30313233, '�����������', '�����', '�������������'),
	   (33343, 30313233, '��������� ', '���������', '���������'),
	   (33353, 30313233, '������', '����', '�����볿���'),
	   (36363, 30313233, '�����������', '���������', '����������'),
	   (37373, 30313233, '���', '�����', '������������'),
	   (38383, 30313233, '��������', '�����', '�������������'),
	   (39393, 30313233, '��������', '³����', '������������� '),
	   (30303, 30313233, '�������', '������ ', '�������������'),
	   (31313, 30313233, '�����', '��������', '������������'),
	   (34323, 30313233, '������', '����', '�������������'),
	   (33333, 30313233, '˳�����', '������', '��������'),
	   (34343, 30313233, '�������', '������', '������������'),
	   (35353, 30313233, '���������', '�����', '���������'),
	   (32043, 30313233, '������', '������', '�������������'),
	   (32073, 30313233, 'ϳ����', ' ���������', '��������'),
	   (32093, 30313233, '�����', '������', '�����������'),
	   (34523, 30313233, '���������', '������', '�������������'),
	   (37073, 30313233, '�������', ' ���������', '���������'),
	   (39063, 30313233, '������', '������', '�������'),
	   (39093, 30313233, '����������', '����', '��������'),
	   (38023, 30313233, '���������', '������', '���������'),
	   (32313, 30313233, '�������', '�����', '�����������'),
	   (34013, 30313233, '������', '���������', '���������'),
	   (38723, 30313233, '��������', '����� ', '������������'),
	   (50505, 50515253, '������', '���������', '�������������'),
	   (51515, 50515253, '����������', '����������', '���������'),
	   (59595, 50515253, '������', '�����', '������������'),
	   (54545, 50515253, '����������', '��������', '��������'),
	   (53535, 50515253, '�������', '����������', '�볿���'),
	   (52525, 50515253, '������', '�����', '�������'),
	   (56565, 50515253, '������', '������', '�����������'),
	   (57575, 50515253, '������', '��������', '�����볿���'),
	   (58585, 50515253, '������', 'ʳ��', '������������'),
	   (52035, 50515253, '������', '������', '������������'),
	   (50685, 50515253, '����', '����', '�����������'),
	   (55555, 50515253, '��������', '����', '�����볿���'),
	   (52095, 50515253, '��������', '����', '���������'),
	   (52075, 50515253, '��������', '�������', '������������'),
	   (53245, 50515253, '�������', '���', '���㳿���'),
	   (59065, 50515253, '�������', '����', ' ���������'),
	   (57725, 50515253, 'ǳ������', '�����', '���������'),
	   (58345, 50515253, '���������', ' �����', '���㳿���'),
	   (54015, 50515253, '����������', '���������', '���㳿���'),
	   (50015, 50515253, '�����������', '������', '��������'),
	   (50025, 50515253, '����������', '�����', '���������'),
	   (58515, 50515253, '������', '������', '�������������'),
	   (52485, 50515253, 'ϳ������', '����', '���㳿���'),
	   (52595, 50515253, '��������', '���������', '�������'),
	   (55955, 50515253, '�������', '���������', '�����'),
	   (56025, 50515253, '���������', '��������', '�������'),
	   (80808, 80818283, '�������', '³����', '����������'),
	   (89898, 80818283, '���������', '�������', '��������'),
	   (88888, 80818283, '�����', '�����', '��������'),
	   (81818, 80818283, '������', '�����', '����������'),
	   (82828, 80818283, '�������', '�������', '���������'),
	   (83838, 80818283, '�����', '������', '���㳿���'),
	   (84848, 80818283, '��������', '������', '�����'),
	   (85858, 80818283, '�����', '������', '��������'),
	   (86858, 80818283, '����������', '�����', '������'),
	   (87878, 80818283, '�������', '���', '�����������'),
	   (88988, 80818283, '˳������', '�����', '������������'),
	   (80528, 80818283, '����������', '���������', '���������'),
	   (80368, 80818283, '�������', '³�����', '���������'),
	   (80188, 80818283, '̳�����', '������', '�����������'),
	   (82228, 80818283, '����������', '������', '��������'),
	   (83328, 80818283, 'ѳ�������', '���������', '��������'),
	   (81198, 80818283, '�����', '³����', '����������'),
	   (86968, 80818283, '������������', '������', '���������'),
	   (89698, 80818283, '���������', '�����', '�������������'),
	   (87548, 80818283, '����������', '���������', '���������'),
	   (82938, 80818283, '�����', '������', '����������'),
	   (84498, 80818283, '��������', '������', '����������'),
	   (89038, 80818283, '����������', '�����', '�������������'),
	   (83098, 80818283, '���������', '���', '���������'),
	   (89998, 80818283, '�������', '�����', '���㳿���')
GO
	   
INSERT DBO.RoomReading
VALUES (5243592, '��� �������������� ���������'),
	   (5272691, '��� �������������� ������'),
	   (5278176, '��� �������� ����� ����������'),
	   (5244419, '��� ��������� ���������� ������'),
	   (5248146, '��� ����������� �������'),
	   (2881395, '��� ���������� � ������� ������'),
	   (2340245, '��� ���������� ������ �� ���������� ��������')
GO

INSERT DBO.Editions
VALUES (2409, '�����-���������'),
	   (2754, '���� ѳ������� �������'),
	   (2832, '�������� "������"'),
	   (2762, '��� "�����������"'),
	   (2505, '����� "������"'),
	   (2555, '"�����"'),
	   (2828, '"������� ��������"'),  
	   (2932, '"����������"'),
	   (2405, '"����������� ��� ������"'),
	   (2232, '"����, ������ � ������"'),
	   (2020, '�����'),
	   (2025, '������-����'),
	   (2327, '���-����'),
	   (2272, '����� ���� ��������'),
	   (2228, '��������'),
	   (2727, '������� ��������'),
	   (2503, 'Hodder & Stoughton General Publishing Division'),
	   (2626, '�����'),
	   (2929, '������'),
	   (2222, '������� ����'),
	   (2525, '��������� ����� - ������'),
	   (2625, '����� ���'),
	   (2323, '������� ���-�����')
GO

INSERT DBO.Authors
VALUES (60102036, '������ ����������'),
	   (60405066, '����� ����'),
	   (61234566, '��� �������'),
	   (67890126, '������ ������'),
	   (60001006, '����� ʳ��'),
	   (66633566, '���� �����������'),
	   (69699696, '��� �����, ���� �����'),
	   (68765436, '�. ������, �.�����, �.�����, �.������'),
	   (61116116, '�. ������, ���� �. ���, �. �������'), 
	   (60090016, '������ ��������'),
	   (61219226, '���� �����'),
	   (62244226, '������ ������'),
	   (63655666, '���� ��������'),
	   (61626366, '������ ������, ������ �������'),
	   (65555566, '���� ����������'),
	   (60000006, '��� �������'),
	   (61111116, '�. �����������'),
	   (62222226, '������ ���'),
	   (63333336, '�. ���볺���'),
	   (64444446, '�. �����������'),
	   (65555556, '������� ����'),
	   (67777776, '������� �������, ������ ����'),
	   (68888886, '����� ������'),
	   (69999996, '����� �������'),
	   (62966266, '�. �����'),
	   (61239876, '�. ���������, �. ����������, �. ��������� �� ��.'), 
	   (60606006, '�. �����'),
	   (62129656, '������ ��������'),
	   (61919196, '����� ����������'),
	   (62929296, '�. �����'),
	   (69686016, '�. ��������'),
	   (63939396, '�. �������'),
	   (64949496, '����� ��������'),
	   (65959596, '�. ����������'),
	   (66969696, '�. ��'),
	   (67979796, '�. ʳ����'),
	   (62424226, '�. �����'),
	   (60197546, '�. ������'),
	   (62422426, '����� �������'),
	   (63321326, '�. ��������'),
	   (62244866, '�. ���������'),
	   (64466446, '³���� ������'),
	   (65566676, '�. ������'),
	   (67722786, '�.�. ���� '),
	   (64545456, '������ �����')
GO

INSERT DBO.Books
VALUES (9925, '����������� JAVA', 60102036, 2409, 9),
	   (9926, '���������� ������ ����', 60405066, 2754, 17),
	   (9927, '451� �� �����������', 61234566, 2832, 19),
	   (9928, '1984', 67890126, 2762, 7),
	   (9929, 'ʳ���� ����', 60001006, 2505, 9),
	   (9930, '������� ����� ������', 60001006, 2505, 19),
	   (9931, 'ʳ���� ����', 60001006,	2505, 9),
	   (9932, '̳���', 60001006, 2505, 12),
	   (9933, '³���������', 60001006, 2505, 15),
	   (9934, '����� ������', 60001006, 2505, 29),
	   (9935, '���� ��������', 60001006, 2505, 23),
	   (9936, '̲���� ��������', 60001006, 2505, 35),
	   (9937, '������ � ����', 66633566, 2555, 16),
	   (9938, 'Microsoft SQL Server 2008', 69699696, 2828, 3),
	   (9939, 'C# 4 � ��������� .NET', 68765436, 2932, 3),
	   (9940, 'Microsoft Visual C# 2008', 61116116,	2405, 5),
	   (9941, '��� ����� �������', 60090016, 2405, 9),
	   (9942, '������ �����������', 61219226, 2505, 1),
	   (9943, '����� �� ���� ��������', 62244226, 2232, 4),
	   (9944, 'PHP. �������, ������� � �������� ����������������', 63655666, 2932, 1),
	   (9945, '������������ ����', 61626366, 2020, 6),
	   (9946, '���������������� �� Python 3', 65555566, 2025, 1),
	   (9947, '�����������. ���� Swift', 60000006, 2327, 1),
	   (9948, '³�����. ������ ������� ', 61111116, 2754, 12),
	   (9949, '������ ������', 62222226, 2272, 11),
	   (9950, '����� ��� ', 63333336, 2754, 44),
	   (9951, '������� � ������� �����', 64444446, 2754, 14),
	   (9952, '������ �� �����. ����� ���� IV', 60001006, 2754, 10),
	   (9953, '�������� �����', 65555556, 2228, 17),
	   (9954, '�������� �������. ��, ��� ������ ��', 67777776, 2727, 6),
	   (9955, 'Dark Tower. The Wind Through the Keyhole', 60001006,	2503, 2),
	   (9956, '����� ��������. ������, ������, ��������', 68888886,	 2626, 7),
	   (9957, '����� ������ � ���� ������', 69999996, 2929, 9),
	   (9958, '���������� ���', 62966266, 2754, 15),
	   (9959, '����. ����. �����', 61239876, 2754, 56),
	   (9960, '������ ���� � ����� �� ��������', 60606006,	2754, 24),
	   (9961, '������ �������� �� ��� �������', 62129656,	2222, 2),
	   (9962, '������ ������', 60001006, 2754, 21),
	   (9963, '��� �����. ������, ��� ������� ��-������', 61919196, 2525, 22),
	   (9964, '����', 60001006,	2754, 24),
	   (9965, '������� ������', 62929296, 2327, 11),
	   (9966, '����� �����. ����� ���� V', 60001006, 2754, 23),
	   (9967, '������ ���', 60001006, 2754, 13),
	   (9968, 'ճ����', 69686016, 2754, 7),
	   (9969, '����� ������', 60000006, 2754, 27),
	   (9970, '������ ������������', 63939396, 2754, 18),
	   (9971, '������. ����� ����������� �����', 64949496, 2754, 16),
	   (9972, '������ ������� ������ � ��', 65959596, 2625, 16),
	   (9973, '���������� � ��������', 66969696, 2754, 14),
	   (9974, '������� � �� ���', 67979796, 2754, 22),
	   (9975, '³�����. ��� �����������', 61111116, 2754, 26),
	   (9976, '�����������', 62424226, 2754, 25),
	   (9977, '������ � ������ ���', 60197546, 2754, 25),
	   (9978, '³�����. ������ �������', 61111116, 2754, 15),
	   (9979, '������ ���', 60001006, 2754, 45),
	   (9980, '���������� ������ �������', 62422426, 2754, 29),
	   (9981, '���� ���', 63321326, 2754, 25),
	   (9982, 'ĳ����� � ��������', 62244866, 2754, 20),
	   (9983, '³���� ������. ����� �����', 64466446, 2754, 41),
	   (9984, '� - �������', 65566676,  2754, 49),
	   (9985, '���������� ������� ������', 67722786, 2625, 35),
	   (9986, '������� ��� �� ��, ��� ������', 64545456,	2323, 3)
GO		
  
INSERT DBO.OtherReaders
VALUES (32323, '380 (50) 462-22-22'),
	   (33343, '380 (50) 368-62-02'),
	   (33353, '380 (97) 738-77-77'),
	   (36363, '380 (50) 477-77-02'),
	   (37373, '380 (67) 614-15-76'),
	   (38383, '380 (50) 451-99-88'),
	   (39393, '380 (99) 406-83-09'),
	   (30303, '380 (50) 328-12-34'),
	   (31313, '380 (67) 636-27-88'),
	   (34323, '380 (50) 315-33-93'),
	   (33333, '380 (67) 520-36-55'),
	   (34343, '380 (95) 888-08-08'),
	   (35353, '380 (67) 406-59-09'),
	   (32043, '380 (67) 679-34-52'),
	   (32073, '380 (67) 363-10-03'),
	   (32093, '380 (50) 328-08-57'),
	   (34523, '380 (66) 220-27-77'),
	   (37073, '380 (67) 566-11-55'),
	   (39063, '380 (97) 487-57-82'),
	   (39093, '380 (68) 240-02-90'),
	   (38023, '380 (98) 400-00-33'),
	   (32313, '380 (93) 878-88-88'),
	   (34013, '380 (67) 372-02-00'),
	   (38723, '380 (67) 620-00-00')
GO

INSERT DBO.Faculty
VALUES (90987659, 'Գ����� , ��������� ������ �� �����������'),
	   (90123459, '�����'),
	   (97080909, '����������'),
	   (94050609, '������������'),
	   (93215679, '������ �������㳿'),
	   (91020309, '��������-���������� ������'),
	   (98765439, '�������� ����������� ������������'),
	   (91234569, 'ϳ�����������, ������� �� ������ ��������')
GO

INSERT DBO.Students
VALUES (50505, '��(�)-16',  90123459),
	   (51515, '��(�)-26',  90123459),
	   (59595, '���(�)-16', 97080909),
	   (54545, '��(�)-14',  97080909),
	   (53535, '��(�)-16',  98765439),
	   (52525, '��-��-16',  90987659),
	   (56565, '��(�)-16',  93215679),
	   (57575, '���(�)-16', 94050609),
	   (58585, '���-16',    97080909),
	   (52035, '��-��-15',  91234569),
	   (50685, '��-��-15',  91234569),
	   (55555, '��-14',	    91234569),
	   (52095, '��-14',     91234569),
	   (52075, '��-16',     90123459),
	   (53245, '��(�)-15',  90123459),
	   (59065, '��(�)-14',  90123459),
	   (57725, '��(�)-24',  90123459),
	   (58345, '��-14',	    90123459),
	   (54015, '��(�)-13',  90123459),
	   (50015, '��(�)-15',  98765439),
	   (50025, '��(�)-14',  98765439),
	   (58515, '��-��-15',  90987659),
	   (52485, '��-14',	    90987659),
	   (52595, '��-14',		90987659),
	   (55955, '��(�)-15',  91020309),
	   (56025, '��(�)-15',  93215679)
GO

INSERT DBO.Cathedra
VALUES (19128731, '��������-���������� ������'),
	   (12345671, '������� �����'),
	   (19876541, '��������� ������'),
	   (10102031, '�������� ��������'),
	   (10908071, '�������������� � ����� �����'),
	   (18765431, '����`������� ������ �� �����'),
	   (15432101, '�������, ���������� �� ��������������'),
	   (15436781, '�������� ���������� �� ��������� ����������')
GO

INSERT DBO.[Degrees]
VALUES (222222, '��������'),
	   (232322, '������� ��������'),
	   (244562, '������ ��������� (�������) ����'),
	   (232772, '��������� ���������'),
	   (266772, '��������'),
	   (211342, '�������� ��������'),
	   (201202, '�����'),
	   (220252, '������'),
	   (242822, '��������'),
	   (262722, '�������� �������'),
	   (292822, '���������'),
	   (205052, '������')
GO

INSERT DBO.Teachers
VALUES (80808, 19128731, 222222),
	   (89898, 19128731, 222222),
	   (88888, 19128731, 222222),
	   (81818, 19128731, 222222),
	   (82828, 12345671, 232322),
	   (83838, 12345671, 232322),
	   (84848, 12345671, 232322),
	   (85858, 15432101, 232322),
	   (86858, 15432101, 244562),
	   (87878, 15432101, 266772),
	   (88988, 19876541, 211342),
	   (80528, 19876541, 244562),
	   (80368, 19876541, 232772),
	   (80188, 19876541, 201202),
	   (82228, 19876541, 220252),
	   (83328, 10102031, 205052),
	   (81198, 10102031, 292822),
	   (86968, 10102031, 262722),
	   (89698, 10908071, 242822),
	   (87548, 10908071, 222222),
	   (82938, 10908071, 222222),
	   (84498, 10908071, 222222),
	   (89038, 15436781, 222222),
	   (83098, 15436781, 222222),
	   (89998, 15436781, 222222)
GO

INSERT DBO.GiveBook
VALUES (11111111, 9925, 32323, '13-01-2017', '20-01-2017', 5243592),
	   (11111112, 9926, 33343, '13-01-2017', '28-01-2017', 5272691),
	   (11111113, 9926, 33353, '15-01-2017', '23-01-2017', 5278176),
	   (11111114, 9928, 36363, '12-01-2017', '19-01-2017', 5244419),
	   (11111115, 9929, 37373, '11-01-2017', '18-01-2017', 5248146),
	   (11111116, 9930, 38383, '09-01-2017', '17-01-2017', 2881395),
	   (11111117, 9931, 39393, '05-01-2017', '15-01-2017', 2340245),
	   (11111118, 9932, 30303, '11-01-2017', '21-01-2017', 5243592),
	   (11111119, 9933, 31313, '23-01-2017', '30-01-2017', 5272691),
	   (11111120, 9934, 34323, '24-01-2017', '30-01-2017', 5278176),
	   (11111121, 9935, 33333, '18-01-2017', '26-01-2017', 5244419),
	   (11111122, 9936, 34343, '24-01-2017', '30-01-2017', 5248146),
	   (11111123, 9937, 35353, '28-01-2017', '09-02-2017', 2881395),
	   (11111124, 9938, 32043, '23-01-2017', '30-01-2017', 2340245),
	   (11111125, 9939, 32073, '12-01-2017', '22-01-2017', 5243592),
	   (11111126, 9940, 32093, '02-02-2017', '10-02-2017', 5272691),
	   (11111127, 9941, 34523, '04-02-2017', '11-02-2017', 5278176),
	   (11111128, 9942, 37073, '06-02-2017', '15-02-2017', 5244419),
	   (11111129, 9943, 39063, '08-02-2017', '12-02-2017', 5243592),
	   (11111130, 9944, 39093, '14-02-2017', '22-02-2017', 5272691),
	   (11111131, 9945, 38023, '16-02-2017', '24-02-2017', 5278176),
	   (11111132, 9946, 32313, '14-02-2017', '19-02-2017', 5243592),
	   (11111133, 9947, 34013, '11-02-2017', '17-02-2017', 5272691),
	   (11111134, 9948, 38723, '22-02-2017', '28-02-2017', 5278176),
	   (11111135, 9949, 50505, '26-02-2017', '03-03-2017', 5244419),
	   (11111136, 9950, 51515, '27-02-2017', '06-03-2017', NULL),
	   (11111137, 9951, 59595, '25-02-2017', '04-03-2017', 2881395),
	   (11111138, 9952, 54545, '19-02-2017', '28-02-2017', 2340245),
	   (11111139, 9953, 53535, '23-02-2017', '01-03-2017', 5243592),
	   (11111140, 9954, 52525, '03-03-2017', '12-03-2017', 5243592),
	   (11111141, 9955, 56565, '04-03-2017', '12-03-2017', 5243592),
	   (11111142, 9956, 57575, '05-03-2017', '13-03-2017', 5243592),
	   (11111143, 9957, 58585, '06-03-2017', '14-03-2017', 5243592),
	   (11111144, 9958, 52035, '07-03-2017', '15-03-2017', 5272691),
	   (11111145, 9959, 50685, '07-03-2017', '16-03-2017', 5278176),
	   (11111146, 9960, 55555, '11-03-2017', '21-03-2017', 5244419),
	   (11111147, 9961, 52095, '12-03-2017', '20-03-2017', 5248146),
	   (11111148, 9962, 52075, '13-03-2017', '20-03-2017', 2881395),
	   (11111149, 9963, 53245, '14-03-2017', '20-03-2017', 2340245),
	   (11111150, 9964, 59065, '16-03-2017', '24-03-2017', 5243592),
	   (11111151, 9965, 57725, '19-03-2017', '27-03-2017', 5272691),
	   (11111152, 9966, 58345, '24-03-2017', '29-03-2017', 5278176),
	   (11111153, 9967, 54015, '22-03-2017', '27-03-2017', NULL),
	   (11111154, 9968, 50015, '29-03-2017', '07-04-2017', 5248146),
	   (11111155, 9969, 50025, '27-03-2017', '02-04-2017', 2881395),
	   (11111156, 9970, 58515, '29-03-2017', '05-04-2017', 2340245),
	   (11111157, 9971, 52485, '29-03-2017', '06-04-2017', 2340245),
	   (11111158, 9972, 52595, '01-04-2017', '07-04-2017', 5243592),
	   (11111159, 9973, 55955, '02-04-2017', '12-04-2017', 5272691),
	   (11111160, 9974, 56025, '03-04-2017', '11-04-2017', 5278176),
	   (11111161, 9975, 80808, '03-04-2017', '09-04-2017', 5244419),
	   (11111162, 9976, 89898, '03-04-2017', '09-04-2017', NULL),
	   (11111163, 9977, 88888, '05-04-2017', '12-04-2017', 2881395),
	   (11111165, 9978, 81818, '07-04-2017', '12-04-2017', 2340245),
	   (11111166, 9979, 82828, '05-04-2017', '11-04-2017', 5243592),
	   (11111167, 9980, 83838, '04-04-2017', '15-04-2017', 5272691),
	   (11111168, 9981, 84848, '10-04-2017', '16-04-2017', 5278176),
	   (11111169, 9982, 85858, '11-04-2017', '19-04-2017', NULL),
	   (11111170, 9983, 86858, '02-04-2017', '09-04-2017', 5248146),
	   (11111171, 9984, 87878, '05-04-2017', '09-04-2017', 2881395),
	   (11111172, 9985, 88988, '06-04-2017', '12-04-2017', 2340245),
	   (11111173, 9986, 80528, '12-04-2017', '19-04-2017', 5243592),
	   (11111174, 9975, 80368, '15-04-2017', '22-04-2017', NULL),
	   (11111175, 9976, 80188, '11-04-2017', '19-04-2017', 5248146),
	   (11111176, 9926, 82228, '10-04-2017', '17-04-2017', 2881395),
	   (11111177, 9926, 83328, '14-04-2017', '24-04-2017', 2340245),
	   (11111178, 9969, 81198, '16-04-2017', '25-04-2017', 5243592),
	   (11111179, 9980, 86968, '17-04-2017', '26-04-2017', 5272691),
	   (11111180, 9969, 89698, '19-04-2017', '29-04-2017', NULL),
	   (11111181, 9982, 87548, '20-04-2017', '27-04-2017', NULL),
	   (11111182, 9983, 82938, '17-04-2017', '27-04-2017', NULL),
	   (11111183, 9984, 84498, '19-04-2017', '24-04-2017', 2881395),
	   (11111184, 9985, 89038, '18-04-2017', '18-04-2017', 2340245),
	   (11111185, 9969, 83098, '14-04-2017', '20-04-2017', 5243592),
	   (11111186, 9984, 89998, '17-04-2017', '26-04-2017', 5243592)
GO

INSERT DBO.Debtors
VALUES (41918174, 9926, 37373, '18-01-2017', '18-02-2017'),
	   (42928274, 9932, 34013, '17-02-2017', '18-03-2017'),
	   (43938374, 9926, 32313, '19-02-2017', '19-03-2017'),
	   (44948474, 9964, 34523, '11-02-2017', '28-02-2017'),
	   (45958574, 9965, 51515, '06-03-2017', '28-03-2017'),
	   (46968674, 9984, 54015, '27-03-2017', '27-04-2017'),
	   (47978774, 9985, 52595, '07-04-2017', '30-04-2017'),
	   (48988874, 9951, 34323, '30-01-2017', '24-02-2017')
GO



-- 7. �������� ������

/* 1) �������� ������ � �������� ����� ������� ��� ������ ���������� ���� ��� ��������,
��� �� ��� ��������, �� ������� ������������ �� �������, ����������, �����,
��������� ����. */

CREATE PROC spFirstSelect
	@FacultyName nvarchar(100)
AS
	SELECT R.ReaderID, R.LName, R.FName, R.MName
	FROM DBO.Readers R
	JOIN DBO.Students S
	ON R.ReaderID = S.StudentID
	JOIN DBO.Faculty F
	ON S.FacultyID = F.FacultyID
	WHERE F.FacultyName = @FacultyName
GO

EXEC spFirstSelect '�����'
GO

/* 2) �������� ������ � �������� ����� ��� �������-��������, �������� � �������
����� 10 ��� �� ������ ������� ��� �� ��� ��������, �� ������� ������������
�� �������, ����������, �����, ����, �� ���������� �������. */

CREATE PROC spSecondSelect
	@FacultyName nvarchar(100)
AS
	SELECT R.LName, R.FName, R.MName, D.DateWith, D.DateTo, S.[Group], F.FacultyName, B.BookName
	FROM DBO.Readers R
	JOIN DBO.Debtors D
	ON R.ReaderID = D.ReaderID
	JOIN DBO.Students S
	ON R.ReaderID = S.StudentID
	JOIN DBO.Faculty F
	ON F.FacultyID = S.FacultyID
	JOIN DBO.Books B
	ON B.BookID = D.BookID
	WHERE F.FacultyName = @FacultyName
GO

EXEC spSecondSelect '�����'
GO

/* 3) �������� ������ �������� ����, �� ��������� ������������ � ������ ����������
��� ��� ������ ����������, ��� ������ ����. */

CREATE PROC spThirdSelect
AS
	SELECT GB.BookID, B.BookName
	FROM DBO.Books B
	JOIN DBO.GiveBook GB
	ON B.BookID = GB.BookID
	GROUP BY GB.BookID, B.BookName
	HAVING COUNT(GB.BookID) > 1
GO

EXEC spThirdSelect
GO

/* 4) �������� ������ � �������� ����� ����, �� �������/�������� �� ������� ��, ���
������ ���������� ����, �������� ��� �� ��� ��������, �� �������� �������, �����
�������, ����� ����������� �� ��������. */

CREATE PROC spForthSelect
	@RoomName nvarchar(100)
AS
	SELECT B.BookID, B.BookName, RR.RoomName
	FROM DBO.Books B
	JOIN DBO.GiveBook GB
	ON B.BookID = GB.BookID
	JOIN DBO.Debtors D
	ON GB.ReaderID = D.ReaderID
	JOIN DBO.RoomReading RR
	ON RR.RoomID = GB.RoomID
	WHERE RR.RoomName = @RoomName
GO

EXEC spForthSelect '��� �������� ����� ����������'
GO

/* 5) ��������� ����� ������, � ��������� (���������) ������� �������, �������-
��������, �������� ���� �������������. */

CREATE PROC spFifthSelect
AS
	SELECT COUNT(GB.RoomID) AS 'ʳ������', GB.RoomID, RR.RoomName
	FROM DBO.RoomReading RR
	JOIN DBO.GiveBook GB
	ON RR.RoomID = GB.RoomID
	GROUP BY GB.RoomID, RR.RoomName
	ORDER BY COUNT(GB.RoomID) DESC
GO

EXEC spFifthSelect
GO

/* 6) �������� ������ � �������� ����� ����, ���������� �� ������������� ���������
�� ������� �����, �������, ��. */

CREATE PROC spSixthSelect
	@CategoryName1 nvarchar(50), @CategoryName2 nvarchar(50), @DateWith date, @DateTo date
AS
	SELECT B.BookID, B.BookName, GB.DateTake, C.CategoryName
	FROM DBO.Books B
	JOIN DBO.GiveBook GB
	ON B.BookID = GB.BookID
	JOIN DBO.Readers R
	ON GB.ReaderID = R.ReaderID
	JOIN DBO.Categories C
	ON R.CategoryID = C.CategoryID
	WHERE (C.CategoryName = @CategoryName1 OR C.CategoryName = @CategoryName2) AND
		   GB.DateTake BETWEEN @DateWith AND @DateTo
GO

EXEC spSixthSelect '�������', '��������', '15-03-2017', '15-04-2017'
GO

/* 7) �������� ������� ��������� ����� ��� ������ ���������� ���� ��� ��������, � 
��� ��������, ��� ������. */

CREATE PROC spSeventhSelect
	@RoomName nvarchar(100), @BookName nvarchar(100)
AS
	SELECT B.BookName, B.Qty, RR.RoomName
	FROM DBO.Books B
	JOIN DBO.GiveBook GB
	ON B.BookID = GB.BookID
	JOIN DBO.RoomReading RR
	ON GB.RoomID = RR.RoomID
	GROUP BY B.BookName, RR.RoomName, B.Qty
	HAVING RR.RoomName = @RoomName AND 
	B.BookName = @BookName;
GO

EXEC spSeventhSelect '��� ���������� ������ �� ���������� ��������', '���������� ������� ������'
GO

/* 8) �������� ������ � �������� ����� �������, ����������� ����� ������������
���������, ������� ����� ���� ������, � ��� ��������, �� �������
������������ �� �������, ����������, �����, ����, �� ���������� �������. */ 

CREATE PROC spEighthSelect
	@days int, @FacultyName nvarchar(100)
AS
	SELECT R.LName, R.FName, R.MName, D.DateWith, D.DateTo, S.[Group], F.FacultyName
	FROM DBO.Readers R
	JOIN DBO.Debtors D
	ON R.ReaderID = D.ReaderID
	JOIN DBO.Students S
	ON R.ReaderID = S.StudentID
	JOIN DBO.Faculty F
	ON F.FacultyID = S.FacultyID
	WHERE DATEDIFF(day, D.DateWith, D.DateTo) > @days AND F.FacultyName = @FacultyName
GO

EXEC spEighthSelect 30, '�����'
GO

/* 9) �������� ������ � �������� ����� ����� ������� �� ������� �� ������ ��� ������
���������� ���� ��� �������� �� ������� �����, �������, ��, � ��� ��������, ��
������� ������������ �� �������, ����������, �����, ����, �� ���������� �������. */

CREATE PROC spNinthSelect
	@DateTakeWith date, @DateTakeTo date, @RoomName nvarchar(100)
AS
	SELECT R.LName, R.FName, R.MName, GB.DateTake, GB.DateGive, RR.RoomName 
	FROM DBO.Readers R
	JOIN DBO.GiveBook GB
	ON R.ReaderID = GB.ReaderID
	JOIN DBO.Debtors D
	ON R.ReaderID = D.ReaderID
	JOIN DBO.RoomReading RR
	ON GB.RoomID = RR.RoomID
	WHERE GB.DateTake BETWEEN @DateTakeWith AND @DateTakeTo AND 
	RR.RoomName LIKE @RoomName;
GO

EXEC spNinthSelect '01-04-2017', '15-04-2017', '��� �������������� ���������'
GO
 
/* 10) �������� ������ � �������� ����� ����, ���������� ������ ������� �� �������  
�����, �������, ��, ������ ����, �� � ����� �� �����. */

CREATE PROC spTenthSelect
	@LName nvarchar(20), @DateTakeWith date, @DateTakeTo date
AS
	SELECT B.BookName AS '�����'
	FROM DBO.Books B
	JOIN DBO.GiveBook GB
	ON B.BookID = GB.BookID
	JOIN DBO.Readers R 
	ON GB.ReaderID = R.ReaderID
	WHERE R.LName = @LName AND GB.DateTake BETWEEN @DateTakeWith AND @DateTakeTo
GO

EXEC spTenthSelect '�������', '02-04-2017', '30-04-2017'
GO

/* 11) ���������, �� � ���� ����� � �������� �� �����������, � � ��� �������. */

CREATE PROC spEleventhSelect
	@CategoryName1 nvarchar(20), @CategoryName2 nvarchar(20), @BookName nvarchar(100)
AS
	SELECT B.BookName, A.FullName, E.EditionName, B.Qty
	FROM DBO.Books B
	JOIN DBO.GiveBook GB
	ON B.BookID = GB.BookID
	JOIN DBO.Readers R
	ON GB.ReaderID = R.ReaderID
	JOIN DBO.Categories C
	ON R.CategoryID = C.CategoryID
	JOIN DBO.Editions E
	ON E.EditionID = B.EditionID
	JOIN DBO.Authors A
	ON A.AuthorID = B.AuthorID
	GROUP BY B.BookName, A.FullName, E.EditionName, B.Qty, C.CategoryName
	HAVING C.CategoryName IN (@CategoryName1, @CategoryName2) AND B.BookName = @BookName
GO

EXEC spEleventhSelect '�������', '��������', '���� ���'
GO

/* 12) �������� ������ �������, � ���� �� ����� ����� ����� � ������, ���� ����� �� ��� ��
������� �����. */

SELECT R.LName, R.FName, R.MName, GB.DateTake, GB.DateGive -- INTO DateMin
FROM DBO.Books B
JOIN DBO.GiveBook GB
ON B.BookID = GB.BookID
JOIN DBO.Readers R
ON GB.ReaderID = R.ReaderID
WHERE B.BookName = '����� ������';
GO

SELECT R.FName, R.LName, R.MName
FROM DateMin R
WHERE R.DateGive = (SELECT MIN(C.DateGive)
					FROM DBO.DateMin C)
GO

/* 13) ������ ����� ���������� ��� �����, ����, ��������� ��� �������, ��������������,
�� �������, ������, ������� ����� ���� �� �������� ������� ������. */

CREATE PROC spThirteenthSelect
	@LName nvarchar(20)
AS
	SELECT R.LName, R.FName, R.MName, S.[Group], F.FacultyName, B.BookName 
	FROM DBO.Debtors D
	JOIN DBO.Readers R
	ON D.ReaderID = R.ReaderID
	JOIN DBO.Students S
	ON R.ReaderID = S.StudentID
	JOIN DBO.Faculty F
	ON S.FacultyID = F.FacultyID
	JOIN DBO.Books B
	ON D.BookID = B.BookID
	WHERE R.LName = @LName
GO

EXEC spThirteenthSelect '��������'
GO
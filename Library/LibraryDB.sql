--1. Створити базу даних бібліотеки ВНЗу Library.
CREATE DATABASE LibraryDB  
ON							
(
	NAME = 'LibraryDB',																		   -- Вказуємо логічне ім'я БД (викорис. при зверненні до БД).
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.CCC\MSSQL\DATA\LibraryDB.mdf',   -- Вказуємо фізичне повне ім'я файлу БД.
	SIZE = 10MB,																			   -- Задаємо початковий розмір файлу БД.
	MAXSIZE = 100MB,																		   -- Задаємо максимальний розмір файлу БД.
	FILEGROWTH = 10MB																		   -- Задаємо значення, на яке буде збільшуватись розмір файлу БД.
)
LOG ON																						   -- Задаємо параметри журналу Бази Даних.
( 
	NAME = 'LogLibraryDB',																	   -- Вказуємо логічне ім'я журналу БД.
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.CCC\MSSQL\DATA\LibraryDB.ldf',   -- Вказуємо фізичне повне ім'я журналу БД.
	SIZE = 5MB,																				   -- Задаємо початковий розмір журналу БД.
	MAXSIZE = 50MB,																			   -- Задаємо максимальний розмір журналу БД.
	FILEGROWTH = 5MB																		   -- Задаємо значення, на яке буде збільшуватись розмір журналу БД.
)               
COLLATE Cyrillic_General_CI_AS																   -- Задаємо кодування для бази даних за замовчуванням

USE LibraryDB
GO

--2. Створити в базі даних таблиці
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




--3. Встановити зв'язки між таблицями
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
  
--таблиця Categories
ALTER TABLE Categories ADD
	CONSTRAINT PK_Categories PRIMARY KEY (CategoryID)
GO

--таблиця Readers
ALTER TABLE Readers ADD 
	CONSTRAINT PK_Readers PRIMARY KEY(ReaderID) 
GO

ALTER TABLE Readers ADD
	CONSTRAINT FK_Readers_Categories FOREIGN KEY (CategoryID)
	REFERENCES Categories(CategoryID)
	ON DELETE CASCADE
GO

--таблиця Editions
ALTER TABLE Editions ADD
	CONSTRAINT PK_Editions PRIMARY KEY (EditionID)
GO

ALTER TABLE Editions ADD
	CONSTRAINT UQ_Edition UNIQUE (EditionName)
GO

-- таблиця Authors
ALTER TABLE Authors ADD
	CONSTRAINT PK_Authors PRIMARY KEY (AuthorID)
GO

ALTER TABLE Authors ADD
	CONSTRAINT UQ_Authors UNIQUE (FullName)
GO

--таблиця Books
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

-- таблиця Faculty
ALTER TABLE Faculty ADD
	CONSTRAINT PK_Faculty PRIMARY KEY (FacultyID)
GO

ALTER TABLE Faculty ADD
	CONSTRAINT UQ_Faculty UNIQUE (FacultyName)
GO

--таблиця Students
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

-- таблиця Cathedra
ALTER TABLE Cathedra ADD
	CONSTRAINT PK_Cathedra PRIMARY KEY (CathedraID)

ALTER TABLE Cathedra ADD
	CONSTRAINT UQ_Cathedra UNIQUE (CathedraName)
GO

-- таблиця Degrees
ALTER TABLE [Degrees] ADD
	CONSTRAINT PK_Degrees PRIMARY KEY (DegreeID)
GO

ALTER TABLE [Degrees] ADD
	CONSTRAINT UQ_Degrees UNIQUE (DegreeName)
GO
--таблиця Teachers
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

--таблиця OtherReaders
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

--таблиця RoomReading
ALTER TABLE RoomReading ADD 
	CONSTRAINT PK_RoomReading PRIMARY KEY(RoomID) 
GO

ALTER TABLE RoomReading ADD 
	CONSTRAINT UQ_RoomReading UNIQUE(RoomName) 
GO

--таблиця Debtors
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

--таблиця GiveBook
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




--4. Задати обмеження
/*1) Створити обмеження на коректність вводу номера телефону.
  2) Створити обмеження, згідно якому користувачами бібліотеки модуть бути: студенти, викладачі, разові читачі.
  3) Створити обмеження, згідно якому кількість примірників не може бути від'ємною.
  4) Створити обмеження на ввід даних в стовпець "Дата здачі" >= "Дата видачі"
  5) Створити обмеження на ввід даних в стовпець "ДатаЗ" < "ДатаДо"*/

--1)
ALTER TABLE OtherReaders
ADD CONSTRAINT CN_OtherReaders_Phone
CHECK (Phone LIKE '[0-9][0-9][0-9] ([0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]')	 
GO

--2)
ALTER TABLE Categories
ADD CONSTRAINT CN_CAtegories_CategoryName
CHECK (CategoryName IN ('Студент','Викладач', 'Разовий читач'))	 
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



-- 5. Створити тригери для таблиць OtherReaders, Studetns, Teachers
-- Тригер на вставку і оновлення даних в таблиці Student
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
	RAISERROR('Запис з таким ID вже існує в таблиці Teachers. 
Ви намагаєтесь добавити викладача до студентів!', 2, 16);
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
	RAISERROR('Запис з таким ID вже існує в таблиці OtherReaders. 
Ви намагаєтесь добавити разового читатча до студентів!', 2, 16);
	ROLLBACK TRAN
END

GO


-- Тригер на вставку і оновлення даних в таблиці OtherReaders
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
	RAISERROR('Запис з таким ID вже існує в таблиці Students. 
Ви намагаєтесь добавити студента до разових читачів!', 3, 17)
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
	RAISERROR('Запис з таким ID вже існує в таблиці Teachers. 
Ви намагаєтесь добавити викладача до разових читачів!', 3, 17)
	ROLLBACK TRAN
END
GO


-- Тригер на вставку і оновлення даних в таблиці Teachers
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
	RAISERROR('Запис з таким ID вже існує в таблиці Student. 
Ви намагаєтесь добавити студента до викладачів!', 4, 18)
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
	RAISERROR('Запис з таким ID вже існує в таблиці OtherReaders. 
Ви намагаєтесь добавити разового читача до викладачів!', 4, 18)
	ROLLBACK TRAN
END
GO




-- 6. Заповнити таблиці даними. 
INSERT DBO.Categories
VALUES (30313233, 'Разовий читач'),
	   (50515253, 'Студент'),
	   (80818283, 'Викладач')
GO

INSERT DBO.Readers (ReaderID, CategoryID, FName, LName, MName)
VALUES (32323, 30313233, 'Варшавський', 'Павло', 'Олександрович'),
	   (33343, 30313233, 'Василенко ', 'Олександр', 'Сергійович'),
	   (33353, 30313233, 'Гереліс', 'Аліна', 'Анатоліївна'),
	   (36363, 30313233, 'Дмитрієвський', 'Владислав', 'Михайлович'),
	   (37373, 30313233, 'Жук', 'Ольга', 'Олександрівна'),
	   (38383, 30313233, 'Колесник', 'Вадим', 'Олександрович'),
	   (39393, 30313233, 'Коркодим', 'Віктор', 'Олександрович '),
	   (30303, 30313233, 'Корнієнко', 'Дмитро ', 'Володимирович'),
	   (31313, 30313233, 'Кушнір', 'Єлізавета', 'Володимирівна'),
	   (34323, 30313233, 'Лабута', 'Ігор', 'Олександрович'),
	   (33333, 30313233, 'Лісовий', 'Руслан', 'Іванович'),
	   (34343, 30313233, 'Ломонос', 'Тетяна', 'Володимирівна'),
	   (35353, 30313233, 'Олексенко', 'Вадим', 'Борисович'),
	   (32043, 30313233, 'Оробей', 'Дмитро', 'Олександрович'),
	   (32073, 30313233, 'Півень', ' Валентина', 'Борисівна'),
	   (32093, 30313233, 'Пазич', 'Євгеній', 'Миколайович'),
	   (34523, 30313233, 'Романенко', 'Євгеній', 'Олександрович'),
	   (37073, 30313233, 'Руденко', ' Олександр', 'Сергійович'),
	   (39063, 30313233, 'Сенчук', 'Наталія', 'Ігорівна'),
	   (39093, 30313233, 'Суслопаров', 'Іван', 'Павлович'),
	   (38023, 30313233, 'Тарасенко', 'Дмитро', 'Андрійович'),
	   (32313, 30313233, 'Черевач', 'Антон', 'Анатолійович'),
	   (34013, 30313233, 'Шевель', 'Олександр', 'Сергійович'),
	   (38723, 30313233, 'Шевченко', 'Ганна ', 'Олександрівна'),
	   (50505, 50515253, 'Воронін', 'Владислав', 'Олександрович'),
	   (51515, 50515253, 'Горбівненко', 'Олександра', 'Миколаївна'),
	   (59595, 50515253, 'Єгоров', 'Павло', 'Вячеславович'),
	   (54545, 50515253, 'Зражевська', 'Анастасія', 'Вадимівна'),
	   (53535, 50515253, 'Луньова', 'Олександра', 'Юліївна'),
	   (52525, 50515253, 'Манзюк', 'Олена', 'Іванівна'),
	   (56565, 50515253, 'Олефір', 'Наталія', 'Валентинівна'),
	   (57575, 50515253, 'Плаксій', 'Катерина', 'Анатоліївна'),
	   (58585, 50515253, 'Рябініна', 'Кіра', 'Олександрівна'),
	   (52035, 50515253, 'Сараєва', 'Наталія', 'Владиславівна'),
	   (50685, 50515253, 'Сонін', 'Іван', 'Ярославович'),
	   (55555, 50515253, 'Сташенко', 'Анна', 'Анатоліївна'),
	   (52095, 50515253, 'Хлопцева', 'Дар’я', 'Миколаївна'),
	   (52075, 50515253, 'Шевченко', 'Світлана', 'Олександрівна'),
	   (53245, 50515253, 'Дяченко', 'Юлія', 'Сергіївна'),
	   (59065, 50515253, 'Єгорова', 'Анна', ' Едуардівна'),
	   (57725, 50515253, 'Зінченко', 'Каміла', 'Едуардівна'),
	   (58345, 50515253, 'Кравченко', ' Каріна', 'Сергіївна'),
	   (54015, 50515253, 'Машкаренко', 'Маргарита', 'Сергіївна'),
	   (50015, 50515253, 'Мельниченко', 'Максим', 'Ігорович'),
	   (50025, 50515253, 'Набережний', 'Назар', 'Назарович'),
	   (58515, 50515253, 'Олексів', 'Богдан', 'Володимирович'),
	   (52485, 50515253, 'Пігнастій', 'Неля', 'Сергіївна'),
	   (52595, 50515253, 'Радченко', 'Єлизавета', 'Петрівна'),
	   (55955, 50515253, 'Тищенко', 'Єлизавета', 'Юріївна'),
	   (56025, 50515253, 'Лозинська', 'Анастасія', 'Ігорівна'),
	   (80808, 80818283, 'Антонюк', 'Віктор', 'Степанович'),
	   (89898, 80818283, 'Артеменко', 'Михайло', 'Юхимович'),
	   (88888, 80818283, 'Бідюк', 'Петро', 'Іванович'),
	   (81818, 80818283, 'Войтко', 'Сергій', 'Васильович'),
	   (82828, 80818283, 'Волошко', 'Світлана', 'Михайлівна'),
	   (83838, 80818283, 'Глоба', 'Лариса', 'Сергіївна'),
	   (84848, 80818283, 'Горобець', 'Оксана', 'Юріївна'),
	   (85858, 80818283, 'Дешко', 'Валерій', 'Іванович'),
	   (86858, 80818283, 'Карвацький', 'Антон', 'Янович'),
	   (87878, 80818283, 'Кузнєцов', 'Юрій', 'Миколайович'),
	   (88988, 80818283, 'Лінючева', 'Ольга', 'Володимирівна'),
	   (80528, 80818283, 'Луговський', 'Олександр', 'Федорович'),
	   (80368, 80818283, 'Мельник', 'Вікторія', 'Миколаївна'),
	   (80188, 80818283, 'Міночкін', 'Дмитро', 'Анатолійович'),
	   (82228, 80818283, 'Панкратова', 'Наталія', 'Дмитрівна'),
	   (83328, 80818283, 'Сівецький', 'Володимир', 'Іванович'),
	   (81198, 80818283, 'Співак', 'Віктор', 'Михайлович'),
	   (86968, 80818283, 'Струтинський', 'Василь', 'Борисович'),
	   (89698, 80818283, 'Уривський', 'Леонід', 'Олександрович'),
	   (87548, 80818283, 'Бондаренко', 'Олександр', 'Федорович'),
	   (82938, 80818283, 'Борис', 'Руслан', 'Степанович'),
	   (84498, 80818283, 'Васильєв', 'Георгій', 'Степанович'),
	   (89038, 80818283, 'Вербицький', 'Євген', 'Володимирович'),
	   (83098, 80818283, 'Веремійчук', 'Юрій', 'Андрійович'),
	   (89998, 80818283, 'Штогріна', 'Олена', 'Сергіївна')
GO
	   
INSERT DBO.RoomReading
VALUES (5243592, 'Зал бібліотекознавчої літератури'),
	   (5272691, 'Зал картографічних видань'),
	   (5278176, 'Зал виставки нових надходжень'),
	   (5244419, 'Зал іноземних періодичних видань'),
	   (5248146, 'Зал електронних ресурсів'),
	   (2881395, 'Зал стародруків і рідкісних видань'),
	   (2340245, 'Зал бібліотечних зібрань та історичних колекцій')
GO

INSERT DBO.Editions
VALUES (2409, 'Санкт-Петербург'),
	   (2754, 'Клуб Сімейного Дозвілля'),
	   (2832, 'Тернопіль "Богдан"'),
	   (2762, 'Київ "Жупанського"'),
	   (2505, 'Харків "Глобус"'),
	   (2555, '"Либідь"'),
	   (2828, '"Русская Редакция"'),  
	   (2932, '"Диалектика"'),
	   (2405, '"Белорусский Дом печати"'),
	   (2232, '"Манн, Иванов и Фербер"'),
	   (2020, 'Питер'),
	   (2025, 'Символ-Плюс'),
	   (2327, 'БХВ-Киев'),
	   (2272, 'Брайт Стар Паблішинг'),
	   (2228, 'Лениздат'),
	   (2727, 'Альпина Паблишер'),
	   (2503, 'Hodder & Stoughton General Publishing Division'),
	   (2626, 'ЭКСМО'),
	   (2929, 'РОСМЭН'),
	   (2222, 'Старого Лева'),
	   (2525, 'Навчальна книга - Богдан'),
	   (2625, 'Країна Мрій'),
	   (2323, 'Альпина нон-фикшн')
GO

INSERT DBO.Authors
VALUES (60102036, 'Ильдар Хабибуллин'),
	   (60405066, 'Стівен Гокінґ'),
	   (61234566, 'Рей Бредбері'),
	   (67890126, 'Джордж Орвелл'),
	   (60001006, 'Стівен Кінг'),
	   (66633566, 'Федір Достоєвський'),
	   (69699696, 'Энн Вебер, Майк Хотек'),
	   (68765436, 'К. Нейгел, Б.Ивьен, Д.Глинн, К.Уотсон'),
	   (61116116, 'К. Нейгел, Джон Д. Рид, М. Скиннер'), 
	   (60090016, 'Роберт Кийосаки'),
	   (61219226, 'Бодо ШЕФЕР'),
	   (62244226, 'Брайан Трейси'),
	   (63655666, 'Мэтт Зандстра'),
	   (61626366, 'Олифер Виктор, Олифер Наталья'),
	   (65555566, 'Марк Саммерфилд'),
	   (60000006, 'Айк Харазян'),
	   (61111116, 'А. Сапковський'),
	   (62222226, 'Джордж Буш'),
	   (63333336, 'А. Цаплієнко'),
	   (64444446, 'С. Пономаренко'),
	   (65555556, 'Даниель Дефо'),
	   (67777776, 'Ребекка Меррилл, Стивен Кови'),
	   (68888886, 'Джойс Перник'),
	   (69999996, 'Джоан Роулинг'),
	   (62966266, 'Р. Риггз'),
	   (61239876, 'Н. Гурницька, Г. Вдовиченко, В. Гранецька та ін.'), 
	   (60606006, 'Ф. Варґас'),
	   (62129656, 'Джеремі Кларксон'),
	   (61919196, 'Карен Блюменталь'),
	   (62929296, 'М. Зузак'),
	   (69686016, 'Т. Ґеррітсен'),
	   (63939396, 'Т. Барабаш'),
	   (64949496, 'Тарас Шевченко'),
	   (65959596, 'Г. Гордасевич'),
	   (66969696, 'М. Ру'),
	   (67979796, 'М. Кідрук'),
	   (62424226, 'Л. Чайлд'),
	   (60197546, 'Е. Ларсон'),
	   (62422426, 'Пауло Коельйо'),
	   (63321326, 'Д. Гартвелл'),
	   (62244866, 'Д. Лаґеркранц'),
	   (64466446, 'Вільям Шекспір'),
	   (65566676, 'Р. Метісон'),
	   (67722786, 'А.К. Дойл '),
	   (64545456, 'Джордж Карлін')
GO

INSERT DBO.Books
VALUES (9925, 'Самоучитель JAVA', 60102036, 2409, 9),
	   (9926, 'Найкоротша історія часу', 60405066, 2754, 17),
	   (9927, '451° за Фаренгейтом', 61234566, 2832, 19),
	   (9928, '1984', 67890126, 2762, 7),
	   (9929, 'Кінець зміни', 60001006, 2505, 9),
	   (9930, 'Ярмарок нічних жахіть', 60001006, 2505, 19),
	   (9931, 'Кінець зміни', 60001006,	2505, 9),
	   (9932, 'Мізері', 60001006, 2505, 12),
	   (9933, 'Відродження', 60001006, 2505, 15),
	   (9934, 'Країна розваг', 60001006, 2505, 29),
	   (9935, 'Зона покриття', 60001006, 2505, 23),
	   (9936, 'МІСТЕР МЕРСЕДЕС', 60001006, 2505, 35),
	   (9937, 'Злочин і кара', 66633566, 2555, 16),
	   (9938, 'Microsoft SQL Server 2008', 69699696, 2828, 3),
	   (9939, 'C# 4 и платформа .NET', 68765436, 2932, 3),
	   (9940, 'Microsoft Visual C# 2008', 61116116,	2405, 5),
	   (9941, 'Как стать богатым', 60090016, 2405, 9),
	   (9942, 'Законы победителей', 61219226, 2505, 1),
	   (9943, 'Выйди из зоны комфорта', 62244226, 2232, 4),
	   (9944, 'PHP. Объекты, шаблоны и методики программирования', 63655666, 2932, 1),
	   (9945, 'Компьютерные сети', 61626366, 2020, 6),
	   (9946, 'Программирование на Python 3', 65555566, 2025, 1),
	   (9947, 'Самоучитель. Язык Swift', 60000006, 2327, 1),
	   (9948, 'Відьмак. Останнє бажання ', 61111116, 2754, 12),
	   (9949, 'Ключові рішення', 62222226, 2272, 11),
	   (9950, 'Книга змін ', 63333336, 2754, 44),
	   (9951, 'Ловушка в Волчьем замке', 64444446, 2754, 14),
	   (9952, 'Чаклун та сфера. Темна вежа IV', 60001006, 2754, 10),
	   (9953, 'Робинзон Крузо', 65555556, 2228, 17),
	   (9954, 'Скорость доверия. То, что меняет всё', 67777776, 2727, 6),
	   (9955, 'Dark Tower. The Wind Through the Keyhole', 60001006,	2503, 2),
	   (9956, 'Майкл Блумберг. Деньги, власть, политика', 68888886,	 2626, 7),
	   (9957, 'Гарри Поттер и Дары Смерти', 69999996, 2929, 9),
	   (9958, 'Библиотека душ', 62966266, 2754, 15),
	   (9959, 'Львів. Кава. Любов', 61239876, 2754, 56),
	   (9960, 'Мерщій тікай і довго не вертайся', 60606006,	2754, 24),
	   (9961, 'Джеремі Кларксон та світ довкола', 62129656,	2222, 2),
	   (9962, 'Чотири сезони', 60001006, 2754, 21),
	   (9963, 'Стів Джобс. Людина, яка мислила по-іншому', 61919196, 2525, 22),
	   (9964, 'ВОНО', 60001006,	2754, 24),
	   (9965, 'Крадійка книжок', 62929296, 2327, 11),
	   (9966, 'Вовки Кальї. Темна вежа V', 60001006, 2754, 23),
	   (9967, 'Доктор Сон', 60001006, 2754, 13),
	   (9968, 'Хірург', 69686016, 2754, 7),
	   (9969, 'Точка обману', 60000006, 2754, 27),
	   (9970, 'Богдан Хмельницький', 63939396, 2754, 18),
	   (9971, 'Кобзар. Повна ілюстрована збірка', 64949496, 2754, 16),
	   (9972, 'Степан Бандера людина і міф', 65959596, 2625, 16),
	   (9973, 'Повернення у притулок', 66969696, 2754, 14),
	   (9974, 'Зазирни у мої сни', 67979796, 2754, 22),
	   (9975, 'Відьмак. Меч призначення', 61111116, 2754, 26),
	   (9976, 'Нездоланний', 62424226, 2754, 25),
	   (9977, 'Диявол у Білому місті', 60197546, 2754, 25),
	   (9978, 'Відьмак. Останнє бажання', 61111116, 2754, 15),
	   (9979, 'Ловець снів', 60001006, 2754, 45),
	   (9980, 'Переможець завжди самотній', 62422426, 2754, 29),
	   (9981, 'Колір зла', 63321326, 2754, 25),
	   (9982, 'Дівчина у павутинні', 62244866, 2754, 20),
	   (9983, 'Вільям Шекспір. Збірка творів', 64466446, 2754, 41),
	   (9984, 'Я - легенда', 65566676,  2754, 49),
	   (9985, 'Повернення Шерлока Холмса', 67722786, 2625, 35),
	   (9986, 'Будущее уже не то, что прежде', 64545456,	2323, 3)
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
VALUES (90987659, 'Фінанси , банківська справа та страхування'),
	   (90123459, 'Право'),
	   (97080909, 'Економічний'),
	   (94050609, 'Географічний'),
	   (93215679, 'Харчові технології'),
	   (91020309, 'Готельно-ресторанна справа'),
	   (98765439, 'Інженерія програмного забезпечення'),
	   (91234569, 'Підприємництво, торгівля та біржова діяльність')
GO

INSERT DBO.Students
VALUES (50505, 'ПВ(н)-16',  90123459),
	   (51515, 'ПВ(н)-26',  90123459),
	   (59595, 'ПТБ(н)-16', 97080909),
	   (54545, 'РО(н)-14',  97080909),
	   (53535, 'ПК(н)-16',  98765439),
	   (52525, 'ФН-ОЦ-16',  90987659),
	   (56565, 'ХТ(н)-16',  93215679),
	   (57575, 'ГРС(н)-16', 94050609),
	   (58585, 'ПТБ-16',    97080909),
	   (52035, 'КТ-ТМ-15',  91234569),
	   (50685, 'ТВ-ТМ-15',  91234569),
	   (55555, 'КТ-14',	    91234569),
	   (52095, 'ТМ-14',     91234569),
	   (52075, 'ПВ-16',     90123459),
	   (53245, 'ПВ(н)-15',  90123459),
	   (59065, 'ПВ(н)-14',  90123459),
	   (57725, 'ПВ(н)-24',  90123459),
	   (58345, 'ПВ-14',	    90123459),
	   (54015, 'ПВ(н)-13',  90123459),
	   (50015, 'ПК(н)-15',  98765439),
	   (50025, 'ПК(н)-14',  98765439),
	   (58515, 'ФН-ОЦ-15',  90987659),
	   (52485, 'ФН-14',	    90987659),
	   (52595, 'ОЦ-14',		90987659),
	   (55955, 'ОГ(н)-15',  91020309),
	   (56025, 'ТХ(н)-15',  93215679)
GO

INSERT DBO.Cathedra
VALUES (19128731, 'Готельно-ресторанної справи'),
	   (12345671, 'Публічне право'),
	   (19876541, 'Банківська справа'),
	   (10102031, 'Оціночна діяльність'),
	   (10908071, 'Товарознавство в митній справі'),
	   (18765431, 'Комп`ютерних систем та мереж'),
	   (15432101, 'Безпеки, експертизи та товарознавства'),
	   (15436781, 'Економіки підприємства та управління персоналом')
GO

INSERT DBO.[Degrees]
VALUES (222222, 'Викладач'),
	   (232322, 'Старший викладач'),
	   (244562, 'Голова предметної (циклової) комісії'),
	   (232772, 'Заступник директора'),
	   (266772, 'Асистент'),
	   (211342, 'Директор бібліотеки'),
	   (201202, 'Декан'),
	   (220252, 'Доцент'),
	   (242822, 'Професор'),
	   (262722, 'Завідувач кафедри'),
	   (292822, 'Проректор'),
	   (205052, 'Ректор')
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



-- 7. Створити запити

/* 1) Отримати перелік і загальне число читачів для даного читального залу або абонента,
або по всій бібліотеці, за ознакою приналежності до кафедри, факультету, курсу,
навчальній групі. */

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

EXEC spFirstSelect 'Право'
GO

/* 2) Отримати список і загальне число всіх читачів-боржників, боржників з терміном
більше 10 днів на даному абоненті або по всій бібліотеці, за ознакою приналежності
до кафедри, факультету, курсу, групі, за категоріями читачів. */

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

EXEC spSecondSelect 'Право'
GO

/* 3) Отримати перелік двадцяти книг, які найчастіше замовляються в даному читальному
залі для даного факультету, для всього ВНЗу. */

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

/* 4) Отримати перелік і загальне число книг, що надійшли/загублені за останній рік, для
даного читального залу, абонента або по всій бібліотеці, за вказаним автором, роком
випуску, роком надходження до бібліотеки. */

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

EXEC spForthSelect 'Зал виставки нових надходжень'
GO

/* 5) Визначити пункт видачі, з найбільшою (найменшою) кількістю читачів, читачів-
боржників, найбільша сума заборгованості. */

CREATE PROC spFifthSelect
AS
	SELECT COUNT(GB.RoomID) AS 'Кількість', GB.RoomID, RR.RoomName
	FROM DBO.RoomReading RR
	JOIN DBO.GiveBook GB
	ON RR.RoomID = GB.RoomID
	GROUP BY GB.RoomID, RR.RoomName
	ORDER BY COUNT(GB.RoomID) DESC
GO

EXEC spFifthSelect
GO

/* 6) Отримати перелік і загальне число книг, замовлених на міжбібліотечному абонементі
за останній місяць, семестр, рік. */

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

EXEC spSixthSelect 'Студент', 'Викладач', '15-03-2017', '15-04-2017'
GO

/* 7) Отримати кількість примірників книги для даного читального залу або абонента, у 
всій бібліотеці, всіх видань. */

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

EXEC spSeventhSelect 'Зал бібліотечних зібрань та історичних колекцій', 'Повернення Шерлока Холмса'
GO

/* 8) Отримати перелік і загальне число читачів, позбавлених права користування
бібліотекою, терміном більше двох місяців, у всій бібліотеці, за ознакою
приналежності до кафедри, факультету, курсу, групі, за категоріями читачів. */ 

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

EXEC spEighthSelect 30, 'Право'
GO

/* 9) Отримати перелік і загальне число нових читачів та читачів які вибули для даного
читального залу або абонента за останній місяць, семестр, рік, у всій бібліотеці, за
ознакою приналежності до кафедри, факультету, курсу, групі, за категоріями читачів. */

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

EXEC spNinthSelect '01-04-2017', '15-04-2017', 'Зал бібліотекознавчої літератури'
GO
 
/* 10) Отримати перелік і загальне число книг, замовлених даними читачем за останній  
місяць, семестр, рік, список книг, які у нього на руках. */

CREATE PROC spTenthSelect
	@LName nvarchar(20), @DateTakeWith date, @DateTakeTo date
AS
	SELECT B.BookName AS 'Книги'
	FROM DBO.Books B
	JOIN DBO.GiveBook GB
	ON B.BookID = GB.BookID
	JOIN DBO.Readers R 
	ON GB.ReaderID = R.ReaderID
	WHERE R.LName = @LName AND GB.DateTake BETWEEN @DateTakeWith AND @DateTakeTo
GO

EXEC spTenthSelect 'Штогріна', '02-04-2017', '30-04-2017'
GO

/* 11) Визначити, чи є дана книга в наявності на абонементах, і в якій кількості. */

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

EXEC spEleventhSelect 'Студент', 'Викладач', 'Колір зла'
GO

/* 12) Отримати перелік читачів, у яких на руках деяка книга і читача, який раніше за всіх її
повинен здати. */

SELECT R.LName, R.FName, R.MName, GB.DateTake, GB.DateGive -- INTO DateMin
FROM DBO.Books B
JOIN DBO.GiveBook GB
ON B.BookID = GB.BookID
JOIN DBO.Readers R
ON GB.ReaderID = R.ReaderID
WHERE B.BookName = 'Точка обману';
GO

SELECT R.FName, R.LName, R.MName
FROM DateMin R
WHERE R.DateGive = (SELECT MIN(C.DateGive)
					FROM DBO.DateMin C)
GO

/* 13) Видати повну інформацію про групу, курс, факультет або кафедру, правопорушення,
їх кількість, штрафи, втрачені книги тощо по заданому прізвищу читача. */

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

EXEC spThirteenthSelect 'Радченко'
GO
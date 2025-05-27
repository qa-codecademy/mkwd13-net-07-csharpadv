IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SEDC_DEMO_SHARP')
BEGIN
    CREATE DATABASE [SEDC_DEMO_SHARP];
END
GO

USE [SEDC_DEMO_SHARP]
GO

DROP TABLE IF EXISTS [dbo].[Student]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[DateOfBirth] [date] NULL,
	[EnrolledDate] [date] NULL,
	[Gender] [nchar](1) NULL,
	[NationalIdNumber] [bigint] NULL,
	[StudentCardNumber] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (1, N'Kalin', N'Mitev', CAST(N'1991-04-10' AS Date), CAST(N'2010-10-08' AS Date), N'M', 391983, N'sc-77618')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (2, N'Gjurgja', N'Jovanova', CAST(N'1985-05-10' AS Date), CAST(N'2003-08-08' AS Date), N'F', 446053, N'sc-98558')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (3, N'Serafim', N'Atanasov', CAST(N'1996-03-13' AS Date), CAST(N'2015-12-23' AS Date), N'M', 411193, N'sc-89758')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (4, N'Milica', N'Trajkova', CAST(N'1993-10-25' AS Date), CAST(N'2012-08-04' AS Date), N'F', 357382, N'sc-17922')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (5, N'Teofilka', N'Ilievska', CAST(N'1983-01-05' AS Date), CAST(N'2001-09-21' AS Date), N'F', 706346, N'sc-79836')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (6, N'Vangja', N'Simonovska', CAST(N'1989-02-02' AS Date), CAST(N'2008-01-09' AS Date), N'F', 289992, N'sc-59022')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (7, N'Vera', N'Aleksovska', CAST(N'1986-01-29' AS Date), CAST(N'2006-01-04' AS Date), N'F', 408320, N'sc-72965')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (8, N'Sirma', N'Nikolovska', CAST(N'1988-03-07' AS Date), CAST(N'2007-08-25' AS Date), N'F', 688007, N'sc-68867')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (9, N'Manuel', N'Velkovski', CAST(N'1981-06-26' AS Date), CAST(N'2002-03-03' AS Date), N'M', 698772, N'sc-26866')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (10, N'Gjorgjija', N'Mitev', CAST(N'1998-02-13' AS Date), CAST(N'2018-08-01' AS Date), N'M', 713806, N'sc-77736')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (11, N'Gjoko', N'Ristevski', CAST(N'1997-10-20' AS Date), CAST(N'2017-12-02' AS Date), N'M', 842177, N'sc-76953')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (12, N'Florinka', N'Jakimovska', CAST(N'1985-10-12' AS Date), CAST(N'2003-12-05' AS Date), N'F', 966770, N'sc-44094')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (13, N'Despot', N'Gjorgjievski', CAST(N'1989-07-02' AS Date), CAST(N'2008-05-14' AS Date), N'M', 304186, N'sc-75206')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (14, N'Persa', N'Janeva', CAST(N'1987-03-12' AS Date), CAST(N'2006-08-21' AS Date), N'F', 452037, N'sc-35408')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (15, N'Lambe', N'Cvetkovski', CAST(N'1982-07-06' AS Date), CAST(N'2003-01-01' AS Date), N'M', 900011, N'sc-44849')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (16, N'Jovana', N'Lazarova', CAST(N'1997-07-07' AS Date), CAST(N'2018-05-05' AS Date), N'F', 209752, N'sc-54134')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (17, N'Evtim', N'Trajkov', CAST(N'1994-10-14' AS Date), CAST(N'2013-02-19' AS Date), N'M', 925080, N'sc-76061')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (18, N'Marjan', N'Gjorgjievski', CAST(N'1986-02-08' AS Date), CAST(N'2005-08-13' AS Date), N'M', 664591, N'sc-99432')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (19, N'Efrem', N'Janev', CAST(N'1992-06-14' AS Date), CAST(N'2010-10-31' AS Date), N'M', 741763, N'sc-61737')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (20, N'Katerina', N'Dimova', CAST(N'1998-02-24' AS Date), CAST(N'2016-08-31' AS Date), N'F', 703519, N'sc-79890')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (21, N'Teodora', N'Nikoloska', CAST(N'1989-07-15' AS Date), CAST(N'2007-07-29' AS Date), N'F', 885066, N'sc-96968')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (22, N'Donka', N'Jovanovska', CAST(N'1985-05-06' AS Date), CAST(N'2005-08-09' AS Date), N'F', 398365, N'sc-28144')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (23, N'Efrosina', N'Taseva', CAST(N'1999-03-22' AS Date), CAST(N'2018-07-29' AS Date), N'F', 920340, N'sc-89988')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (24, N'Natalija', N'Pavlovska', CAST(N'1995-10-29' AS Date), CAST(N'2015-12-30' AS Date), N'F', 715908, N'sc-81950')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (25, N'Atanasija', N'Ivanova', CAST(N'1982-11-24' AS Date), CAST(N'2003-10-31' AS Date), N'F', 702902, N'sc-27721')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (26, N'Krstana', N'Stefanovska', CAST(N'1993-07-31' AS Date), CAST(N'2013-11-24' AS Date), N'F', 109170, N'sc-95863')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (27, N'Maksim', N'Petrushevski', CAST(N'1984-08-08' AS Date), CAST(N'2005-03-29' AS Date), N'M', 187782, N'sc-15071')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (28, N'Daniel', N'Kostadinov', CAST(N'1993-11-09' AS Date), CAST(N'2014-01-24' AS Date), N'M', 646907, N'sc-35280')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (29, N'Gerasim', N'Ristevski', CAST(N'1995-02-28' AS Date), CAST(N'2013-12-20' AS Date), N'M', 203301, N'sc-85856')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (30, N'Nikita', N'Ristovski', CAST(N'1999-01-16' AS Date), CAST(N'2019-02-07' AS Date), N'M', 329170, N'sc-50625')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (31, N'Klimentina', N'Stojanovska', CAST(N'1991-06-12' AS Date), CAST(N'2012-05-01' AS Date), N'F', 286475, N'sc-30608')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (32, N'Veljana', N'Krstevska', CAST(N'1985-02-09' AS Date), CAST(N'2003-06-04' AS Date), N'F', 940584, N'sc-29221')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (33, N'Grozdan', N'Asani', CAST(N'1980-08-30' AS Date), CAST(N'1998-12-07' AS Date), N'M', 934543, N'sc-43715')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (34, N'Trpana', N'Cvetanovska', CAST(N'1988-01-08' AS Date), CAST(N'2006-06-16' AS Date), N'F', 890322, N'sc-48959')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (35, N'Zivka', N'Petrushevska', CAST(N'1996-04-30' AS Date), CAST(N'2016-02-16' AS Date), N'F', 788231, N'sc-16865')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (36, N'Zaklina', N'Miloshevska', CAST(N'1994-01-08' AS Date), CAST(N'2014-10-13' AS Date), N'F', 909872, N'sc-67398')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (37, N'Bogdan', N'Dimitrov', CAST(N'1990-07-09' AS Date), CAST(N'2009-04-05' AS Date), N'M', 168878, N'sc-25329')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (38, N'Karanfilka', N'Tasevska', CAST(N'1980-05-07' AS Date), CAST(N'1998-08-19' AS Date), N'F', 746949, N'sc-28425')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (39, N'Krstana', N'Miteva', CAST(N'1990-04-04' AS Date), CAST(N'2011-01-31' AS Date), N'F', 875376, N'sc-40951')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (40, N'Elica', N'Kostovska', CAST(N'1981-04-12' AS Date), CAST(N'2000-08-13' AS Date), N'F', 401728, N'sc-24211')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (41, N'Ristana', N'Stojkova', CAST(N'1992-06-25' AS Date), CAST(N'2012-04-20' AS Date), N'F', 403426, N'sc-40770')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (42, N'Eva', N'Taseva', CAST(N'1991-10-31' AS Date), CAST(N'2011-08-25' AS Date), N'F', 858442, N'sc-48400')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (43, N'Paskal', N'Dimitrov', CAST(N'1994-07-14' AS Date), CAST(N'2013-10-05' AS Date), N'M', 254752, N'sc-85195')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (44, N'Nikita', N'Ivanovski', CAST(N'1992-07-13' AS Date), CAST(N'2011-09-15' AS Date), N'M', 781807, N'sc-22478')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (45, N'Milena', N'Blazevska', CAST(N'1998-10-10' AS Date), CAST(N'2019-06-27' AS Date), N'F', 182247, N'sc-42724')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (46, N'Vasilka', N'Taseva', CAST(N'1994-12-29' AS Date), CAST(N'2013-03-18' AS Date), N'F', 513522, N'sc-30244')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (47, N'Risto', N'Jakimovski', CAST(N'1996-08-10' AS Date), CAST(N'2016-10-08' AS Date), N'M', 755227, N'sc-54291')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (48, N'Elisaveta', N'Petkovska', CAST(N'1994-09-05' AS Date), CAST(N'2013-06-21' AS Date), N'F', 373583, N'sc-96615')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (49, N'Gligor', N'Ristovski', CAST(N'1996-05-28' AS Date), CAST(N'2016-08-09' AS Date), N'M', 657550, N'sc-70684')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (50, N'Nedelko', N'Simonovski', CAST(N'1990-01-20' AS Date), CAST(N'2008-09-12' AS Date), N'M', 912533, N'sc-34761')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (51, N'Janakij', N'Donev', CAST(N'1995-07-19' AS Date), CAST(N'2016-05-16' AS Date), N'M', 314534, N'sc-19798')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (52, N'Roska', N'Mihajlovska', CAST(N'1987-07-10' AS Date), CAST(N'2005-07-05' AS Date), N'F', 269234, N'sc-73472')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (53, N'Marko', N'Spasovski', CAST(N'1985-01-05' AS Date), CAST(N'2004-10-05' AS Date), N'M', 937432, N'sc-58201')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (54, N'Snezana', N'Dimitrova', CAST(N'1986-01-17' AS Date), CAST(N'2005-11-02' AS Date), N'F', 718910, N'sc-46724')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (55, N'Sande', N'Nikoloski', CAST(N'1989-10-22' AS Date), CAST(N'2008-03-14' AS Date), N'M', 853396, N'sc-86056')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (56, N'Lenka', N'Ristevska', CAST(N'1996-03-30' AS Date), CAST(N'2015-09-15' AS Date), N'F', 955847, N'sc-71160')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (57, N'Veronika', N'Jovanova', CAST(N'1995-03-03' AS Date), CAST(N'2013-06-13' AS Date), N'F', 416170, N'sc-80925')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (58, N'Bozana', N'Dimitrova', CAST(N'1996-07-23' AS Date), CAST(N'2015-05-22' AS Date), N'F', 212564, N'sc-82719')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (59, N'Cvetan', N'Todorovski', CAST(N'1993-05-21' AS Date), CAST(N'2012-01-20' AS Date), N'M', 115384, N'sc-87877')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (60, N'Mileva', N'Angelova', CAST(N'1986-04-26' AS Date), CAST(N'2006-06-14' AS Date), N'F', 570047, N'sc-94871')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (61, N'Boshko', N'Jovanoski', CAST(N'1979-11-17' AS Date), CAST(N'1999-01-13' AS Date), N'M', 512766, N'sc-87238')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (62, N'Metodij', N'Jakimovski', CAST(N'1996-01-12' AS Date), CAST(N'2014-11-04' AS Date), N'M', 306247, N'sc-38476')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (63, N'Serafim', N'Krstevski', CAST(N'1997-03-06' AS Date), CAST(N'2015-07-20' AS Date), N'M', 760003, N'sc-68903')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (64, N'Zorka', N'Todorova', CAST(N'1985-11-03' AS Date), CAST(N'2005-09-01' AS Date), N'F', 347168, N'sc-61120')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (65, N'Danail', N'Atanasovski', CAST(N'1982-07-05' AS Date), CAST(N'2002-05-04' AS Date), N'M', 817496, N'sc-49868')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (66, N'Todorka', N'Poposka', CAST(N'1993-05-27' AS Date), CAST(N'2011-12-08' AS Date), N'F', 678794, N'sc-91339')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (67, N'Lena', N'Petrova', CAST(N'1997-01-08' AS Date), CAST(N'2016-01-01' AS Date), N'F', 466454, N'sc-38507')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (68, N'Mileva', N'Stojanova', CAST(N'1994-10-03' AS Date), CAST(N'2015-01-13' AS Date), N'F', 314240, N'sc-46449')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (69, N'Gjuro', N'Petrov', CAST(N'1983-10-28' AS Date), CAST(N'2002-12-21' AS Date), N'M', 677511, N'sc-86701')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (70, N'Suzana', N'Nikoloska', CAST(N'1991-06-14' AS Date), CAST(N'2011-09-13' AS Date), N'F', 422093, N'sc-54217')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (71, N'Borjana', N'Ristovska', CAST(N'1994-02-14' AS Date), CAST(N'2012-12-08' AS Date), N'F', 172623, N'sc-33244')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (72, N'Teodor', N'Stojanoski', CAST(N'1996-08-20' AS Date), CAST(N'2015-08-21' AS Date), N'M', 401629, N'sc-22132')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (73, N'Rajko', N'Nikoloski', CAST(N'1993-10-13' AS Date), CAST(N'2013-01-07' AS Date), N'M', 128479, N'sc-49687')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (74, N'Gorjana', N'Jakimovska', CAST(N'1987-06-22' AS Date), CAST(N'2008-01-12' AS Date), N'F', 946161, N'sc-10332')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (75, N'Rada', N'Stojanovska', CAST(N'1994-12-16' AS Date), CAST(N'2013-01-20' AS Date), N'F', 408691, N'sc-10236')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (76, N'Blaga', N'Arsovska', CAST(N'1993-03-16' AS Date), CAST(N'2013-12-30' AS Date), N'F', 968866, N'sc-12707')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (77, N'Vojo', N'Kocev', CAST(N'1980-10-31' AS Date), CAST(N'2000-03-20' AS Date), N'M', 616958, N'sc-22361')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (78, N'Jakov', N'Asani', CAST(N'1981-12-02' AS Date), CAST(N'2001-07-10' AS Date), N'M', 786908, N'sc-26056')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (79, N'Bozidar', N'Petrushevski', CAST(N'1990-01-31' AS Date), CAST(N'2009-08-18' AS Date), N'M', 870001, N'sc-98605')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (80, N'Vasilka', N'Nikoloska', CAST(N'1995-02-13' AS Date), CAST(N'2015-03-11' AS Date), N'F', 306824, N'sc-62729')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (81, N'Emanuel', N'Ilievski', CAST(N'1990-12-07' AS Date), CAST(N'2011-09-26' AS Date), N'M', 461528, N'sc-26512')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (82, N'Nikifor', N'Donev', CAST(N'1983-11-08' AS Date), CAST(N'2003-05-24' AS Date), N'M', 825433, N'sc-63568')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (83, N'Anastasija', N'Gjorgjieva', CAST(N'1996-05-28' AS Date), CAST(N'2016-06-06' AS Date), N'F', 952152, N'sc-86302')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (84, N'Karanfilka', N'Mladenovska', CAST(N'1993-01-27' AS Date), CAST(N'2013-04-15' AS Date), N'F', 766932, N'sc-28971')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (85, N'Zorica', N'Aleksovska', CAST(N'1996-07-15' AS Date), CAST(N'2017-03-05' AS Date), N'F', 825259, N'sc-58771')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (86, N'Divna', N'Stojkovska', CAST(N'1985-03-30' AS Date), CAST(N'2004-12-02' AS Date), N'F', 814836, N'sc-90604')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (87, N'Simona', N'Todorovska', CAST(N'1996-10-24' AS Date), CAST(N'2016-11-05' AS Date), N'F', 341378, N'sc-39770')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (88, N'Ksenija', N'Lazarova', CAST(N'1985-01-25' AS Date), CAST(N'2006-01-19' AS Date), N'F', 139140, N'sc-73332')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (89, N'Sotir', N'Arsovski', CAST(N'1989-12-21' AS Date), CAST(N'2008-01-19' AS Date), N'M', 597583, N'sc-46972')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (90, N'Sofija', N'Petrovska', CAST(N'1985-02-01' AS Date), CAST(N'2004-04-03' AS Date), N'F', 140409, N'sc-37916')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (91, N'Gjurcin', N'Ristovski', CAST(N'1995-12-02' AS Date), CAST(N'2015-03-21' AS Date), N'M', 923768, N'sc-49893')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (92, N'Angja', N'Trajkovska', CAST(N'1990-01-27' AS Date), CAST(N'2010-12-11' AS Date), N'F', 718638, N'sc-34656')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (93, N'Ljubomir', N'Angelov', CAST(N'1991-01-02' AS Date), CAST(N'2010-05-29' AS Date), N'M', 181429, N'sc-48773')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (94, N'Olivera', N'Dimitrova', CAST(N'1986-08-12' AS Date), CAST(N'2006-11-25' AS Date), N'F', 975432, N'sc-52927')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (95, N'Blagorodna', N'Ristovska', CAST(N'1990-01-11' AS Date), CAST(N'2010-04-03' AS Date), N'F', 919471, N'sc-84993')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (96, N'Sonja', N'Cvetkovska', CAST(N'1993-06-29' AS Date), CAST(N'2014-04-20' AS Date), N'F', 305634, N'sc-35838')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (97, N'Trajanka', N'Stojcevska', CAST(N'1993-07-14' AS Date), CAST(N'2013-06-08' AS Date), N'F', 736569, N'sc-98334')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (98, N'Stojanka', N'Tasevska', CAST(N'1980-04-27' AS Date), CAST(N'2000-12-28' AS Date), N'F', 835344, N'sc-80969')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (99, N'Nada', N'Ivanova', CAST(N'1990-12-24' AS Date), CAST(N'2011-06-30' AS Date), N'F', 393115, N'sc-77101')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (100, N'Zvonko', N'Petreski', CAST(N'1983-01-17' AS Date), CAST(N'2003-12-19' AS Date), N'M', 181249, N'sc-56376')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (101, N'Denica', N'Stankovska', CAST(N'1987-05-12' AS Date), CAST(N'2006-03-19' AS Date), N'F', 105604, N'sc-21370')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (102, N'Teodor', N'Ristov', CAST(N'1990-09-26' AS Date), CAST(N'2010-03-17' AS Date), N'M', 897203, N'sc-43624')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (103, N'Donka', N'Ristova', CAST(N'1997-11-17' AS Date), CAST(N'2016-05-05' AS Date), N'F', 564967, N'sc-64427')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (104, N'Oliver', N'Angelovski', CAST(N'1989-05-23' AS Date), CAST(N'2007-11-25' AS Date), N'M', 502785, N'sc-40215')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (105, N'Simeona', N'Ivanovska', CAST(N'1996-10-24' AS Date), CAST(N'2015-09-09' AS Date), N'F', 700957, N'sc-93929')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (106, N'Divna', N'Tasevska', CAST(N'1990-05-21' AS Date), CAST(N'2009-06-25' AS Date), N'F', 345863, N'sc-35529')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (107, N'Dragana', N'Koceva', CAST(N'1985-11-18' AS Date), CAST(N'2004-08-05' AS Date), N'F', 961526, N'sc-77789')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (108, N'Cedomir', N'Dimitrievski', CAST(N'1984-11-30' AS Date), CAST(N'2005-06-25' AS Date), N'M', 534528, N'sc-17223')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (109, N'Sande', N'Gjorgjiev', CAST(N'1980-01-06' AS Date), CAST(N'2000-03-03' AS Date), N'M', 757694, N'sc-84466')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (110, N'Georgi', N'Stojkovski', CAST(N'1997-08-25' AS Date), CAST(N'2016-02-12' AS Date), N'M', 853301, N'sc-44872')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (111, N'Paraskeva', N'Jovanova', CAST(N'1979-08-17' AS Date), CAST(N'1997-09-30' AS Date), N'F', 944661, N'sc-25949')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (112, N'Igor', N'Petreski', CAST(N'1989-08-16' AS Date), CAST(N'2009-09-22' AS Date), N'M', 857526, N'sc-22373')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (113, N'Jasminka', N'Nikoloska', CAST(N'1985-10-22' AS Date), CAST(N'2004-05-12' AS Date), N'F', 293480, N'sc-16239')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (114, N'Sandra', N'Cvetanovska', CAST(N'1984-08-17' AS Date), CAST(N'2003-09-06' AS Date), N'F', 787856, N'sc-28125')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (115, N'Nestor', N'Angelovski', CAST(N'1994-07-15' AS Date), CAST(N'2013-03-18' AS Date), N'M', 790370, N'sc-85965')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (116, N'Fidan', N'Petkovski', CAST(N'1984-05-09' AS Date), CAST(N'2004-07-23' AS Date), N'M', 464991, N'sc-71950')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (117, N'Ubavka', N'Dodevska', CAST(N'1992-05-12' AS Date), CAST(N'2012-01-13' AS Date), N'F', 680549, N'sc-57786')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (118, N'Rahela', N'Ivanova', CAST(N'1985-07-05' AS Date), CAST(N'2005-06-18' AS Date), N'F', 743946, N'sc-88826')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (119, N'Dimitar', N'Stojanoski', CAST(N'1981-03-17' AS Date), CAST(N'2000-07-28' AS Date), N'M', 456478, N'sc-52308')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (120, N'Temelko', N'Dodevski', CAST(N'1982-07-12' AS Date), CAST(N'2001-01-04' AS Date), N'M', 772667, N'sc-47163')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (121, N'Rusalina', N'Miloshevska', CAST(N'1990-02-24' AS Date), CAST(N'2009-03-16' AS Date), N'F', 108110, N'sc-62068')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (122, N'Olga', N'Jakimovska', CAST(N'1994-08-16' AS Date), CAST(N'2012-09-08' AS Date), N'F', 530045, N'sc-10965')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (123, N'Tihomir', N'Dimov', CAST(N'1981-11-02' AS Date), CAST(N'2001-11-07' AS Date), N'M', 279473, N'sc-40543')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (124, N'Jasna', N'Markovska', CAST(N'1993-04-26' AS Date), CAST(N'2012-10-20' AS Date), N'F', 586892, N'sc-43205')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (125, N'Stamen', N'Bogdanovski', CAST(N'1987-10-31' AS Date), CAST(N'2005-12-27' AS Date), N'M', 158336, N'sc-59955')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (126, N'Petranka', N'Ivanovska', CAST(N'1995-06-26' AS Date), CAST(N'2016-03-30' AS Date), N'F', 870771, N'sc-64219')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (127, N'Zlata', N'Velkovska', CAST(N'1982-03-15' AS Date), CAST(N'2001-12-29' AS Date), N'F', 913877, N'sc-68614')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (128, N'Evtim', N'Stankovski', CAST(N'1981-12-05' AS Date), CAST(N'2000-06-17' AS Date), N'M', 766965, N'sc-23423')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (129, N'Vesna', N'Mihajlovska', CAST(N'1980-12-23' AS Date), CAST(N'1999-01-04' AS Date), N'F', 514288, N'sc-69187')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (130, N'Eva', N'Dimitrova', CAST(N'1994-11-15' AS Date), CAST(N'2014-05-25' AS Date), N'F', 720567, N'sc-27815')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (131, N'Despot', N'Mladenovski', CAST(N'1980-10-23' AS Date), CAST(N'2000-03-04' AS Date), N'M', 916966, N'sc-32896')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (132, N'Zlatko', N'Stefanovski', CAST(N'1981-06-05' AS Date), CAST(N'2001-05-13' AS Date), N'M', 407569, N'sc-11238')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (133, N'Serafim', N'Arsov', CAST(N'1980-11-01' AS Date), CAST(N'1999-03-05' AS Date), N'M', 912435, N'sc-26415')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (134, N'Bozana', N'Lazarova', CAST(N'1994-04-20' AS Date), CAST(N'2012-08-31' AS Date), N'F', 183539, N'sc-61870')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (135, N'Donka', N'Trajkova', CAST(N'1983-12-30' AS Date), CAST(N'2004-05-03' AS Date), N'F', 293741, N'sc-79381')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (136, N'Gjoko', N'Bozinovski', CAST(N'1990-10-09' AS Date), CAST(N'2010-11-13' AS Date), N'M', 101030, N'sc-89608')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (137, N'Vangja', N'Ivanova', CAST(N'1989-09-15' AS Date), CAST(N'2008-01-21' AS Date), N'F', 790707, N'sc-17712')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (138, N'Florinka', N'Mitreska', CAST(N'1985-07-30' AS Date), CAST(N'2006-07-07' AS Date), N'F', 477862, N'sc-76790')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (139, N'Veljana', N'Miloshevska', CAST(N'1998-06-28' AS Date), CAST(N'2016-11-18' AS Date), N'F', 687690, N'sc-10622')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (140, N'Panche', N'Atanasovski', CAST(N'1980-05-21' AS Date), CAST(N'1999-03-01' AS Date), N'M', 965085, N'sc-87095')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (141, N'Zvonko', N'Ivanov', CAST(N'1993-11-25' AS Date), CAST(N'2013-01-28' AS Date), N'M', 308016, N'sc-82805')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (142, N'Donco', N'Kostovski', CAST(N'1989-01-29' AS Date), CAST(N'2009-12-16' AS Date), N'M', 349385, N'sc-89938')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (143, N'Vera', N'Ilievska', CAST(N'1993-02-16' AS Date), CAST(N'2011-05-09' AS Date), N'F', 696249, N'sc-92282')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (144, N'Liljana', N'Jovanovska', CAST(N'1992-06-07' AS Date), CAST(N'2010-08-27' AS Date), N'F', 162594, N'sc-81469')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (145, N'Teodosij', N'Stojanovski', CAST(N'1998-02-08' AS Date), CAST(N'2016-05-20' AS Date), N'M', 446103, N'sc-33993')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (146, N'Stefanija', N'Popovska', CAST(N'1982-10-06' AS Date), CAST(N'2002-06-03' AS Date), N'F', 351744, N'sc-78752')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (147, N'Lena', N'Ilieva', CAST(N'1985-03-29' AS Date), CAST(N'2004-03-22' AS Date), N'F', 305619, N'sc-89367')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (148, N'Janko', N'Dimitrievski', CAST(N'1998-11-02' AS Date), CAST(N'2017-11-05' AS Date), N'M', 915092, N'sc-80057')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (149, N'Zdravko', N'Stojkovski', CAST(N'1991-12-05' AS Date), CAST(N'2010-09-15' AS Date), N'M', 646453, N'sc-14311')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (150, N'Branko', N'Tasevski', CAST(N'1980-04-24' AS Date), CAST(N'2000-06-26' AS Date), N'M', 365534, N'sc-94526')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (151, N'Ratka', N'Mitrevska', CAST(N'1979-09-16' AS Date), CAST(N'2000-08-07' AS Date), N'F', 980492, N'sc-75359')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (152, N'Ljupco', N'Stefanovski', CAST(N'1999-02-15' AS Date), CAST(N'2018-04-02' AS Date), N'M', 694192, N'sc-69286')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (153, N'Ljubinka', N'Cvetanovska', CAST(N'1985-05-16' AS Date), CAST(N'2003-10-27' AS Date), N'F', 566066, N'sc-88917')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (154, N'Rahela', N'Petrovska', CAST(N'1980-02-08' AS Date), CAST(N'2000-09-14' AS Date), N'F', 521307, N'sc-67358')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (155, N'Elica', N'Cvetanovska', CAST(N'1991-11-20' AS Date), CAST(N'2011-12-16' AS Date), N'F', 836348, N'sc-41616')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (156, N'Kocho', N'Mitev', CAST(N'1995-12-26' AS Date), CAST(N'2015-06-05' AS Date), N'M', 769825, N'sc-82231')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (157, N'Fanija', N'Jakimovska', CAST(N'1999-03-28' AS Date), CAST(N'2019-10-28' AS Date), N'F', 744286, N'sc-95361')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (158, N'Zorica', N'Jovanoska', CAST(N'1994-07-10' AS Date), CAST(N'2014-11-06' AS Date), N'F', 900011, N'sc-12162')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (159, N'Florinka', N'Kostovska', CAST(N'1985-09-25' AS Date), CAST(N'2005-08-30' AS Date), N'F', 515199, N'sc-99579')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (160, N'Stefanija', N'Ilievska', CAST(N'1993-04-05' AS Date), CAST(N'2012-04-22' AS Date), N'F', 196228, N'sc-17405')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (161, N'Zaklina', N'Petrova', CAST(N'1997-05-17' AS Date), CAST(N'2017-05-17' AS Date), N'F', 764057, N'sc-52013')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (162, N'Roska', N'Jakimovska', CAST(N'1991-01-22' AS Date), CAST(N'2010-03-08' AS Date), N'F', 476757, N'sc-75874')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (163, N'Zagorka', N'Bozinovska', CAST(N'1993-11-02' AS Date), CAST(N'2013-08-23' AS Date), N'F', 829735, N'sc-77870')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (164, N'Rumena', N'Gjorgjievska', CAST(N'1994-03-30' AS Date), CAST(N'2013-03-16' AS Date), N'F', 184977, N'sc-26935')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (165, N'Gordana', N'Petreska', CAST(N'1989-10-14' AS Date), CAST(N'2009-05-19' AS Date), N'F', 343600, N'sc-56501')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (166, N'Emilija', N'Nikoloska', CAST(N'1998-05-13' AS Date), CAST(N'2018-08-01' AS Date), N'F', 901214, N'sc-73876')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (167, N'Zoran', N'Bozinovski', CAST(N'1991-08-07' AS Date), CAST(N'2011-02-04' AS Date), N'M', 466413, N'sc-78397')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (168, N'Timotej', N'Janevski', CAST(N'1992-07-24' AS Date), CAST(N'2013-03-12' AS Date), N'M', 403323, N'sc-32449')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (169, N'Sande', N'Iliev', CAST(N'1995-02-25' AS Date), CAST(N'2014-07-31' AS Date), N'M', 996007, N'sc-35901')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (170, N'Krste', N'Lazarov', CAST(N'1992-10-28' AS Date), CAST(N'2012-03-05' AS Date), N'M', 338652, N'sc-79028')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (171, N'Timotej', N'Bogdanovski', CAST(N'1998-03-23' AS Date), CAST(N'2016-03-23' AS Date), N'M', 807389, N'sc-86233')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (172, N'Emanuel', N'Trajkov', CAST(N'1985-06-11' AS Date), CAST(N'2004-07-22' AS Date), N'M', 240193, N'sc-99388')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (173, N'Sonja', N'Todorova', CAST(N'1993-06-10' AS Date), CAST(N'2012-03-04' AS Date), N'F', 522263, N'sc-20294')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (174, N'Oliver', N'Velickovski', CAST(N'1998-10-14' AS Date), CAST(N'2018-03-29' AS Date), N'M', 351115, N'sc-88680')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (175, N'Filip', N'Gjorgjievski', CAST(N'1984-11-02' AS Date), CAST(N'2003-10-08' AS Date), N'M', 231139, N'sc-61186')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (176, N'Ratka', N'Stojanovska', CAST(N'1979-10-16' AS Date), CAST(N'1998-06-01' AS Date), N'F', 804754, N'sc-34626')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (177, N'Persa', N'Todorova', CAST(N'1985-08-12' AS Date), CAST(N'2005-09-25' AS Date), N'F', 619334, N'sc-20403')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (178, N'Teodosij', N'Nikolov', CAST(N'1980-02-01' AS Date), CAST(N'2000-05-30' AS Date), N'M', 756496, N'sc-45953')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (179, N'Vasil', N'Stojanovski', CAST(N'1997-01-24' AS Date), CAST(N'2015-04-20' AS Date), N'M', 474360, N'sc-86811')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (180, N'Eva', N'Angelovska', CAST(N'1997-11-11' AS Date), CAST(N'2016-03-22' AS Date), N'F', 164700, N'sc-87798')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (181, N'Jasmina', N'Atanasovska', CAST(N'1996-09-16' AS Date), CAST(N'2017-06-17' AS Date), N'F', 502281, N'sc-88081')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (182, N'Efrosina', N'Mladenovska', CAST(N'1997-09-13' AS Date), CAST(N'2015-11-27' AS Date), N'F', 908437, N'sc-49334')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (183, N'Zdravka', N'Nikolova', CAST(N'1980-05-14' AS Date), CAST(N'2000-06-21' AS Date), N'F', 872585, N'sc-44888')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (184, N'Trpe', N'Cvetkovski', CAST(N'1979-06-15' AS Date), CAST(N'1998-10-03' AS Date), N'M', 331125, N'sc-27003')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (185, N'Snezana', N'Dimovska', CAST(N'1981-06-11' AS Date), CAST(N'2002-04-28' AS Date), N'F', 551328, N'sc-79996')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (186, N'Dragan', N'Angelovski', CAST(N'1981-03-21' AS Date), CAST(N'2001-02-11' AS Date), N'M', 973983, N'sc-57041')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (187, N'Gerasim', N'Jovanovski', CAST(N'1997-03-19' AS Date), CAST(N'2017-08-24' AS Date), N'M', 575967, N'sc-90269')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (188, N'Teodosij', N'Mitev', CAST(N'1995-10-04' AS Date), CAST(N'2014-12-14' AS Date), N'M', 202905, N'sc-27772')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (189, N'Neda', N'Stojanova', CAST(N'1981-08-06' AS Date), CAST(N'1999-08-25' AS Date), N'F', 307888, N'sc-96379')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (190, N'Teofil', N'Vasilevski', CAST(N'1998-07-18' AS Date), CAST(N'2018-12-30' AS Date), N'M', 724621, N'sc-63662')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (191, N'Gligor', N'Stojanovski', CAST(N'1981-11-09' AS Date), CAST(N'2001-07-22' AS Date), N'M', 302697, N'sc-57857')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (192, N'Bozidar', N'Stojkovski', CAST(N'1999-01-02' AS Date), CAST(N'2017-06-10' AS Date), N'M', 847856, N'sc-43348')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (193, N'Melanija', N'Trajkova', CAST(N'1994-01-06' AS Date), CAST(N'2013-02-15' AS Date), N'F', 346151, N'sc-14884')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (194, N'Mihail', N'Nikoloski', CAST(N'1983-12-22' AS Date), CAST(N'2003-02-22' AS Date), N'M', 446857, N'sc-51400')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (195, N'Mihail', N'Petrovski', CAST(N'1984-08-06' AS Date), CAST(N'2004-09-17' AS Date), N'M', 788955, N'sc-76488')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (196, N'Blagoj', N'Trajkov', CAST(N'1998-07-01' AS Date), CAST(N'2019-05-04' AS Date), N'M', 109364, N'sc-73013')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (197, N'Nikita', N'Mitev', CAST(N'1987-06-16' AS Date), CAST(N'2007-08-06' AS Date), N'M', 896343, N'sc-82917')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (198, N'Aleksandra', N'Dimitrievska', CAST(N'1991-07-30' AS Date), CAST(N'2011-04-11' AS Date), N'F', 733756, N'sc-37009')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (199, N'Rahela', N'Stojanoska', CAST(N'1981-03-28' AS Date), CAST(N'2000-07-12' AS Date), N'F', 107965, N'sc-43784')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (200, N'Antonio', N'Jovanoski', CAST(N'1991-02-12' AS Date), CAST(N'2011-06-03' AS Date), N'M', 939027, N'sc-67964')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (201, N'Zvonko', N'Atanasov', CAST(N'1994-03-04' AS Date), CAST(N'2013-01-01' AS Date), N'M', 656200, N'sc-31358')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (202, N'Katina', N'Velickovska', CAST(N'1981-06-06' AS Date), CAST(N'2001-03-10' AS Date), N'F', 894384, N'sc-16107')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (203, N'Temjana', N'Velkovska', CAST(N'1994-05-16' AS Date), CAST(N'2014-11-09' AS Date), N'F', 209677, N'sc-16435')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (204, N'Ozren', N'Pavlovski', CAST(N'1985-12-14' AS Date), CAST(N'2004-11-18' AS Date), N'M', 506931, N'sc-71311')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (205, N'Kiril', N'Dodevski', CAST(N'1983-02-25' AS Date), CAST(N'2002-01-23' AS Date), N'M', 958949, N'sc-32923')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (206, N'Petra', N'Stojkova', CAST(N'1991-12-09' AS Date), CAST(N'2012-11-12' AS Date), N'F', 388220, N'sc-10176')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (207, N'Hristo', N'Mitrevski', CAST(N'1985-02-16' AS Date), CAST(N'2004-11-27' AS Date), N'M', 607031, N'sc-54618')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (208, N'Gavril', N'Ivanov', CAST(N'1981-04-30' AS Date), CAST(N'1999-07-01' AS Date), N'M', 892203, N'sc-41388')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (209, N'Slave', N'Janev', CAST(N'1993-08-23' AS Date), CAST(N'2013-10-15' AS Date), N'M', 929311, N'sc-70209')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (210, N'Angja', N'Risteska', CAST(N'1992-05-20' AS Date), CAST(N'2010-05-18' AS Date), N'F', 794044, N'sc-73191')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (211, N'Spasija', N'Aleksovska', CAST(N'1993-04-10' AS Date), CAST(N'2012-08-04' AS Date), N'F', 168731, N'sc-18198')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (212, N'Tashko', N'Bogdanovski', CAST(N'1979-08-30' AS Date), CAST(N'1998-11-24' AS Date), N'M', 556367, N'sc-15409')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (213, N'Bozidar', N'Ristovski', CAST(N'1997-04-08' AS Date), CAST(N'2015-08-01' AS Date), N'M', 233837, N'sc-51469')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (214, N'Trendafilka', N'Dimitrova', CAST(N'1989-11-27' AS Date), CAST(N'2008-11-09' AS Date), N'F', 205098, N'sc-94778')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (215, N'Stefan', N'Petrovski', CAST(N'1980-01-28' AS Date), CAST(N'1999-10-17' AS Date), N'M', 972032, N'sc-71479')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (216, N'Marika', N'Arsovska', CAST(N'1991-02-17' AS Date), CAST(N'2009-03-28' AS Date), N'F', 357395, N'sc-78559')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (217, N'Todor', N'Atanasov', CAST(N'1995-03-12' AS Date), CAST(N'2015-04-04' AS Date), N'M', 562936, N'sc-97122')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (218, N'Marina', N'Dimitrovska', CAST(N'1984-01-27' AS Date), CAST(N'2004-11-01' AS Date), N'F', 261958, N'sc-76663')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (219, N'Liljana', N'Dimitrova', CAST(N'1991-08-23' AS Date), CAST(N'2009-10-24' AS Date), N'F', 107799, N'sc-11719')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (220, N'Stojanka', N'Krstevska', CAST(N'1998-04-30' AS Date), CAST(N'2018-10-04' AS Date), N'F', 416228, N'sc-70761')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (221, N'Despina', N'Petrovska', CAST(N'1994-05-25' AS Date), CAST(N'2014-07-18' AS Date), N'F', 305240, N'sc-16398')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (222, N'Evgenij', N'Simonovski', CAST(N'1988-11-04' AS Date), CAST(N'2009-09-08' AS Date), N'M', 261611, N'sc-29016')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (223, N'Sofronij', N'Arsovski', CAST(N'1982-07-15' AS Date), CAST(N'2001-12-15' AS Date), N'M', 243772, N'sc-48533')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (224, N'Stojmena', N'Ivanovska', CAST(N'1994-12-01' AS Date), CAST(N'2014-10-19' AS Date), N'F', 735297, N'sc-92808')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (225, N'Milka', N'Stojcevska', CAST(N'1991-10-23' AS Date), CAST(N'2011-10-24' AS Date), N'F', 400545, N'sc-19633')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (226, N'Frosina', N'Trajkovska', CAST(N'1991-12-02' AS Date), CAST(N'2011-08-13' AS Date), N'F', 711892, N'sc-16739')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (227, N'Angelina', N'Popovska', CAST(N'1986-10-07' AS Date), CAST(N'2005-05-03' AS Date), N'F', 899520, N'sc-29739')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (228, N'Aleksandra', N'Popova', CAST(N'1996-05-10' AS Date), CAST(N'2014-08-21' AS Date), N'F', 516343, N'sc-51362')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (229, N'Fanija', N'Angelova', CAST(N'1993-04-24' AS Date), CAST(N'2011-09-20' AS Date), N'F', 876757, N'sc-67643')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (230, N'Sotir', N'Todorovski', CAST(N'1987-09-27' AS Date), CAST(N'2007-10-15' AS Date), N'M', 671706, N'sc-59534')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (231, N'Vojo', N'Popovski', CAST(N'1993-12-28' AS Date), CAST(N'2012-07-19' AS Date), N'M', 368518, N'sc-55067')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (232, N'Jonce', N'Dodevski', CAST(N'1980-05-12' AS Date), CAST(N'2000-11-06' AS Date), N'M', 951324, N'sc-55718')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (233, N'Ristana', N'Gjorgjieva', CAST(N'1993-06-28' AS Date), CAST(N'2012-12-19' AS Date), N'F', 507664, N'sc-55700')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (234, N'Srebre', N'Dimov', CAST(N'1986-07-21' AS Date), CAST(N'2005-04-06' AS Date), N'M', 799392, N'sc-54878')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (235, N'Todorka', N'Dodevska', CAST(N'1994-03-11' AS Date), CAST(N'2014-04-12' AS Date), N'F', 491782, N'sc-59646')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (236, N'Krste', N'Andonov', CAST(N'1987-05-20' AS Date), CAST(N'2008-04-23' AS Date), N'M', 325226, N'sc-61504')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (237, N'Irinej', N'Petkovski', CAST(N'1994-09-25' AS Date), CAST(N'2015-03-21' AS Date), N'M', 379626, N'sc-43748')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (238, N'Pavle', N'Risteski', CAST(N'1997-08-19' AS Date), CAST(N'2016-08-08' AS Date), N'M', 525851, N'sc-42224')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (239, N'Spomenka', N'Mitrevska', CAST(N'1984-04-18' AS Date), CAST(N'2005-01-16' AS Date), N'F', 768434, N'sc-93206')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (240, N'Kuzman', N'Petkovski', CAST(N'1987-04-02' AS Date), CAST(N'2007-12-16' AS Date), N'M', 577483, N'sc-12495')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (241, N'Domnika', N'Trajkovska', CAST(N'1996-05-19' AS Date), CAST(N'2015-08-23' AS Date), N'F', 596301, N'sc-86478')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (242, N'Todorka', N'Stankovska', CAST(N'1979-09-08' AS Date), CAST(N'1998-04-18' AS Date), N'F', 887132, N'sc-68644')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (243, N'Gerasim', N'Cvetkovski', CAST(N'1992-02-29' AS Date), CAST(N'2010-12-25' AS Date), N'M', 591030, N'sc-28729')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (244, N'Boris', N'Asani', CAST(N'1980-10-30' AS Date), CAST(N'1999-08-17' AS Date), N'M', 583080, N'sc-66456')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (245, N'Gorazd', N'Stefanovski', CAST(N'1994-09-02' AS Date), CAST(N'2015-05-16' AS Date), N'M', 796006, N'sc-18281')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (246, N'Petkana', N'Atanasova', CAST(N'1992-10-04' AS Date), CAST(N'2011-09-09' AS Date), N'F', 670572, N'sc-20975')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (247, N'Antonio', N'Lazarov', CAST(N'1995-04-29' AS Date), CAST(N'2015-02-24' AS Date), N'M', 491767, N'sc-54435')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (248, N'Cvetanka', N'Gjorgjievska', CAST(N'1979-08-04' AS Date), CAST(N'1998-01-29' AS Date), N'F', 707132, N'sc-93435')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (249, N'Veljana', N'Ristova', CAST(N'1985-10-31' AS Date), CAST(N'2005-07-25' AS Date), N'F', 871212, N'sc-68512')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (250, N'Konstantina', N'Cvetanovska', CAST(N'1984-05-06' AS Date), CAST(N'2004-05-29' AS Date), N'F', 734526, N'sc-96177')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (251, N'Marko', N'Ristovski', CAST(N'1994-01-09' AS Date), CAST(N'2012-10-01' AS Date), N'M', 170816, N'sc-87495')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (252, N'Eva', N'Ivanova', CAST(N'1987-06-06' AS Date), CAST(N'2008-02-09' AS Date), N'F', 785518, N'sc-29568')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (253, N'Veronika', N'Popova', CAST(N'1997-10-09' AS Date), CAST(N'2015-12-20' AS Date), N'F', 110300, N'sc-62836')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (254, N'Grigor', N'Dimovski', CAST(N'1982-05-13' AS Date), CAST(N'2001-06-01' AS Date), N'M', 825154, N'sc-14676')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (255, N'Ljupco', N'Dimovski', CAST(N'1988-07-06' AS Date), CAST(N'2007-09-23' AS Date), N'M', 550720, N'sc-70541')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (256, N'Tadej', N'Donev', CAST(N'1984-04-04' AS Date), CAST(N'2002-09-20' AS Date), N'M', 475149, N'sc-86708')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (257, N'Kristina', N'Ivanovska', CAST(N'1992-03-15' AS Date), CAST(N'2012-02-09' AS Date), N'F', 880646, N'sc-98825')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (258, N'Mileva', N'Velickovska', CAST(N'1990-08-31' AS Date), CAST(N'2010-05-01' AS Date), N'F', 608306, N'sc-25360')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (259, N'Ljubomir', N'Mitrevski', CAST(N'1993-09-01' AS Date), CAST(N'2012-02-22' AS Date), N'M', 783801, N'sc-21510')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (260, N'Cedomir', N'Asani', CAST(N'1998-06-11' AS Date), CAST(N'2019-03-22' AS Date), N'M', 458267, N'sc-80740')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (261, N'Svetlana', N'Georgievska', CAST(N'1983-10-02' AS Date), CAST(N'2002-05-21' AS Date), N'F', 377206, N'sc-50858')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (262, N'Mileva', N'Pavlova', CAST(N'1994-06-15' AS Date), CAST(N'2014-10-05' AS Date), N'F', 880191, N'sc-49324')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (263, N'Mirka', N'Georgieva', CAST(N'1997-05-06' AS Date), CAST(N'2016-05-22' AS Date), N'F', 765297, N'sc-11736')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (264, N'Ekaterina', N'Stojcevska', CAST(N'1997-05-05' AS Date), CAST(N'2016-12-05' AS Date), N'F', 934045, N'sc-65820')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (265, N'Varvara', N'Janevska', CAST(N'1986-11-15' AS Date), CAST(N'2006-10-05' AS Date), N'F', 515567, N'sc-71142')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (266, N'Dimitrij', N'Stefanovski', CAST(N'1982-10-07' AS Date), CAST(N'2002-09-25' AS Date), N'M', 315719, N'sc-87867')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (267, N'Sara', N'Todorovska', CAST(N'1980-03-26' AS Date), CAST(N'1998-04-05' AS Date), N'F', 814201, N'sc-35825')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (268, N'Atanas', N'Janevski', CAST(N'1998-05-28' AS Date), CAST(N'2019-05-18' AS Date), N'M', 948949, N'sc-43872')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (269, N'Lidija', N'Jovanovska', CAST(N'1991-06-12' AS Date), CAST(N'2010-11-16' AS Date), N'F', 102957, N'sc-29738')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (270, N'Klimentina', N'Pavlovska', CAST(N'1984-12-25' AS Date), CAST(N'2005-09-15' AS Date), N'F', 257261, N'sc-76146')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (271, N'Marta', N'Arsova', CAST(N'1998-07-27' AS Date), CAST(N'2017-05-13' AS Date), N'F', 591093, N'sc-77296')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (272, N'Borjan', N'Petrushevski', CAST(N'1991-08-14' AS Date), CAST(N'2012-02-10' AS Date), N'M', 711463, N'sc-92232')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (273, N'Simeona', N'Popovska', CAST(N'1989-06-23' AS Date), CAST(N'2008-08-15' AS Date), N'F', 397023, N'sc-33803')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (274, N'Cvetanka', N'Kuzmanovska', CAST(N'1991-10-05' AS Date), CAST(N'2012-06-07' AS Date), N'F', 295082, N'sc-68550')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (275, N'Trendafilka', N'Nikoloska', CAST(N'1990-01-02' AS Date), CAST(N'2009-05-20' AS Date), N'F', 553827, N'sc-90949')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (276, N'Goran', N'Todorovski', CAST(N'1987-06-24' AS Date), CAST(N'2008-02-05' AS Date), N'M', 683593, N'sc-91952')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (277, N'Trendafilka', N'Ivanova', CAST(N'1983-11-03' AS Date), CAST(N'2003-10-10' AS Date), N'F', 302765, N'sc-96433')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (278, N'Meglena', N'Petrushevska', CAST(N'1993-12-14' AS Date), CAST(N'2013-06-19' AS Date), N'F', 199276, N'sc-31764')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (279, N'Vangel', N'Ilievski', CAST(N'1982-07-07' AS Date), CAST(N'2000-12-23' AS Date), N'M', 488265, N'sc-31879')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (280, N'Kostadin', N'Nikolovski', CAST(N'1991-08-17' AS Date), CAST(N'2012-03-28' AS Date), N'M', 363804, N'sc-96898')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (281, N'Tamara', N'Mitrevska', CAST(N'1993-09-27' AS Date), CAST(N'2013-11-19' AS Date), N'F', 934803, N'sc-50603')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (282, N'Filimena', N'Popova', CAST(N'1990-01-21' AS Date), CAST(N'2010-12-20' AS Date), N'F', 587328, N'sc-39057')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (283, N'Vesna', N'Ivanova', CAST(N'1986-12-11' AS Date), CAST(N'2007-08-21' AS Date), N'F', 848205, N'sc-21458')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (284, N'Efrosina', N'Trifunova', CAST(N'1994-05-25' AS Date), CAST(N'2014-01-02' AS Date), N'F', 566656, N'sc-75502')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (285, N'Mihail', N'Iliev', CAST(N'1989-08-08' AS Date), CAST(N'2010-03-12' AS Date), N'M', 505057, N'sc-12850')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (286, N'Efimija', N'Lazarova', CAST(N'1993-05-14' AS Date), CAST(N'2011-05-29' AS Date), N'F', 944474, N'sc-58776')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (287, N'Spomenka', N'Jovanoska', CAST(N'1989-01-26' AS Date), CAST(N'2007-08-03' AS Date), N'F', 579659, N'sc-92202')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (288, N'Bojan', N'Ivanov', CAST(N'1980-11-28' AS Date), CAST(N'2000-12-04' AS Date), N'M', 780914, N'sc-27408')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (289, N'Gjorgjija', N'Jovanovski', CAST(N'1997-07-14' AS Date), CAST(N'2018-06-29' AS Date), N'M', 303457, N'sc-97727')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (290, N'Lenka', N'Atanasovska', CAST(N'1989-01-04' AS Date), CAST(N'2008-11-07' AS Date), N'F', 722925, N'sc-45295')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (291, N'Mojsej', N'Dimitrov', CAST(N'1998-10-29' AS Date), CAST(N'2018-04-21' AS Date), N'M', 915763, N'sc-17110')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (292, N'Veronika', N'Kostovska', CAST(N'1997-03-27' AS Date), CAST(N'2016-07-01' AS Date), N'F', 754898, N'sc-47078')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (293, N'Timotej', N'Jovanov', CAST(N'1999-03-30' AS Date), CAST(N'2018-06-21' AS Date), N'M', 377776, N'sc-13461')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (294, N'Andon', N'Petrov', CAST(N'1993-02-12' AS Date), CAST(N'2012-01-17' AS Date), N'M', 597024, N'sc-62931')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (295, N'Viktor', N'Lazarov', CAST(N'1987-11-21' AS Date), CAST(N'2008-03-19' AS Date), N'M', 726942, N'sc-30515')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (296, N'Angel', N'Gjorgjiev', CAST(N'1981-03-01' AS Date), CAST(N'2002-02-03' AS Date), N'M', 154344, N'sc-26316')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (297, N'Apostol', N'Petrushevski', CAST(N'1987-02-06' AS Date), CAST(N'2006-11-25' AS Date), N'M', 873534, N'sc-96545')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (298, N'Teofil', N'Ivanovski', CAST(N'1983-12-18' AS Date), CAST(N'2002-12-04' AS Date), N'M', 167336, N'sc-54889')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (299, N'Darinka', N'Koceva', CAST(N'1983-03-29' AS Date), CAST(N'2001-11-23' AS Date), N'F', 934008, N'sc-86721')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (300, N'Manuel', N'Stojanov', CAST(N'1981-06-22' AS Date), CAST(N'2002-03-01' AS Date), N'M', 915308, N'sc-99888')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (301, N'Nada', N'Stefanovska', CAST(N'1983-10-31' AS Date), CAST(N'2002-05-25' AS Date), N'F', 786078, N'sc-84429')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (302, N'Caslav', N'Petrushevski', CAST(N'1986-06-06' AS Date), CAST(N'2005-11-20' AS Date), N'M', 914638, N'sc-78627')
GO
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [DateOfBirth], [EnrolledDate], [Gender], [NationalIdNumber], [StudentCardNumber]) VALUES (303, N'Kostadinka', N'Ivanovska', CAST(N'1981-01-31' AS Date), CAST(N'2001-06-21' AS Date), N'F', 184762, N'sc-27122')
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO

SELECT * FROM [dbo].[Student]
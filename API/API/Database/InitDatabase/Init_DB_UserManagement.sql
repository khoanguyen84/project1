USE [DataManagement]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 10/1/2019 3:06:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](500) NOT NULL,
	[CountryCode] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 10/1/2019 3:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobName] [nvarchar](200) NOT NULL,
	[YearOfExperience] [int] NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/1/2019 3:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[DOB] [datetime] NULL,
	[UserMobile] [varchar](50) NULL,
	[UserEmail] [varchar](50) NULL,
	[FaceBookUrl] [varchar](50) NULL,
	[LinkedInUrl] [varchar](50) NULL,
	[TwitterUrl] [varchar](50) NULL,
	[PersonalWebUrl] [varchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[CountryId] [int] NULL,
	[JobId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [CountryName], [CountryCode]) VALUES (1, N'Việt Nam', N'12345')
INSERT [dbo].[Country] ([Id], [CountryName], [CountryCode]) VALUES (2, N'Thái Lan', N'12345')
INSERT [dbo].[Country] ([Id], [CountryName], [CountryCode]) VALUES (3, N'Lào', N'12345')
INSERT [dbo].[Country] ([Id], [CountryName], [CountryCode]) VALUES (4, N'Campuchia', N'12345')
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Job] ON 

INSERT [dbo].[Job] ([Id], [JobName], [YearOfExperience]) VALUES (1, N'C#', 2)
INSERT [dbo].[Job] ([Id], [JobName], [YearOfExperience]) VALUES (2, N'Java', 4)
INSERT [dbo].[Job] ([Id], [JobName], [YearOfExperience]) VALUES (3, N'Phython', 4)
INSERT [dbo].[Job] ([Id], [JobName], [YearOfExperience]) VALUES (4, N'Php', 3)
INSERT [dbo].[Job] ([Id], [JobName], [YearOfExperience]) VALUES (5, N'Game Mobile', 4)
SET IDENTITY_INSERT [dbo].[Job] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (1, N'Khoa Nguyen 2', CAST(N'1990-09-09T00:00:00.000' AS DateTime), N'0935216417 2', N'khoa.nguyen1@codegym.vn', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', 0, 1, 1)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (2, N'KhoaNguyen2', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'123456789', N'khoa.nguyen+1@codegym.vn', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', 0, 1, 2)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (3, N'KhoaNguyen3', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'123456789', N'khoa.nguyen+3@codegym.vn', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', 0, 2, 3)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (4, N'Khoa Nguyen 44', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'123456789', N'khoa.nguyen+4@codegym.vn', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', 0, 2, 4)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (5, N'rojuva', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'+1 (809) 891-2958', N'mijopapyj@mailinator.com', N'https://www.gojiwes.info', N'https://www.nico.tv', N'https://www.qaqipopewotut.me', N'https://www.camaqil.org.au', 0, 3, 5)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (6, N'sysizod', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'Eos magna fugiat di', N'sizy@mailinator.net', N'Laboriosam sapiente', N'Veniam rem et digni', N'Laborum Sed tempore', N'Corrupti dignissimo', 0, 3, 1)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (7, N'podocuco', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'Dolor sed non molest', N'cokadifyj@mailinator.net', N'Cupidatat do culpa o', N'Pariatur Numquam eu', N'Inventore dolores am', N'Magna odit in magna ', 0, 4, 2)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (8, N'podocuco', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'Dolor sed non molest', N'cokadifyj@mailinator.net', N'Cupidatat do culpa o', N'Pariatur Numquam eu', N'Inventore dolores am', N'Magna odit in magna ', 1, 4, 3)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (9, N'qekujacyla', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'+1 (972) 907-8708', N'qozyd@mailinator.net', N'https://www.popifalobyloxez.cm', N'https://www.nilulykyqy.org', N'https://www.mehikuzo.co.uk', N'https://www.zomokiso.co.uk', 1, 1, 4)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (10, N'tocejaj', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'+1 (688) 237-8169', N'cilufijyj@mailinator.net', N'https://www.putu.org.au', N'https://www.pokakaru.cm', N'https://www.gamelarafodaqy.co', N'https://www.lotecyrebuniwy.com', 0, 2, 5)
INSERT [dbo].[Users] ([UserId], [UserName], [DOB], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted], [CountryId], [JobId]) VALUES (11, N'tocejaj', CAST(N'1990-08-08T00:00:00.000' AS DateTime), N'+1 (688) 237-8169', N'cilufijyj@mailinator.net', N'https://www.putu.org.au', N'https://www.pokakaru.cm', N'https://www.gamelarafodaqy.co', N'https://www.lotecyrebuniwy.com', 0, 3, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_User_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Country]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Job] FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Job]
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 10/1/2019 3:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE[dbo].[AddUser]  
@UserName varchar(50),  
    @UserMobile varchar(50),  
    @UserEmail varchar(50),  
    @FaceBookUrl varchar(50),  
    @LinkedInUrl varchar(50),  
    @TwitterUrl varchar(50),  
    @PersonalWebUrl varchar(50)  
AS  
BEGIN  
SET NOCOUNT ON;  
insert into Users(UserName, UserMobile, UserEmail, FaceBookUrl, LinkedInUrl, TwitterUrl, PersonalWebUrl)  
values(@UserName, @UserMobile, @UserEmail, @FaceBookUrl, @LinkedInUrl, @TwitterUrl, @PersonalWebUrl)  
END  
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 10/1/2019 3:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[DeleteUser]  
@UserId int  
AS  
BEGIN  
SET NOCOUNT ON;  
update Users set IsDeleted = 1 where UserId = @UserId  
END  
GO
/****** Object:  StoredProcedure [dbo].[GetAllCountries]    Script Date: 10/1/2019 3:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[GetAllCountries]  
AS  
BEGIN  
SET NOCOUNT ON; 

SELECT [Id]
      ,[CountryName]
      ,[CountryCode]
FROM [dbo].[Country]

END  
GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 10/1/2019 3:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[GetAllUsers]  
AS  
BEGIN  
SET NOCOUNT ON; 

SELECT u.[UserId]
      ,u.[UserName]
      ,FORMAT(u.[DOB], 'dd/MM/yyyy') AS [DOB]
      ,u.[UserMobile]
      ,u.[UserEmail]
      ,u.[FaceBookUrl]
      ,u.[LinkedInUrl]
      ,u.[TwitterUrl]
      ,u.[PersonalWebUrl]
      ,u.[IsDeleted]
      ,c.[CountryName]
      ,j.[JobName]
	  ,j.[YearOfExperience]
FROM [dbo].[Users] u 
		INNER JOIN [dbo].[Country] c ON u.CountryId = c.Id
		INNER JOIN [dbo].[Job] j ON u.JobId = j.Id
WHERE u.IsDeleted = 0
		

END  
GO
/****** Object:  StoredProcedure [dbo].[GetUserById]    Script Date: 10/1/2019 3:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[GetUserById]  
@UserId int  
AS  
BEGIN  
SET NOCOUNT ON;  

--IF(NOT EXISTS(SELECT * FROM Users WHERE UserId = @UserId AND IsDeleted = 0))
--BEGIN
--	RAISERROR('Invaid user', 1, 100)
--	RETURN
--END

SELECT [UserId]
      ,[UserName]
      ,FORMAT([DOB], 'dd/MM/yyyy') AS [DOB]
      ,[UserMobile]
      ,[UserEmail]
      ,[FaceBookUrl]
      ,[LinkedInUrl]
      ,[TwitterUrl]
      ,[PersonalWebUrl]
      ,[IsDeleted]
      ,[CountryId]
      ,[JobId]
FROM [dbo].[Users]
WHERE UserId = @UserId
END  
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 10/1/2019 3:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[UpdateUser]  
@UserId int,  
@UserName varchar(50),  
    @UserMobile varchar(50),  
    @UserEmail varchar(50),  
    @FaceBookUrl varchar(50),  
    @LinkedInUrl varchar(50),  
    @TwitterUrl varchar(50),  
    @PersonalWebUrl varchar(50)  
AS  
BEGIN  
SET NOCOUNT ON;  
update Users set  
UserName = @UserName,  
    UserMobile = @UserMobile,  
    UserEmail = @UserEmail,  
    FaceBookUrl = @FaceBookUrl,  
    LinkedInUrl = @LinkedInUrl,  
    TwitterUrl = @TwitterUrl,  
    PersonalWebUrl = @PersonalWebUrl  
where UserId = @UserId  
END  
GO

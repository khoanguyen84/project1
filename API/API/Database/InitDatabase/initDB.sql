USE [DataManagement]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/30/2019 11:10:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[UserMobile] [varchar](50) NULL,
	[UserEmail] [varchar](50) NULL,
	[FaceBookUrl] [varchar](50) NULL,
	[LinkedInUrl] [varchar](50) NULL,
	[TwitterUrl] [varchar](50) NULL,
	[PersonalWebUrl] [varchar](50) NULL,
	[IsDeleted] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserName], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted]) VALUES (1, N'Khoa Nguyen', N'0935216417', N'khoa.nguyen@codegym.vn', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', 0)
INSERT [dbo].[Users] ([UserId], [UserName], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted]) VALUES (2, N'KhoaNguyen2', N'123456789', N'khoa.nguyen+1@codegym.vn', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', 0)
INSERT [dbo].[Users] ([UserId], [UserName], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted]) VALUES (3, N'KhoaNguyen3', N'123456789', N'khoa.nguyen+3@codegym.vn', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', 0)
INSERT [dbo].[Users] ([UserId], [UserName], [UserMobile], [UserEmail], [FaceBookUrl], [LinkedInUrl], [TwitterUrl], [PersonalWebUrl], [IsDeleted]) VALUES (4, N'Khoa Nguyen 44', N'123456789', N'khoa.nguyen+4@codegym.vn', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', N'https://www.google.com/', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_User_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 9/30/2019 11:10:48 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 9/30/2019 11:10:48 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 9/30/2019 11:10:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[GetAllUsers]  
AS  
BEGIN  
SET NOCOUNT ON;  
select * from Users  
END  
GO
/****** Object:  StoredProcedure [dbo].[GetUserById]    Script Date: 9/30/2019 11:10:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[GetUserById]  
@UserId int  
AS  
BEGIN  
SET NOCOUNT ON;  
select * from Users where UserId = @UserId;  
END  
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 9/30/2019 11:10:48 AM ******/
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

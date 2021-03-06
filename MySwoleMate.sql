/****** Object:  Database [MySwoleMate]    Script Date: 3/18/2016 1:47:57 PM ******/
CREATE DATABASE [MySwoleMate]
GO
USE [MySwoleMate]
GO
/****** Object:  Table [dbo].[Trainee]    Script Date: 3/18/2016 1:47:57 PM ******/
CREATE TABLE [dbo].[Trainee](
	[TraineeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](30) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Height] [int] NOT NULL,
	[Weight] [int] NOT NULL,
	[CellNbr] [char](10) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[Age] [int] NOT NULL,
	[WorkoutID] [int],
 CONSTRAINT [PK_Trainee] PRIMARY KEY CLUSTERED 
(
	[TraineeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[WorkoutPlan]    Script Date: 7/1/2019 5:42:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Workout](
	[WorkoutID] [int] identity(1,1) NOT NULL,
	[WorkoutName] [varchar](100) NOT NULL,
	[Exercise1] [varchar](100) NOT NULL,
	[Exercise1Reps] [numeric](4, 0) NOT NULL,
	[Exercise1Sets] [numeric](4, 0) NOT NULL,
	[Exercise2] [varchar](100) NOT NULL,
	[Exercise2Reps] [numeric](4, 0) NOT NULL,
	[Exercise2Sets] [numeric](4, 0) NOT NULL,
	[Exercise3] [varchar](100) NOT NULL,
	[Exercise3Reps] [numeric](4, 0) NOT NULL,
	[Exercise3Sets] [numeric](4, 0) NOT NULL,
	[Exercise4] [varchar](100) NOT NULL,
	[Exercise4Reps] [numeric](4, 0) NOT NULL,
	[Exercise4Sets] [numeric](4, 0) NOT NULL,
	[Exercise5] [varchar](100) NOT NULL,
	[Exercise5Reps] [numeric](4, 0) NOT NULL,
	[Exercise5Sets] [numeric](4, 0) NOT NULL,
 CONSTRAINT [PK_Workout] PRIMARY KEY CLUSTERED 
(
	[WorkoutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Trainee]  WITH CHECK ADD  CONSTRAINT [FK_Trainee_Workout] FOREIGN KEY([WorkoutID])
REFERENCES [dbo].[Workout] ([WorkoutID])
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Trainee] CHECK CONSTRAINT [FK_Trainee_Workout]
GO


/****** Object:  Table [dbo].[WorkoutPlan]    Script Date: 7/30/2019 11:30:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Measurement](
	[MeasurementID] [int] identity(1,1) NOT NULL,
	[Weight] [int] NOT NULL,
	[Waist] [int] NOT NULL,
	[BodyFat] [int] NOT NULL,
	[Chest] [int] NOT NULL,
	[UpperArm] [int] NOT NULL,
	[ScheduleID] [int] NOT NULL,
 CONSTRAINT [PK_Measurement] PRIMARY KEY CLUSTERED 
(
	[MeasurementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  Table [dbo].[Schedule]    Script Date: 7/1/2019 11:35:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Schedule](
	[ScheduleID] [int] identity(1,1) NOT NULL,
	[ScheduleDtTime] [dateTime] NOT NULL,
	[InputDtTime] [dateTime] NOT NULL,
	[TraineeID] [int] NOT NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Measurement]  WITH CHECK ADD  CONSTRAINT [FK_Measurement_Schedule] FOREIGN KEY([ScheduleID])
REFERENCES [dbo].[Schedule] ([ScheduleID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Measurement] CHECK CONSTRAINT [FK_Measurement_Schedule]
GO

ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Trainee] FOREIGN KEY([TraineeID])
REFERENCES [dbo].[Trainee] ([TraineeID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Trainee]
GO
USE [EmployeeDetails]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 30-08-2023 05:49:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[eid] [int] NOT NULL IDENTITY(1,1),
	[name] [varchar](255) NULL,
	[emailid] [varchar](255) NULL,
	[mobile] [varchar](15) NULL,
	[hired_date] [date] NULL,
	[tid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[eid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Employee_Project]    Script Date: 30-08-2023 05:49:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee_Project](
	[eid] [int] NOT NULL,
	[pid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[eid] ASC,
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Project]    Script Date: 30-08-2023 05:49:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Project](
	[pid] [int] NOT NULL,
	[name] [varchar](255) NULL,
	[start_date] [date] NULL,
	[expected_end_date] [date] NULL,
	[actual_end_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Team]    Script Date: 30-08-2023 05:49:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Team](
	[tid] [int] NOT NULL,
	[name] [varchar](255) NULL,
	[teamdescription] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([tid])
REFERENCES [dbo].[Team] ([tid])
GO

ALTER TABLE [dbo].[Employee_Project]  WITH CHECK ADD FOREIGN KEY([eid])
REFERENCES [dbo].[Employee] ([eid])
GO

ALTER TABLE [dbo].[Employee_Project]  WITH CHECK ADD FOREIGN KEY([pid])
REFERENCES [dbo].[Project] ([pid])
GO



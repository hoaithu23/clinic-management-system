USE [ClinicDb]
GO
/****** Object:  Table [dbo].[DoctorTbl]    Script Date: 14-Sep-21 2:42:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoctorTbl](
	[DocId] [int] IDENTITY(1,1) NOT NULL,
	[DocName] [varchar](100) NOT NULL,
	[DocDOB] [date] NOT NULL,
	[DOCGEN] [varchar](10) NOT NULL,
	[DOCSPEC] [varchar](50) NOT NULL,
	[DOCEXP] [int] NOT NULL,
	[DOCPHONE] [varchar](50) NOT NULL,
	[DocAdd] [varchar](100) NOT NULL,
	[DocPass] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DocId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PatientTbl]    Script Date: 14-Sep-21 2:42:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientTbl](
	[PatId] [int] IDENTITY(100,1) NOT NULL,
	[PatName] [varchar](50) NOT NULL,
	[PatGen] [varchar](10) NOT NULL,
	[PatDOB] [date] NOT NULL,
	[PatAdd] [varchar](100) NOT NULL,
	[PatPhone] [varchar](15) NOT NULL,
	[PatHIV] [varchar](10) NOT NULL,
	[PatAll] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PrescriptionTbl]    Script Date: 14-Sep-21 2:42:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PrescriptionTbl](
	[PrescId] [int] IDENTITY(500,1) NOT NULL,
	[DocId] [int] NOT NULL,
	[DocName] [varchar](50) NOT NULL,
	[PatId] [int] NOT NULL,
	[PatName] [varchar](50) NOT NULL,
	[LabTestId] [int] NOT NULL,
	[LabTestName] [varchar](50) NOT NULL,
	[Medicines] [varchar](100) NOT NULL,
	[Cost] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PrescId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReceptionistTbl]    Script Date: 14-Sep-21 2:42:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReceptionistTbl](
	[RecepId] [int] IDENTITY(800,1) NOT NULL,
	[RecepName] [varchar](50) NOT NULL,
	[RecepPhone] [varchar](50) NOT NULL,
	[RecepAdd] [varchar](100) NOT NULL,
	[RecepPass] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RecepId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TestTbl]    Script Date: 14-Sep-21 2:42:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TestTbl](
	[TestNum] [int] IDENTITY(2000,1) NOT NULL,
	[TestName] [varchar](50) NOT NULL,
	[TestCost] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TestNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[PrescriptionTbl]  WITH CHECK ADD  CONSTRAINT [FK1] FOREIGN KEY([DocId])
REFERENCES [dbo].[DoctorTbl] ([DocId])
GO
ALTER TABLE [dbo].[PrescriptionTbl] CHECK CONSTRAINT [FK1]
GO
ALTER TABLE [dbo].[PrescriptionTbl]  WITH CHECK ADD  CONSTRAINT [FK2] FOREIGN KEY([PatId])
REFERENCES [dbo].[PatientTbl] ([PatId])
GO
ALTER TABLE [dbo].[PrescriptionTbl] CHECK CONSTRAINT [FK2]
GO
ALTER TABLE [dbo].[PrescriptionTbl]  WITH CHECK ADD  CONSTRAINT [FK3] FOREIGN KEY([LabTestId])
REFERENCES [dbo].[TestTbl] ([TestNum])
GO
ALTER TABLE [dbo].[PrescriptionTbl] CHECK CONSTRAINT [FK3]
GO

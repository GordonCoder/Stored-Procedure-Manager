INSERT INTO [dbo].[AM_Buttons]
           ([ButtonID]
           ,[ButtonName]
           ,[SPName])
     VALUES
           ('1','Not Configured',NULL)
		   ,('2','Not Configured',NULL)
		   ,('3','Not Configured',NULL)
		   ,('4','Not Configured',NULL)
		   ,('5','Not Configured',NULL)
		   ,('6','Not Configured',NULL)
		   ,('7','Not Configured',NULL)
		   ,('8','Not Configured',NULL)
		   ,('9','Not Configured',NULL)
		   ,('10','Not Configured',NULL)


INSERT INTO [dbo].[AM_ButtonParam]
		([ParamID]
		,[ButtonID]
		,[ParamName]
		,[ParamValue])
     VALUES
		('1','1',NULL,NULL)
		,('2','1',NULL,NULL)
		,('3','1',NULL,NULL)
		,('4','1',NULL,NULL)
		,('5','1',NULL,NULL)

		,('1','2',NULL,NULL)
		,('2','2',NULL,NULL)
		,('3','2',NULL,NULL)
		,('4','2',NULL,NULL)
		,('5','2',NULL,NULL)

		,('1','3',NULL,NULL)
		,('2','3',NULL,NULL)
		,('3','3',NULL,NULL)
		,('4','3',NULL,NULL)
		,('5','3',NULL,NULL)

		,('1','4',NULL,NULL)
		,('2','4',NULL,NULL)
		,('3','4',NULL,NULL)
		,('4','4',NULL,NULL)
		,('5','4',NULL,NULL)

		,('1','5',NULL,NULL)
		,('2','5',NULL,NULL)
		,('3','5',NULL,NULL)
		,('4','5',NULL,NULL)
		,('5','5',NULL,NULL)

		,('1','6',NULL,NULL)
		,('2','6',NULL,NULL)
		,('3','6',NULL,NULL)
		,('4','6',NULL,NULL)
		,('5','6',NULL,NULL)

		,('1','7',NULL,NULL)
		,('2','7',NULL,NULL)
		,('3','7',NULL,NULL)
		,('4','7',NULL,NULL)
		,('5','7',NULL,NULL)

		,('1','8',NULL,NULL)
		,('2','8',NULL,NULL)
		,('3','8',NULL,NULL)
		,('4','8',NULL,NULL)
		,('5','8',NULL,NULL)

		,('1','9',NULL,NULL)
		,('2','9',NULL,NULL)
		,('3','9',NULL,NULL)
		,('4','9',NULL,NULL)
		,('5','9',NULL,NULL)

		,('1','10',NULL,NULL)
		,('2','10',NULL,NULL)
		,('3','10',NULL,NULL)
		,('4','10',NULL,NULL)
		,('5','10',NULL,NULL)

INSERT INTO [dbo].[AM_Executable]
           ([ExecutableID]
           ,[ButtonID]
           ,[ExecutablePath]
           ,[ExecutableParam]
		   ,[EPCheckBox])
     VALUES
	 ('1','1',NULL,NULL,'False')
	 ,('2','2',NULL,NULL,'False')
	 ,('3','3',NULL,NULL,'False')
	 ,('4','4',NULL,NULL,'False')
	 ,('5','5',NULL,NULL,'False')
	 ,('6','6',NULL,NULL,'False')
	 ,('7','7',NULL,NULL,'False')
	 ,('8','8',NULL,NULL,'False')
	 ,('9','9',NULL,NULL,'False')
	 ,('10','10',NULL,NULL,'False')

INSERT INTO [dbo].[AM_FileImport]
           ([FileID]
           ,[ButtonID]
           ,[FilePath]
		   ,[FPCheckBox])
     VALUES
			('1','1',NULL,'False')
			,('2','2',NULL,'False')
			,('3','3',NULL,'False')
			,('4','4',NULL,'False')
			,('5','5',NULL,'False')
			,('6','6',NULL,'False')
			,('7','7',NULL,'False')
			,('8','8',NULL,'False')
			,('9','9',NULL,'False')
			,('10','10',NULL,'False')

INSERT INTO [dbo].[AM_Notes]
           ([NoteID]
           ,[ButtonID]
           ,[NoteText])
     VALUES
			('1','1',NULL)
			,('2','2',NULL)
			,('3','3',NULL)
			,('4','4',NULL)
			,('5','5',NULL)
			,('6','6',NULL)
			,('7','7',NULL)
			,('8','8',NULL)
			,('9','9',NULL)
			,('10','10',NULL)






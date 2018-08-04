INSERT INTO [dbo].[AM_Buttons]
           ([ButtonID]
           ,[ButtonName]
           ,[SPName]
		   ,[IDandName])
     VALUES
            ('01','Not Configured',NULL,'Button 1 - Not Configured')
		   ,('02','Not Configured',NULL,'Button 2 - Not Configured')
		   ,('03','Not Configured',NULL,'Button 3 - Not Configured')
		   ,('04','Not Configured',NULL,'Button 4 - Not Configured')
		   ,('05','Not Configured',NULL,'Button 5 - Not Configured')
		   ,('06','Not Configured',NULL,'Button 6 - Not Configured')
		   ,('07','Not Configured',NULL,'Button 7 - Not Configured')
		   ,('08','Not Configured',NULL,'Button 8 - Not Configured')
		   ,('09','Not Configured',NULL,'Button 9 - Not Configured')
		   ,('10','Not Configured',NULL,'Button 10 - Not Configured')


INSERT INTO [dbo].[AM_ButtonParam]
		([ParamID]
		,[ButtonID]
		,[ParamName]
		,[ParamValue])
     VALUES
		('01','01',NULL,NULL)
		,('02','01',NULL,NULL)
		,('03','01',NULL,NULL)
		,('04','01',NULL,NULL)
		,('05','01',NULL,NULL)

		,('01','02',NULL,NULL)
		,('02','02',NULL,NULL)
		,('03','02',NULL,NULL)
		,('04','02',NULL,NULL)
		,('05','02',NULL,NULL)

		,('01','03',NULL,NULL)
		,('02','03',NULL,NULL)
		,('03','03',NULL,NULL)
		,('04','03',NULL,NULL)
		,('05','03',NULL,NULL)

		,('01','04',NULL,NULL)
		,('02','04',NULL,NULL)
		,('03','04',NULL,NULL)
		,('04','04',NULL,NULL)
		,('05','04',NULL,NULL)

		,('01','05',NULL,NULL)
		,('02','05',NULL,NULL)
		,('03','05',NULL,NULL)
		,('04','05',NULL,NULL)
		,('05','05',NULL,NULL)

		,('01','06',NULL,NULL)
		,('02','06',NULL,NULL)
		,('03','06',NULL,NULL)
		,('04','06',NULL,NULL)
		,('05','06',NULL,NULL)

		,('01','07',NULL,NULL)
		,('02','07',NULL,NULL)
		,('03','07',NULL,NULL)
		,('04','07',NULL,NULL)
		,('05','07',NULL,NULL)

		,('01','08',NULL,NULL)
		,('02','08',NULL,NULL)
		,('03','08',NULL,NULL)
		,('04','08',NULL,NULL)
		,('05','08',NULL,NULL)

		,('01','09',NULL,NULL)
		,('02','09',NULL,NULL)
		,('03','09',NULL,NULL)
		,('04','09',NULL,NULL)
		,('05','09',NULL,NULL)

		,('01','10',NULL,NULL)
		,('02','10',NULL,NULL)
		,('03','10',NULL,NULL)
		,('04','10',NULL,NULL)
		,('05','10',NULL,NULL)

INSERT INTO [dbo].[AM_Executable]
           ([ExecutableID]
           ,[ButtonID]
           ,[ExecutablePath]
           ,[ExecutableParam]
		   ,[EPCheckBox])
     VALUES
	 ('01','01',NULL,NULL,'False')
	 ,('02','02',NULL,NULL,'False')
	 ,('03','03',NULL,NULL,'False')
	 ,('04','04',NULL,NULL,'False')
	 ,('05','05',NULL,NULL,'False')
	 ,('06','06',NULL,NULL,'False')
	 ,('07','07',NULL,NULL,'False')
	 ,('08','08',NULL,NULL,'False')
	 ,('09','09',NULL,NULL,'False')
	 ,('10','10',NULL,NULL,'False')

INSERT INTO [dbo].[AM_Notes]
           ([NoteID]
           ,[ButtonID]
           ,[NoteText])
     VALUES
			('01','01',NULL)
			,('02','02',NULL)
			,('03','03',NULL)
			,('04','04',NULL)
			,('05','05',NULL)
			,('06','06',NULL)
			,('07','07',NULL)
			,('08','08',NULL)
			,('09','09',NULL)
			,('10','10',NULL)






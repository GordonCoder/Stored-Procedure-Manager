CREATE VIEW [dbo].[AM_Button1Info]
AS
WITH 
Param1 AS (SELECT bp.ParamID AS ParamID, bp.ButtonID AS ButtonID, bp.ParamName AS ParamName1, bp.ParamValue AS ParamValue1 FROM dbo.AM_ButtonParam bp WHERE bp.ParamID = 1 AND bp.ButtonID = 1)
,Param2 AS (SELECT bp.ParamID AS ParamID, bp.ButtonID AS ButtonID, bp.ParamName AS ParamName2, bp.ParamValue AS ParamValue2 FROM dbo.AM_ButtonParam bp WHERE bp.ParamID = 2 AND bp.ButtonID = 1)
,Param3 AS (SELECT bp.ParamID AS ParamID, bp.ButtonID AS ButtonID, bp.ParamName AS ParamName3, bp.ParamValue AS ParamValue3 FROM dbo.AM_ButtonParam bp WHERE bp.ParamID = 3 AND bp.ButtonID = 1)
,Param4 AS (SELECT bp.ParamID AS ParamID, bp.ButtonID AS ButtonID, bp.ParamName AS ParamName4, bp.ParamValue AS ParamValue4 FROM dbo.AM_ButtonParam bp WHERE bp.ParamID = 4 AND bp.ButtonID = 1)
,Param5 AS (SELECT bp.ParamID AS ParamID, bp.ButtonID AS ButtonID, bp.ParamName AS ParamName5, bp.ParamValue AS ParamValue5 FROM dbo.AM_ButtonParam bp WHERE bp.ParamID = 5 AND bp.ButtonID = 1)
SELECT
b.ButtonID AS ButtonID
,b.ButtonName AS ButtonName
,b.SPName AS SPName
,p1.ParamName1
,p1.ParamValue1
,p2.ParamName2
,p2.ParamValue2
,p3.ParamName3
,p3.ParamValue3
,p4.ParamName4
,p4.ParamValue4
,p5.ParamName5
,p5.ParamValue5
,e.ExecutablePath AS ExecutablePath
,e.ExecutableParam AS ExecutableParam
,e.EPCheckBox AS EPCheckBox
,f.FilePath AS FilePath
,f.FPCheckBox AS FPCheckBox
,n.NoteText AS NoteText
FROM 
dbo.AM_Buttons b
LEFT JOIN dbo.AM_Executable e ON b.ButtonID = e.ButtonID 
LEFT JOIN dbo.AM_FileImport f ON b.ButtonID = f.ButtonID 
LEFT JOIN dbo.AM_Notes n ON b.ButtonID = n.ButtonID
LEFT JOIN Param1 p1 ON b.ButtonID = p1.ButtonID
LEFT JOIN Param2 p2 ON b.ButtonID = p2.ButtonID
LEFT JOIN Param3 p3 ON b.ButtonID = p3.ButtonID
LEFT JOIN Param4 p4 ON b.ButtonID = p4.ButtonID
LEFT JOIN Param5 p5 ON b.ButtonID = p5.ButtonID
WHERE b.ButtonID = 1

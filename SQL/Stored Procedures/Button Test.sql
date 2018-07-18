
CREATE Procedure ButtonTest
AS 

UPDATE dbo.AM_Buttons 
SET 
ButtonID = '10'
,ButtonName = 'Button Name Test'
,SPName = 'SP Name Test'
WHERE ButtonID = '10'

UPDATE dbo.AM_ButtonParam 
SET
ParamName = 'Param 1 Name Test'
,ParamValue = 'Param 1 Value Test'
WHERE
ParamID = '1'
AND
ButtonID = '10'


UPDATE dbo.AM_Executable 
SET 
ExecutablePath = 'Executable Path Test'
,ExecutableParam = 'Executable Param Test'
WHERE
ExecutableID = '10'
AND
ButtonID = '10'


UPDATE dbo.AM_Notes 
SET 
NoteText = 'Note Text Test'
WHERE
NoteID = '10'
AND
ButtonID = '10'

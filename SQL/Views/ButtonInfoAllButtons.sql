CREATE VIEW [dbo].[AM_ButtonInfo_AllButtons]
AS
SELECT        
dbo.AM_Buttons.ButtonID, 
dbo.AM_Buttons.ButtonName, 
dbo.AM_Buttons.SPName, 
dbo.AM_ButtonParam.ParamID, 
dbo.AM_ButtonParam.ParamName, 
dbo.AM_ButtonParam.ParamValue, 
dbo.AM_Executable.ExecutableID, 
dbo.AM_Executable.ExecutablePath, 
dbo.AM_Executable.EPCheckBox, 
dbo.AM_Executable.ExecutableParam
FROM            
dbo.AM_Buttons 
INNER JOIN dbo.AM_ButtonParam ON dbo.AM_Buttons.ButtonID = dbo.AM_ButtonParam.ButtonID 
INNER JOIN dbo.AM_Executable ON dbo.AM_Buttons.ButtonID = dbo.AM_Executable.ButtonID
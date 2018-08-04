CREATE FUNCTION [dbo].[fn_GetButtonData] 
(
	-- Add the parameters for the function here
	@SelectedButtonID varchar(50)
)
RETURNS TABLE
AS
RETURN
SELECT * FROM [dbo].[AM_ButtonInfo_AllButton]
WHERE ButtonID = @SelectedButtonID;
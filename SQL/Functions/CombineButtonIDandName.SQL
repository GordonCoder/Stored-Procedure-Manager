Create FUNCTION [dbo].[fn_CombineButtonIDandName] 
(
)
RETURNS int
AS
BEGIN

RETURN (SELECT CONCAT('Button ', CONVERT(varchar(10), ButtonId) , ' - ', ButtonName)  FROM [dbo].[AM_Buttons])

END


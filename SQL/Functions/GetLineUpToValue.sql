
/****** Object:  UserDefinedFunction [dbo].[fn_GetLineUpToValue]    Script Date: 8/3/2018 9:51:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
SELECT dbo.fn_GetLineThroughLast(' -12-3456','-')
SELECT dbo.fn_GetLineThroughLast(' 123-456-789-000','-')

SELECT dbo.fn_GetLineBeforeLast(' -12-3456','-')
SELECT dbo.fn_GetLineBeforeLast(' 123-456-789-000','-')

SELECT dbo.fn_GetRestOfLineAfterLast(' -12-3456','-')
SELECT dbo.fn_GetRestOfLineAfterLast(' 123-456-789-000','-')

SELECT dbo.fn_GetLineUpToValue(' 12-3456','-')
SELECT dbo.fn_GetLineUpToValue(' 123-456-789-000','-')
*/
/* ====================================================================== */
/* Gets what is in the line before the input string occurance (any length) */
CREATE FUNCTION [dbo].[fn_GetLineUpToValue](@tmval2 varchar(2000),@vlsf varchar(2000))
RETURNS varchar(2000)
AS
BEGIN
DECLARE @spot int
DECLARE @av varchar(2000)
SET @av=LTRIM(RTRIM(@tmval2))

SET @spot = PATINDEX('%' + @vlsf + '%',@av)
if @spot > 0
SET @av=LTRIM(RTRIM(SUBSTRING(@av,1,@spot-1)))
-- otherwise, just returns what was sent in

RETURN LTRIM(RTRIM(@av))
END
GO



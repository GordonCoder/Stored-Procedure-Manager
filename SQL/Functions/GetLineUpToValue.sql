
/****** Object:  UserDefinedFunction [dbo].[fn_GetLineUpToValue]    Script Date: 8/3/2018 9:51:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
SELECT '>' + dbo.fn_GetLineBeforeLast(' -ER-ERROR','-') + '<'
SELECT '>' + dbo.fn_GetLineBeforeLast(' oskiekf-lwidjoke-kasdofkjeoijIOIJlkdjafOIS-asdfkj','-') + '<'
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



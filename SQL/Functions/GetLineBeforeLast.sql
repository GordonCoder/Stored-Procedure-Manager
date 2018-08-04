SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
SELECT '>' + dbo.fn_GetLineThroughLast(' -ER-ERROR','-') + '<'
SELECT '>' + dbo.fn_GetLineThroughLast(' oskiekf-lwidjoke-kasdofkjeoijIOIJlkdjafOIS-asdfkj','-') + '<'
*/
/* ====================================================================== */
/* Gets the front part of line before the last string occurance (any length) */
CREATE FUNCTION [dbo].[fn_GetLineBeforeLast](@tmval2 varchar(2000),@vlsf varchar(2000))
RETURNS varchar(2000)
AS
BEGIN
DECLARE @spot int
DECLARE @av varchar(2000)
DECLARE @part1 varchar(2000)
DECLARE @part2 varchar(2000)

SET @part1 = ''
SET @part2 = @tmval2
SET @av = @part2

SET @spot = PATINDEX('%' + @vlsf + '%',@part2)
while @spot > 0
BEGIN
-- pull that value into part1
SET @part1 = @part1 + SUBSTRING(@part2,1,@spot + LEN(@vlsf) - 1)

-- reset value of part2
SET @part2 = SUBSTRING(@part2,@spot + LEN(@vlsf),LEN(@part2) - (@spot + LEN(@vlsf) - 1))


-- reset the loop control variable
SET @spot = PATINDEX('%' + @vlsf + '%',@part2)
END

-- otherwise, just returns what was sent in (if never found, @part2 still = @av)
SET @av = SUBSTRING(@part1,1,LEN(@part1)-LEN(@vlsf))
RETURN @av
END
GO



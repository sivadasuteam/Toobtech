


create PROCEDURE [dbo].[Sp_Add]
	@param1 int ,
	@param2 int
AS
begin
BEGIN TRY  
  declare @result int
  
select @result=@param1+@param2 
select @result 
END TRY  
BEGIN CATCH  
   print 'exception'
END CATCH  
end
go


--StoreProcedure
--Syntax

--CREATE PROCEDURE <Procedure_Name,> 
--	-- Add the parameters for the stored procedure here
--	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
--	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
--END
--GO







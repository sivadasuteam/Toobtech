create  proc Sp_valid1(@id int )
as
begin
select *from  [dbo].[isvalid] where userid=@id
end
exec Sp_valid1 101



create proc sp_valid123(@id int)
as
begin
if exists (select *from [isvalid] where userid=@id)
begin 
print 'true'
end
else
begin 
print'False'
end
End
exec sp_valid123 101

--upadte/insert/delete by using stores procedure
create proc Mysecond123 (@StatementType nvarchar(20) = '',@password varchar(max),@userid int)
as
begin
if (@StatementType ='insert')
insert into isvalid values(@userid,@password)
end
if(@StatementType='update')
begin
update isvalid set userid=@userid,password=@password where userid=@userid
end
if(@StatementType='delete')
begin
delete from isvalid where userid=@userid
end

exec Mysecond123 'insert', 'Mani',104
exec Mysecond123 'update', 'srikanth',104
exec Mysecond123 'Delete', 'srikanth',104
select *from isvalid


--create proc Mysecondtable (@StatementType nvarchar(20) = '',@tablename SYSNAME = '',@password varchar(max),@userid int)
--as
-- DECLARE @DynamicSQL NVARCHAR(4000)
--      SET @DynamicSQL = N'SELECT * FROM ' + @tablename
--begin
--if (@StatementType ='insert')
--insert into @DynamicSQL  values(@userid,@password)
--end
--if(@StatementType='update')
--begin
--update isvalid set userid=@userid,password=@password where userid=@userid
--end
--if(@StatementType='delete')
--begin
--delete from isvalid where userid=@userid
--en


 




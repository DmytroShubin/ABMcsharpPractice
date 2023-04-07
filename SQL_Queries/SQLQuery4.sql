--use ABM
select*from [dbo].[DmytroBills]
 --where ProductDescription='Pork Loin'

SELECT GETDATE();


update [DmytroBills] set AddedBy='Dmytro',LastUpdatedBy='Max',LastUodatedOn='2023-02-13 20:17:10.420' where ProductId=4
delete [DmytroBills] where ProductId=4;
delete [DmytroBills] where ProductId=8;
delete [DmytroBills] where ProductId=9;
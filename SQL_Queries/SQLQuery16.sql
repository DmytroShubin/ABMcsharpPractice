--create database Demodb

use Demodb

--SELECT GETDATE();
--select * from Table_Area
select ID,Description,IsActive from [dbo].[Table_Area]
select ID,Description,IsActive from [dbo].[Table_SubArea]
select ID,Description,IsActive from [dbo].[Table_City]
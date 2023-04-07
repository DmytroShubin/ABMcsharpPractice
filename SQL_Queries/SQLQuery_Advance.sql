select * from [dbo].[Table_Emp]

--select Name,Last_Name,Age,Gender,Department from [dbo].[Table_Emp] where  Name like'%%'or Last_Name like '%%'and Age like '%%'and Gender like '%%'and Department like '%%' order by name asc

--Select 
--ID, 
--ISNULL(Name,'John') as Name, 
--Last_Name, 
--ISNULL(Age,18) as Age, 
--ISNULL(Gender,'M')as Gender, 
--ISNULL(Department,'Sales')as Department 
--from [dbo].[Table_Emp] 

--select 
--Gender,
--COUNT(*)as count
-- from 
-- Table_Emp
-- Group BY
-- Gender;

-- select 
-- Last_Name,
-- Department,
-- '' as SecondaryId   
-- from 
-- Table_Emp
--select 
--ROW_NUMBER() over (order by Name) as ID
--from
--[dbo].[Table_Users]

SELECT SUM(Age) as total_Age
FROM [dbo].[Table_Emp]
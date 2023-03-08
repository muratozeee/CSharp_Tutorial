--Select
--Select the cloumn=* from customers we are calling the Customers informations...
Select * from Customers 

---we can take  ContackName CompanyName and City select and take from Customers...!

Select ContactName,CompanyName, City  from Customers

--Also we can use with alias let's see

Select ContactName name,CompanyName company,City city from Customers

--ANSII standartss

--we search the London city customer in data base and take them...

Select * from Customers where City='Berlin' 

-- we can see the all products with cloumns
Select * from Products
---Notes=Sql is insensitive for words...!

-- we are taking CategoryID=1 we are calling it...
-- we are taking CategoryID=1 or   CategoryID=3 we are calling it...
Select *from Products where CategoryID=1  or CategoryID=3
--Also we can use and both properties we can call them...
Select * from Products where CategoryID=1 and UnitPrice>=10

--Also for example we want to filter in trendyol website for buy something but you want to see between 5-10$ product we can use like that at below..!
--we filtered as a product name A ,B ,c 
select * from Products order by ProductName


-- we filtered the for ProductID then Same name is listed word depending on word queue
 select * from Products order by ProductID,ProductName

 select * from Products order by UnitPrice asc --ascending
 
 select * from Products order by UnitPrice desc --descending

 select *from Products where  CategoryID=1 order by UnitPrice desc

 --How many products do we have..!

 select COUNT(*) from Products

 --how many do we have product as a CateegoryID=2

 select COUNT(*) from Products where CategoryID=2

 --Which Catogery How many different Product Do we have?

 select CategoryID from Products group by CategoryID


  select CategoryID,count(*) from Products group by CategoryID

  --Also if we want to Products numbers<=10 we want to see and we will add products them

  select CategoryID,COUNT(*) from Products group by CategoryID  having COUNT(*)<=10

  --Also if we want to Products numbers<=10 we want to see and we will add products them adtional UnitPRice>20 products

    select CategoryID,COUNT(*) from Products where UnitPrice>20 group by CategoryID  having COUNT(*)<10




 
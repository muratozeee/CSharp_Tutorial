select* from Products;

select * from  Products order by Products.UnitPrice

select sum(UnitPrice) as 'Earn Money',ProductName from Products group by ProductName order by sum(UnitPrice);


select*from Orders--CustomerID

select*from Customers--CustomerID

select*from Products--ProductID

select*from [Order Details] order by ProductID--ProductID Quantity

select sum(p.UnitPrice*5),p.ProductName from Products p group by p.ProductName order by sum(UnitPrice)


--Assigment
select p.ProductName,sum(od.UnitPrice*Quantity) as 'Total amount of money'  from Products p 
inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o on o.OrderID=od.OrderID
group by p.ProductName order by sum(od.UnitPrice*od.Quantity)



select sum(od.UnitPrice*od.Quantity) as 'Total'  from ((Products p 
inner join [Order Details] od on p.ProductID=od.ProductID)
inner join Orders o on o.OrderID=od.OrderID)
group by od.UnitPrice order by sum(od.UnitPrice*od.Quantity)



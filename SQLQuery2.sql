--Select //comment line
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers 

Select * from Customers where City = 'London'

--case insensitive
sElEcT * from Products where CategoryID=1 or CategoryID=3

sElEcT * from Products where CategoryID=1 and UnitPrice>10

select * from Products order by  UnitPrice  --order bay sırala demek

select * from Products order by  UnitPrice asc  --ascending artan sırayla

select * from Products order by  UnitPrice  desc  --descending azalan sırayla

select * from Products where CategoryID=1 order by  UnitPrice desc 

select count(*) from Products --products tablosundaki dataları sayar.

select count(*) from Customers --customers tablosundaki dataları sayar.

select count(*) Adet from Products where CategoryID=2

select CategoryID,count(*) from Products group by CategoryID 

select CategoryID,count(*) from Products group by CategoryID having count(*)<10

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 50

--DTO DATA TRANSFORMATİON OBJECT

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID



select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
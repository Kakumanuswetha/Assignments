--2.1)
--b)Write a Query to display the results from the above two tables:
			--CartId,  ProductName, Quantity, UnitPrice
			
		--Hint :  Quantity should takes from Cart table
SELECT c.CartID,p.ProductName,c.Quantity,p.UnitPrice FROM Cart AS c INNER JOIN Products AS p ON c.ProductID=p.ProductID;
--c)
--INNERJOIN
SELECT * FROM Cart INNER JOIN Products ON Cart.ProductID=Products.ProductID;
--RIGHT OUTER JOIN
SELECT * FROM Cart RIGHT OUTER JOIN Products ON Cart.ProductID=Products.ProductID;
--LEFT OUTER JOIN
SELECT * FROM Cart LEFT OUTER JOIN Products ON Cart.ProductID=Products.ProductID;
--FULL OUTER JOIN
SELECT * FROM Cart FULL OUTER JOIN Products ON Cart.ProductID=Products.ProductID;

--2.2)
CREATE TABLE Student
(
	StudentID INT PRIMARY KEY,
	StudentName VARCHAR(255),
	CourseName VARCHAR(255),
	CityName VARCHAR(255),
)
INSERT INTO Student VALUES(1,'Swetha','.NET','Vijayawada');
INSERT INTO Student VALUES(2,'Lahari','.NET','Vijayawada');
INSERT INTO Student VALUES(3,'Mohini','Angular','Hyderabad');
INSERT INTO Student VALUES(4,'Manasa','Angular','Hyderabad');
INSERT INTO Student VALUES(5,'Reethu','React','Bangalore');
INSERT INTO Student VALUES(6,'Roshan','React','Hyderabad');
INSERT INTO Student VALUES(7,'Yash','Javascript','Delhi');
INSERT INTO Student VALUES(8,'Sarthak','Javascript','Delhi');
INSERT INTO Student VALUES(9,'Pranay','Node','Hyderabad');
INSERT INTO Student VALUES(10,'Tripthi','Node','Hyderabad');

SELECT * FROM Student;
--a) Find out how many Students are joined for "Angular"  Course
SELECT COUNT(*) AS NO_OF_STUDENTS_IN_ANGULAR_COURSE FROM Student WHERE CourseName='Angular';
--b)Find out how many Students are joined from  "Hyderabad"  City
SELECT COUNT(*) AS NO_OF_STUDENTS_FROM_HYDERABAD FROM Student WHERE CityName='Hyderabad';
--c)Display No. of Students are join from each  City based 
SELECT COUNT(*) AS NO_OF_STUDENTS,CityName AS CITY FROM Student GROUP BY CityName;
--d)Display No. of Students are join from each  Course  based 
SELECT COUNT(*) AS NO_OF_STUDENTS,CourseName AS COURSE FROM Student GROUP BY CourseName;
--e)Display the counts  by grouping based on  city, course 
SELECT COUNT(*) AS NO_OF_STUDENTS_BASED_ON_CITY_AND_COURSE FROM Student GROUP BY CityName,CourseName;

--2.3)

--a)Get the orders from orders placed by the users belongs to given city. 
SELECT OrderID,OrderDate,TotalAmount FROM Orders WHERE UserID IN (SELECT UserID FROM Users WHERE City='VIJAYAWADA');
--b)Get the orders from orders placed by the users not belongs to given city. 
SELECT OrderID,OrderDate,TotalAmount FROM Orders WHERE UserID NOT IN (SELECT UserID FROM Users WHERE City='VIJAYAWADA');
--c)Display the products if any items exists in the cart table   
SELECT * FROM Products WHERE EXISTS(SELECT ProductID FROM Cart)
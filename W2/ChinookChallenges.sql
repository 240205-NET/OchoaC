-- On the Chinook DB, practice writing queries with the following exercises

-- List all customers (full name, customer id, and country) who are not in the USA

SELECT CONCAT(c.FirstName, ' ', c.LastName)
FROM Customer AS c
WHERE Country NOT LIKE 'USA';

-- List all customers from Brazil
SELECT *
FROM Customer
WHERE Country LIKE 'Brazil';
-- List all sales agents
SELECT *
FROM [dbo].[Employee]
WHERE Title LIKE '%sale%agent%';


-- Retrieve a list of all countries in billing addresses on invoices
SELECT BillingCountry
FROM Invoice
GROUP BY BillingCountry;

-- Retrieve how many invoices there were in 2009, and what was the sales total for that year?
    -- (challenge: find the invoice count sales total for every year using one query)
SELECT COUNT(*) AS '# of Invoices', SUM(Total) AS 'Total Sum'
FROM Invoice
WHERE InvoiceDate BETWEEN '2009' AND '2010';

-- how many line items were there for invoice #37
SELECT COUNT(*) AS '# of Items'
FROM InvoiceLine
WHERE InvoiceId = 37

-- how many invoices per country?
SELECT COUNT(*) AS '# of Invoices', BillingCountry
FROM Invoice
GROUP BY BillingCountry

-- Retrieve the total sales per country, ordered by the highest total sales first.

SELECT SUM(Total) AS 'Total Sales', BillingCountry
FROM Invoice
GROUP BY BillingCountry
ORDER BY 'Total Sales' DESC;



-- JOINS CHALLENGES
-- Show all invoices of customers from brazil (mailing address not billing)

SELECT I.*
FROM Invoice AS I
JOIN Customer AS C ON I.CustomerId = C.CustomerId
WHERE C.Country LIKE 'Brazil';

-- Show all invoices together with the name of the sales agent for each one
SELECT I.*, CONCAT(E.FirstName, ' ', E.LastName) AS 'Sales Agent'
FROM Invoice AS I
JOIN Customer AS C ON I.CustomerId = C.CustomerId
JOIN Employee AS E ON E.EmployeeId = C.SupportRepId;

-- Show all playlists ordered by the total number of tracks they have
SELECT P.Name, COUNT(*) AS '# of Tracks'
FROM Playlist AS P
JOIN PlaylistTrack AS PT ON P.PlaylistId = PT.PlaylistId
GROUP BY P.Name
ORDER BY '# of Tracks' DESC;

-- Which sales agent made the most sales in 2009?
SELECT 

-- How many customers are assigned to each sales agent?

-- Which track was purchased the most ing 20010?

-- Show the top three best selling artists.

-- Which customers have the same initials as at least one other customer?



-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?

-- 2. which artists did not record any tracks of the Latin genre?

-- 3. which video track has the longest length? (use media type table)

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.


-- DML exercises

-- 1. insert two new records into the employee table.

-- 2. insert two new records into the tracks table.

-- 3. update customer Aaron Mitchell's name to Robert Walter

-- 4. delete one of the employees you inserted.

-- 5. delete customer Robert Walter.
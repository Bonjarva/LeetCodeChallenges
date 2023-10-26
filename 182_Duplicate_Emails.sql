/*
 Table: Person
 
 +-------------+---------+
 | Column Name | Type    |
 +-------------+---------+
 | id          | int     |
 | email       | varchar |
 +-------------+---------+
 id is the primary key (column with unique values) for this table.
 Each row of this table contains an email. The emails will not contain uppercase letters.
 
 
 Write a solution to report all the duplicate emails. Note that it's guaranteed that the email field is not NULL.
 
 Return the result table in any order.
 
 The result format is in the following example.
 
 
 
 Example 1:
 
 Input: 
 Person table:
 +----+---------+
 | id | email   |
 +----+---------+
 | 1  | a@b.com |
 | 2  | c@d.com |
 | 3  | a@b.com |
 +----+---------+
 Output: 
 +---------+
 | Email   |
 +---------+
 | a@b.com |
 +---------+
 Explanation: a@b.com is repeated two times.
 
 */
-- Solution Plan
-- 1.Initial query to get the necessary element from the table
--SELECT p.email FROM Person p
--
-- 2. Rejoin to Person table and compare the email to match but with a different ID
/*
 SELECT
 p.email
 FROM
 Person p
 JOIN Person p2 
 ON p.email = p2.email
 AND p.id <> p2.id
 */
--
-- Group emails to get unique entries
/*
 SELECT
 p.email
 FROM
 Person p
 JOIN Person p2 ON p.email = p2.email
 AND p.id <> p2.id
 GROUP BY
 p.email*/
--Simplified query using the HAVING method
SELECT
    email
from
    Person
group by
    email
having
    count(email) > 1
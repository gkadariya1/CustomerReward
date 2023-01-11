# Retail Customer Reward

A retailer offers a rewards program to its customers, awarding points based on each recorded purchase.

A customer receives 2 points for every dollar spent over $100 in each transaction, plus 1 point for every
dollar spent over $50 in each transaction
(e.g. a $120 purchase = 2x$20 + 1x$50 = 90 points).

Given a record of every transaction during a three-month period, calculate the reward points earned for
each customer per month and total.


## Versions
Framework : .net core 3.1
Language:   c# 10


## Important URL
Swagger UI - https://localhost:44339/swagger/index.html


## How to run the application
1. Clone the repository
2. Open in IDE (Visual Studio or VS Code)
3. Build the project
4. Run the project

##Data

###Customer

| CustomerId    | CustomerName  |
|---------------|---------------|
| 111           | Customer1     |
| 112           | Customer2     |
| 113           | Customer3     |
| 114           | Customer4     |
| 115           | Customer5     |
| 116           | Customer6     |
| 117           | Customer7     |
| 118           | Customer8     |


###Transaction

| TransactionId  | CustomerId  | TransactionDate  | TransactionAmount|
|----------------|-------------|------------------|------------------|
| 1              | 1           | 2022-07-12       |       100        |
| 2              | 1           | 2022-08-04       |       220        |
| 3              | 1           | 2022-08-20       |       100        |
| 4              | 1           | 2022-09-04       |       180        |
| 5              | 1           | 2022-09-07       |       125        |
| 7              | 2           | 2022-06-05       |       123        |
| 8              | 2           | 2022-06-27       |       370        |
| 9              | 2           | 2022-07-04       |       110        |
| 10             | 2           | 2022-07-14       |       235        |
| 11             | 2           | 2022-08-05       |       160        |
| 12             | 2           | 2022-08-18       |       275        |
| 13             | 3           | 2022-06-05       |       105        |
| 14             | 3           | 2022-06-27       |       380        |
| 15             | 3           | 2022-07-04       |       190        |
| 16             | 3           | 2022-07-13       |       103        |
| 17             | 3           | 2022-03-27       |       550        |
| 18             | 3           | 2022-08-02       |       485        |
| 19             | 3           | 2022-08-15       |       240        |

**LINQ Queries in C#**

This repository demonstrates the use of LINQ (Language Integrated Query) in C# to manipulate and analyze a collection of games. It covers a wide range of operations including filtering, sorting, grouping, aggregation, pagination, and joins.

**Overview**

The project uses a list of games, each having a title, genre, release year, rating, and price. The queries show how to perform common data operations in C# using LINQ.

LINQ Operations Demonstrated

Selecting Data: Extracting specific properties like all game titles from the list.

Filtering: Finding games by genre, rating, price, or other conditions, such as all RPGs or games with a rating above 9.0.

Ordering and Sorting: Sorting games by release year, rating, or other criteria, both ascending and descending.

Aggregation and Counting: Calculating the total number of games, total price, highest rating, and lowest rating.

Grouping: Grouping games by genre to organize them logically.

Pagination: Skipping a number of records and taking a limited set for page-like results.

First, Single, Last Queries: Retrieving the first, single, or last matching game, with safe options when no match exists.

Distinct and Existence Checks: Finding unique genres, checking if a certain game exists, or verifying if all games meet a condition.

Joins: Combining games with another list, such as game reviews, to enrich the dataset.

Special Queries: Examples include getting low-budget RPGs, top-rated games, last few games, and other filtered selections.

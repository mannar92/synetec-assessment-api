# Synetec Basic .Net API assessement

This is Synetec's basic API developer assessment.

If you are reading this, you most probably have been asked to complete this assessment as part of Synetec's interview process.

In this repository, you will find the base project and instructions on what to do with them. 

## How to complete this test

Please follow the instructions in the Instructions.pdf, found in this repository

## How to submit your completed test

To sumbit your test, please 
1. Fork this repository
2. Complete the test as per the instructions PDF 
3. Commit your changes to your (forked) repo 
4. Send us an http link to your repo that contains the completed test 

**This repo is Read-Only!!** So please don't try to open a pull request

## My Solution Approach 

1. Review the code and see if it works (it does).
2. Identify code smells and bad practises.
3. Decide on the design pattern and refactoring methodology.
4. Start small refactoring based on SOLID principles and Domain-Driven Design (DDD) pattern.
5. Test if calculations are correct (i.e. Unit test it).

## Step 1: Code Review and Code Smells
1. Three projects, probably trying to implement the DDD design pattern
2. GET api/BonusPool returns all employees so the name is misleading
3. POST api/BonusPool supposedly calculated the bonus by employee Id
	3.1 It would be better to split the controller into EmployeesController where the above logic is implemented. Also having routes to the API calls (e.g. api/bonuspool/allemployees) is highly understandable.
	3.2 Also, both services use newly created instances of the BonusPoolServices, therefore the letter  D of the SOLID principles is not followed.
4. BonusPoolService class is responsible for more than one logic, therefore the letter S in SOLID principles is not followed.
5. DTOs can be achieved with a Mapper class or AutoMapper
6. Add folders to projects for spitting the logic and different layers in the application
7. DbContext should be achieved through dependency injenction and not being initialised every time is used. Use repositories for reusable queries and DB operations.
8. Add middleware for exception handling,
9. Add logging,
10. Identify the key domain and follow the DDD pattern.

## Step 2: Decide on DDD and Refactoring Methodology
1. Domain Layer:
	1.1 BonusPoolDomain
2. API Layer:
	2.1 ○ EmployeeController
	2.2 BonusPoolController
	2.3 Services for each controller
	2.4 DTOs with Mapper
	2.5 Exception handling with middleware



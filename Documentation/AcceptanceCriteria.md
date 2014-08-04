# Acceptance Criteria

## Scenario: Lowest Goal Difference

    Given the 'leaguetable.txt' file
	When I pass the file name as a command line parameter
	Then the team name of the team with 
       the lowest goal difference is displayed in the console

## Scenario: Smallest Goal Difference
	
	Given the 'leaguetable.txt' file
	When I pass the file name as a command line parameter
    And I pass '/s' as a command line parameter
	Then the team name of the team with 
       the smallest goal difference is displayed in the console

## Scenario: Aggregate Command Line Processing

    Given the 'leaguetable.txt' file
    When I pass the file name as a command line parameter
	And I pass one (and only one) of the following 
  	   aggregate command line parameters
    Then the team name of the team with
       that matches the specified criteria is displayed in the console 

* **/l** - lowest goal difference
* **/h** - highest goal difference
* **/s** - smallest goal difference

## Scenario: Team Specific Command Line Processing

	Given the 'leaguetable.txt' file
	When I pass the file name as a command line parameter
	And I pass one (and only one) of the following
	   team specific command line parameters
	Then the specified team name and corresponding 
       criteria value are displayed in the console

* **/d "team name"** - goal difference for the specified team
* **/f "team name"** - goals *for* for the specified team
* **/a "team name"** - goals *against* for the specified team

## Scenario: Alternative Data Source
	
	Given the XML data at the URL 'http://bit.ly/1kyp1Qr'
	When I pass the URL as a command line parameter
	Then the data is used as an alternative data source
	   for all existing command line parameters

## Scenario: Error Logging

	Given the application is executing 
	When an unexpected error occurs
    Then the error message, date, and time are 
       logged to a log file called 'errors.log' 
       (in the same folder that the application is running from)

## Scenario: Verbose Logging

    Given the command line parameter '/v' is used
	   (can be used with any other command line parameter)
	When the application is executing       
    Then ALL program output is written to a file called 'output.log'
       (in the same folder that the application is running from)
    And no output is displayed in the console
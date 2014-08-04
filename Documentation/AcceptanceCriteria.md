# Acceptance Criteria

## Scenario 1: Lowest Goal Difference

    Given the 'leaguetable.txt' file
	When I pass the file name as a command line parameter
	Then the team name of the team with
       the lowest goal difference is displayed in the console

## Scenario 2: Smallest Goal Difference

	Given the 'leaguetable.txt' file
	When I pass the file name as a command line parameter
    And I pass '/s' as a command line parameter
	Then the team name of the team with
       the smallest goal difference is displayed in the console

## Scenario 3: Aggregate Command Line Processing

    Given the 'leaguetable.txt' file
    When I pass the file name as a command line parameter
	And I pass one (and only one) of the following
  	   aggregate command line parameters
    Then the team name of the team with
       that matches the specified criteria is displayed in the console

* **/l** - lowest goal difference
* **/h** - highest goal difference
* **/s** - smallest goal difference
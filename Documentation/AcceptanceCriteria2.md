## Scenario 4: Alternative Data Source

	Given the XML data at the URL 'http://bit.ly/1kyp1Qr'
	When I pass the URL as a command line parameter
	Then the data is used as an alternative data source
	   for all existing command line parameters

## Scenario 5: Error Logging

	Given the application is executing
	When an unexpected error occurs
    Then the error message, date, and time are
       logged to a log file called 'errors.log'
       (in the same folder that the application is running from)

## Scenario 6: Verbose Logging

    Given the command line parameter '/v' is used
	   (can be used with any other command line parameter)
	When the application is executing
    Then ALL program output is written to a file called 'output.log'
       (in the same folder that the application is running from)
    And no output is displayed in the console
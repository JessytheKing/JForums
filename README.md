# JForums


# Test Readiness Review

| TestNumber    | Test Description |Test Method |
| ------------- | -------------    |------------|
| 1  | User shall be able to insert Email|Demonstration|
| 1.1  | User shall create a Username|  Demonstration    |
| 1.2 | User shall create a Password |Demonstration|
| 1.3  | User shall be able to create an account|Analysis     |
| 2  | User shall be to change Password|Demonstration       |
|2.1|User shall be able to Enable secure login|Demostration|
|2.2| User shall be able to Generate recovery codes|Demostation|
|2.3| User shall be able update their profiles| Analysis|
|3| User shall be able to publish forums based on topic|Test|
|3.1| User shall be able to delete published forums |Test| 
|4| User shall be able to post comments|Demonstration|
|4.1| User shall be able to reply to comments|Demonstration|
|4.2| User shall be able to delete comments|Demonstration|
|5| Website shall display Forums|Inspection|
|5.1| Website shall display Comments|Inspection|
|5.2| Website shall update forums based on recently created|Inspection|
|5.3|Website shall display  top 5 most trending forum|Inspection|
|5.4|Website shall display top 5 most downvoted forum|Inspection|
|6|Menu shall lead users to the correct view|Demonstration|
|6.1| Homepage shall display to top 5 forums in both downvoted and trending|Demonstration|
|6.2| Homepage shall point to topic forums and account settings|Demonstartion|

# Requirement Traceability
|Test Number| Account| Manage Account | Forums | Comments | Display|
| --------- | -------|----------------|--------|----------|--------|
|1          |  OK    |                |        |          |        |  
|1.1        |  OK    |                |        |          |        |
|1.2        |  OK    |                |        |          |        |
|1.3        |  OK    |                |        |          |        |
|2          |        |    OK          |        |          |        |        
|2.1        |        |    OK          |        |          |        |        
|2.2        |        |    OK          |        |          |        |          
|2.3        |        |    OK          |        |          |        |         
|3          |        |                | OK     |          |        |
|3.1        |        |                | NO     |          |        |
|4          |        |                | OK     |          |        |
|4.1        |        |                | OK     |          |        |
|4.2        |        |                | NO     |          |        |
|5          |        |                |        | OK       |        |
|5.1        |        |                |        | OK       |        |
|5.2        |        |                |        | OK       |        |
|5.3        |        |                |        | OK       |        |
|5.4        |        |                |        | OK       |        |
|6          |        |                |        |          |    NO  |
|6.1        |        |                |        |          |    NO  |
|6.2        |        |                |        |          |    NO  |

# Exit Criteria
|Test Number| Status | TimeStamp      | Build  | Requirement| Test Procedure|
| --------- | -------|----------------|--------|------------|---------------|
|1          |Passed  |11/03/2019     | 1.0     |Create Profile| Enter the Email/Username/Password|  
|1.1        |Passed  |11/03/2019     | 1.0       |Create Profile            | unit test              |
|1.2        |Passed  |11/03/2019     | 1.0       |Create Profile            | unit test              |
|1.3        |Passed  |11/03/2019     | 1.0       |Create Profile            | unit test              |
|2          |Passed  |11/03/2019     | 1.0       |Manage Profile            | Enter changes to email/password             |        
|2.1        |Passed  |11/03/2019     | 1.0       |Manage Profile            | unit test              |        
|2.2        |Passed  |11/03/2019     | 1.0       |Manage Profile            | unit test              |         
|2.3        |Passed  |11/03/2019     | 1.0       |Manage Profile            | unit test               |         
|3          |Passed  |11/03/2019     | 1.0       |Forums            | unit test/View the webpage              |
|3.1        |Failed  |11/03/2019     | 1.0       |Forums            |  unit test/View the webpage             |
|4          |Passed  |11/03/2019     | 1.0       |Comment            | unit test/View the webpage              |
|4.1        |Passed  |11/03/2019     | 1.0       |Comment            | unit test/View the webpage               |
|4.2        |Failed  |11/03/2019     | 1.0       |Comment            |               |
|5          |Passed  |11/03/2019     | 1.0       |Display            |Verify via webpage                |               |
|5.1        |Failed  |11/03/2019     | 1.0       |Display          |         TBA      |
|5.2        |Failed  |11/03/2019     | 1.0       |Display         |          TBA     |
|5.3        |Failed  |11/03/2019     | 1.0       |Display         |           TBA    |
|5.4        |Failed  |11/03/2019     | 1.0       |Display          |            TBA   |
|6          |Failed  |11/03/2019     | 1.0       |Display            |           TBA  |
|6.1        |Failed  |11/03/2019     | 1.0       |Display            |          TBA  |
|6.2        |Failed  |11/03/2019     | 1.0       |            |           TBA  |

#Findings
* Still Alot to do, on the display portion
* Create Account works on view
* Post works
* comments work
* Work on views

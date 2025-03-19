# OrderProcessingApp
Processing Customer Orders

Overview
This is a simple ASP.NET web application designed to process customer orders. 
The application calculates a discount for loyal customers based on their order amount.

Business Logic:
1. If the order amount is $100 or more and the customer is "Loyal", a 10% discount is applied.
2. Otherwise, no discount is applied.
3. The final order total is displayed on the results page.

Features
1. Order Amount: Customers can enter their order amount and select their customer type ("New" or "Loyal").
2. Discount Calculation: Automatically calculates and displays the discount and the final amount.

Technical Details
1. ASP.NET Application
    1. Developed using ASP.NET Core MVC.
    2. Two views are included: one for order entry and one for displaying results.

2. Business Logic
    1. The discount logic is implemented based on the specified business rules.
    2. Handles edge cases, such as invalid inputs or edge order amounts (Ex: $100).

3. Version Control with GitHub
    1. The project is hosted on GitHub.
    2. Branching strategy used: 
        Main Branch: This branch contains production-ready code.
        Develop Branch: Merges all feature branches for further testing before merging into main.

4. CI/CD Integration
    1. A CI/CD pipeline using GitHub Actions is set up to automatically run tests upon each commit.
    2. It automates the process of building, testing, publishing, and storing the application every time changes are pushed to the main branch or when a pull request is created for it.
    3. .github\workflows\ci-cd-pipeline.yml [Reference fil]
    4. Automated tests are implemented using xUnit.


Steps to Build and Run the Application:
Clone the repository:

git clone https://github.com/sanumolu5/OrderProcessingApp.git
cd OrderProcessingApp

Restore the dependencies:
dotnet restore

Build the application:
dotnet build

Run the application:
dotnet run

Open your browser and go to http://localhost:[port number]/ to use the application.

Run the automated tests locally:
dotnet test
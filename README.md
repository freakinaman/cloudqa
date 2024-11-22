# CloudQA Developer Task

This project is part of the application process for the CloudQA Developer Internship. It involves creating an automation script using **C#** and **Selenium** to test fields on the [Automation Practice Form](https://app.cloudqa.io/home/AutomationPracticeForm).

## Project Overview

The program performs the following:
1. Fills in the "First Name" field with **"Aman"**.
2. Fills in the "Email" field with **"aman@example.com"**.
3. Selects **"Male"** in the gender radio buttons.
4. Validates each field to ensure the values are correctly entered.

## Technologies Used
- **Language**: C#
- **Automation Tool**: Selenium WebDriver
- **Browser**: Google Chrome (via ChromeDriver)
- **Framework**: .NET 8.0

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/freakinaman/cloudqa.git
   cd cloudqa
2. Build the project:
   ```bash
    dotnet build
3. Run the program:
   ```bash
    dotnet run
## Key Features
1. Uses explicit waits to ensure elements are available before interacting.
2. Designed to be robust against changes in element positioning or properties.
3. Prints validation results for each test in the terminal.

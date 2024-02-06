# StackOverflow Application

## Overview
This project is an ASP.NET application designed to mimic the functionality of StackOverflow, a popular question-and-answer website. The application allows users to register, log in, post questions, view questions, provide answers, and interact with the community.

## Features
- **User Authentication:** Users can register for an account and log in securely using hashed passwords.
- **Question Posting:** Registered users can post questions to the community, which are then visible to other users.
- **Search Functionality:** Users can search for specific questions using keywords, allowing for easy navigation and discovery.
- **Question Voting:** Users can vote on questions, indicating their relevance or usefulness to the community.
- **Answer Submission:** Registered users can provide answers to questions posed by others, contributing to the knowledge base of the community.
- **View Tracking:** The application tracks the number of views each question receives, providing insight into its popularity.
- **User Identification:** Questions display the username of the user who posted them, along with the date and time of posting.

## Sections
- **Home:** The landing page of the application, where users can view recent questions and navigate to other sections.
- **About:** Provides information about the purpose and goals of the StackOverflow application.
- **Contact:** Allows users to get in touch with the development team or enterprise behind the application.
- **Search:** Enables users to search for specific questions using keywords.
- **Question View:** Displays individual questions along with answers, votes, and other relevant details.
- **Question Creation:** Allows registered users to create and submit new questions to the community.

## Technologies Used
- **ASP.NET MVC Framework:** Used for building the web application's architecture and handling HTTP requests.
- **C# Programming Language:** Used for server-side logic and backend development.
- **Bootstrap Framework:** Used for front-end design and layout, ensuring a responsive and user-friendly interface.
- **SQL Server Database:** Used for storing user data, questions, answers, and other application information.

## Setup Instructions
1. Clone this repository to your local machine.
2. Install Visual Studio and Microsoft SQL Server if you haven't already.
3. Open the project in Visual Studio.
4. In Visual Studio, navigate to `View` > `Server Explorer`.
5. Click on `StackOverflowDatabaseDbContext` in the Server Explorer.
6. Add database security by selecting Windows Authentication and click "Ok".
7. Run the application using IIS Express (commonly launched with Google Chrome).


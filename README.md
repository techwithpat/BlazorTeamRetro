# Real-Time Retrospective Application with SignalR

Welcome to the repository for the Real-Time Retrospective Application with SignalR! In this project, we introduce you to the concept of real-time communication using SignalR. We have created a small application using Blazor WebAssembly to facilitate retrospective meetings at the end of a sprint in agile environments. The application allows team members to share feedback on the completed sprint in real time.

## Application Overview

The application consists of three main columns where team members can enter their thoughts:

1. **Things that Went Well:** This column allows team members to enter aspects of the sprint that went well, such as achievements or positive outcomes.

2. **Something to be Improved:** In this column, team members can add items that need improvement or areas that could be better in the future.

3. **Actions to Take:** This column is used to suggest actions that the team can take based on the feedback received during the retrospective.


SignalR is a powerful tool that facilitates real-time communication between clients and servers. To make this possible, we are hosting the Blazor WebAssembly application in an ASP.NET Core application, which will serve as the backend. 

## Project Structure

The solution comprises three projects:

1. **Client Project:** This is the Blazor WebAssembly application, which runs on the client side and handles user interactions.

2. **Server Project:** The ASP.NET Core application hosts the Blazor application and is responsible for managing real-time communication through SignalR.

3. **Shared Project:** This project contains classes that are shared between the client and server projects. Notable classes include "RetrospectiveItem" and "ItemType," which represent the model used in the application.

## Getting Started

To set up the application locally and explore the real-time features, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred code editor.
3. Build the solution to restore NuGet packages and dependencies.
4. Start the server project.

## Dependencies

- .NET 7 and Web Development Workload

Make sure to have the required runtime and SDK versions installed to run the application smoothly.

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use the code and modify it as needed.

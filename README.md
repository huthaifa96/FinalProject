# Final Week Project

## Project Goal

The aim of this project is to create a test framework for a Book Store. The store's functionality, navigation around the website, creating new accounts and testing existing ones will all be tested whilst also testing different API requests.

I aim to use the GitHub features to make regular commits and create a project board, follow the scrum model by holding regular stand-ups and reviews and have a README file that is thorough and done to a high degree of accuracy.

## Class Diagram

![Class Diagram](https://github.com/huthaifa96/FinalProject/blob/main/Images/ClassDiagramFinalProject.PNG)

## Sprints

#### Sprint 1 Review

The main purpose of the first sprint was to play around with the website and see what tests could be run and to create the initial framework. Also, the aim was to create some basic tests regarding the Book Store's homepage.

#### Sprint 1 Retrospective
All the tasks set out for the first sprint were achieved. However, when creating the test framework, there was a few issues in terms of installing the correct NuGet packages and setting up the POM in the right way. Thankfully, this was resolved and basic tests were created.

#### Sprint 2 Review
The aim of this sprint was to build on the basic tests done in sprint two and create tests around creating a new user and signing in to the website. Setting up the API test framework and creating tests for basic requests were the other tasks set out for sprint two. However, only creating tests around creating a new user and signing in to the website were achieved.

#### Sprint 2 Retrospective
Sprint two didn't go completely according to plan. The sprint started by creating basic tests for the login page but when an attempt to upload the latest local file to GitHub was made, it failed to overwite the remote file. Unfortunately, this wasn't resolved even after asking for help and researching the issue. This task should've been timeboxed to avoid wasting time as setting up the API request tests weren't made. This will now have to be moved to sprint three.

#### Sprint 3 Review

The aim of this sprint was to complete the uncompleted tasks. In sprint two, I didn't get round to completing the tests for the API requests so this was done in sprint three. Also, a run through of the documentation was done to ensure everything was done to a high degree of accuracy.

#### Sprint 3 Retrospective
When carrying out the tests for the different API requests, the GET requests worked fine but I had issues with the POST requests. A "user ID not authorised" error popped up so I had to stick to the GET request test.

### Project Review

The project requirements was to create automated web tests for the book store on demoqa.com and to try and create API request tests. The automated web tests run smoothly and basic functionality of the website was tested, so in this section this could be considered a success. For the API tests, a GET request was tested and this also passed. However, when trying to do a POST request, an error saying that "user ID is not authorized" came up and this was the reason why no POST request test could be conducted. Also, working in the SCRUM framework helped me stay organised despite the setbacks and this can be seen from the recorded documentation in the project board.

### Project Retrospective

A lot of lessons can be taken from this project. Firstly, starting with thorough research at the beginning of the project would help productivity later on in the project. On the subject of productivity, each task should've been timeboxed because this would help in planning future sprints as you'd know roughly how long each task will realistically take. This would have helped me as I felt that I ran out of time near the end to carry out more tests.

I also tried planning out all the API tests when I don't think I had a solid understanding of how API's operated. So, I lost some time because of this as I realised some of the planned tests weren't possible or were too complicated for me to do.
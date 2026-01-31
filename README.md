This is an APP that help students to track their studys.

## Features
- login
- signup
- add subjects and tasks
- generate study plans (1 - 5 tasks per day)
- timer for each task
- statistics and reports
- dark mode?
- notifications?

## Tech Stack
Architecture: 3 layers (UI layer: winforms, Logic layer: c#, Data layer: sql)
Language: C# .NET 8.0
Dataflow: UI layer input -> logic layer process, validate etc -> Data layer store get data -> logic layer return bool to UI

## Logic algorithms
Task genration algorithm: Greedy algorithm, factors: status, due date, priority, estimated time

## Database Schema
Database: PostgreSQL
Schema:
- Users (userID, username, user_eEmail, created_at, last_login)
- UserPasswords (passwordID, userID, hashed_username_passowrd, salt)
- UserSettings (userID, max_daily_task, enable_notifications, vloume, region)
- Subjects (subjectID, userID, name)
- Tasks (taskID, subjectID, name, description, estimated_time, priority, due_date, completed, created_at)
- DailyPlans (planID, userID, date)
- DailyPlanTasks (planID, taskID, TasksOrder)



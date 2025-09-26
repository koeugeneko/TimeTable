# 📚 Personal Revision Timetable System

A C# WinForms application designed to help students manage their revision schedules more effectively.  
The system is tailored for exam preparation (e.g. GCSEs, A-Levels), providing **flexible scheduling**, **smart reminders**, and **progress tracking**.  

---

## ✨ Features (Planned & Implemented)

- 👤 **User Accounts** (registration, login)  
- 📅 **Timetable & Session Planner** (subjects, topics, exams, sessions, reminders)  
- ⏱️ **Revision Timer** (start/stop/pause with notifications)  
- 🔄 **Smart Rescheduler** (balances subjects if sessions are missed)  
- 📊 **Progress Tracking** (graphs, hours studied, completion rates)  
- 🏆 **Reward System** (streaks, points, badges, leaderboard)  
- 🎨 **Customisable UI** (themes, preferences, user-friendly design)  
- 📂 **Database Integration** (PostgreSQL with relational schema & ER diagram)  

---

# 🗂️ Project Structure


```markdown
/RevisionTimetable
│── Database   → PostgreSQL scripts, schema & ER diagrams  
│── UI         → WinForms user controls & panels  
│── Logic      → Core business logic (algorithms, scheduling, rewards)  
│── Testing    → Automated and manual test cases  
│──  README.md   → This file
│── NEA write-up → Word documentation for the NEA
```

---

## ✅ Programming To-Do List

### Database
- [ ] Create **User Table** (userID, username, password, dateRegistered)  
- [ ] Create **Subject Table** (subjectID, subjectName, subjectLevel)  
- [ ] Create **Topic Table** (topicID, topicName, subjectID FK)  
- [ ] Create **Events Table** (eventID, subjectID FK, eventName, eventDate)  
- [ ] Create **Sessions Table** (sessionID, userID FK, topicID FK, start/end time, completed, notes)  
- [ ] Create **Reminders Table** (reminderID, sessionID FK, reminderTime, sent)  
- [ ] Create **Preferences Table** (preferenceID, userID FK, preferredStudyTime)  
- [ ] Create **ProgressTracking Table** (trackID, userID FK, topicID FK, totalHours, completionRate)  
- [ ] Create **ResourceLinks Table** (resourceID, topicID FK, resourceName, linkURL, type)  
- [ ] Implement **sample data seeding** for testing  
- [ ] Write **basic SQL queries** (CRUD operations for all tables)  
- [ ] Write **advanced SQL queries** (leaderboard ranking, progress stats, missed session handling)  

### Logic Layer
- [ ] Implement **User Account System** (registration, login, logout)  
- [ ] Implement **Subject & Topic Management** (add, edit, delete)  
- [ ] Implement **Exam & Event Management** (create, update, delete)  
- [ ] Build **Session Scheduler** (generate sessions based on subjects & exams)  
- [ ] Build **Timer System** (start, pause, stop with notifications)  
- [ ] Add **Smart Rescheduler** (reschedule missed sessions automatically)  
- [ ] Add **Reminder System** (trigger based on session & user preference)  
- [ ] Add **Progress Tracking** (calculate hours studied, completion rates)  
- [ ] Add **Reward System** (streak counter, points, badges)  
- [ ] Add **Leaderboard** (rank users by streaks, hours, or points)  

### UI Layer
- [ ] Create **Login & Registration Forms**  
- [ ] Create **Dashboard Panel** (overview of progress + upcoming sessions)  
- [ ] Create **Calendar View** (sessions, exams, reminders)  
- [ ] Create **Session Control Panel** (start/pause/stop timer)  
- [ ] Create **Subject/Topic Management UI**  
- [ ] Create **Progress Graphs UI** (study hours, completion %)  
- [ ] Create **Rewards & Leaderboard UI**  
- [ ] Add **User Preferences Panel** (themes, study time preferences)  
- [ ] Implement **smooth navigation with panels/user controls**  

### Testing
- [ ] Write **unit tests** for database queries  
- [ ] Write **unit tests** for logic components (scheduler, reminders, progress)  
- [ ] Run **manual UI testing** (form navigation, input validation)  
- [ ] Perform **integration testing** (database ↔ logic ↔ UI)  

---

## 🛠️ Tech Stack

- **Language:** C# (WinForms)  
- **Database:** PostgreSQL  
- **IDE:** Visual Studio  

---

## 👥 Clients & Users

- 🎯 **Primary Users:** Students preparing for GCSEs & A-Levels  
- 👨‍👩‍👧 **Secondary Users:** Parents, teachers, friends (optional features)  

---

## 📅 Timeline

The project is planned for completion by **Easter** (as per NEA constraints).  

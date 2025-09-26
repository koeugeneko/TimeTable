# 📚 Personal Revision Timetable System

A C# WinForms application designed to help students manage their revision schedules more effectively.  
The system is tailored for exam preparation (e.g. GCSEs, A-Levels), providing **flexible scheduling**, **smart reminders**, and **progress tracking**.  

---

## ✨ Features (Planned & Implemented)

- 🔐 **User Authentication** (registration, login, encrypted passwords with Argon2 hashing)  
- 📅 **Timetable & Session Planner** (subjects, topics, exams, sessions, reminders)  
- ⏱️ **Revision Timer** (start/stop/pause with smart notifications)  
- 🧠 **Smart Rescheduler** (automatically balances subjects if sessions are missed)  
- 📊 **Progress Tracking** (graphs, hours studied, completion rates)  
- 🏆 **Reward System** (streaks, points, badges, leaderboard)  
- 🎨 **Customisable UI** (themes, preferences, user-friendly design)  
- 🛡️ **Security Features** (input validation, defensive design, logs, backup & recovery)  
- 📂 **Database Integration** (PostgreSQL with relational schema & ER diagram)  

---

## 🗂️ Project Structure

/RevisionTimetable
│── /Database # PostgreSQL scripts, schema & ER diagrams
│── /Docs # Design documents, diagrams, write-up
│── /UI # WinForms user controls & panels
│── /Logic # Core business logic (algorithms, scheduling, rewards)
│── /Security # Encryption & defensive design
│── /Testing # Test cases (black box, white box)
│── README.md # This file

---

## ✅ To-Do List

### Core Design & Documentation
- [ ] Complete **Top-Down / Hierarchical Diagram**  
- [ ] Create **Class Diagram**  
- [ ] Define **SQL Queries** (CRUD + advanced queries)  
- [ ] Finalise **Interface Design for User Controls**  
- [ ] Write missing **Notes** (if needed or skip per NEA spec)  

### Development
- [ ] Implement **User Authentication** (registration, login, Argon2 hashing)  
- [ ] Implement **Subject/Topic/Exam CRUD**  
- [ ] Build **Session Scheduler & Timer**  
- [ ] Add **Reminder System** (notifications + rescheduling)  
- [ ] Develop **Progress Tracker** (hours studied, graphs)  
- [ ] Create **Reward & Leaderboard System**  
- [ ] Add **Customisation & Preferences** (themes, morning/evening study prefs)  
- [ ] Secure system with **input validation + error handling**  
- [ ] Add **database backup & recovery support**  

### Database
- [ ] Finalise **Schema Diagram** (`User`, `Subject`, `Topic`, `Events`, `Sessions`, etc.)  
- [ ] Create **Entity Relationship Diagram**  
- [ ] Implement **Database Tables** in PostgreSQL  
- [ ] Test with **sample data**  

### Testing
- [ ] Perform **Black Box Testing** (1000+ randomised inputs)  
- [ ] Perform **White Box Testing** (trace tables, error handling)  
- [ ] Write **test documentation & results**  

---

## 🛠️ Tech Stack

- **Language:** C# (WinForms)  
- **Database:** PostgreSQL  
- **Encryption:** Argon2 for password hashing  
- **IDE:** Visual Studio  

---

## 👥 Clients & Users

- 🎯 **Primary Users:** Students preparing for GCSEs & A-Levels  
- 👨‍👩‍👧 **Secondary Users:** Parents, teachers, friends (optional features)  

---

## 📅 Timeline

The project is planned for completion by **Easter** (as per NEA constraints).  

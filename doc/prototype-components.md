# Project Outline

## Basics: 

### Components

Test user: Goblin 
- will have lots of really great ideas and input them directly into a form that sends a request to the chatbot to parse and determine how to deliver to the backend.

Chatbot (API remote endpoint): 
- takes whatever bullshit the user says and breaks down thoughts into categories, then delivers well-formed data to the correct database table. 
- provides feedback to the user and fosters productive conversation. (currently completing the full data cycle, this will be handled by multiple chatbots later)

Backend: .NET Core 8 using C#
- dynamic state machine 
- event system
  - track time spent on tasks in schedule db table, write properties such as time since last 'x' activity
  - queue/dequeue tasks
  - facilitate data travel among components
  - handle logging, timers, alarms, etc
- invoking scripts data processing begins here once a sanitized input arrives from the chatbot
- If identified as a "note", it goes to the "user notes" database
- If identified as a "task", it goes to the "agenda" database

Database: SQL (any sql provider dont care)
- User Info 
  - user notes table: just id and note text right now.
  - user skills table: planned feature
- Agenda
  - tasks table: id, description, priority
  - schedule table: id, task_id, time, etc

API scripting: Python
- I don't actually know how to use this at all but I am pretty sure you just import everything and push tab until the program is finished.

Wildcard: Android companion app
- Currently I just want it installed on my mom's tablet
- lets her view my schedule
- exactly one interactive feature which is a button that will let mom send VOIP to my computer, scaring the shit out of me while i am working.

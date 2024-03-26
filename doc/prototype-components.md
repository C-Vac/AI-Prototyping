# Project Outline

## Basics: 

### Components Overview

The user: Goblin will have ideas and input them directly into a form that sends a request to the model's interface to parse and determine how to send to the backend.

LLM 

Backend: .NET Core 8 for app state controller and event system, data routing begins here once a sanitized input arrives from the initial model
- If identified as a "note", it goes to the "user notes" database
- If identified as a "task", it goes to the "agenda" database

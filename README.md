# Game-Project

> **Still in early stages of development. Not yet a working game.**
>
> The features and tech stack should be seen as plans for features to come and technologies to be utilized.

Immerse yourself in a medieval fantasy world where your choices shape your destiny. Engage in epic quests, interact with intriguing characters, and explore unknown lands — all through descriptive text that ignites your imagination. Dictate your hero's journey through adventures, battles and professions. Whether you rise as a noble knight, a cunning rogue, or a wise mage, the adventure is yours to experience.

## Features

### Account Features

* Secure registration and log-in with ASP.NET Core Identity.
* Private messaging between users.
* Communicate through a forum for discussions and support.

### Game Features

* Build a custom character.
* Challenge other players' characters and monsters to gain experience in order to level up.
* Collect gold from battles or working various jobs.
* Visit the city's trade disctrict to buy equipment.
* Loot or gather material and exotic items to trade or craft equipment with.

## Tech Stack

### Backend

* **ASP.NET Core**: The framework on which the application is built upon.
* **C#**: The programming language used for backend development.
* **Minimal API**: A lightweight REST API in ASP.NET Core.
* **SQL**: Utilizing Entity Framework for relational data.
* **MongoDB**: Utilizing MongoDB Driver for non-relational data.
* **ASP.NET Core Identity**: Authentication and authorization.

### Frontend - Not yet implemented

* **Blazor**: For an interactive web UI with C#.
* **HTML & CSS**: For structure and specifik styling of the web UI.
* **Bootstrap**: For responsive design and user friendly components.

## Future improvements (TODO)

> As of now, in the very beginning of this project, this is more of a to do-list rather than improvements I plan to implement in the future.

1. Design and decide on database management systems. Current plan is SQL for more permanent data such as monsters and equipment and MongoDB for more dynamic data such as a characters inventory.
2. Setup an API for all CRUD operations.
3. Implement a simple game engine that returns the winner (and maybe handles rewards such as experience points or gold).

# Wrestling Match Creator

A C# console application for designing and configuring professional wrestling match cards. The program is not a match simulator — it is a match setup and card-building tool where users can create wrestlers, assemble them into different types of matches, and build a complete event card.

- **Course:** CSC 260 — Object-Oriented Programming
- **Instructor:** Prof. Jenkins
- **Semester:** Spring 2026

## Project Overview

The user can:

- Create wrestlers with customizable attributes
- Build different types of matches (Normal 1v1, Tag Team 2v2, Triple Threat 3-way)
- Assign wrestlers (or teams of wrestlers) to those matches
- View the finalized match card for the event

The project demonstrates the four core OOP pillars: inheritance, encapsulation, polymorphism, and abstraction.

## Class Design

The project uses 9 classes that demonstrate both inheritance ("is-a") and composition ("has-a") relationships.

| Class | Type | Description |
| --- | --- | --- |
| Person | Base class | Shared attributes for any person: Name, Age, Height |
| Wrestler | Inherits Person | Adds FinishingMove, WeightClass, ExperienceLevel |
| Roster | Composition | Holds the full pool of Wrestler objects; enforces no duplicates |
| Team | Composition | Holds exactly two Wrestler objects plus a TeamName |
| Match | Abstract base class | Defines abstract methods (Validate(), GetSummary()) |
| NormalMatch | Inherits Match | Standard 1v1 match with exactly two wrestlers |
| TagTeamMatch | Inherits Match | 2v2 match using two Team objects |
| TripleThreatMatch | Inherits Match | 3-way match with exactly three wrestlers |
| MatchCard | Composition | Holds an ordered list of Match objects for the full event |

## OOP Pillars Demonstrated

- **Inheritance:** Person → Wrestler; Match → NormalMatch, TagTeamMatch, TripleThreatMatch
- **Encapsulation:** All fields are private and exposed through properties
- **Polymorphism:** Each match subclass overrides GetSummary() with its own formatting
- **Abstraction:** Match is abstract and forces subclasses to implement Validate() and GetSummary()

## Development Plan

### Core Class Library (Linux / VS Code)

Build and test all OOP classes as a console-based C# project.

- [x] Create Person base class
- [x] Create Wrestler class (inherits Person)
- [x] Create Roster class
- [x] Create Team class
- [x] Create abstract Match class
- [x] Create NormalMatch subclass
- [x] Create TagTeamMatch subclass
- [x] Create TripleThreatMatch subclass
- [x] Create MatchCard class
- [x] Build simple console test harness in Program.cs to verify all classes work

## Tech Stack

- **Language:** C#
- **Framework:** .NET 8 (console application)
- **IDE:** VS Code (Linux)
- **Version Control:** Git (self-hosted)

## Version Control

This project is tracked with Git. The primary repository is hosted on a self-hosted Gitea server, and the project is also mirrored to GitHub at https://github.com/EricKoens1/WrestlingMatchCreator for instructor access. Commits are made regularly as each class and feature is completed, with meaningful messages describing each change. A minimum of 5 meaningful commits will be made over the course of development (the project rubric requirement).

## Rubric Requirements Checklist

- [x] At least 4 classes in the design (this project has 9)
- [x] Demonstrates inheritance
- [x] Demonstrates encapsulation
- [x] Demonstrates polymorphism
- [x] Demonstrates abstraction
- [x] Uses version control with meaningful commits
- [x] Project statement, plan, requirements, UI mockup, and class design documented (covered in proposal)

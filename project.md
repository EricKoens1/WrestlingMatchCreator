# Wrestling Match Creator

A C# Windows Forms application for designing and configuring professional wrestling match cards. The program is not a match simulator — it is a match setup and card-building tool where users can create wrestlers, assemble them into different types of matches, and build a complete event card.

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
| Match | Abstract base class | Defines shared properties and abstract methods (Validate(), GetSummary()) |
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

### Phase 1 — Core Class Library (Linux / VS Code)

Build and test all OOP classes as a console-based C# project. This phase is fully cross-platform and can be developed on Linux.

- [ ] Create Person base class
- [ ] Create Wrestler class (inherits Person)
- [ ] Create Roster class
- [ ] Create Team class
- [ ] Create abstract Match class
- [ ] Create NormalMatch subclass
- [ ] Create TagTeamMatch subclass
- [ ] Create TripleThreatMatch subclass
- [ ] Create MatchCard class
- [ ] Build simple console test harness in Program.cs to verify all classes work

### Phase 2 — Windows Forms UI (Windows / Visual Studio)

Add the graphical user interface on top of the tested class library.

- [ ] Create Windows Forms project in Visual Studio
- [ ] Import existing class files
- [ ] Build Roster form (add/view wrestlers)
- [ ] Build Create Match form (select match type and assign wrestlers)
- [ ] Build Match Card form (view complete event lineup)
- [ ] Wire up all UI events to existing class methods
- [ ] Final testing and polish

## Tech Stack

- **Language:** C#
- **Framework:** .NET (console for Phase 1, Windows Forms for Phase 2)
- **IDEs:** VS Code (Linux, Phase 1), Visual Studio (Windows, Phase 2)
- **Version Control:** Git (self-hosted)

## Version Control

This project is tracked with Git on a self-hosted Git server. Commits are made regularly as each class and feature is completed, with meaningful messages describing each change. A minimum of 5 meaningful commits will be made over the course of development (the project rubric requirement).

## Rubric Requirements Checklist

- [ ] At least 4 classes in the design (this project has 9)
- [ ] Demonstrates inheritance
- [ ] Demonstrates encapsulation
- [ ] Demonstrates polymorphism
- [ ] Demonstrates abstraction
- [ ] Uses version control with meaningful commits
- [ ] Project statement, plan, requirements, UI mockup, and class design documented (covered in proposal)

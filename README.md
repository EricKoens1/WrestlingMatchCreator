# WrestlingMatchCreator

CSC 260 class project — Eric Koens, DSU.

A C# console application for designing and configuring professional wrestling match cards. The user creates wrestlers, assembles them into different match types, and builds a complete event card. The project demonstrates the four core OOP pillars: inheritance, encapsulation, polymorphism, and abstraction.

## Features

- Create wrestlers with name, age, height, finishing move, weight class, and experience level
- Build three match types:
  - **NormalMatch** — 1v1
  - **TagTeamMatch** — 2v2 using `Team` objects
  - **TripleThreatMatch** — three-way singles match
- Assemble matches into a `MatchCard` for the full event
- Validation prevents duplicate wrestlers in the same match or across team rosters

## Class Design

Nine classes total:

- `Person` (base) → `Wrestler`
- `Roster` — pool of wrestlers, no duplicates
- `Team` — exactly two wrestlers plus a team name
- `Match` (abstract) → `NormalMatch`, `TagTeamMatch`, `TripleThreatMatch`
- `MatchCard` — ordered list of matches

See `project.md` for the full table and OOP pillar mapping.

## Build and Run

Requires .NET 8 SDK.

```bash
cd src/WrestlingConsole
dotnet build
dotnet run
```

The program runs a console test harness that builds five matches (including three intentionally-invalid ones to demonstrate validation), then prints the full match card.

## Project Layout

```
WrestlingMatchCreator/
├── src/
│   ├── WrestlingClassLib/     # All 9 classes
│   └── WrestlingConsole/      # Program.cs entry point
├── docs/                      # Submission documents
│   ├── EricKoensProject_Writeup.docx
│   └── EricKoensProject_TestCases.docx
├── project.md                 # Design overview and rubric checklist
└── README.md
```

## Documentation

- **Writeup:** `docs/EricKoensProject_Writeup.docx` — rubric-aligned project writeup
- **Test cases:** `docs/EricKoensProject_TestCases.docx` — 26 manual test cases across 8 sections
- **Design overview:** `project.md`

## Tech Stack

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** VS Code (Linux)
- **Version Control:** Git — primary on self-hosted Gitea, mirrored to https://github.com/EricKoens1/WrestlingMatchCreator

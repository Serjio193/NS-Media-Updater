# Architecture

## Core rule

The application owns its implementation. Existing public projects can be studied as technical references, but their source code is not copied unless the applicable license explicitly permits that use.

## High-level flow

```
Local folders ───────┐
                     │
Nintendo Switch ─DBI─┼──> NS Media Updater Core ───> UI
                     │
Remote catalog ──────┘
```

## Projects

### NSMediaUpdater.Core

Pure domain models, interfaces and comparison logic. It must not depend on UI frameworks, DBI, filesystem APIs or a specific database.

Important domain concepts:

- `Game`
- `GamePackage`
- `ConsoleTitle`
- `PackageType`
- `UpdateCandidate`

### NSMediaUpdater.Infrastructure

Persistence, filesystem, caching, configuration and logging.

### NSMediaUpdater.Providers.Dbi

Windows/DBI integration. The first milestone is read-only:

1. detect the DBI MTP device;
2. enumerate DBI virtual storage;
3. locate Installed games;
4. parse the console inventory;
5. return normalized `ConsoleTitle` records.

Writing/transferring to DBI comes only after inventory parsing is stable.

### NSMediaUpdater.App

Windows desktop UI. This project is intentionally not pinned to a guessed Windows App SDK package version in the initial scaffold. We add it after the first UI/SDK spike.

## Package model

Base, Update, DLC, Translation and Mod are tracked separately. The application must never collapse them into one ambiguous version number.

## Update comparison

```
PC package state
      │
      ├────┐
      │    ▼
      │  Comparison Engine ──> update/missing/current status
      │    ▲
      ├────┘
Switch inventory
      │
      └──────── Remote catalog state
```

## Data safety

Any future update workflow should follow:

1. download to staging;
2. validate expected metadata/hash when available;
3. record the package;
4. transfer/copy;
5. verify completion;
6. refresh inventory.

Do not overwrite a known-good file before the replacement is validated.

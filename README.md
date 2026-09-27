# NS Media Updater

Windows desktop manager for a Nintendo Switch game library with DBI MTP integration.

> Project status: early development / architecture phase.

## What we are building

NS Media Updater is intended to keep three views of the library in sync:

```
PC Library  ↔  Nintendo Switch / DBI MTP  ↔  Remote Catalog
```

Planned capabilities:

- scan one or more local folders and build a searchable game library;
- track Base Game / Update / DLC / translation / mod packages separately;
- show covers, descriptions and metadata;
- detect a Nintendo Switch connected through DBI MTP;
- read the installed-game inventory exposed by DBI;
- compare installed versions with local and remote versions;
- show missing updates, DLC and translations;
- maintain a download/update queue;
- stage and validate files before transfer;
- keep metadata, catalog and transport integrations behind replaceable providers.

## Architecture

```
src/
├─ NSMediaUpdater.Core/
│  ├─ Models/
│  ├─ Abstractions/
│  └─ Services/
├─ NSMediaUpdater.Infrastructure/
├─ NSMediaUpdater.Providers.Dbi/
└─ NSMediaUpdater.App/            (Windows UI; added after the first SDK spike)

docs/
├─ ARCHITECTURE.md
├─ ROADMAP.md
└─ REFERENCE_PROJECTS.md
```

The core application is our own implementation. Existing public projects may be studied to understand approaches and protocols, but source code is not copied unless its licensing explicitly allows that use.

## Initial milestone

1. Local library scanner.
2. SQLite-backed catalog.
3. Package classification.
4. DBI MTP device detection.
5. Read-only installed-game inventory.
6. PC ↔ Switch version comparison.
7. Basic Windows UI.

## Development

Current baseline:

- C# / .NET
- Windows desktop
- DBI MTP integration through a dedicated provider
- provider-based architecture for external services

See [Architecture](docs/ARCHITECTURE.md) and [Roadmap](docs/ROADMAP.md).

## License

No software license is granted by this repository. All rights are reserved unless explicitly stated otherwise.

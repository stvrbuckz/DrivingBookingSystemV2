The domain layer contains the core business logic and domain entities of the application. 

It is the heart of the system and should be independent of any external frameworks or libraries.

Characteristics:
- No references to outer layers (no database, no UI or HTTP).
- No external libraries unless they are  for utilities.
- Focused soley on business logic.

It contains the business rules and logic that govern the behavior of the system. 

The domain layer is responsible for defining:
- entities
- value objects
- aggregates
- domain services 


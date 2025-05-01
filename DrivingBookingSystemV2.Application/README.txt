The application folder contains Application Logic.

This layer orchestrates use cases. It sits betwen the Domain and the outer layers like Infrastructure or Web.

Characteristics:
- It depends on the Domain layer.
- Should not contain domain logic - only orcherstrates it.
- Free from framework-specific code.

What it includes:
- Use cases
- DTOs (Data Transfer Objects)
- Application services
- Validators
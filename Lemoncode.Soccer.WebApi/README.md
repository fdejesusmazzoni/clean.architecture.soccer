## Migrations commands

# Create a new migration:

dotnet ef migrations add <Migration name> --project ../Lemoncode.Soccer.Infra.Repository.EfCore --startup-project . --context SoccerContext

# Remove migration (not database applied)

dotnet ef migrations remove --project ../Lemoncode.Soccer.Infra.Repository.EfCore --startup-project . --context SoccerContext

# Remove migration and changes in bd

# Update database

dotnet ef database update --project ../Lemoncode.Soccer.Infra.Repository.EfCore --startup-project . --context SoccerContext

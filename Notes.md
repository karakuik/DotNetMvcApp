# Learning/Notes

## Database
- **Commands**: 
  - dotnet ef migrations add InitialCreate --context MvcCelebrityContext 
  - dotnet ef database update --context MvcMovieContext
- **Drop DB**:
  - Delete the .db files and the migrations folder ~/migrations/
- **What is a context?**
    - In the context of Entity Framework Core, a "context" refers to a subclass of DbContext which represents a session with the underlying database. It is responsible for coordinating Entity Framework functionality for a particular data model. 
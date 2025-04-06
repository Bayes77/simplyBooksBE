using simplyBooksBE.Models;
using simplyBooksBE.Interfaces;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc;

namespace simplyBooksBE.Endpoints
{
    public static class AuthorsEndpoints
    {
        public static void MapAuthorsEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/authors").WithTags(nameof(Authors));

            group.MapGet("/", async (IAuthorsServices authorsServices) =>
            {
                return await authorsServices.GetAllAuthorsAsync();
            })
                .WithName("GetAllAuthors")
                .WithOpenApi()
                .Produces<List<Authors>>(StatusCodes.Status200OK);

            group.MapGet("/{id}", async (IAuthorsServices authorsServices, int id) =>
            {
                var author = await authorsServices.GetAuthorByIdAsync(id);
                return Results.Ok(author);
            })
                .WithName("GetAuthorById")
                .WithOpenApi()
                .Produces<Authors>(StatusCodes.Status200OK);

            group.MapPost("/", async (IAuthorsServices authorsServices, Authors author) =>
            {
                var authorExsists = await authorsServices.CreateAuthorAsync(author);
                return Results.Created($"/api/authors/{authorExsists.ID}", authorExsists);
            })
                .WithName("CreateAuthor")
                .WithOpenApi()
                .Produces<Authors>(StatusCodes.Status201Created);

            group.MapPut("/{id}", async (IAuthorsServices authorsServices, int id, [FromBody] Authors author) =>
            {
                var updatedAuthor = await authorsServices.UpdateAuthorAsync(id, author);
                return Results.Ok(updatedAuthor);
            })
                .WithName("UpdateAuthor")
                   .WithOpenApi()
                .Produces<Authors>(StatusCodes.Status200OK);

            group.MapDelete("/{id}", async (IAuthorsServices authorsServices, int id) =>
            {
                var author = await authorsServices.DeleteAuthorAsync(id);
                return Results.NoContent();
            })
                .WithName("DeleteAuthor")
                .WithOpenApi()
                .Produces<Authors>(StatusCodes.Status200OK);
        }
    }
}

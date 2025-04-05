using simplyBooksBE.Models;
using simplyBooksBE.Interfaces;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

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
                .Produces<List<Authors>>(StatusCodes.Status200OK);

            group.MapGet("/{id}", async (IAuthorsServices authorsServices, int id) =>
            {
                return await authorsServices.GetAuthorByIdAsync(id);
            })
                .WithName("GetAuthorById")
                .Produces<Authors>(StatusCodes.Status200OK);

            group.MapPost("/", async (IAuthorsServices authorsServices, Authors author) =>
            {
                return await authorsServices.CreateAuthorAsync(author);
            })
                .WithName("CreateAuthor")
                .Produces<Authors>(StatusCodes.Status201Created);

            group.MapPut("/{id}", async (IAuthorsServices authorsServices, int id, Authors author) =>
             {
                 return await authorsServices.UpdateAuthorAsync(author);
             })
                 .WithName("UpdateAuthor")
                 .Produces<Authors>(StatusCodes.Status200OK);
            group.MapDelete("/{id}", async (IAuthorsServices authorsServices, int id) =>
            {
                return await authorsServices.DeleteAuthorAsync(id);
            })
                .WithName("DeleteAuthor")
                .Produces<Authors>(StatusCodes.Status200OK);


        }
    }
}

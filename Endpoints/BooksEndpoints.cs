

using simplyBooksBE.Interfaces;
using simplyBooksBE.Models;

namespace simplyBooksBE.Endpoints
{
    public static class BooksEndpoints
    {
        public static void MapBooksEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/books").WithTags(nameof(Books));

            group.MapGet("/", async (IBooksServices booksServices) =>
            {
                return await booksServices.GetAllBooksAsync();
            })
                .WithName("GetAllBooks")
                .WithOpenApi()
                .Produces<List<Books>>(StatusCodes.Status200OK);

            group.MapGet("/{id}", async (IBooksServices booksServices, int id) =>
            {
                return await booksServices.GetBookByIdAsync(id);
            })
                .WithName("GetBookById")
                .WithOpenApi()
                .Produces<Books>(StatusCodes.Status200OK);

            group.MapPost("/", async (IBooksServices booksServices, Books book) =>
            {
                return await booksServices.CreateBookAsync(book);
            })
                .WithName("CreateBook")
                .WithOpenApi()
                .Produces<Books>(StatusCodes.Status201Created);

            group.MapPut("/{id}", async (IBooksServices booksServices, int id, Books book) =>
             {
                 var existingBook = await booksServices.UpdateBookAsync(id,book);
                 return Results.Ok(book);
             })
                 .WithName("UpdateBook")
                    .WithOpenApi()
                 .Produces<Books>(StatusCodes.Status200OK);

            group.MapDelete("/{id}", async (IBooksServices booksServices, int id) =>
            {
                return await booksServices.DeleteBookAsync(id);
            })
                .WithName("DeleteBook")
                .WithOpenApi()
                .Produces<Books>(StatusCodes.Status200OK);
        }    }
}

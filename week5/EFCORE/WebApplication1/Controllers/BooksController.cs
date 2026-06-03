using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("/api/books")]
    [ApiController]
    public class BooksController(AppDBContext appDBContext) : ControllerBase
    {
        // insert new record
        [HttpPost("add")]
        public async Task<IActionResult> AddNewBook([FromBody] Book model)
        {
            appDBContext.Books.Add(model);
            await appDBContext.SaveChangesAsync();
            return Ok(model);
        }

        // practice get
        [HttpGet("all")]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = appDBContext.Books
                            .ToList();

            return Ok(result);
        }

        // insert bulk new record
        [HttpPost("bulk")]
        public async Task<IActionResult> AddBooks([FromBody] List<Book> model)
        {
            appDBContext.Books.AddRange(model);
            await appDBContext.SaveChangesAsync();

            return Ok(model);
        }

        // insert related data
        [HttpPost("related")]
        public async Task<IActionResult> AddRelatedData([FromBody] Book model)
        {
            //var author = new Author()
            //{
            //    Name = "Aut1",
            //    Email = "test@gmail.com"
            //};

            //model.Author = author;

            // or we can send it directly using the api call
            // also author can be empty as its nullable


            appDBContext.Books.Add(model);
            await appDBContext.SaveChangesAsync();
            return Ok(model);
        }

        // update records
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateBook([FromRoute] int id, [FromBody] Book model)
        {
            var book = appDBContext.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            book.Title = model.Title;
            book.Description = model.Description;
            book.NoOfPages = model.NoOfPages;

            await appDBContext.SaveChangesAsync();

            return Ok(model);
        }

        // update books with single query
        // in below method we need to send all data in model if we not send any field then its value will be set to null
        [HttpPut("updatesinglereq")]
        public async Task<IActionResult> UpdateBooWithSingleQueryk([FromBody] Book model)
        {
            appDBContext.Books.Update(model);
            // the above method will change the state automatically
            // to achieve state change manually
            // appDBContext.Entry(model) = Microsoft.EntityFrameworkCore.EntityState.Modified;

            await appDBContext.SaveChangesAsync();

            return Ok(model);
        }

        // bulk update
        [HttpPut("updatebulk")]
        public async Task<IActionResult> UpdateBulk()
        {
            await appDBContext.Books
            .Where(x => x.NoOfPages == 100)
            .ExecuteUpdateAsync(x => x
            .SetProperty(p => p.Description, p => p.Title + "this is desc")
            .SetProperty(p => p.Title, p => p.Title + "updated")
            //.SetProperty(p=>p.NoOfPages, 100)
            );

            return Ok();
        }

        // delete record
        [HttpDelete("delete/{bookId}")]
        public async Task<IActionResult> DeleteBookByIdAsync([FromRoute] int bookId)
        {
            //var book = await appDBContext.Books.FindAsync(bookId);

            //if(book == null)
            //{
            //    return NotFound();
            //}

            //appDBContext.Books.Remove(book);

            //await appDBContext.SaveChangesAsync();

            // or
            var book = new Book { Id = bookId };
            appDBContext.Entry(book).State = EntityState.Deleted;

            await appDBContext.SaveChangesAsync();

            return Ok();
        }

        // delete bulk
        [HttpDelete("deletebulk")]
        public async Task<IActionResult> DeleteBookBulkAsync()
        {
            //var books = await appDBContext.Books.Where(x => x.Id < 5).ToListAsync();
            //appDBContext.Books.RemoveRange(books);
            //await appDBContext.SaveChangesAsync();

            // or

            int deletedRowsCount = await appDBContext.Books
            .Where(x => x.Id < 9)
            .ExecuteDeleteAsync();

            Console.WriteLine($"Successfully deleted {deletedRowsCount} books.");

            return Ok(new {
                Message = "Bulk deletion completed.",
                DeletedCount = deletedRowsCount
            });
        }

        // AsNoTracking - it will not change the entity state so query performance will be high and is used to improve performance
        [HttpGet("notrack")]
        public async Task<IActionResult> GetAllBooksAsNoTracking()
        {
            var result = await appDBContext.Books.AsNoTracking()
                            .ToListAsync();

            return Ok(result);
        }


        // getting related data from the db
        // Navigational preperties
        [HttpGet("getrelateddata")]
        public async Task<IActionResult> GetAllBooksrelated()
        {
            var result = await appDBContext.Books
                            .Select(x => new
                            {
                                Id = x.Id,
                                Title = x.Title,
                                Author = x.Author != null ? x.Author.Name : "NA",
                                Language = x.Language
                            })
                            .ToListAsync();

            return Ok(result);
        }

        // Eager leading - we need to create foreign keys 
        // include
        [HttpGet("eagerloading")]
        public async Task<IActionResult> GetAllBooksEager()
        {
            var result = await appDBContext
                            .Books
                            .Include(x => x.Author)
                            // the below will throw the depth error as language model consists Books as collection and that book points to language so it creates a cycle
                            // to resolve that we need to comment the books collection in the language class.
                            .Include(x => x.Language)
                            .FirstAsync();

            return Ok(result);
        }

        // get books acc to language
        // to use this we need to comment language foreign key in the book model to break the cyclic dependency
        [HttpGet("langbooks")]
        public async Task<IActionResult> GetLanguageBooks()
        {
            var result = await appDBContext
                            .Languages
                            //.Include(x => x.Books)
                            .ToListAsync();

            return Ok(result);
        }
        

        // Explicit loading
        // Load, Reference ( 1-1 mapping ), Collection
        [HttpGet("explicit")]
        public async Task<IActionResult> GetAllBooksExplicit()
        {
            var book = await appDBContext.Books.FirstAsync();

            // await appDBContext.Entry(book).Reference(x => x.Language).LoadAsync(); // to use this comment the list of books in language model
            await appDBContext.Entry(book).Reference(x => x.Author).LoadAsync();

            return Ok(book);

            // using collection
            // we need to comment the language foreign key in the books model
            //var languages = await appDBContext.Languages.ToListAsync();

            //foreach(var language in languages)
            //{
            //    await appDBContext.Entry(language).Collection(x => x.Books)
            //        .Query()
            //        .Where(x=>x.NoOfPages > 100)
            //        .LoadAsync();
            //}

            //return Ok(languages);
        }

        // lazy loading
        // to enable it we need to use the package: Microsoft.EntityFrameworkCore.Proxies
        // we can enable this method in onConfiguring method in DBContext class or in program.cs
        // we need to make virtual navigations (ie the foreign keys will set to virtual)
        [HttpGet("lazy")]
        public async Task<IActionResult> GetAllBooksLazy()
        {
            var book = await appDBContext.Books.FirstAsync();

            var author = book.Author;

            return Ok(book);
        }

        // using sql queries
        [HttpGet("sql")]
        public async Task<IActionResult> GetAllBooksSql()
        {
            // need to comment the language foreign key in the book model
            var books = await appDBContext.Books.FromSql($"select * from Books").ToListAsync();

            return Ok(books);
        }

        // stored proc
        [HttpGet("sp")] 
        public async Task<IActionResult> Proc()
        {
            // comment the language foreign key in books
            //var books = await appDBContext.Books.FromSql($"EXEC SP_GetAllBooks").ToListAsync();

            var parameter = new SqlParameter("@BookId", 1);

            var books = await appDBContext.Books.FromSql($"EXEC SP_GetBookById {parameter}").ToListAsync();

            return Ok(books);
        }

        // sqlquery
        [HttpGet("sqlq")]
        public async Task<IActionResult> GetBooksSql()
        {
            //var books = await appDBContext.Database.SqlQuery<Book>($"Select * from Books").ToListAsync();
            var books = await appDBContext.Database.SqlQuery<int>($"Select Id from Books").ToListAsync();

            return Ok(books);
        }
    }
}
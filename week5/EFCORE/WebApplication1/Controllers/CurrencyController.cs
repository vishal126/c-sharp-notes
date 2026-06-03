using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDBContext _appDbContext;
        public CurrencyController(AppDBContext dbContext)
        {
            this._appDbContext = dbContext;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            //var result = this._appDbContext.Currencies.ToList();
            //var result = (from currencies in _appDbContext.Currencies
            //             select currencies).ToList();

            var result = await this._appDbContext.Currencies.ToListAsync();
            //var result = await (from currencies in _appDbContext.Currencies
            //             select currencies).ToListAsync();

            return Ok(result);
        }

        
        //getting using primary key
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCurrencyByIdAsync([FromRoute] int id)
        {
            var result = await this._appDbContext.Currencies.FindAsync(id);

            return Ok(result);
        }

        //getting using another key/column
        [HttpGet("{name}")]
        public async Task<IActionResult> GetCurrencyByNameAsync([FromRoute] string name)
        {
            //var result = await this._appDbContext.Currencies.Where(x => x.Title == name).FirstAsync(); // throws exception if no data is available
            var result = await this._appDbContext.Currencies.Where(x => x.Title == name).FirstOrDefaultAsync(); // not throw exception

            //var result = await this._appDbContext.Currencies.Where(x => x.Title == name).SingleAsync(); // throws exception if no data is available
            //var result = await this._appDbContext.Currencies.Where(x => x.Title == name).FirstOrDefaultAsync(); // not throw exception

            // if duplicate data exists ie duplicate name then single returns exception
            // single method scan full table as it has to check for duplicate as well
            // while first method returns the first element only.

            return Ok(result);
        }

        //getting data using multiple params
        [HttpGet("{name}/{description}")]
        public async Task<IActionResult> GetCurrencyByMultipleParamsAsync([FromRoute] string name, [FromRoute] string description)
        {
            var result = await this._appDbContext.Currencies.FirstOrDefaultAsync(x => x.Title == name && x.Description == description);

            return Ok(result);
        }


        // this will not send any data if description is not passed but not throws any error
        // called using /{name}?description={value}
        //[HttpGet("{name}")]
        //public async Task<IActionResult> GetCurrencyByMultipleParamsAsync([FromRoute] string name, [FromQuery] string? description)
        //{
        //    var result = await this._appDbContext.Currencies.FirstOrDefaultAsync(x => x.Title == name && x.Description == description);

        //    return Ok(result);
        //}

        // or if description is passed then check the desc else check title only

        //[HttpGet("{name}")]
        //public async Task<IActionResult> GetCurrencyByMultipleParamsAsync([FromRoute] string name, [FromQuery] string? description)
        //{
        //    var result = await this._appDbContext.Currencies.
        //                          FirstOrDefaultAsync( x =>
        //                          x.Title == name
        //                          && (string.IsNullOrEmpty(description) || x.Description == description));

        //    return Ok(result);
        //}


        // getting duplicate records
        [HttpGet("duplicate/{name}")]
        public async Task<IActionResult> GetDuplicateRecordAsync([FromRoute] string name, [FromQuery] string? description)
        {
            var result = await this._appDbContext.Currencies
                                  .Where(x =>
                                  x.Title == name
                                  && (string.IsNullOrEmpty(description) || x.Description == description)).ToListAsync();

            return Ok(result);
        }

        // getting records for multiple ids
        [HttpPost("all")]
        public async Task<IActionResult> GetDuplicateRecordAsync([FromBody] List<int> ids)
        {
            var result = await _appDbContext.Currencies
                         .Where(x => ids.Contains(x.Id))
                         .ToListAsync();
            return Ok(result);
        }

        // select specific column
        [HttpPost("allCol")]
        public async Task<IActionResult> GetSpecificColumn([FromBody] List<int> ids)
        {
            //var result = await _appDbContext.Currencies
            //             .Where(x => ids.Contains(x.Id))
            //             .Select(x => new Currency
            //             {
            //                 Id = x.Id,
            //                 Title = x.Title
            //             })
            //             .ToListAsync();

            //var result = await _appDbContext.Currencies
            //             .Where(x => ids.Contains(x.Id))
            //             .Select(x => new
            //             {
            //                 currId = x.Id,
            //                 currTitle = x.Title
            //             })
            //             .ToListAsync();

            //practice self
            var result = await _appDbContext.Currencies
                         .Where(x => ids.Contains(x.Id))
                         .Select(x => new CurrencyDt
                         {
                             CurrencyId = x.Id,
                             CurrencyName = x.Title
                         })
                         .ToListAsync();

            return Ok(result);
        }
    }
}

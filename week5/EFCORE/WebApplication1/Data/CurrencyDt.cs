using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Runtime.InteropServices.Marshalling;

namespace WebApplication1.Data
{
    public class CurrencyDt
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
    }
}
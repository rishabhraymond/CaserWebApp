using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caser.Business.Interfaces
{
    public interface IValidation
    {
        public string GetExtension(string filename);
        public bool IsValidExcel(IFormFile file);
    }
}

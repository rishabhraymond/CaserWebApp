using Caser.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caser.Business
{
    public class CaseChanger : ICaseChanger
    {
        public IFormFile CamelToSnake(IFormFile file)
        {
            var filename = file.FileName;
            var validation = new Validation();
            var extension = validation.GetExtension(filename); 
            return null;

        }
    }
}

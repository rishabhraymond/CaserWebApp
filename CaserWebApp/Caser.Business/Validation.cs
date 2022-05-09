using Caser.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caser.Business
{
    public class Validation : IValidation
    {

        public string GetExtension(string filename)
        {
            return filename.Split('.')[1] ?? "";
        }

        public bool IsValidExcel(IFormFile file)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using(var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                using (ExcelPackage excel = new ExcelPackage(ms))
                {
                    var worksheets = excel.Workbook.Worksheets;
                    foreach(var worksheet in worksheets)
                    {
                        if(worksheet.Tables.Count < 0)
                        {
                            return false;
                        } 
                        var tables = worksheet.Tables;
                        foreach(var table in tables)
                        {
                            if(table.Columns.Count < 0)
                            {
                                return false;
                            }
                            var columns = table.Columns;
                            foreach(var column in columns)
                            {
                                var type = column.Name.Split('-').Last();
                                if (type != "CC" || type != "SC")
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            
            return true;
        }
    }
}

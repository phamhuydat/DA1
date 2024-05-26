using App.Data.Entities.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
    public static class AddProdcutDetailSeender
    {
        public static void SeenData(this EntityTypeBuilder<AppProductDetail> builder)
        {
            var now = DateTime.Now;



        }
    }
}

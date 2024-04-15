using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class MstOrderStatusSeeder
	{
		public static void SeedData(this EntityTypeBuilder<MstOrderStatus> builder)
		{
			var now = DateTime.Now;
			builder.HasData(
				new MstOrderStatus
				{
					Id = DB.OrderStatusId.STATUS_PENDING,
					Name = DB.OrderStatusId.STATUS_PENDING_NAME,
					CreatedDate = now
				},
				new MstOrderStatus
				{
					Id = DB.OrderStatusId.STATUS_PROCESSING,
					Name = DB.OrderStatusId.STATUS_PROCESSING_NAME,
					CreatedDate = now
				},
				new MstOrderStatus
				{
					Id = DB.OrderStatusId.STATUS_DONE,
					Name = DB.OrderStatusId.STATUS_DONE_NAME,
					CreatedDate = now
				},
				new MstOrderStatus
				{
					Id = DB.OrderStatusId.STATUS_CANCELED,
					Name = DB.OrderStatusId.STATUS_CANCELED_NAME,
					CreatedDate = now
				});
		}
	}
}

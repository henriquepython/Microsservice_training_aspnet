using Dapper;
using Discount.Grpc.Data;
using Discount.Grpc.Entities;
using Discount.Grpc.Repositories;

namespace Discount.Grpc.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly DbContextDapper _dbContext;
        public DiscountRepository(DbContextDapper dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            using (var connection = _dbContext.Connection)
            {
                var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>("SELECT * FROM Coupon WHERE ProductName = @ProductName", new { ProductName = productName });

                if (coupon is null)
                {
                    return new Coupon()
                    {
                        ProductName = "No Discount",
                        Amount = 0,
                        Description = "No Discount Desc"
                    };
                }

                return coupon;
            }
        }

        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            using (var connection = _dbContext.Connection)
            {
                var affected = await connection.ExecuteAsync
                    ("INSERT INTO public.coupon(productname, description, amount) VALUES(@ProductName, @Description, @Amount)",
                    new
                    {
                        ProductName = coupon.ProductName,
                        Description = coupon.Description,
                        Amount = coupon.Amount,
                    });

                if (affected == 0) return false;

                return true;
            }
        }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
                var affected = await _dbContext.Connection.ExecuteAsync("UPDATE public.coupon SET productname = @ProductName, description = @Description, amount = @Amount WHERE id = @Id",
                    new
                    {
                        ProductName = coupon.ProductName,
                        Description = coupon.Description,
                        Amount = coupon.Amount,
                        Id = coupon.Id
                    });

                if (affected == 0) return false;

                return true;
        }

        public async Task<bool> DeleteDiscount(string productName)
        {
            using (var connection = _dbContext.Connection)
            {
                var affected = await connection.ExecuteAsync
                    ("DELETE FROM Coupon WHERE ProductName = @ProductName",
                    new
                    {
                        ProductName = productName
                    });

                if (affected == 0) return false;

                return true;
            }
        }
    }
}

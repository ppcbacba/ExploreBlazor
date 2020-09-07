using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinishedExampleProject.Data
{
    public class CouponService
    {
        public Task<int> CheckCoupon(string coupon)
        {
            try
            {
                var discountvalue = Program.CouponDictionary[coupon];
                return Task.FromResult(discountvalue);
            }
            catch
            {
                return Task.FromResult(0);
            }
        }
    }
}

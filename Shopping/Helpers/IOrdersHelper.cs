using Shopping.Common;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Helpers
{
    public interface IOrdersHelper
    {
        Task<Response> ProcessOrderAsync(ShowCartViewModel model);

        Task<Response> CancelOrderAsync(int id);

    }

}

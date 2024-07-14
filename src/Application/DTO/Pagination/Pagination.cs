using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWD_IMS.src.Application.DTO.Pagination
{
    public class PaginationReq
    {
        public int Page { get; set; }

        public int PageSize { get; set; }
    }

    public class PaginationResp
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Page<T>
    {
        public List<T> Data { get; set; }
        public int TotalCount { get; set; }

        public Page() { }
        public Page(List<T> data, int totalCount)
        {
            Data = data;
            TotalCount = totalCount;
        }

    }

}

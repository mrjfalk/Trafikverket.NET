using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikverket.Net
{
    public sealed class OrFilterOperator : BaseOperator
    {
        public OrFilterOperator()
            : base()
        {

        }

        public OrFilterOperator(IEnumerable<FiltersBase> childFilters)
            : base(childFilters)
        {

        }

        public OrFilterOperator(params FiltersBase[] childFilters)
            : base(childFilters)
        {

        }
    }
}

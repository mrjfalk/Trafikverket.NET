using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikverket.Net
{
    public sealed class AndFilterOperator : BaseOperator
    {
        public AndFilterOperator()
            : base()
        {

        }

        public AndFilterOperator(IEnumerable<FiltersBase> childFilters)
            : base(childFilters)
        {

        }

        public AndFilterOperator(params FiltersBase[] childFilters)
            : base(childFilters)
        {

        }
    }
}

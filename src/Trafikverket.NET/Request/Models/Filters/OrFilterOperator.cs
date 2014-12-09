using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikverket.NET
{
	/// <summary>
	/// Or filter operator, check if at least one of multiple filters are true.
	/// </summary>
    public sealed class OrFilterOperator : BaseOperator
    {
		/// <summary>
		/// Or filter operator, check if at least one of multiple filters are true.
		/// </summary>
        internal OrFilterOperator()
            : base()
        {

        }

		/// <summary>
		/// Or filter operator, check if at least one of multiple filters are true.
		/// </summary>
		/// <param name="childFilters">Filters to check</param>
        public OrFilterOperator(IEnumerable<FiltersBase> childFilters)
            : base(childFilters)
        {

        }

		/// <summary>
		/// Or filter operator, check if at least one of multiple filters are true.
		/// </summary>
		/// <param name="childFilters">Filters to check</param>
        public OrFilterOperator(params FiltersBase[] childFilters)
            : base(childFilters)
        {

        }
    }
}

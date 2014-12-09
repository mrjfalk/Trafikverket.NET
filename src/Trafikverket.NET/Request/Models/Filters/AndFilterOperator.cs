using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikverket.NET
{
	/// <summary>
	/// And filter operator, check if multiple filters all are true
	/// </summary>
    public sealed class AndFilterOperator : BaseOperator
    {
        internal AndFilterOperator()
            : base()
        {

        }

		/// <summary>
		/// And filter operator, check if multiple filters all are true
		/// </summary>
		/// <param name="childFilters">Filters to check</param>
        public AndFilterOperator(IEnumerable<FiltersBase> childFilters)
            : base(childFilters)
        {

        }

		/// <summary>
		/// And filter operator, check if multiple filters all are true
		/// </summary>
		/// <param name="childFilters">Filters to check</param>
        public AndFilterOperator(params FiltersBase[] childFilters)
            : base(childFilters)
        {

        }
    }
}

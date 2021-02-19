using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace univer.Libs.Attributes
{
    public class Column : Attribute
    {
        public string ColumnName { get; set; }

        public Column(string columnName)
        {
            ColumnName = columnName;
        }
    }
}

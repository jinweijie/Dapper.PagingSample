using System;

namespace Dapper.PagingSample.Entity
{
    public partial class Log
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public DateTime? Date { get; set; }
        public string Thread { get; set; }
        public string Location { get; set; }
        public string Message { get; set; }
        public DateTimeOffset? CreateTime { get; set; }

        public int TotalCount { get; set; }
    }
}

using System;

namespace Dapper.PagingSample.Entity
{
    [Serializable]
    public class LogSearchCriteria
    {
        public string Level { get; set; }
        public string Message { get; set; }
    }
}

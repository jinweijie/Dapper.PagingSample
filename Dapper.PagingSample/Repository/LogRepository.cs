using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper.PagingSample.Common;
using Dapper.PagingSample.Entity;

namespace Dapper.PagingSample.Repository
{
    public class LogRepository : RepositoryBase
    {
        /// <summary>
        /// LogRepository
        /// </summary>
        /// <param name="connectionString"></param>
        public LogRepository(string connectionString): base(connectionString)
        {
        }


        public Tuple<IEnumerable<Log>, int> Find(LogSearchCriteria criteria
            , int pageIndex
            , int pageSize
            , string[] asc
            , string[] desc)
        {
            using (IDbConnection connection = base.OpenConnection())
            {
                const string countQuery = @"SELECT COUNT(1)
                                            FROM      [Log] l
                                            INNER JOIN [Level] lv ON l.LevelId = lv.Id
                                            /**where**/";

                const string selectQuery = @"  SELECT  *
                            FROM    ( SELECT    ROW_NUMBER() OVER ( /**orderby**/ ) AS RowNum, l.*, lv.Name as [Level]
                                      FROM      [Log] l
                                      INNER JOIN [Level] lv ON l.LevelId = lv.Id
                                      /**where**/
                                    ) AS RowConstrainedResult
                            WHERE   RowNum >= (@PageIndex * @PageSize + 1 )
                                AND RowNum <= (@PageIndex + 1) * @PageSize
                            ORDER BY RowNum";

                SqlBuilder builder = new SqlBuilder();

                var count = builder.AddTemplate(countQuery);
                var selector = builder.AddTemplate(selectQuery, new { PageIndex = pageIndex, PageSize = pageSize });

                if (!string.IsNullOrEmpty(criteria.Level))
                    builder.Where("lv.Name= @Level", new { Level = criteria.Level });

                if (!string.IsNullOrEmpty(criteria.Message))
                {
                    var msg = "%" + criteria.Message + "%";
                    builder.Where("l.Message Like @Message", new { Message = msg });
                }

                foreach (var a in asc)
                {
                    if(!string.IsNullOrWhiteSpace(a))
                        builder.OrderBy(a);
                }

                foreach (var d in desc)
                {
                    if (!string.IsNullOrWhiteSpace(d))
                        builder.OrderBy(d + " desc");
                }

                var totalCount = connection.Query<int>(count.RawSql, count.Parameters).Single();
                var rows = connection.Query<Log>(selector.RawSql, selector.Parameters);

                return new Tuple<IEnumerable<Log>, int>(rows, totalCount);
            }
        }


        public Tuple<IEnumerable<Log>, int> FindWithOffsetFetch(LogSearchCriteria criteria
                                                , int pageIndex
                                                , int pageSize
                                                , string[] asc
                                                , string[] desc)
        {
            using (IDbConnection connection = base.OpenConnection())
            {
               
                const string selectQuery = @" ;WITH _data AS (
                                            SELECT l.*, lv.Name AS [Level]
                                            FROM      [Log] l
                                            INNER JOIN [Level] lv ON l.LevelId = lv.Id
                                            /**where**/
                                        ),
                                            _count AS (
                                                SELECT COUNT(1) AS TotalCount FROM _data
                                        )
                                        SELECT * FROM _data CROSS APPLY _count /**orderby**/ OFFSET @PageIndex * @PageSize ROWS FETCH NEXT @PageSize ROWS ONLY";

                SqlBuilder builder = new SqlBuilder();
                
                var selector = builder.AddTemplate(selectQuery, new { PageIndex = pageIndex, PageSize = pageSize });

                if (!string.IsNullOrEmpty(criteria.Level))
                    builder.Where("lv.Name = @Level", new { Level = criteria.Level });

                if (!string.IsNullOrEmpty(criteria.Message))
                {
                    var msg = "%" + criteria.Message + "%";
                    builder.Where("l.Message Like @Message", new { Message = msg });
                }
                
                foreach (var a in asc)
                {
                    if (!string.IsNullOrWhiteSpace(a))
                        builder.OrderBy(a);
                }

                foreach (var d in desc)
                {
                    if (!string.IsNullOrWhiteSpace(d))
                        builder.OrderBy(d + " desc");
                }
                
                var rows = connection.Query<Log>(selector.RawSql, selector.Parameters).ToList();

                if(rows.Count == 0)
                    return new Tuple<IEnumerable<Log>, int>(rows, 0);
                

                return new Tuple<IEnumerable<Log>, int>(rows, rows[0].TotalCount);
                
            }
        }


    }
}

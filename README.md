Dapper Custom Pagination Sample
========================================
# Introduction

Sample for custom pagination using Dapper. Supporting sorting + criteria + pagination.

# Usage

* Unzip `Database\Database.7z`, attach to LocalDB, or restore to your favoriate Sql Server instance and change the connection string in App.Config.
* Open solution and run the application.

# Method sample:
```csharp
 Tuple<IEnumerable<Log>, int> Find(LogSearchCriteria criteria
            , int pageIndex
            , int pageSize
            , string[] asc
            , string[] desc);
```
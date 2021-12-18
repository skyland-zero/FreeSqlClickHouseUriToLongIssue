// See https://aka.ms/new-console-template for more information
using FreeSqlClickHouseUriToLongIssue;


var connStr = @"Host=192.168.10.45;Port=8123;Database=test;Username=default;Password=abc123";

var fsql = new FreeSql.FreeSqlBuilder()
              .UseConnectionString(FreeSql.DataType.ClickHouse, connStr)
              .UseAutoSyncStructure(true)
              .UseExitAutoDisposePool(false)
              .Build();

Console.WriteLine("开始创建数据");
var json = "[{\"date\":\"2021-12-19T02:47:53.4365075 08:00\",\"temperatureC\":6,\"temperatureF\":42,\"summary\":\"Balmy\"},{\"date\":\"2021-12-20T02:47:53.4366893 08:00\",\"temperatureC\":36,\"temperatureF\":96,\"summary\":\"Bracing\"},{\"date\":\"2021-12-21T02:47:53.4366903 08:00\",\"temperatureC\":-15,\"temperatureF\":6,\"summary\":\"Bracing\"},{\"date\":\"2021-12-22T02:47:53.4366904 08:00\",\"temperatureC\":14,\"temperatureF\":57,\"summary\":\"Cool\"},{\"date\":\"2021-12-23T02:47:53.4366905 08:00\",\"temperatureC\":29,\"temperatureF\":84,\"summary\":\"Mild\"}]";
var data = new List<Entity>();
for (int i = 0; i < 20; i++)
{
    var t = new Entity
    {
        Id = Guid.NewGuid().ToString(),
        Content = json,
        Content2 = json,
        Content3 = json,
        Content4 = json,
        Content5 = json,
        Content6 = json,
        Content7 = json,
        Content8 = json,
        Content9 = json,
        Content10 = json
    };
    data.Add(t);
}
Console.WriteLine("开始插入");

//fsql.Insert(data).ExecuteAffrows();

await fsql.Insert(data).ExecuteAffrowsAsync();

Console.WriteLine("插入完成");


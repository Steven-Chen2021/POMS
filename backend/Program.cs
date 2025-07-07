using PomsApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var orders = new List<Order>
{
    new("PO001", 10, 5, "Shipper A", "Consignee A", "Los Angeles", "New York", "H001", "Air"),
    new("PO002", 20, 20, "Shipper B", "Consignee B", "Chicago", "Houston", "H002", "Road"),
    new("PO003", 15, 15, "Shipper C", "Consignee C", "Seattle", "Miami", "H003", "Sea"),
    new("PO004", 40, 30, "Shipper D", "Consignee D", "London", "Paris", "H004", "Rail"),
    new("PO005", 50, 50, "Shipper E", "Consignee E", "Tokyo", "Osaka", "H005", "Sea"),
    new("PO006", 60, 45, "Shipper F", "Consignee F", "Beijing", "Shanghai", "H006", "Air"),
    new("PO007", 70, 70, "Shipper G", "Consignee G", "Dubai", "Berlin", "H007", "Road"),
    new("PO008", 80, 70, "Shipper H", "Consignee H", "Sydney", "Melbourne", "H008", "Sea"),
    new("PO009", 90, 80, "Shipper I", "Consignee I", "Mumbai", "Delhi", "H009", "Air"),
    new("PO010", 100, 90, "Shipper J", "Consignee J", "San Francisco", "Las Vegas", "H010", "Rail")
};

app.MapGet("/api/orders", () => orders);

app.Run();

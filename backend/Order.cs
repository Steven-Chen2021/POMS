namespace PomsApi;

public record Order(
    string PoNumber,
    int OrderQty,
    int ShipQty,
    string Shipper,
    string Consignee,
    string From,
    string To,
    string HouseNo,
    string Shipway);

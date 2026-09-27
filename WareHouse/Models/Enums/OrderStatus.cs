namespace WareHouse.Models.Enums
{
    public enum OrderStatus
    {
        Placed = 1,
        Validating,
        Reserved,
        Packing,
        Shipped,
        Rejected,
        Cancelled,
    }
}

namespace ApiMeli.Core.Domain.Enums
{
  public static class EEndpointType
  {
    public static string AllOrders       { get { return "allorders"; } }
    public static string QueueAllOrders  { get { return "queueallorders"; } }
    public static string Order           { get { return "order"; } }
    public static string QueueOrder      { get { return "queueorder"; } }
    public static string Products        { get { return "product"; } }
    public static string Price           { get { return "price"; } }
    public static string Stock           { get { return "stock"; } }
    public static string Tracking        { get { return "tracking"; } }
  }
}
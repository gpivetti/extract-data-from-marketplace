using System;
using System.Text;
using System.Collections.Generic;

namespace ApiMeli.Sources.MercadoLivre.Domain.Models
{
  public class MeliOrder
  {
    public int id { get; set; }
    public string status { get; set; }
    public object status_detail { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_closed { get; set; }
    public IList<OrderItem> order_items { get; set; }
    public int total_amount { get; set; }
    public string currency_id { get; set; }
    public Buyer buyer { get; set; }
    public Seller seller { get; set; }
    public IList<Payment> payments { get; set; }
    public Feedback feedback { get; set; }
    public Shipping shipping { get; set; }
    public IList<string> tags { get; set; }
  }

  public class Item
  {
    public string id { get; set; }
    public string title { get; set; }
    public object variation_id { get; set; }
    public IList<object> variation_attributes { get; set; }
  }

  public class OrderItem
  {
    public Item item { get; set; }
    public int quantity { get; set; }
    public int unit_price { get; set; }
    public string currency_id { get; set; }
  }

  public class BillingInfo
  {
    public string doc_type { get; set; }
    public string doc_number { get; set; }
  }

  public class Buyer
  {
    public string id { get; set; }
    public string nickname { get; set; }
    public string email { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public BillingInfo billing_info { get; set; }
  }

  public class Seller
  {
    public string id { get; set; }
    public string nickname { get; set; }
    public string email { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
  }

  public class Payment
  {
    public string id { get; set; }
    public int transaction_amount { get; set; }
    public string currency_id { get; set; }
    public string status { get; set; }
    public object date_created { get; set; }
    public object date_last_modified { get; set; }
  }

  public class Feedback
  {
    public object purchase { get; set; }
    public object sale { get; set; }
  }

  public class Shipping
  {
    public long id { get; set; }
  }
}


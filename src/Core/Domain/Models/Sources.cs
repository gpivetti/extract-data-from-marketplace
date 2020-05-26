using System.Collections.Generic;

namespace ApiMeli.Core.Domain.Models
{
  public class Sources
  {
    public string _id { get; set; }
    public string name { get; set; }
    public string descricao { get; set; }
    public string token { get; set; }
    public SourceApi api { get; set; }
  }

  public class SourceApi
  {
    public string baseuri { get; set; }
    public IList<ApiHeader> headers { get; set; }
    public object authorization { get; set; }
    public ApiEndpoints endpoints { get; set; }
  }

  public class ApiEndpoints
  {
    public int _id { get; set; }
    public string type { get; set; }
    public string method { get; set; }
    public string uri { get; set; }
    public object authorization { get; set; }
    public IList<ApiHeader> headers { get; set; }
  }

  public class ApiHeader
  {
    public string key { get; set; }
    public string value { get; set; }
  }  
}
using System.Collections.Generic;

namespace ApiMeli.Core.Domain.Models
{

    public class CustumerSource
    {
        public string custumerId { get; set; }
        public string name { get; set; }
        public CustumerSourceSource source { get; set; }
        public CustumerSourceApi api { get; set; }
    }

    public class CustumerSourceApi
    {
        public CustumerSourceHeader headers { get; set; }
        public List<string> endpotins { get; set; }
        public object enpointsCustumizateds { get; set; }
    }    


    public class CustumerSourceHeader
    {
        public string key { get; set; }
        public string value { get; set; }
    }  

    public class CustumerSourceSource
    {
        public string name { get; set; }
        public string descricao { get; set; }
        public string token { get; set; }
        public CustumerSourceSourceApi api { get; set; }
    }

    public class CustumerSourceSourceApi
    {
        public string baseuri { get; set; }
        public IList<CustumerSourceHeader> headers { get; set; }
        public object authorization { get; set; }
        public Endpoints endpoints { get; set; }
    }

    public class Endpoints
    {
        public CustumerSourceEndpointsOrders orders { get; set; }
    }    

    public class CustumerSourceEndpointsOrders
    {
        public string type { get; set; }
        public string method { get; set; }
        public string uri { get; set; }
        public object authorization { get; set; }
        public object headers { get; set; }
    }
}
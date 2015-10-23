using System.Collections.Generic;
using Newtonsoft.Json;

public class JsonEncoder
{
    public List<CustomField> Data { get; set; } 
    
    public JsonEncoder(List<CustomField> data )
    {
        Data = data;
    }

    public string GetJson()
    {
        return JsonConvert.SerializeObject(Data);
    }
}
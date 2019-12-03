
using Newtonsoft.Json;
public class JsonValues
{

    public JsonValues(Metadata metadata,object value)
    {


        if (value.GetType().Name != "JObject")
        {
            this.value = value.ToString();

        }
        else
        {
            var vvalue = JsonConvert.DeserializeObject<Value>(value.ToString());
            this.value = vvalue.value.ToString();
        }

    }
    public string value { get; set; }
    public Metadata Metadata { get; set; }
}

public class Value
{
    public string key { get; set; }
    public int value { get; set; }
}

public class Metadata
{
    public string href { get; set; }
    public string type { get; set; }
    public string resourcetype { get; set; }
}

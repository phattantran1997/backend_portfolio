using System.Collections.Generic;
using Newtonsoft.Json;

public class Block
{
    public List<BlockItem> Results { get; set; }
}

public class BlockItem
{
    public string Id { get; set; }
   
}

public class NotionBlog
{
    [JsonProperty("cover")]
    public CoverDetails Cover { get; set; }

    [JsonProperty("properties")]
    public PropertiesDetails Properties { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("public_url")]
    public string PublicUrl { get; set; }

    [JsonProperty("developer_survey")]
    public string DeveloperSurveyUrl { get; set; }

    [JsonProperty("request_id")]
    public string RequestId { get; set; }
}
public class CoverDetails
{
    [JsonProperty("external")]
    public ExternalDetails External { get; set; }
}

public class ExternalDetails
{
    [JsonProperty("url")]
    public string Url { get; set; }
}

public class PropertiesDetails
{
    [JsonProperty("title")]
    public TitleDetails Title { get; set; }
}

public class TitleDetails
{
    [JsonProperty("title")]
    public List<TextDetails> Title { get; set; }
}

public class TextDetails
{
    [JsonProperty("plain_text")]
    public string PlainText { get; set; }
}
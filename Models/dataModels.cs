using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace iNFO.API;


// --- LANDING PAGE ---

public class LandingPage_GetData
{
    [JsonPropertyName("INFO_SID")]
    public string INFO_SID { get; set; }
    [JsonPropertyName("INFO_NAME")]
    public string INFO_NAME { get; set; }
    [JsonPropertyName("DESCRIPTION")]
    public string DESCRIPTION { get; set; }
    [JsonPropertyName("DETAIL")]
    public List<LandingPage_GetDataDetail> DETAIL { get; set; }
    public LandingPage_GetData()
    {
        DETAIL = new List<LandingPage_GetDataDetail>();
    }
}

public class LandingPage_GetDataDetail
{

    [JsonPropertyName("INFO_DETAIL_SID")]
    public string INFO_DETAIL_SID { get; set; }
    [JsonPropertyName("INFO_DETAIL_NAME")]
    public string INFO_DETAIL_NAME { get; set; }
    [JsonPropertyName("DESCRIPTION")]
    public string DESCRIPTION { get; set; }
    [JsonPropertyName("IMAGE_BINARY")]
    public string IMAGE_BINARY { get; set; }
    [JsonPropertyName("IMAGE_NAME")]
    public string IMAGE_NAME { get; set; }
    [JsonPropertyName("IMAGE_PATH")]
    public string IMAGE_PATH { get; set; }
    [JsonPropertyName("IMAGE_EXT")]
    public string IMAGE_EXT { get; set; }
}

// ===============================================================================================

// --- PRODUCTS & SERVICES PAGE ---
public class categoryProduct
{
    [JsonPropertyName("REFF_GENERIC_SID")]
    public string REFF_GENERIC_SID { get; set; }
    [JsonPropertyName("VALUE")]
    public string VALUE { get; set; }
    [JsonPropertyName("CATEGORY")]
    public string CATEGORY { get; set; }
    [JsonPropertyName("R_PI1")]
    public int R_PI1 { get; set; }
    [JsonPropertyName("DETAIL")]
    public List<subProduct> DETAIL { get; set; }
    public categoryProduct()
    {
        DETAIL = new List<subProduct>();
    }
}


public class subProduct
{
    [JsonPropertyName("PRODUCT_SUBCATEGORY_SID")]
    public string PRODUCT_SUBCATEGORY_SID { get; set; }
    [JsonPropertyName("PRODUCT_SUBCATEGORY_NAME")]
    public string PRODUCT_SUBCATEGORY_NAME { get; set; }
}

// ===============================================================================================

// --- LIST PRODUCTS PAGE ---

public class listProducts
{
    [JsonPropertyName("PRODUCT_SID")]
    public string PRODUCT_SID { get; set; }
    [JsonPropertyName("PRODUCT_NAME")]
    public string PRODUCT_NAME { get; set; }
    [JsonPropertyName("IMAGE_BINARY")]
    public string IMAGE_BINARY { get; set; }
    [JsonPropertyName("IMAGE_NAME")]
    public string IMAGE_NAME { get; set; }
    [JsonPropertyName("IMAGE_PATH")]
    public string IMAGE_PATH { get; set; }
    [JsonPropertyName("IMAGE_EXT")]
    public string IMAGE_EXT { get; set; }
}

// ===============================================================================================

// --- PRODUCT DETAIL PAGE ---

public class productDetail
{
    [JsonPropertyName("PRODUCT_SID")]
    public string PRODUCT_SID { get; set; }
    [JsonPropertyName("PRODUCT_NAME")]
    public string PRODUCT_NAME { get; set; }
    [JsonPropertyName("DESCRIPTION")]
    public string DESCRIPTION { get; set; }
    [JsonPropertyName("IMAGE_BINARY")]
    public string IMAGE_BINARY { get; set; }
    [JsonPropertyName("IMAGE_NAME")]
    public string IMAGE_NAME { get; set; }
    [JsonPropertyName("IMAGE_PATH")]
    public string IMAGE_PATH { get; set; }
    [JsonPropertyName("IMAGE_EXT")]
    public string IMAGE_EXT { get; set; }
    [JsonPropertyName("CH_CATALOG")]
    public bool CH_CATALOG { get; set; }
    [JsonPropertyName("CATALOG_LINK")]
    public string CATALOG_LINK { get; set; }

}


// ===============================================================================================

// --- TECHNOLOGY PAGE ---

public class technology
{
    [JsonPropertyName("INFO_SID")]
    public string INFO_SID { get; set; }
    [JsonPropertyName("INFO_NAME")]
    public string INFO_NAME { get; set; }
    [JsonPropertyName("DESCRIPTION")]
    public string DESCRIPTION { get; set; }
}


// ===============================================================================================

// --- OPERATION PAGE ---

public class operation
{
    [JsonPropertyName("OPERATION_SID")]
    public string OPERATION_SID { get; set; }
    [JsonPropertyName("OPERATION_IID")]
    public int OPERATION_IID { get; set; }
    [JsonPropertyName("OPERATION_UID")]
    public string OPERATION_UID { get; set; }
    [JsonPropertyName("NAME")]
    public string NAME { get; set; }
    [JsonPropertyName("YEAR")]
    public int YEAR { get; set; }
    [JsonPropertyName("MONTH")]
    public int MONTH { get; set; }
    [JsonPropertyName("TARGET_VALUE")]
    public int TARGET_VALUE { get; set; }
    [JsonPropertyName("REALIZATION_VALUE")]
    public int REALIZATION_VALUE { get; set; }
    [JsonPropertyName("CATEGORY_SID")]
    public string CATEGORY_SID { get; set; }
    [JsonPropertyName("CATEGORY_NAME")]
    public string CATEGORY_NAME { get; set; }
    [JsonPropertyName("CATEGORY_RPI1")]
    public int CATEGORY_RPI1 { get; set; }
}


// ===============================================================================================

// --- RIG POSITION PAGE ---

public class rigPosition
{
    [JsonPropertyName("RIG_SID")]
    public string RIG_SID { get; set; }
    [JsonPropertyName("RIG_NAME")]
    public string RIG_NAME { get; set; }
    [JsonPropertyName("IMAGE_BINARY")]
    public string IMAGE_BINARY { get; set; }
    [JsonPropertyName("IMAGE_NAME")]
    public string IMAGE_NAME { get; set; }
    [JsonPropertyName("IMAGE_PATH")]
    public string IMAGE_PATH { get; set; }
    [JsonPropertyName("IMAGE_EXT")]
    public string IMAGE_EXT { get; set; }
    [JsonPropertyName("ISACTIVE")]
    public bool ISACTIVE { get; set; }
    [JsonPropertyName("SORT_ORDER")]
    public string SORT_ORDER { get; set; }
    [JsonPropertyName("DETAIL")]
    public List<rigPositionDetail> DETAIL { get; set; }
    public rigPosition()
    {
        DETAIL = new List<rigPositionDetail>();
    }
}

public class rigPositionDetail
{
    [JsonPropertyName("RIG_DETAIL_SID")]
    public string RIG_DETAIL_SID { get; set; }
    [JsonPropertyName("RIG_DETAIL_NAME")]
    public string RIG_DETAIL_NAME { get; set; }
    [JsonPropertyName("DESCRIPTION")]
    public string DESCRIPTION { get; set; }
    [JsonPropertyName("ISACTIVE")]
    public bool ISACTIVE { get; set; }
}


// ===============================================================================================

// --- NEWS PAGE ---

public class news
{
    [JsonPropertyName("NEWS_SID")]
    public string NEWS_SID { get; set; }
    [JsonPropertyName("TITLE")]
    public string TITLE { get; set; }
    [JsonPropertyName("TITLE_LINK")]
    public string TITLE_LINK { get; set; }
    [JsonPropertyName("NEWS_DATE")]
    public DateTime NEWS_DATE { get; set; }
    [JsonPropertyName("DESCRIPTION")]
    public string DESCRIPTION { get; set; }
    [JsonPropertyName("IMAGE_BINARY")]
    public string IMAGE_BINARY { get; set; }
    [JsonPropertyName("IMAGE_NAME")]
    public string IMAGE_NAME { get; set; }
    [JsonPropertyName("IMAGE_PATH")]
    public string IMAGE_PATH { get; set; }
    [JsonPropertyName("IMAGE_EXT")]
    public string IMAGE_EXT { get; set; }
}


// ===============================================================================================

// --- HSSE PERFORMANCE PAGE ---

public class HSSEData
{
    [JsonPropertyName("HSSE_SID")]
    public string HSSE_SID { get; set; }
    [JsonPropertyName("HSSE_IID")]
    public int HSSE_IID { get; set; }
    [JsonPropertyName("HSSE_UID")]
    public string HSSE_UID { get; set; }
    [JsonPropertyName("YEAR")]
    public int YEAR { get; set; }
    [JsonPropertyName("CATEGORY_SID")]
    public string CATEGORY_SID { get; set; }
    [JsonPropertyName("CATEGORY_NAME")]
    public string CATEGORY_NAME { get; set; }
    [JsonPropertyName("CATEGORY_RPI1")]
    public int CATEGORY_RPI1 { get; set; }
    [JsonPropertyName("DETAIL")]
    public List<HSSEDataDetail> DETAIL { get; set; }
    public HSSEData()
    {
        DETAIL = new List<HSSEDataDetail>();
    }
}

public class HSSEDataDetail
{
    [JsonPropertyName("HSSE_DETAIL_SID")]
    public string HSSE_DETAIL_SID { get; set; }
    [JsonPropertyName("NAME")]
    public string NAME { get; set; }
    [JsonPropertyName("MONTH")]
    public int MONTH { get; set; }
    [JsonPropertyName("VALUE")]
    public float VALUE { get; set; }
    [JsonPropertyName("IMAGE_BINARY")]
    public string IMAGE_BINARY { get; set; }
    [JsonPropertyName("IMAGE_NAME")]
    public string IMAGE_NAME { get; set; }
    [JsonPropertyName("IMAGE_PATH")]
    public string IMAGE_PATH { get; set; }
    [JsonPropertyName("IMAGE_EXT")]
    public string IMAGE_EXT { get; set; }
}

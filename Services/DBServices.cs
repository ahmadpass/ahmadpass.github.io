using Dapper;
using System.Data;

namespace iNFO.API.Services;

// --- LANDING PAGE ---
public interface ILandingPageService
{
    Task<List<LandingPage_GetData>> GetData();
    Task<List<LandingPage_GetDataDetail>> GetDataDetail(string INFO_SID);
}
public class LandingPageService : ILandingPageService
{
    private readonly DBConnection _connectionDB;

    public LandingPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================


    public async Task<List<LandingPage_GetData>> GetData()
    {
        // LandingPage_GetData response = new LandingPage_GetData();
        //IEnumerable<dynamic> dataList = new List<dynamic>();
        List<LandingPage_GetData> dataList = new List<LandingPage_GetData>();

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<LandingPage_GetData>)await conn.QueryAsync<LandingPage_GetData>("sp__LandingPage_GetData", null, commandType: CommandType.StoredProcedure);

            conn.Close();
        }


        // return dataList.Select(async x => new LandingPage_GetData()
        // {
        //     INFO_SID = x.INFO_SID,
        //     INFO_NAME = x.INFO_NAME,
        //     DESCRIPTION = x.DESCRIPTION,
        //     DETAIL = await GetDataDetail(x.INFO_SID)
        // }
        // ).ToList();

        foreach (var itm in dataList)
        {
            itm.DETAIL = await GetDataDetail(itm.INFO_SID);
        }
        return dataList;
    }

    // =================================================================================================================

    public async Task<List<LandingPage_GetDataDetail>> GetDataDetail(string INFO_SID)
    {

        // var template = new { INFO_SID = INFO_SID };
        // var parameter = new DynamicParameters(template);

        var parameter = new Dictionary<string, object>
        {
            { "@INFO_SID", INFO_SID }
        };

        //IEnumerable<dynamic> dataListDetail = new List<dynamic>();
        List<LandingPage_GetDataDetail> dataListDetail = new List<LandingPage_GetDataDetail>();

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();

            dataListDetail = (List<LandingPage_GetDataDetail>)await conn.QueryAsync<LandingPage_GetDataDetail>("sp__LandingPage_GetDataDetail", parameter, commandType: CommandType.StoredProcedure);

            conn.Close();
        }


        return dataListDetail.Select(x => new LandingPage_GetDataDetail()
        {
            INFO_DETAIL_SID = x.INFO_DETAIL_SID,
            INFO_DETAIL_NAME = x.INFO_DETAIL_NAME,
            DESCRIPTION = x.DESCRIPTION,
            IMAGE_BINARY = x.IMAGE_BINARY,
            IMAGE_NAME = x.IMAGE_NAME,
            IMAGE_PATH = x.IMAGE_PATH,
            IMAGE_EXT = x.IMAGE_EXT
        }
).ToList();
    }

    // =================================================================================================================


}

// =======================================================================================================================

// --- PRODUCTS & SERVICES PAGE ---
public interface IProductsPageService
{
    Task<List<categoryProduct>> GetCategoryProducts();
    Task<List<subProduct>> GetSubProducts(string CATEGORY_SID);
}

public class ProductsPageService : IProductsPageService
{
    private readonly DBConnection _connectionDB;

    public ProductsPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================

    public async Task<List<categoryProduct>> GetCategoryProducts()
    {

        List<categoryProduct> dataList = new List<categoryProduct>();

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<categoryProduct>)await conn.QueryAsync<categoryProduct>("sp__ProductService_GetCategoryProduct", null, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        foreach (var itm in dataList)
        {
            itm.DETAIL = await GetSubProducts(itm.REFF_GENERIC_SID);
        }
        return dataList;
    }

    // ======================================================================================================================
    public async Task<List<subProduct>> GetSubProducts(string CATEGORY_SID)
    {
        List<subProduct> dataList = new List<subProduct>();
        var parameter = new Dictionary<string, object>
        {
            { "@CATEGORYPRODUCT_SID", CATEGORY_SID }
        };

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<subProduct>)await conn.QueryAsync<subProduct>("sp__ProductService_GetSubProduct", parameter, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        return dataList;

    }

}


// --- LIST PRODUCTS PAGE ---
public interface IListProductsPageService
{
    Task<List<listProducts>> GetListProducts(string SUBCATEGORY_SID);
}

public class ListProductsPageService : IListProductsPageService
{
    private readonly DBConnection _connectionDB;

    public ListProductsPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================

    public async Task<List<listProducts>> GetListProducts(string SUBCATEGORY_SID)
    {
        List<listProducts> dataList = new List<listProducts>();
        var parameter = new Dictionary<string, object>
        {
            { "@SUBCATEGORY_SID", SUBCATEGORY_SID }
        };

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<listProducts>)await conn.QueryAsync<listProducts>("sp__ProductService_GetProduct", parameter, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        return dataList;
    }


}

// --- PRODUCT DETAIl PAGE ---
public interface IProductDetailPageService
{
    Task<List<productDetail>> GetProductDetail(string PRODUCT_SID);
}

public class ProductDetailPageService : IProductDetailPageService
{
    private readonly DBConnection _connectionDB;

    public ProductDetailPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================

    public async Task<List<productDetail>> GetProductDetail(string PRODUCT_SID)
    {
        List<productDetail> dataList = new List<productDetail>();
        var parameter = new Dictionary<string, object>
        {
            { "@PRODUCT_SID", PRODUCT_SID }
        };

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<productDetail>)await conn.QueryAsync<productDetail>("sp__ProductService_GetProductDetail", parameter, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        return dataList;
    }


}


// --- TECHNOLOGY PAGE ---
public interface ITechnologyPageService
{
    Task<List<technology>> GetTechnology();
}

public class TechnologyPageService : ITechnologyPageService
{
    private readonly DBConnection _connectionDB;

    public TechnologyPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================

    public async Task<List<technology>> GetTechnology()
    {
        List<technology> dataList = new List<technology>();

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<technology>)await conn.QueryAsync<technology>("sp__Technology_GetData", null, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        return dataList;
    }


}


// --- OPERATION PAGE ---
public interface IOperationPageService
{
    Task<List<operation>> GetOperation();
}

public class OperationPageService : IOperationPageService
{
    private readonly DBConnection _connectionDB;

    public OperationPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================

    public async Task<List<operation>> GetOperation()
    {
        List<operation> dataList = new List<operation>();

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<operation>)await conn.QueryAsync<operation>("sp__Operation_GetData", null, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        return dataList;
    }


}


// =======================================================================================================================

// --- RIG POSITION PAGE ---
public interface IRigPositionPageService
{
    Task<List<rigPosition>> GetRigPosition();
    Task<List<rigPositionDetail>> GetRigPositionDetail(string RIG_SID);
}

public class RigPositionPageService : IRigPositionPageService
{
    private readonly DBConnection _connectionDB;

    public RigPositionPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================

    public async Task<List<rigPosition>> GetRigPosition()
    {

        List<rigPosition> dataList = new List<rigPosition>();

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<rigPosition>)await conn.QueryAsync<rigPosition>("sp__RigPosition_GetData", null, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        foreach (var itm in dataList)
        {
            itm.DETAIL = await GetRigPositionDetail(itm.RIG_SID);
        }
        return dataList;
    }

    // ======================================================================================================================
    public async Task<List<rigPositionDetail>> GetRigPositionDetail(string RIG_SID)
    {
        List<rigPositionDetail> dataList = new List<rigPositionDetail>();
        var parameter = new Dictionary<string, object>
        {
            { "@RIG_SID", RIG_SID }
        };

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<rigPositionDetail>)await conn.QueryAsync<rigPositionDetail>("sp__RigPosition_GetDataDetail", parameter, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        return dataList;

    }

}


// --- NEWS PAGE ---
public interface INewsPageService
{
    Task<List<news>> GetNews();
}

public class NewsPageService : INewsPageService
{
    private readonly DBConnection _connectionDB;

    public NewsPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================

    public async Task<List<news>> GetNews()
    {
        List<news> dataList = new List<news>();

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<news>)await conn.QueryAsync<news>("sp__News_GetData", null, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        return dataList;
    }


}


// =======================================================================================================================

// --- HSSE PERFORMANCE PAGE ---
public interface IHSSEPageService
{
    Task<List<HSSEData>> GetHSSE(int YEAR, int MONTH);
    Task<List<HSSEDataDetail>> GetHSSEDetail(string HSSE_SID, int MONTH);
}

public class HSSEPageService : IHSSEPageService
{
    private readonly DBConnection _connectionDB;

    public HSSEPageService(DBConnection connectionDB)
    {
        _connectionDB = connectionDB;
    }

    // =================================================================================================================

    public async Task<List<HSSEData>> GetHSSE(int YEAR, int MONTH)
    {

        List<HSSEData> dataList = new List<HSSEData>();
        var parameter = new Dictionary<string, object>
        {
            { "@YEAR", YEAR }
        };

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<HSSEData>)await conn.QueryAsync<HSSEData>("sp__Hsse_GetData", parameter, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        foreach (var itm in dataList)
        {
            itm.DETAIL = await GetHSSEDetail(itm.HSSE_SID, MONTH);
        }
        return dataList;
    }

    // ======================================================================================================================
    public async Task<List<HSSEDataDetail>> GetHSSEDetail(string HSSE_SID, int MONTH)
    {
        List<HSSEDataDetail> dataList = new List<HSSEDataDetail>();
        var parameter = new Dictionary<string, object>
        {
            { "@HSSE_SID", HSSE_SID },
            { "@MONTH", MONTH}
        };

        using (IDbConnection conn = _connectionDB.Connection)
        {
            conn.Open();
            dataList = (List<HSSEDataDetail>)await conn.QueryAsync<HSSEDataDetail>("sp__Hsse_GetDataDetail", parameter, commandType: CommandType.StoredProcedure);

            conn.Close();
        }

        return dataList;

    }

}

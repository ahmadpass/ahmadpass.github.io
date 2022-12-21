using iNFO.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace iNFO.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class LandingPageController : ControllerBase
{
    private readonly ILandingPageService _service;

    public LandingPageController(ILandingPageService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<LandingPage_GetData>> Get()
    {

        return await _service.GetData();
    }
}

[Route("api/[controller]")]
[ApiController]
public class ProductsPageController : ControllerBase
{
    private readonly IProductsPageService _service;

    public ProductsPageController(IProductsPageService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<categoryProduct>> Get()
    {

        return await _service.GetCategoryProducts();
    }
}

[Route("api/[controller]")]
[ApiController]
public class ListProductsPageController : ControllerBase
{
    private readonly IListProductsPageService _service;

    public ListProductsPageController(IListProductsPageService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("{SUBCATEGORY_SID}")]
    public async Task<List<listProducts>> Get(string SUBCATEGORY_SID)
    {

        return await _service.GetListProducts(SUBCATEGORY_SID);
    }
}


[Route("api/[controller]")]
[ApiController]
public class ProductDetailPageController : ControllerBase
{
    private readonly IProductDetailPageService _service;

    public ProductDetailPageController(IProductDetailPageService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("{PRODUCT_SID}")]
    public async Task<List<productDetail>> Get(string PRODUCT_SID)
    {

        return await _service.GetProductDetail(PRODUCT_SID);
    }
}


[Route("api/[controller]")]
[ApiController]
public class TechnologyPageController : ControllerBase
{
    private readonly ITechnologyPageService _service;

    public TechnologyPageController(ITechnologyPageService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<technology>> Get()
    {

        return await _service.GetTechnology();
    }
}


[Route("api/[controller]")]
[ApiController]
public class OperationPageController : ControllerBase
{
    private readonly IOperationPageService _service;

    public OperationPageController(IOperationPageService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<operation>> Get()
    {

        return await _service.GetOperation();
    }
}


[Route("api/[controller]")]
[ApiController]
public class RigPositionPageController : ControllerBase
{
    private readonly IRigPositionPageService _service;

    public RigPositionPageController(IRigPositionPageService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<rigPosition>> Get()
    {

        return await _service.GetRigPosition();
    }
}


[Route("api/[controller]")]
[ApiController]
public class NewsPageController : ControllerBase
{
    private readonly INewsPageService _service;

    public NewsPageController(INewsPageService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<news>> Get()
    {

        return await _service.GetNews();
    }
}


[Route("api/[controller]")]
[ApiController]
public class HSSEPageController : ControllerBase
{
    private readonly IHSSEPageService _service;

    public HSSEPageController(IHSSEPageService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("{YEAR}/{MONTH}")]
    public async Task<List<HSSEData>> Get(int YEAR, int MONTH)
    {

        return await _service.GetHSSE(YEAR, MONTH);
    }
}

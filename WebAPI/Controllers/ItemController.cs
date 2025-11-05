using DomainClasses.Base;
using Microsoft.AspNetCore.Mvc;
using p01_ServiceLayer_Class_Library.DALContracts;
using p03_DataAccessLayer_Class_Library;
using DomainClasses.OfficeBuildings.Interfaces;
using DomainClasses.OfficeBuildings.Classes;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : BaseController<Item>
    {

        private readonly ILogger<ItemController> _logger;
        private readonly IBaseDataAccessLayer _baseDataAccessLayer;
        private readonly IBuildingManager _buildingManager;


        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
            _baseDataAccessLayer = new BaseDataAccessLayer();
            _buildingManager = new BuildingManager();
        }

        /*
        [HttpGet(Name = "GetItem")]
        public IEnumerable<Item> Get()
        {
            return _baseDataAccessLayer.Get();
        }
        */

        [HttpGet(Name = "GetItem")]
        public IEnumerable<Building> Get()
        {
            return _buildingManager.GetAll();
        }

    }
}

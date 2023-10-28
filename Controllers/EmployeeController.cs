using AutoMapper;
using Core_AutoMapper.Services;
using Core_AutoMapper.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Core_AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IMapper mapper;
        EmployeeService service;
        List<EmployeeViewModel> records;

        public EmployeeController(IMapper mapper, EmployeeService service)
        {
            this.mapper = mapper;
            this.service = service;
            records = new List<EmployeeViewModel>();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var employees = service.GetEmoployees();
            records = mapper.Map<List<EmployeeViewModel>>(employees);
            return Ok(records);
        }
    }
}

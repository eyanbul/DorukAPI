using AutoMapper;
using BL.Abstract;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace API.Controllers
{
    [Route("report")]
    public class ReportController : Controller
    {
        private IReportService reportService;

        public ReportController(IReportService _faqService)
        {
            reportService = _faqService;
        }

        [HttpGet("getdurations")]
        //[Authorize(Roles = "Admin")]
        public string GetDurations()
        {
            var resultModel = reportService.GetAll();
            var result = JsonConvert.SerializeObject(resultModel);
            
            return result;
        }
    }
}
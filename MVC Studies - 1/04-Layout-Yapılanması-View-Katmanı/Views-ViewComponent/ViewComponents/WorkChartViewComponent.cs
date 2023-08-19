using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Views_ViewComponent.Models;

namespace Views_ViewComponent.ViewComponents
{
    public class WorkChartViewComponent : ViewComponent
    {
        List<WorkChart> workChart = new List<WorkChart>()
        {
            new WorkChart("Halim Can Ocaklı", new List<bool>()
            {
                true, true, false, true, false
            }),
            new WorkChart("Raziye Dogan", new List<bool>()
            {
                false, false, true, true, false
            }),
            new WorkChart("Oğuzhan Deniz", new List<bool>()
            {
                true, true, false, true, true
            }),
            new WorkChart("Berkin Topaloğlu", new List<bool>()
            {
                false, false, false, true, false
            }),
            new WorkChart("Yasin Mersin", new List<bool>()
            {
                false, true, true, false, false
            }),
            new WorkChart("İrem Alkaşi", new List<bool>()
            {
                true, true, false, true, true
            })
        };

        public IViewComponentResult Invoke()
        {
            return View(workChart);
        }
    }
}

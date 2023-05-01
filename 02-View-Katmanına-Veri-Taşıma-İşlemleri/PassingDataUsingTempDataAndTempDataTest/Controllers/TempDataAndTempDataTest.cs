using Microsoft.AspNetCore.Mvc;

namespace PassingDataUsingTempDataAndTempDataTest.Controllers
{
    public class TempDataAndTempDataTest : Controller
    {
        // İçerisinde Object tipinde değer tutar.
        // Key-Value mantığı ile çalışır.
        // Diğer yöntemlerden farklı olarak kendi View'ına veri taşımakla birlikte Action'dan Action'a veri taşır ve de Action'dan View'a veri taşır.
        // Tarayıcılardaki Cookie mantığını kullanır.
        // Bir sefere mahsus kullanılabilir.
        public IActionResult PassingDataUsingTempData()
        {
            TempData["Name"] = "Halim";

            // PassingDataUsingTempData actionunu atlayıp PassingDataUsingTempDataTest actionuna geçelim.
            return RedirectToAction("PassingDataUsingTempDataTest");

            // return View();
        }

        public IActionResult PassingDataUsingTempDataTest()
        {
            TempData.Keep("Name");  // TempData'nın birden fazla defa kullanılmasını sağlar.
            //string name = TempData["Name"].ToString();
            return View();
        }
    }
}

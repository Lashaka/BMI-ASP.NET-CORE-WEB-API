using Microsoft.AspNetCore.Mvc;

namespace BMI_API.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        [Route("GetBMI")]
        public IActionResult GetBMI(double weight, double height)
        {
            BMI NewBMI = new BMI(weight, height);
            return Ok(NewBMI.getBmi());
        }

        [HttpGet]
        [Route("IdealWeight")]
        public IActionResult IdealWeight(double weight, double height)
        {
            BMI NewBMI = new BMI(weight, height);
            return Ok(NewBMI.IdealWeight());
        }

        [HttpGet]
        [Route("BMICategory")]
        public IActionResult BMICategory(double weight, double height)
        {
            BMI NewBMI = new BMI(weight, height);
            return Ok(NewBMI.BMICategory());
        }

        [HttpGet]
        [Route("Recommandations")]
        public IActionResult Recommandations(double weight, double height)
        {
            BMI NewBMI = new BMI(weight, height);
            return Ok(NewBMI.Recommandations());
        }
    }

}

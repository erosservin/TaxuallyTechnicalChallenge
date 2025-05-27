using Microsoft.AspNetCore.Mvc;
using Taxually.TechnicalTest.VatRegistrationService;
using Taxually.TechnicalTest.VatRegistrationService.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taxually.TechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VatRegistrationController : ControllerBase
    {
        private readonly IVatRegistrationService vatRegistrationService;

        public VatRegistrationController(IVatRegistrationService vatRegistrationService)
        {
            this.vatRegistrationService = vatRegistrationService;
        }

        /// <summary>
        /// Registers a company for a VAT number in a given country
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] VatRegistrationRequestDto request)
        {
            try
            {
                await vatRegistrationService.RegisterAsync(request);
                return Ok();
            }
            catch (Exception)
            {
                // Exception should be logged
                // A localized user facing message should be returned
                return BadRequest("Incorrect input data");
            }
        }
    }
}

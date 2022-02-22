using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerForm.FormService;
using CustomerForm.Model;
using Microsoft.AspNetCore.Mvc;

namespace CustomerForm.Controllers
{
    [ApiController]
    [Route("api/customerform")]

    public class FormController : ControllerBase
    {
        private IFormServices formService;

        public FormController(IFormServices _formService) {

            this.formService = _formService;
        }

            //Post Request
        [HttpPost]
        public ActionResult Post([FromForm] FormSubmissionRequest request) {
            // Checks inputed values in form
            if (!ModelState.IsValid) return BadRequest(new FormResponseMessage
            {
                success = false,
                message = ModelState.Values.Where(x => x.Errors.Count > 0)
                                                .FirstOrDefault().Errors.FirstOrDefault().ErrorMessage
            });

            var isSuccess =formService.FormAction(request);

            FormResponseMessage data;

            if (!isSuccess)
            {
                data = new FormResponseMessage
                {
                    success = false,
                    message = "An Error Occured processing request"
                };
                //lol this should work oo
                return StatusCode(500, data);
            }

            data = new FormResponseMessage
            {
                success = true,
                message = "Record added successfully"
            };

            return Ok(data);

        }
    }
}

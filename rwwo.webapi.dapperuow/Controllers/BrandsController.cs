using Microsoft.AspNetCore.Mvc;
using rwwo.webapi.dapperuow.DTOs;
using rwwo.webapi.dapperuow.Interfaces;
using rwwo.webapi.dapperuow.Models;

namespace rwwo.webapi.dapperuow.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public BrandsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Brand>> GetBrands()
        {
            return await unitOfWork.Brands.Get();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }
            var brand = await unitOfWork.Brands.Find(id);
            if (brand == null)
            {
                return NotFound();
            }

            return Ok(brand);
        }

        [HttpPost]
        public async Task<IActionResult> PostBrand(BrandInputModel model)
        {
            await unitOfWork.Brands.Add(model);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutBrand(BrandUpdateModel model)
        {
            if (model == null || model.id == Guid.Empty)
            {
                return BadRequest();
            }

            var brand = await unitOfWork.Brands.Find(model.id);

            if (brand == null)
            {
                return NotFound();
            }

            await unitOfWork.Brands.Update(model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var brand = await unitOfWork.Brands.Find(id);

            if (brand == null)
            {
                return NotFound();
            }

            await unitOfWork.Brands.Remove(brand);
            return Ok();
        }
    }
}

using System.Threading.Tasks;
using AutoMapper;
using EcommerceApp.Api.Dtos;
using EcommerceApp.Core.Entities;
using EcommerceApp.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketRepository _basketRepo;
        private readonly IMapper _mapper;

        public BasketController(IBasketRepository basketRepo, IMapper mapper)
        {
            _basketRepo = basketRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBaskertById(string id)
        {
            var basket = await _basketRepo.GetBasketAsync(id);

            return Ok(basket ?? new CustomerBasket(id)); 
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasketDto basket)
        {
            var customerBasket = _mapper.Map<CustomerBasketDto, CustomerBasket>(basket);
            var updatedBasket = await _basketRepo.UpdateBasketAsync(customerBasket);

            return Ok(updatedBasket);
        }

        [HttpDelete]
        public async Task DeleteBasket(string id)
        {
             await _basketRepo.DeleteBasketAsync(id);
        }
    }
}

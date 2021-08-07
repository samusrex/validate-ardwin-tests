using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace CardsApi.Controllers
{
    [Route("api/Validate")]
    [ApiController]
    public class ValidateController : ControllerBase
    {


        private readonly CardContext _context;


        public ValidateController(CardContext context)
        {
            
                _context = context;
            
        }


        [HttpPost]
        public async Task<ActionResult<Card>> ValidateCard(Card card)
        {
            //var result = await _context.Cards.AnyAsync(e => e.CardId.Contains(card.CardId));

            var res = await _context.Cards
                   .Where(c => c.CustomerId == card.CustomerId)
                   .Where(c => c.CardId == card.CardId)
                   .Where(c => c.Token == card.Token)
                   .Where(c => c.CVV == card.CVV)
                   .AnyAsync();
                   

            return Ok(res);

        }
    }
}

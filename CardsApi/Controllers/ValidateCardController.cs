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


        [HttpPost("{id}")]
        public async Task<IActionResult> ValidateCard(string id)
        {
            var result = await _context.Cards.AnyAsync(e => e.CardId.Contains(id));

            return Ok(result);

        }
    }
}

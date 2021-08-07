using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CardsApi.Controllers
{
    [Route("api/Rotate")]
    [ApiController]
    public class RotateController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetRotateItems()
        {
            int[] arrayData = { 3, 4, 5 };
            for (int i = 0; i < 2; i++)
            {

                int aux = arrayData[0];
                arrayData[0] = arrayData[^1];

                for (int j = 1; j < arrayData.Length - 1; j++)
                {
                    int aux2 = arrayData[j];
                    arrayData[j] = aux;
                    aux = aux2;
                }

                arrayData[^1] = aux;
            }


            return Ok(value: arrayData);
        }

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace TodoApi.Models
{
    public class Card
    {

        public Card()
        {
            CardId = Guid.NewGuid().ToString();
            Token = Guid.NewGuid().ToString();
            CreationDate = DateTime.Now;
        }
        
        public long Id { get; set; }

        public int CustomerId { get; set; }

        public long CardNumber { get; set; }
        
        public int CVV { get; set; }
        public string CardId { get; set; }
        public string Token { get; set; }

        public DateTime CreationDate { get; set; }


       




    }
}
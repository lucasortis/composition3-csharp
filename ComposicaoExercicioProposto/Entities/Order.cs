using System;
using System.Collections.Generic;
using System.Text;
using ComposicaoExercicioProposto.Entities.Enum;


namespace ComposicaoExercicioProposto.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItens = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {

        }

        

    }
}

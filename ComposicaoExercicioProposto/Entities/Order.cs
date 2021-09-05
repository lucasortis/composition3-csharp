using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using ComposicaoExercicioProposto.Entities.Enum;


namespace ComposicaoExercicioProposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem order in Items)
            {
                sum += order.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Client: " + Client.ToString());
            sb.AppendLine("Order items: ");
            foreach(OrderItem order in Items)
            {
                sb.AppendLine(order.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}

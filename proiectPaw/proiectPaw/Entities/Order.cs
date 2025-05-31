using proiectPaw.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

class Order
{
    public Guid Id { get;  set; }
    public DateTime OrderDate { get;  set; }
    public string CustomerName { get;  set; }

    public Order(DateTime orderDate, string customerName)
    {
        Id = Guid.NewGuid();
        OrderDate = orderDate;
        CustomerName = customerName;
    }

}

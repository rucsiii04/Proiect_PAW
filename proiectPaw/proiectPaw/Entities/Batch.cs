using System;
using System.Windows.Forms;

class Batch
{
    public Guid Id { get; set; }
    public DateTime ProductionDate { get;  set; }
    public DateTime ExpirationDate { get; set; }
    public int Quantity { get; set; }
    public override string ToString()
    {
        return $"{Id.ToString().Substring(0, 8)} - Exp: {ExpirationDate:dd.MM.yyyy} - Qty: {Quantity}";
    }
}


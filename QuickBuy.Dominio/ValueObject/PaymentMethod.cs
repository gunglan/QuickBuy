using QuickBuy.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ValueObject
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool ItsBill
        {
            get { return Id == (int)PaymentTypeEnum.Bill; }
        }
        public bool ItsCreditCard
        {
            get { return Id == (int)PaymentTypeEnum.CreditCard; }
        }
        public bool ItsDeposit
        {
            get { return Id == (int)PaymentTypeEnum.Deposit; }
        }
        public bool ItsUndefined
        {
            get { return Id == (int)PaymentTypeEnum.Undefined; }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppAirLineReservation
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public string OrderID { get; set; }
        public int PaymentMethodID { get; set; }
        public int PassengerID { get; set; }
        public decimal AdultPrice { get; set; }
        public int AdultNumber { get; set; }
        public Nullable<decimal> ChildPrice { get; set; }
        public Nullable<int> ChildNumber { get; set; }
        public Nullable<decimal> ServiceFee { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Passenger Passenger { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}

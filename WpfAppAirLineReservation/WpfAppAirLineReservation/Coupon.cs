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
    
    public partial class Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coupon()
        {
            this.Orders = new HashSet<Order>();
            this.TaxFreeProductOrders = new HashSet<TaxFreeProductOrder>();
        }
    
        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<int> AirLineID { get; set; }
        public Nullable<int> UniformNo { get; set; }
        public Nullable<double> Discount { get; set; }
    
        public virtual AirLine AirLine { get; set; }
        public virtual TravelAgency TravelAgency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxFreeProductOrder> TaxFreeProductOrders { get; set; }
    }
}

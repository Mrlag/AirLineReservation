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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.MemberFeedbacks = new HashSet<MemberFeedback>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderID { get; set; }
        public int AirLineID { get; set; }
        public Nullable<int> UniformNo { get; set; }
        public int DeparturePlace { get; set; }
        public int ArrivalPlace { get; set; }
        public int TravalClassID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public System.DateTime ArrivalDate { get; set; }
        public System.TimeSpan ArrivalTime { get; set; }
        public Nullable<int> CouponID { get; set; }
        public Nullable<int> FlightRoute { get; set; }
        public int OrderStatusID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int PaymentMethodID { get; set; }
        public int AdultCount { get; set; }
        public decimal AdultPrice { get; set; }
        public int ChildCount { get; set; }
        public decimal ChildPrice { get; set; }
        public decimal ServiceFee { get; set; }
    
        public virtual AirLine AirLine { get; set; }
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
        public virtual Coupon Coupon { get; set; }
        public virtual MemberAccount MemberAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberFeedback> MemberFeedbacks { get; set; }
        public virtual OrderStatu OrderStatu { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual TravelAgency TravelAgency { get; set; }
        public virtual TravelClass TravelClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

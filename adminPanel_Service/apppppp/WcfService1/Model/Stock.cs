//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public short id { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string ISBN { get; set; }
        public Nullable<short> StockCount { get; set; }
    }
}

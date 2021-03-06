//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JigyasyaAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QueryConfig
    {
        public System.Guid Id { get; set; }
        public System.DateTimeOffset Created { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public int HomeMode { get; set; }
        public int OrderNum { get; set; }
        public bool Enabled { get; set; }
        public bool AllowPrint { get; set; }
        public bool AllowSearch { get; set; }
        public bool UserAssignable { get; set; }
        public bool RoleAssignable { get; set; }
        public string StatsName { get; set; }
        public string Description { get; set; }
        public string StatsCode { get; set; }
        public string QueryTable { get; set; }
        public string ReturnType { get; set; }
        public string FilterString { get; set; }
        public string ExpandString { get; set; }
        public Nullable<int> QueryCount { get; set; }
        public string QueryResults { get; set; }
        public Nullable<System.DateTimeOffset> LastQueryUpdate { get; set; }
        public int RowOrder { get; set; }
        public string CenterDescription { get; set; }
        public string TopLeftDescription { get; set; }
        public string TopRightDescription { get; set; }
        public string BottomLeftDescription { get; set; }
        public string BottomRightDescription { get; set; }
        public string SymbolIcon { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string Custom4 { get; set; }
        public string Custom5 { get; set; }
        public string ButtonDataTemplate { get; set; }
        public Nullable<int> ButtonRowSpan { get; set; }
        public Nullable<int> ButtonColoumnSpan { get; set; }
        public string DataTemplate { get; set; }
    }
}

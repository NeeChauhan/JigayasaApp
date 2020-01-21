using System;

namespace JigayasaApp.Models
{
    public partial class QueryConfig
    {
        public System.Guid Id { get; set; }
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

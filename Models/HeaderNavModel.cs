namespace TPLOCAL1.Models
{
    public class HeaderNavModel
    {
        public string Title { get; set; } = "Title by default";
        public List<NavItem> NavItems { get; set; } = new List<NavItem>();
    }

    public class NavItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
    }
}

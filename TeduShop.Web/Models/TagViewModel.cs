using System;

namespace TeduShop.Web.Models
{
    public class TagViewModel
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdateBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool? Status { get; set; }
    }
}
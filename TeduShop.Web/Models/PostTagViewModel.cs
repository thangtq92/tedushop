using System;

namespace TeduShop.Web.Models
{
    public class PostTagViewModel
    {
        public class PostTag
        {
            public int PostID { get; set; }

            public virtual PostViewModel Post { get; set; }

            public string TagID { get; set; }

            public virtual TagViewModel Tag { get; set; }
            public DateTime? CreatedDate { get; set; }

            public string CreatedBy { get; set; }

            public DateTime? UpdatedDate { get; set; }

            public string UpdateBy { get; set; }

            public string MetaKeyword { get; set; }

            public string MetaDescription { get; set; }

            public bool? Status { get; set; }
        }
    }
}
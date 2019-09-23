using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTedu.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        //Tiêu đề trang Seo
        string SeoPageTitle { set; get; }
        //chuyển sang Html url file
        string SeoAlias { set; get; } 

        string SeoKeywords { set; get; }

        string SeoDescription { set; get; }
    }
}

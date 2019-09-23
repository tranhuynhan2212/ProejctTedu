using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTedu.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguageID { set; get; }
    }
}

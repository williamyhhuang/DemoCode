using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode.DesignPattern.Adapter
{
    /// <summary>
    /// CatAdapterClassType
    /// </summary>
    public class CatAdapterClassType : Dog, ICat
    {
        /// <summary>
        /// 貓叫
        /// </summary>
        public void Meow()
        {
            this.Bark();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSample.Models
{
    public class ContentViewModel
    {
        public ContentViewModel()
        {
            Contents = new List<Content>();
        }
        /// <summary>
        /// 内容列表
        /// </summary>
        public List<Content> Contents { get; set; }
    }
}

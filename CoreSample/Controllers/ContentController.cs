using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CoreSample.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content content;
        public ContentController(IOptions<Content> option)
        {
            content = option.Value;
        }

        public IActionResult Index()
        {
            var contentView = new ContentViewModel();
            //for (int i = 1; i < 11; i++)
            //{
            //    var content = new Content
            //    {
            //        Id = i,
            //        title = $"{i}的标题",
            //        content = $"{i}的内容",
            //        status = 1,
            //        add_time = DateTime.Now.AddDays(-i)
            //    };
            //    contentView.Contents.Add(content);
            //}
            contentView.Contents.Add(content);
            return View(contentView);
        }
    }
}
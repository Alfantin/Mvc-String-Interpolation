using MvcSI.Models;
using System.Web.Mvc;

namespace MvcSI.Controllers {

    public class HomeController : Controller {

        private Db db = new Db();

        private ActionResult Layout(string body) {
            return Content($@"
                <html>
                    <head>
                        <title>String Interpolation View Engine</title>
                    </head>
                    <body>
                        {body}
                    </body>
                </html>
            ");
        }

        public ActionResult Index() {
            return Layout($@"
                <h1>People</h1>
                <ul>
                    {db.people.map(i =>
                        $"<li>{i.Name} / {i.Phone}</li>"
                    )}
                </ul>
            ");
        }
    }

}

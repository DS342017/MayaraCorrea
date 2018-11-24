using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebMVC1.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {

            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("Pedidos").Result;
            return View(response.Content.ReadAsAsync<IEnumerable<Models.PedidoMVC>>().Result);
        }


        public ActionResult AdicionarPedidos(int id = 0)
        {
            return View(new Models.PedidoMVC());
        }

        [HttpPost]
        public ActionResult AdicionarPedidos(Models.PedidoMVC Pedido)
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.PostAsJsonAsync("Pedidos", Pedido).Result;

            return RedirectToAction("Index");
        }

        public ActionResult EditarPedidos(int id = 0)
        {

            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("Pedidos/" + id.ToString()).Result;
            return View(response.Content.ReadAsAsync<Models.PedidoMVC>().Result);
        }
        [HttpPost]
        public ActionResult EditarPedidos(Models.PedidoMVC Pedido)
        {

            HttpResponseMessage response = GlobalVariable.WebApiClient.PutAsJsonAsync("Pedidos/" + Pedido.idPedido, Pedido).Result;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.DeleteAsync("Pedidos/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }


    }
}
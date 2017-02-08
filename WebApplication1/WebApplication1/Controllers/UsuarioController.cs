using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            UsuarioModel usuario = new UsuarioModel();
            usuario.id = 1;
            usuario.nombre = "Victor";
            usuario.apellido = "E.M";

            usuarios.Add(usuario);

            UsuarioModel usuario2 = new UsuarioModel();
            usuario2.id = 2;
            usuario2.nombre = "Isra";
            usuario2.apellido = "Sensei";

            usuarios.Add(usuario2);

            return View(usuarios);
        }
    }
}
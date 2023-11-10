using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Etapa_3.Models;


namespace Etapa_3.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cadastro c)
        {
            CadastroRepository cR = new CadastroRepository();
            cR.Cadastrar(c);
            ViewBag.Cadastrar = "Cadastro realizado com Sucesso! Faça o login!";
            return View();  
        }

        public IActionResult Deletar(int idcadastro)
        {
            if(HttpContext.Session.GetInt32("idcadastro") == null)
            {
                return RedirectToAction("Login", "Cadastro");
            }
            else
                {
                CadastroRepository cR = new CadastroRepository();
                cR.Deletar(idcadastro);
                return RedirectToAction("Listagem","Cadastro");
                }
        }

        public IActionResult Editar(int idcadastro)
        {
            CadastroRepository cR = new CadastroRepository();
            return View(cR.BuscaPorId(idcadastro));
        }

        [HttpPost]
        public IActionResult Editar(Cadastro c)
        {
            if(HttpContext.Session.GetInt32("idcadastro") == null)
            {
                return RedirectToAction("Login", "Cadastro");
            }
            else
            {
            CadastroRepository cR = new CadastroRepository();
            cR.Editar(c);
            ViewBag.Editar = "Cadastro atualizado com Sucesso!";
            return View();
            }
        }

        public IActionResult Listagem()
        {
            CadastroRepository cR = new CadastroRepository();
            return View(cR.Listar());
            
        }

        public IActionResult ListaFaleConosco()
        {
            FaleConoscoRepository fR = new FaleConoscoRepository();
            return View(fR.Listar());
            
        } 

        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
         public IActionResult Login(Cadastro c)
        {
            CadastroRepository cR = new CadastroRepository();
            Cadastro cadastroEncontrado = cR.VerificaLogin(c);

            if(cadastroEncontrado == null)
                {
                ViewBag.MensagemErro = "Falha no login, por favor, tente novamente.";
                return View();
                }
            
                HttpContext.Session.SetInt32("idcadastro", cadastroEncontrado.idcadastro);
                HttpContext.Session.SetString("nome", cadastroEncontrado.nome);

                return RedirectToAction ("Restrito","Cadastro");
            
            

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Cadastro");
        }
        
        public IActionResult Restrito()
        {
            
                return View();
                        
        }
    }
}
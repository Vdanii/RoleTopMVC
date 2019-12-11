using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enuns;
using RoleTopMVC.Repositorios;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class LoginController : AbstractController
    {

        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public IActionResult Index5(){
            
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                NomeView2 = "Nav1"
            });
        }

        public IActionResult Login(IFormCollection form)
        {

            try
            {
                System.Console.WriteLine("====================================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("====================================");

                var user = form["email"];
                var senha = form["senha"];

                var c = clienteRepositorio.ObterCliente(user);
                if (c != null)
                {
                    if (c.Senha.Equals(senha))
                    {
                        switch (c.TipoUsuario)
                        {
                            case (uint) TipoUsuario.CLIENTE:

                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, user);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, c.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, c.TipoUsuario.ToString());
                                return RedirectToAction("Index6", "Cliente"); 
                            
                            case (uint) TipoUsuario.ADMINISTRADOR:

                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, user);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, c.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, c.TipoUsuario.ToString());
                                return RedirectToAction("Dashboard", "Administrador");
                            
                            default :

                                return View("Erro");


                        }
                    }
                    else
                    {
                        return View("Erro", new MensagemViewModel("Senha Incorreta"){
                        
                            NomeView = "Login",
                            NomeView2 = "Nav1"


                });
                    }
                }
                else
                {
                    return View("Erro", new MensagemViewModel($"Usuario {user} não encontrado"){
                    
                    NomeView = "Login",

                });
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new MensagemViewModel("Falha em Logar"){
                    NomeView = "Login",

                });
                
            }
        }
    }
}
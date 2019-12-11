using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enuns;
using RoleTopMVC.Models;
using RoleTopMVC.Repositorios;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public IActionResult Index4()
        {
            
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                NomeView2 = "Nav1"
            });
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente();

                cliente.Nome = form["nome"];
                cliente.Email = form["email"];
                cliente.Senha = form["senha"];
                cliente.Telefone = form ["celular"];
                cliente.CPF = form["CPF ou CNPJ"];
                
                cliente.TipoUsuario = (uint) TipoUsuario.CLIENTE;
                clienteRepositorio.Inserir(cliente);

                string userEmail = cliente.Email;
                string userNome = cliente.Nome;
                string user = cliente.TipoUsuario.ToString(); 

                return View("Sucesso", new MensagemViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                    
                });
            } 
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new MensagemViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}
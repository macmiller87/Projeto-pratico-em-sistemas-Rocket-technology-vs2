using Cadastro_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_MVC.Controllers
{
    public class PessoaController1 : Controller
    {
        // GET: PessoaController1
        public ActionResult Index()
        { 
            // Criar uma refência para o PessoaModel //
            PessoaModel pModel = new PessoaModel();

            // Executar o método Listar() //
            return View(pModel.Listar());
        }

        // GET: PessoaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PessoaController1/Create
        [HttpGet]
        public ActionResult Create()
        {
            // A View agora está relacionada com o modelo //
            return View(new PessoaModel());
        }

        // POST: PessoaController1/Create
        // método que salva o formulário no Banco de Dados, e redireciona para a página Index ao submeter //
        [HttpPost]
        public ActionResult Create(PessoaModel pModel)
        {

            if (ModelState.IsValid) // Testa se o model (Anotação) é valida //
            {
                // método que salva o formulário no Banco de Dados, e redireciona para a página Index ao submeter //
                pModel.Salvar();
                return RedirectToAction("Index");
            }
            else
            {
                return View(pModel);
            }
        }

        // Este método apenas recupera o registro e mostra no formulario para alteração dos Dados //
        // GET: PessoaController1/Edit/5
        [HttpGet]
        public ActionResult Edit(int id) // Este parametro é o ID da pessoa ou PessoaID //
        {
            PessoaModel pModel = new PessoaModel();
            pModel.Editar(id);
            return View(pModel);
        }

        // Este método salva no Banco de Dados os dados alterados //
        // POST: PessoaController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaModel pModel)
        {
            pModel.Atualizar();
            return RedirectToAction("Index");
        }

        // Este método realiza a exclusão do registro, passando os dados para o Model PessoaModel //
        // GET: PessoaController1/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            PessoaModel pModel = new PessoaModel();
            pModel.Excluir(id);

            return RedirectToAction("Index");
        }

        // Alterar este código para excluir em 2 etapas, semelhante ao  EDITAR //
        // POST: PessoaController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

// CadastroFuncionarioService.cs
using System;
using System.Collections.Generic;
using SuaApp.Domain.Entities;

namespace SuaApp.Services
{
    public class CadastroFuncionarioService
    {
        private List<CadastroFuncionarioEntity> _funcionarios = new List<CadastroFuncionarioEntity>();

        public IEnumerable<CadastroFuncionarioEntity> GetAll()
        {
            return _funcionarios;
        }

        public CadastroFuncionarioEntity GetById(int id)
        {
            return _funcionarios.Find(funcionario => funcionario.Id == id);
        }

        public void Add(CadastroFuncionarioEntity funcionario)
        {
            funcionario.Id = _funcionarios.Count + 1;
            _funcionarios.Add(funcionario);
        }

        public bool IsValid(CadastroFuncionarioEntity funcionario)
        {

            return true;
        }
    }
}

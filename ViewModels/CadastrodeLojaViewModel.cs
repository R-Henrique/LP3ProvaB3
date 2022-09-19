using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstabelecimetoApsNetMvc.Models;



namespace MvcRazorViews.ViewModels;

public class CadastrodeLojaViewModel
{
    public int Id {get; set;}
    public int Piso {get; set;}
    public string Nome  {get; set;}
    public string Descricao {get; set;}
    public bool Tipo {get; set;}
    public string Email {get; set;}

 public CadastrodeLojaViewModel(
    int id, string nome, string descricao, string email, int piso , bool tipo  )
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Tipo = tipo;
        Email = email;
    
    }

}
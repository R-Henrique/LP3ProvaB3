using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

public class ListaLojaKiosqueController:Controller{
    private static List<CadastrodeLojaViewModel> lojas = new List<CadastrodeLojaViewModel>
    {
        new CadastrodeLojaViewModel(1, "tenis@gmail.com","Tenis Brasil" ,"Aqui você encontra os tênis" ,"loja", 3 , true ),
        new CadastrodeLojaViewModel(2, "lem@email.com","Lembranças já","vem comprar sua lembrança","kiosque",3, true ),
        new CadastrodeLojaViewModel(3, "sorvet@gmail.com","Sorvetinho gelado" ,"sorvete gelado de qualidade", "kiosque", 1, true),
        new CadastrodeLojaViewModel(4, "adidas@outlook.com","Adidas","os melhores tênis aqui", "loja" , 2, false ),
        new CadastrodeLojaViewModel(5, "atacadoa@gmail.com", "Atacado","os melhores preços aqui", "loja",3,true )

    };

    public IActionResult Index()
    {
        return (lojas);
    }
    public IActionResult Show(int id )
    {
        return View(lojas[id-1]);
    }

}
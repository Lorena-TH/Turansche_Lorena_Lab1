using System.Drawing;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Turansche_Lorena_Lab1.Controllers
{
    public class ProbaController : Controller
    {
        // o metoda cu denumirea Index care va returna un string reprezentand un mesaj de bun venit dat utilizatorului
        public string Index()  
        {
            return "This is my default action...";
        }



       // O metoda cu o alta denumire specificata de fiecare student care va returna un string reprezentand un salut dat utilizatorului
       //public string Welcome()
       //{
       //    return "This is the Welcome action method...";
       // }



        // O metoda cu o denumire specificata de fiecare student care va avea un parametru de tip
        // string si un parametru de tip intreg ale caror valori vor fi afisate utilizatorului impreuna cu
        // un mesaj
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}

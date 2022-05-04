using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var song = GetSong();
            ViewBag.MainTitle = "My favorite song";
            return View(song);
        }

        private SongModel GetSong()
        {
            SongModel song = new SongModel
            {
                Name = "EL MAKINON",
                Genre = "Latin",
                Album = "KG0516",
                ReleasedDate = new DateTime(2021, 03, 25),
                Lyrics = "Ando por ahi\nCon los de siempre, un flow cabron\nDando vuelta en un maquinon\nCristales G5 en un capsulon (en un capsulon)\nY desde que sali (desde que sali)\nTodos quieren repetir (todos quieren repetir)\nPero ando en otra, baby, ya me fui\nY ahora ando por ahi\nCon los de siempre, un flow cabron\nDando vuelta en un maquinon\nCristales G5 en un capsulon (en un capsulon)\nY ando por ahi\nCon los de siempre, un flow cabron (eh eh eh)\nDando vuelta en un maquinon (ah)\nCristales G5 en un capsulon (Mariah, baby)\nY la guagua esta G5\nBaby, pa adentro no se ve\nPodemos bellaquear, tambien podemos prender\nYo te quiero esposar como si fuera un cuartel\nUn Airbnb o nos vamos pa un hotel\nDonde quiera te como (como)\nPa escaparnos tu dime como (uy)\nDime si somos o no somos, a ninguno perdono\nEste booty se va y eso es sin darle promo\nHasta abajo desde los dieciseis\nDesde chamaquita rompiendo la ley (Rompiendo la ley)\nEl DM explotando, pero es que no hay break\nNos comimos hoy, manana replay (ah ah)\nHasta abajo desde los dieciseis\nDesde chamaquita rompiendo la ley\nEl DM explotando, pero es que no hay break (uy)\nNos comimos hoy, manana replay (ahora no hay break, papi)\nY ando por ahi\nCon los de siempre, un flow cabron\nDando vuelta en un maquinon\nCristales G5 en un capsulon (en un capsulon)\nAndo por ahi\nCon los de siempre, un flow cabron (ah ah)\nDando vuelta en un maquinon (ah, ey)\nCristales G5 en un capsulon (en un capsulon)\nMe aburri de la Jeepeta y saque un maquinon\nQue cuando lo acelero sienten la presion\nBellaquita de profesion (-ion), puesta pal problemon (-on)\nMis diablas andan todas de mision\nAndo en un Lamborghini que en la alfombra dice Diablo\nPa arriba la puerta si la abro\nBaby, comparame con la que sea, yo la parto (ey)\nMi hijo va a ser millonario desde el parto (wuh)\nDe mis babies ninguna le baja\nLas Jordans nueva de caja\nY la cuenta nadie me la paga (no)\nTe gustan como yo, no te hagas (ven y dale, ey)\nHasta abajo desde los dieciseis\nDesde chamaquita rompiendo la ley (rompiendo la ley)\nMe tiran, pero es que no hay break\nNos conocimos hoy, manana replay (ah ah)\nHasta abajo desde los dieciseis\nDesde chamaquita rompiendo la ley\nEl DM explotando, pero es que no hay break (uy)\nNos comimos hoy, manana replay (ahora no hay break, papi)\nLa verdadera bichota, papi\nJaja, y la toxica\nYa tu sabes (mmm)\nKarol G\nCon Mariah (ah, yeh, un capsulon)\nEy (Ahora no hay break, papi)\nCuidao\nQue venimos por ahi (mmm, ja)\nCon un flow bien cabron (papi)\n(It's Mariah, babe\nMariah Angeliq\nNo)"
            };

            return song;
        }
    }
}

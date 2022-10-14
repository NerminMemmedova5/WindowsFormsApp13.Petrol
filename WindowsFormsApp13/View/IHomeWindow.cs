using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp13.Model;

namespace WindowsFormsApp13.View
{
    public interface IHomeWindow
    {
        EventHandler<EventArgs> WindowLoad { get; set; }
        EventHandler<EventArgs> PetrolChangeClicked { get; set; }
        EventHandler<EventArgs> MoneyChangeClicked { get; set; }
        EventHandler<EventArgs> LiterChangeClicked { get; set; }
       
        EventHandler<EventArgs> CheckClicked { get; set; }
        EventHandler<EventArgs> LoadClicked { get; set; }
        EventHandler<EventArgs> PriceChanged { get;set; }
        EventHandler<EventArgs> LiterChanged { get;set; }
        List<Petrol> Petrols { set; }
        List<Check>Checks { set; }
        string PriceText { get; set; }
        string MoneyText { get; set; }
        string LiterText { get; set; }
        string SumPrice { get; set; }

        bool SetEnableMoney { get; set; }
        bool SetEnableLiter { get; set; }

    }
}

using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp13.Data;
using WindowsFormsApp13.Model;
using WindowsFormsApp13.View;

namespace WindowsFormsApp13.Presenter
{
    public class HomePresenter
    {
        private readonly PetrolContext _db;
        private IHomeWindow _view;


        public HomePresenter(IHomeWindow view)
        {
            _view = view;
            _db = new PetrolContext();

            var count = _db.Petrols.Count();
            if (count == 0)
            {
                _db.Petrols.AddRange(new List<Petrol>
                {
                    new Petrol
                    {
                        Name="A-92",
                        Price=1,
                    },
                    new Petrol
                    {
                        Name="A-95",
                        Price=2,
                    },
                    new Petrol
                    {
                        Name="A-98",
                        Price=2.30,
                    },
                    new Petrol
                    {
                        Name="Dizel",
                        Price=0.80,
                    },
                });
                _db.SaveChanges();
            }

            _view.WindowLoad += WindowLoad;
            _view.PetrolChangeClicked += PetrolChangeClicked;
            _view.PetrolChangeClicked += ViewLiterChanged;
            _view.MoneyChangeClicked += MoneyChangeClicked;
            _view.LiterChangeClicked += LiterChangeClicked;

            _view.CheckClicked += CheckClicked;
            _view.LoadClicked += LoadClicked;

            _view.LiterChanged += ViewLiterChanged;
            _view.PriceChanged += ViewPriceChanged;
        }

        private void ViewLiterChanged(object sender, EventArgs e)
        {
            try
            {

                var total = Convert.ToDouble(_view.LiterText) * Convert.ToDouble(_view.PriceText);

                _view.SumPrice = total.ToString();
            }
            catch
            {
            }
        }
        private void ViewPriceChanged(object sender, EventArgs e)
        {

            _view.SumPrice = _view.MoneyText;
        }
        private void WindowLoad(object sender, EventArgs e)
        {
            _view.Petrols = _db.Petrols.ToList();
        }
        public Petrol SelectedPetrol { get; set; }
        private void PetrolChangeClicked(object sender, EventArgs e)
        {
            SelectedPetrol = (sender as ComboBox).SelectedItem as Petrol;

            _view.PriceText = SelectedPetrol.Price.ToString();
        }
        private void MoneyChangeClicked(object sender, EventArgs e)
        {
            _view.SetEnableMoney = !_view.SetEnableMoney;
        }
        private void LiterChangeClicked(object sender, EventArgs e)
        {
            _view.SetEnableLiter = !_view.SetEnableLiter;
        }
        private void CheckClicked(object sender, EventArgs e)
        {
            var check = new Check
            {
                PetrolName = SelectedPetrol.Name,
                TotalLiter = Convert.ToDouble(_view.LiterText),
                Payment = Convert.ToDouble(_view.SumPrice)
            };
            _db.Checks.Add(check);
            _db.SaveChanges();
            MessageBox.Show("Check Ugurla Elave Olundu");


        }
        private void LoadClicked(object sender, EventArgs e)
        {
            var checks = _db.Checks.ToList();
            _view.Checks = checks;
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp13.Model;

namespace WindowsFormsApp13.View
{
    public partial class HomeWindow : Form,IHomeWindow
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> WindowLoad { get; set; }
        public EventHandler<EventArgs> PetrolChangeClicked { get; set; }
        public EventHandler<EventArgs> MoneyChangeClicked { get; set; }
        public EventHandler<EventArgs> LiterChangeClicked { get; set; }
       
        public EventHandler<EventArgs> CheckClicked { get; set; }
       public EventHandler<EventArgs> LoadClicked { get; set; }
        public List<Petrol> Petrols { set {

                petrolComboB.DataSource = null;
                petrolComboB.DataSource = value;
            } }
        public List<Check> Checks { set {

                checkListB.DataSource = null;
                checkListB.DataSource = value;
            } }
        public string PriceText { get =>priceTxtB.Text; set=>priceTxtB.Text=value ; }
        public string MoneyText { get => moneyTxtB.Text; set => moneyTxtB.Text=value; }
        public string LiterText { get => literTxtB.Text; set => literTxtB.Text=value; }
        public string SumPrice { get => sumpriceTxtB.Text; set => sumpriceTxtB.Text=value; }
        public bool SetEnableMoney { get => moneyTxtB.Enabled; set => moneyTxtB.Enabled=value; }
        public bool SetEnableLiter { get => literTxtB.Enabled; set => literTxtB.Enabled=value; }
        public EventHandler<EventArgs> PriceChanged { get; set; }
        public EventHandler<EventArgs> LiterChanged { get; set; }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            WindowLoad.Invoke(sender, e);
        }
        private void petrolComboB_SelectedIndexChanged(object sender, EventArgs e)
        {
            PetrolChangeClicked.Invoke(sender, e);
        }

        private void moneyRadioB_CheckedChanged(object sender, EventArgs e)
        {
            LiterChangeClicked.Invoke(sender, e);
        }

        private void literRadioB_CheckedChanged(object sender, EventArgs e)
        {
            MoneyChangeClicked.Invoke(sender, e);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            CheckClicked.Invoke(sender, e);
        }


       public void CalculatorInOil(double price)
        {
            var petrol = petrolComboB.SelectedItem as Petrol;
            sumpriceTxtB.Text = moneyTxtB.Text;
            try
            {
                if (moneyTxtB.Enabled)
                {
                    literTxtB.Text = (int.Parse(moneyTxtB.Text) / price).ToString();
                }
                else
                {
                    moneyTxtB.Text = (int.Parse(literTxtB.Text) / price).ToString();
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadClicked.Invoke(sender, e);
        }

        private void moneyTxtB_TextChanged(object sender, EventArgs e)
        {
            PriceChanged.Invoke(sender, e);
        }

        private void literTxtB_TextChanged(object sender, EventArgs e)
        {

            LiterChanged.Invoke(sender, e);
        }
    }
}

using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShopTest : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendersBinding = new BindingSource();
        private decimal storeProfit = 0;
        public ConsignmentShopTest()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource= store.Items.Where(x => x.Sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendersBinding.DataSource = store.Venders;
            venderListbox.DataSource = vendersBinding;

            venderListbox.DisplayMember = "Display";
            venderListbox.ValueMember = "Display";
        }

        private void ConsignmentShopTest_Load(object sender, EventArgs e)
        {

        }
        private void SetupData()
        {

            store.Venders.Add(new Vender { FirstName = "Martin", LastName = "Lester" });
            store.Venders.Add(new Vender { FirstName = "Neil", LastName = "Wallace" });
            store.Items.Add(new Item
            {
                Title = "Flowers in the Attic",
                Description = "A book about kids growing up in an attic.",
                Price = 3.99M,
                Owner = store.Venders[0]
            });
            store.Items.Add(new Item
            {
                Title = "Wizard of Oz",
                Description = "A book about a magic land",
                Price = 4.50M,
                Owner = store.Venders[1]
            });
            store.Items.Add(new Item
            {
                Title = "Harry Potter",
                Description = "A book about Wizards.",
                Price = 2.20M,
                Owner = store.Venders[0]
            });
            store.Items.Add(new Item
            {
                Title = "Secret Garden",
                Description = "A book about a garden, dugh.",
                Price = 3.50M,
                Owner = store.Venders[0]
            });
            store.Name = "Last Book Store";
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            // figure out what is selected from item list
            // copy that to shopping list
            // do we remove from item list? im gonna say no atm
            Item selectedItem = (Item)itemsListbox.SelectedItem;

            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);
        }

        private void makePurchaseButton_Click(object sender, EventArgs e)
        {
            // Mark each item in cart as sold
            // clear the cart

            foreach (Item item in shoppingCartData)
            {
                item.Sold= true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1-(decimal)item.Owner.Commission) * item.Price;
            }
            shoppingCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("£{0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendersBinding.ResetBindings(false);
        }
    }
}

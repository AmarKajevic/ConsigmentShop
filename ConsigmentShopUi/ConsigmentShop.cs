using ConsigmentShopLibrary;

namespace ConsigmentShopUi
{
    public partial class ConsigmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource CartBinding = new BindingSource();
        BindingSource vendorsbinding = new BindingSource();
        private decimal storeProfit = 0;
        public ConsigmentShop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            ItemsListbox.DataSource = itemsBinding;

            ItemsListbox.DisplayMember = "Display";
            ItemsListbox.ValueMember = "Display";

            CartBinding.DataSource = shoppingCartData;
            ShoppingCartListbox.DataSource = CartBinding;

            ShoppingCartListbox.DisplayMember = "Display";
            ShoppingCartListbox.ValueMember = "Display";

            vendorsbinding.DataSource = store.Vendors;
            VendorlistBox.DataSource = vendorsbinding;

            VendorlistBox.DisplayMember = "Display";
            VendorlistBox.ValueMember = "Display";

        }
        private void SetupData()
        {
            

            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby dick",
                Description = "a book about whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "A Tale of two Cities",
                Description = "a book about revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Harry Potter",
                Description = "a book about a boy",
                Price = 5.20M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "a book about girl",
                Price = 1.50M,
                Owner = store.Vendors[0]
            });
            store.Name = "Seconds are better";

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {

            Item selectedItem = (Item)ItemsListbox.SelectedItem;

            shoppingCartData.Add(selectedItem);

            CartBinding.ResetBindings(false);
        }

        private void Makepurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
                
            }
            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            StoreProfitValue.Text = String.Format("${0}", storeProfit);



            CartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsbinding.ResetBindings(false);
        }
    }
}
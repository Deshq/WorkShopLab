using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WorkShop_Nikiforov.Classes;
using System.Collections.Generic;

namespace WorkShop_Nikiforov
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            this.StyleManager = msmMain;            

            msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;

            Loader.LoadRecipeFromTxt(WorkShop.Recipes);
            foreach (Recipe R in WorkShop.Recipes)
            {
                ComboBoxCakes.Items.Add(R.Name);
            }

            Loader.LoadProductsToMaterialsFromTxt(WorkShop.MaterialsInStorage);                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxQuantity.Text = "1";
  
        }
        
        private void TrackBarQuantity_Scroll(object sender, ScrollEventArgs e)
        {
            TextBoxQuantity.Text = TrackBarQuantity.Value.ToString();
        }

        private void TrackBarQuantity_Scroll_1(object sender, ScrollEventArgs e)
        {
            TextBoxQuantity.Text = TrackBarQuantity.Value.ToString();
        }
             
        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
             
        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void TrackBarQuantity_Scroll_2(object sender, ScrollEventArgs e)
        {
            TextBoxQuantity.Text = TrackBarQuantity.Value.ToString();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void TileAddOrder_Click(object sender, EventArgs e)
        {
             bool OnlyNumbers = TextBoxQuantity.Text.Any(x => !char.IsLetter(x));
            if (OnlyNumbers)
            {
                if (ComboBoxCakes.SelectedItem != null)
                {

                    string SelectedCake = ComboBoxCakes.SelectedItem.ToString();
                    foreach (Recipe R in WorkShop.Recipes)
                    {
                        if (SelectedCake == R.Name)
                        {
                            Order OrderN = new Order(SelectedCake, Convert.ToInt32(TextBoxQuantity.Text), R);
                            WorkShop.Orders.Add(OrderN);
                        }
                    }                    
                }
            }

        }

        private void TileCompute_Click(object sender, EventArgs e)
        {
            Order.GenBasketOfProd(WorkShop.Orders);
            if (Order.AvailabilityMaterials(WorkShop.MaterialsInStorage))
            {
                MetroFramework.MetroMessageBox.Show(this, Order.CostСalculation(Order.Basket), "Total price: " + Order.CostСalculation(WorkShop.MaterialsInStorage).ToString() + "$", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else

            {
                MetroFramework.MetroMessageBox.Show(this, Order.CostСalculation(Order.Basket), "Lack of products, estimated price: " + Order.CostСalculation(WorkShop.MaterialsInStorage).ToString() + "$", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Order.Clear();

        }

        private void TileClearOrders_Click(object sender, EventArgs e)
        {
            WorkShop.Orders.Clear();
        }
       
        private void TileClearRecipes_Click(object sender, EventArgs e)
        {
            WorkShop.Recipes.Clear();
            ComboBoxCakes.Items.Clear();
        }

        private void metroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void MetroContextMenu2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (msmMain.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
                msmMain.Theme = MetroFramework.MetroThemeStyle.Light;               
            }
            else
            {
                metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
                msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;                
            }
        }
    }
}

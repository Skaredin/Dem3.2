using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddem3._2
{
    public partial class Produkt : Form
    {
        public Produkt()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem3SkaredinDataSet.Product". При необходимости она может быть перемещена или удалена.
                this.productTableAdapter.Fill(this.___Dem3SkaredinDataSet.Product);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.___Dem3SkaredinDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

   

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.___Dem3SkaredinDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         

        }
        private void RedaktirovanieToIsmenenieBUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            RedaktirovanieToIsmenenie redaktirovanieToIsmenenie = new RedaktirovanieToIsmenenie();
            redaktirovanieToIsmenenie.Show();
           
        }
    }
}

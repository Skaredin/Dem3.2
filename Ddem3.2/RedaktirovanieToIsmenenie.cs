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
    public partial class RedaktirovanieToIsmenenie : Form
    {
        public RedaktirovanieToIsmenenie()
        {
            InitializeComponent();
        }
        private void Photo()
        {
            try
            {
                ImagePB.Image = Image.FromFile(mainImagePathComboBox.Text.Replace(@" ",@""));
            }
            catch (Exception)
            {

              
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

        private void RedaktirovanieToIsmenenie_Load(object sender, EventArgs e)
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

        private void LeftBUT_Click(object sender, EventArgs e)
        {
            if (mainImagePathComboBox.Text != "") { Photo(); }
            productBindingSource.MovePrevious();
        }

        private void mainImagePathComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RigihtBUT_Click(object sender, EventArgs e)
        {
            if (mainImagePathComboBox.Text != "") { Photo(); }
            productBindingSource.MoveNext();
        }

        private void SaveBUT_Click(object sender, EventArgs e)
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

        private void DobavlenieBUT_Click(object sender, EventArgs e)
        {
            productBindingSource.AddNew();
            
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите добавить данные?", "Сохранение", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Validate();
                    this.productBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.___Dem3SkaredinDataSet);
                    this.Hide();
                    Produkt produkt = new Produkt();
                    produkt.Show();
                }
                else {
                    this.Hide();
                    Produkt produkt = new Produkt();
                    produkt.Show();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

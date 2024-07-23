using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DrinkMachine
{
    public partial class txtPrice : Form
    {
        XmlDocument xmlDocument = new XmlDocument();
        string pathName = Directory.GetCurrentDirectory() + "\\drinkDate.xml";
        public txtPrice()
        {
            InitializeComponent();
            LoadXmlOnInit();         
            ShowAllDrinks();
        }

        private void LoadXmlOnInit()
        {
            if (File.Exists(pathName))
            {
                try
                {
                    xmlDocument.Load(pathName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter loading XML file: " + ex.Message);
                }
            }
            else
            {
                XmlNode root = xmlDocument.CreateElement("Drinks");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(pathName);
            }
        }


        private void createDrink()
        {
            XmlNode Drink = xmlDocument.CreateElement("Drink");
            xmlDocument.FirstChild.AppendChild(Drink);
            Drink.AppendChild(xmlDocument.CreateElement("Name")).InnerText = txtNewDrink.Text;
            Drink.AppendChild(xmlDocument.CreateElement("Sugar")).InnerText = cmbSuger.Text;
            Drink.AppendChild(xmlDocument.CreateElement("Coffee")).InnerText = cmbCoffee.Text;
            Drink.AppendChild(xmlDocument.CreateElement("Cocoa")).InnerText = cmbCocoa.Text;
            Drink.AppendChild(xmlDocument.CreateElement("Milk")).InnerText = cmbMilk.Text;
            Drink.AppendChild(xmlDocument.CreateElement("Price")).InnerText = textBox1.Text;
        }
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            createDrink();
        }

        private void clearingFields()
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is ComboBox || ctr is TextBox)
                {
                    ctr.Text = string.Empty;    
                }
            }
            textBox1.Text = "0";   
        }

        private void btnKeeping_Click(object sender, EventArgs e)
        {
            xmlDocument.Save(pathName);
            ShowAllDrinks();
            clearingFields();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) + 0.5).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = (double.Parse(textBox1.Text) - 0.5).ToString();
            }
        }

        private void ShowAllDrinks()
        {
            dgvDrinkTable.Rows.Clear();
            foreach (XmlNode Drink in xmlDocument.FirstChild.ChildNodes)
            {
                string name = "", suger = "", coffee = "", cacau = "", milk = "", price = "";

                foreach (XmlNode node in Drink.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "Name":
                            name = node.InnerText;
                            break;
                        case "Sugar":
                            suger = node.InnerText;
                            break;
                        case "Coffee":
                            coffee = node.InnerText;
                            break;
                        case "Cocoa":
                            cacau = node.InnerText;
                            break;
                        case "Milk":
                            milk = node.InnerText;
                            break;
                        case "Price":
                            price = node.InnerText;
                            break;
                            default:
                            break;
                    }
                }
                dgvDrinkTable.Rows.Add(name, suger, coffee, cacau, milk, price);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (XmlNode Drink in xmlDocument.FirstChild.ChildNodes)
            {
                if (Drink.SelectSingleNode("Name").InnerText == txtNewDrink.Text)
                {
                    Drink.SelectSingleNode("Sugar").InnerText = cmbSuger.Text;
                    Drink.SelectSingleNode("Coffee").InnerText = cmbCoffee.Text;
                    Drink.SelectSingleNode("Cocoa").InnerText = cmbCocoa.Text;
                    Drink.SelectSingleNode("Milk").InnerText = cmbMilk.Text;
                    Drink.SelectSingleNode("Price").InnerText = textBox1.Text;

                    ShowAllDrinks();
                    MessageBox.Show("עודכן בהצלחה, כעת יש לעשות שמירה");

                }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (XmlNode Drink in xmlDocument.FirstChild.ChildNodes)
            {
                if (Drink.SelectSingleNode("Name").InnerText == txtNewDrink.Text)
                {
                    xmlDocument.FirstChild.RemoveChild(Drink);
                    ShowAllDrinks();
                }

            }
        }
    }
}

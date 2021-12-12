using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private const int MAX = 5;
        private Person[] arrPerson = new Person[MAX];
        private int zaehler = 0;
        public Form1()
        {
            
            InitializeComponent();
            actAnzahl();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            arrPerson[zaehler] = new Person(tbVname.Text, tbNname.Text, tbEmail.Text);
            libPerson.Items.Add(string.Format("{0} {1} {2}", tbVname.Text, tbNname.Text, tbEmail.Text)); // mit string.format() string bauen, weil Add() nur ein arg erwartet
            zaehler++;
            actAnzahl();
            clearBoxes();
            tbVname.Focus(); // setzt cursor in das eingabefeld nachdem abgesendet wurde
            
            if(zaehler >= MAX)
            {
                btSave.Enabled = false;
            }
        }

        private void clearBoxes()
        {
            tbVname.Clear();
            tbNname.Clear();
            tbEmail.Clear();
        }

        private void actAnzahl()
        {
            
            label1.Text = string.Format("Personandaten {0}/{1}", zaehler, MAX);
            progBCount.Value = zaehler;

        }

        private void libPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillBoxes(libPerson.SelectedIndex);
        }

        private void fillBoxes(int selectedIndex)
        {
            if(selectedIndex != -1) // ist false wenn kein Eintrag in der Liste markiert ist
            {
                tbVname.Text = arrPerson[selectedIndex].Vorname;
                tbNname.Text = arrPerson[selectedIndex].Nachname;
                tbEmail.Text = arrPerson[selectedIndex].Email;
            }
            
        }
    }
}

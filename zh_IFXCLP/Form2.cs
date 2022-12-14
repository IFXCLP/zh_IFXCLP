using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh_IFXCLP.Models;

namespace zh_IFXCLP
{
    public partial class Form2 : Form
    {
        jatekosContext context = new jatekosContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            posztszures();
        }

        private void textposzt_TextChanged(object sender, EventArgs e)
        {
            posztszures();
        }

        private void posztszures()
        {
            var post = from x in context.Posztoks
                       where x.Poszt.Contains(textposzt.Text)
                       select x;
            listposzt.DataSource = post.ToList();
            listposzt.DisplayMember = "Poszt";
        }

        private void listposzt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedjatekos2 = (Posztok)listposzt.SelectedValue;
            var jatekosok2 = from x in context.Jatekosoks
                            where x.PosztId == selectedjatekos2.PosztId
                            select new sargadetail
                            {
                                sargalap = x.Sarga
                            };
            listjatekos2.DataSource = jatekosok2.ToList();
            listjatekos2.DisplayMember = "sargalap";
        }
    }
}

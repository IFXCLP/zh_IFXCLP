using zh_IFXCLP.Models;

namespace zh_IFXCLP
{
    public partial class Form1 : Form
    {
        jatekosContext context = new jatekosContext();
        public Form1()
        {
            InitializeComponent();

        }

        private void textnemzetiseg_TextChanged(object sender, EventArgs e)
        {
            orszagszures();
        }

        private void orszagszures()
        {
            var orszag = from x in context.Nemzetisegeks
                         where x.Nemzetiseg.Contains(textnemzetiseg.Text)
                         select x;

            listnemzetiseg.DataSource = orszag.ToList();
            listnemzetiseg.DisplayMember = "Nemzetiseg";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orszagszures();
        }

        private void listnemzetiseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            listnemzetisegek();
        }

        private void listnemzetisegek()
        {
            var selectedjatekos = (Nemzetisegek)listnemzetiseg.SelectedValue;
            var jatekosok = from x in context.Jatekosoks
                            where x.NemzetisegId == selectedjatekos.NemzetisegId
                            select new sargadetail
                            {
                                sargalap = x.Sarga
                            };
            listjatekos.DataSource = jatekosok.ToList();
            listjatekos.DisplayMember = "sargalap";
        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            var selectedsarga = (sargadetail)listjatekos.SelectedItem;
            var sargatobedeleted = (from x in context.Jatekosoks
                                    where x.Sarga == selectedsarga.sargalap
                                    select x).FirstOrDefault();
            context.Jatekosoks.Remove(sargatobedeleted);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            listnemzetisegek();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan kilép?","igen/nem",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
    public class sargadetail
    {
        public int sargalap { get; set; }
    }
}
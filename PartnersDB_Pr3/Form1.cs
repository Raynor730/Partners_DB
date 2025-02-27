using PartnersDB_Pr3.Models;

namespace PartnersDB_Pr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            using (PartnersContext db = new PartnersContext())
            {
                var partners = db.Partners.ToList();

                foreach (Partner partner in partners)
                {
                    labelPartners.Text = $"{partner.Id}.{partner.IdTypeOfPartner}.{partner.NamePartner}.{partner.LegalAddres}.{partner.Inn}.{partner.DirectorFullName}.{partner.Phone}.{partner.Email}.{partner.Rating}";
                }
            }
        }
    }
}

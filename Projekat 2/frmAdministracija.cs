using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_2
{
    public partial class frmAdministracija : Form
    {
        BazaProjektaDataSet ds = new BazaProjektaDataSet();
        BazaProjektaDataSetTableAdapters.KategorijaTableAdapter kategorijaAdapter = new BazaProjektaDataSetTableAdapters.KategorijaTableAdapter();
        BazaProjektaDataSetTableAdapters.ProizvodTableAdapter proizvodAdapter = new BazaProjektaDataSetTableAdapters.ProizvodTableAdapter();
        BazaProjektaDataSetTableAdapters.RacunTableAdapter racunAdapter = new BazaProjektaDataSetTableAdapters.RacunTableAdapter();
        BazaProjektaDataSetTableAdapters.StatistikaTableAdapter statistikaAdapter = new BazaProjektaDataSetTableAdapters.StatistikaTableAdapter();

        List<klArtikal> Artikli = new List<klArtikal>();

        DateTime dt = new DateTime(2021, 08, 06);
        Rectangle rect = new Rectangle(882, 360, 178, 178);

        public frmAdministracija()
        {
            InitializeComponent();
            kategorijaAdapter.Fill(ds.Kategorija);
            proizvodAdapter.Fill(ds.Proizvod);
            racunAdapter.Fill(ds.Racun);
            statistikaAdapter.Fill(ds.Statistika);

            var topLeftHeaderCell = dtgProizvod.TopLeftHeaderCell;
            var topLeftHeaderCell1 = dtgRacun.TopLeftHeaderCell;
            dtgProizvod.DataSource = ds.Proizvod;
            cmbKategorija.DataSource = ds.Kategorija;
            cmbKategorija.DisplayMember = "ime_kategorije";
            cmbKategorija.SelectedIndex = -1;

            dtpPocetni.MinDate = dt;
            dtpPocetni.MaxDate = DateTime.Today;
            dtpKrajnji.MinDate = dt;
            dtpKrajnji.MaxDate = DateTime.Today;
            dtpPocetni.Value = dt;
            dtpKrajnji.Value = DateTime.Today;
        }

        private void crtajLiniju(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 700, 50, 700, this.ClientSize.Height - 18);
        }

        private void Dodaj(object sender, EventArgs e)
        {
            double a;
            if (txtDodajNaziv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli naziv artikla!!!");
            }
            else if (txtDodajCenu.Text.Trim().Length == 0 || !double.TryParse(txtDodajCenu.Text, out a))
            {
                MessageBox.Show("Niste uneli cenu artikla ili ste uneli slovo u polje za cenu!!!");
            }
            else if (cmbKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Niste izabrali kategoriju!!!");
                return;
            }
            else
            {
                BazaProjektaDataSet.ProizvodRow Red = ds.Proizvod.NewProizvodRow();
                Red.id_kategorije = cmbKategorija.SelectedIndex + 1;
                Red.naziv = txtDodajNaziv.Text;
                Red.cena = double.Parse(txtDodajCenu.Text);
                ds.Proizvod.AddProizvodRow(Red);
                MessageBox.Show("Uspešno ste dodali proizvod.");
                proizvodAdapter.Update(ds.Proizvod);
                dtgProizvod.DataSource = ds.Proizvod;
                cmbKategorija.SelectedIndex = -1;
                txtDodajCenu.Clear();
                txtDodajNaziv.Clear();
            }
            ObrisiSelekciju();
        }



        private void Pretraga(object sender, EventArgs e)
        {
            if (dtpPocetni.Value.Date > dtpKrajnji.Value.Date)
            {
                MessageBox.Show("Početni datum ne može biti veći od krajnjeg!!!");
                dtpPocetni.Value = dt;
                dtpKrajnji.Value = DateTime.Today.Date;
            }
            else
            {
                var d = from r in ds.Racun
                        where r.datum_kupovine >= dtpPocetni.Value && r.datum_kupovine <= dtpKrajnji.Value
                        select r;

                if (d.Any())
                    dtgRacun.DataSource = d.CopyToDataTable();
                else
                {
                    MessageBox.Show("Ne postoje kupovine u zadatom opsegu!!!");
                    dtgRacun.DataSource = null;
                }
            }
            ObrisiSelekciju();
        }

        private void Prodaja(object sender, EventArgs e)
        {
            DialogResult izlaz = MessageBox.Show("Da li želite da pređete u deo namenjen za prodaju?", "Prodaja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (izlaz == DialogResult.Yes)
            {
                frmProdaja pr = new frmProdaja();
                this.Hide();
                pr.ShowDialog();
                this.Close();
            }
        }

        private void Pocetni(object sender, EventArgs e)
        {
            DialogResult izlaz = MessageBox.Show("Da li želite da pređete u početni program?", "Log", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (izlaz == DialogResult.Yes)
            {
                frmLog lg = new frmLog();
                this.Hide();
                lg.ShowDialog();
                this.Close();
            }
        }

        private void Izlaz(object sender, EventArgs e)
        {
            DialogResult izlaz = MessageBox.Show("Da li želite da ugasite program?", "Gašenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (izlaz == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Kontakt(object sender, EventArgs e)
        {
            MessageBox.Show("Email administratora: igornrt3619@gs.viser.edu.rs", "Kontakt");
        }

        private void Pomoc(object sender, EventArgs e)
        {
            frmPomoc pom = new frmPomoc();
            pom.ShowDialog();
        }

        private void Obrisi(object sender, EventArgs e)
        {
            foreach (DataGridViewCell celija in dtgProizvod.SelectedCells)
            {
                if (celija.Selected)
                {
                    MessageBox.Show("Proizvod uspešno obrisan.");
                    dtgProizvod.Rows.RemoveAt(celija.RowIndex);
                    proizvodAdapter.Update(ds.Proizvod);
                }
            }
            ObrisiSelekciju();
        }
        bool crtanje = false;
        private void Pogledaj(object sender, EventArgs e)
        {
            Artikli = new List<klArtikal>();

            var mesec = from s in ds.Statistika
                        where s.datum.Month == dtpMesec.Value.Month
                        select s;

            int brArtikala = 0;
            if (mesec.Count() != 0)
            {
                foreach (var redM in mesec)
                {
                    brArtikala += redM.kolicina;
                }
                foreach (var redM in mesec)
                {
                    bool ima = false;
                    int kolicina = 0;
                    var naziv = from p in ds.Proizvod
                                where p.id_proizvoda == redM.id_proizvoda
                                select p.naziv;

                    foreach (var redS in ds.Statistika)
                    {
                        if (redM.id_proizvoda == redS.id_proizvoda && redM.datum.Month == dtpMesec.Value.Month)
                            kolicina += redS.kolicina;
                    }

                    var id_proizvoda = from st in ds.Statistika
                                       where st.id_proizvoda == redM.id_proizvoda
                                       select st.id_proizvoda;

                    foreach (klArtikal artikal in Artikli)
                    {
                        if (artikal.Id == id_proizvoda.First())
                        {
                            ima = true;
                        }
                    }
                    double procenat = Math.Round(((double)kolicina / brArtikala) * 100.0, 2);
                    if (ima == false)
                        Artikli.Add(new klArtikal(naziv.First(), id_proizvoda.First(), kolicina, procenat));

                }
                lbStatistika.DataSource = Artikli;
                ObrisiSelekciju();
                lbStatistika.Visible = true;
                crtanje = true;
                this.Paint += crtaj;
                Refresh();
            }
            else
            {
                crtanje = false;
                MessageBox.Show("U zadatom mesecu nema prodaje!!!");
                lbStatistika.Visible = false;
                this.Paint += crtaj;
                Refresh();
            }
            ObrisiSelekciju();
        }

        private void crtaj(object sender, PaintEventArgs e)
        {
            if (crtanje)
            {
                float ugao = 0;
                e.Graphics.DrawEllipse(Pens.Black, rect);
                for (int i = 0; i < Artikli.Count; i++)
                {
                    e.Graphics.FillPie(VratiCetkicu(), rect, ugao, (float)(Artikli[i].Procenat / 100) * 360);
                    ugao += (float)(Artikli[i].Procenat / 100) * 360;
                }
            }
            else
                e.Graphics.DrawRectangle(Pens.Black, 0, 0, 0, 0);
        }

        private Brush VratiCetkicu()
        {
            PropertyInfo[] nizCetkicaInfo = typeof(Brushes).GetProperties();
            Brush[] nizCetkica = new Brush[nizCetkicaInfo.Length];
            for (int i = 0; i < nizCetkicaInfo.Length; i++)
            {
                nizCetkica[i] = (Brush)nizCetkicaInfo[i].GetValue(null, null);
            }
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return nizCetkica[rnd.Next(1, nizCetkica.Length)];
        }

        private void frmAdministracija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaProjektaDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.bazaProjektaDataSet.Proizvod);
            // TODO: This line of code loads data into the 'bazaProjektaDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.bazaProjektaDataSet.Proizvod);
            this.Paint += crtajLiniju;
            ObrisiSelekciju();
        }

        private void ObrisiSelekciju()
        {
            dtgProizvod.ClearSelection();
            dtgRacun.ClearSelection();
            lbStatistika.ClearSelected();
        }

        private void Deselektuj(object sender, EventArgs e)
        {
            ObrisiSelekciju();
        }
    }
}
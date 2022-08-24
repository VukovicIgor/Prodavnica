using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_2
{
    public partial class frmProdaja : Form
    {
        BazaProjektaDataSet ds = new BazaProjektaDataSet();
        BazaProjektaDataSetTableAdapters.KategorijaTableAdapter kategorijaAdapter = new BazaProjektaDataSetTableAdapters.KategorijaTableAdapter();
        BazaProjektaDataSetTableAdapters.ProizvodTableAdapter proizvodAdapter = new BazaProjektaDataSetTableAdapters.ProizvodTableAdapter();
        BazaProjektaDataSetTableAdapters.RacunTableAdapter racunAdapter = new BazaProjektaDataSetTableAdapters.RacunTableAdapter();
        BazaProjektaDataSetTableAdapters.StatistikaTableAdapter statistikaAdapter = new BazaProjektaDataSetTableAdapters.StatistikaTableAdapter();


        public frmProdaja()
        {
            InitializeComponent();


            kategorijaAdapter.Fill(ds.Kategorija);
            proizvodAdapter.Fill(ds.Proizvod);
            racunAdapter.Fill(ds.Racun);
            statistikaAdapter.Fill(ds.Statistika);

            var topLeftHeaderCell = dtgProizvod.TopLeftHeaderCell;
            var topLeftHeaderCell1 = dtgRacun.TopLeftHeaderCell;
            var topLeftHeaderCell2 = dtgKategorija.TopLeftHeaderCell;

            var pro = from p in ds.Proizvod
                      orderby p.naziv 
                      select p;

            dtgProizvod.DataSource = pro.CopyToDataTable();
            txtPretraga.ReadOnly = true;
            numKolicina.Minimum = 1;
            txtIznosRacuna.Text = "0 RSD";
        }
        private void Pretraga(object sender, EventArgs e)
        {
            if (!rbKategorija.Checked && !rbProizvod.Checked)
            {
                MessageBox.Show("Niste izabrali kategoriju za pretragu!!!");
                return;
            }
            if (rbKategorija.Checked)
            {
                var kat = from k in ds.Kategorija
                          where k.ime_kategorije.ToLower().StartsWith(txtPretraga.Text.ToLower())
                          select k;

                if (kat.Any())
                    dtgKategorija.DataSource = kat.CopyToDataTable();
                else
                {
                    MessageBox.Show("Ne postoji zadata kategorija!!!");
                    txtPretraga.ResetText();
                }
            }
            if (rbProizvod.Checked)
            {
                var pro = from p in ds.Proizvod
                          orderby p.naziv
                          where p.naziv.ToLower().StartsWith(txtPretraga.Text.ToLower())
                          select p;

                if (pro.Any())
                    dtgProizvod.DataSource = pro.CopyToDataTable();
                else
                {
                    MessageBox.Show("Ne postoji zadati proizvod!!!");
                    txtPretraga.ResetText();
                }
            }
            ObrisiSelekciju();
        }

        private void PretragaKategorije(object sender, EventArgs e)
        {
            txtPretraga.ReadOnly = false;
        }

        private void PretragaProizvoda(object sender, EventArgs e)
        {
            txtPretraga.ReadOnly = false;
        }

        private void PrikazProizvoda(object sender, DataGridViewCellMouseEventArgs e)
        {
            var pro = from p in ds.Proizvod
                      orderby p.naziv
                      where p.id_kategorije == int.Parse((dtgKategorija.CurrentRow.Cells["id_kategorije"].Value).ToString())
                      select p;

            if (pro.Any())
                dtgProizvod.DataSource = pro.CopyToDataTable();
        }

        private void Administracija(object sender, EventArgs e)
        {
            DialogResult izlaz = MessageBox.Show("Da li želite da pređete u administrativni deo?", "Administracija", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (izlaz == DialogResult.Yes)
            {
                frmAdministracija am = new frmAdministracija();
                this.Hide();
                am.ShowDialog();
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
        double cenaRacuna = 0;
        private void Dodaj(object sender, EventArgs e)
        {
            DataGridViewRow IzProizvod = dtgProizvod.CurrentRow;  //Sa Majkrosoftovog sajta https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/dataset-datatable-dataview/adding-data-to-a-datatable
            int id = int.Parse((IzProizvod.Cells["idproizvoda"].Value).ToString());
            string naziv = (IzProizvod.Cells["naziv"].Value).ToString();
            double cena = double.Parse((IzProizvod.Cells["cena"].Value).ToString());
            double kolicina = double.Parse(numKolicina.Value.ToString());
            double ukCenaProiz = cena * kolicina;

            dtgRacun.Rows.Add(new object[] { id, naziv, cena, kolicina, ukCenaProiz });

            cenaRacuna += ukCenaProiz;
            txtIznosRacuna.Text = cenaRacuna.ToString() + " RSD";
            ObrisiSelekciju();
        }

        private void StornProizvod(object sender, EventArgs e)
        {
            if (dtgRacun.Rows.Count == 0)
            {
                MessageBox.Show("Nemate unete proizvode!!!", "Račun");
                return;
            }
            foreach (DataGridViewCell celija in dtgRacun.SelectedCells)
            {
                if (celija.Selected)
                {
                    int red = celija.RowIndex;
                    DialogResult izlaz = MessageBox.Show("Storniraj proizvod?", "Storniraj proizvod", MessageBoxButtons.YesNo);
                    if (izlaz == DialogResult.Yes)
                    {
                        cenaRacuna -= double.Parse((dtgRacun.Rows[red].Cells["iznos"].Value).ToString());
                        dtgRacun.Rows.RemoveAt(red);
                        txtIznosRacuna.Text = cenaRacuna.ToString() + " RSD";
                        dtgRacun.Update();
                    }
                }
            }
            ObrisiSelekciju();
        }

        private void StornRacun(object sender, EventArgs e)
        {
            if (dtgRacun.Rows.Count == 0)
            {
                MessageBox.Show("Nemate unete proizvode!!!", "Račun");
            }
            else
            {
                DialogResult izlaz = MessageBox.Show("Da li sigurno želite da stornirate račun?", "Storniraj račun", MessageBoxButtons.YesNo);
                if (izlaz == DialogResult.Yes)
                {
                    dtgRacun.Rows.Clear();
                    txtIznosRacuna.Text = (cenaRacuna = 0).ToString() + " RSD";
                }
            }
            ObrisiSelekciju();
        }

        private void Placanje(object sender, EventArgs e)
        {
            if (dtgRacun.Rows.Count == 0)
            {
                MessageBox.Show("Nemate unete proizvode!!!", "Račun");
            }
            else
            {
                DialogResult izlaz = MessageBox.Show("Ukupan iznos je " + cenaRacuna + " dinara." + "\n" + "Završiti račun?", "Račun", MessageBoxButtons.YesNo);
                if(izlaz == DialogResult.Yes)
                {
                    BazaProjektaDataSet.RacunRow r = ds.Racun.NewRacunRow();
                    r.zbir = cenaRacuna;
                    r.datum_kupovine = DateTime.Today;
                    ds.Racun.AddRacunRow(r);

                    for (int i = 0; i < dtgRacun.Rows.Count; i++)
                    {
                        BazaProjektaDataSet.StatistikaRow s = ds.Statistika.NewStatistikaRow();
                        s.id_proizvoda = int.Parse((dtgRacun.Rows[i].Cells["id_proizvoda"].Value).ToString());
                        s.datum = DateTime.Now;
                        s.kolicina = int.Parse((dtgRacun.Rows[i].Cells["kolicina"].Value).ToString());
                        ds.Statistika.AddStatistikaRow(s);
                    }
                    racunAdapter.Update(ds);
                    statistikaAdapter.Update(ds);
                    txtIznosRacuna.Text = (cenaRacuna = 0).ToString() + " RSD";
                    dtgRacun.Rows.Clear();

                }
            }
            ObrisiSelekciju();
        }

        private void DupliKlik(object sender, EventArgs e)
        {
            DataGridViewRow IzProizvod = dtgProizvod.CurrentRow;  //Sa Majkrosoftovog sajta https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/dataset-datatable-dataview/adding-data-to-a-datatable
            int id = int.Parse((IzProizvod.Cells["idproizvoda"].Value).ToString());
            string naziv = (IzProizvod.Cells["naziv"].Value).ToString();
            double cena = double.Parse((IzProizvod.Cells["cena"].Value).ToString());
            double kolicina = double.Parse(numKolicina.Value.ToString());
            double ukCenaProiz = cena * kolicina;

            dtgRacun.Rows.Add(new object[] { id, naziv, cena, kolicina, ukCenaProiz });

            cenaRacuna += ukCenaProiz;
            txtIznosRacuna.Text = cenaRacuna.ToString() + " RSD";
            ObrisiSelekciju();
        }

        private void frmProdaja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaProjektaDataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.bazaProjektaDataSet.Proizvod);
            // TODO: This line of code loads data into the 'bazaProjektaDataSet.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.bazaProjektaDataSet.Kategorija);
            ObrisiSelekciju();
        }

        private void Deselektuj(object sender, EventArgs e)
        {
            ObrisiSelekciju();
        }

        private void ObrisiSelekciju()
        {
            var pro = from p in ds.Proizvod
                      orderby p.naziv
                      select p;

            dtgProizvod.DataSource = pro.CopyToDataTable();
            dtgKategorija.DataSource = ds.Kategorija;
            dtgKategorija.ClearSelection();
            dtgProizvod.ClearSelection();
            dtgRacun.ClearSelection();
        }
    }
}

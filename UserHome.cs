using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class UserHome : Form
    {
        public ListBox MyListBox { get; }

        public decimal Total;

        public int num, numP, numB, numT, numS, numBP, numO;// for Medical suppliers add to cart controll
        public int numper, numNC, numFO, numDS, numCS, numFW, numHC; // for personal care add cart control
        public int numPre, numME, numEL, numAntiB, numAntiD, numLod, numRes;// for prescription medication cart control
        public int numV, numZim,numSen, numFro, numCat, numRep, numAll; // for vetenaries
        //
        //
        public int plasterQuant, BandageQuant, BPmonitorQuant, OxygenatorQuant, SyringeQuant, ThermometerQuant; // for Medical Supplies Quantities
        public int nightcreamQuant, creamsoapQuant, HandsCreamQuant, drykinOilQuant, FaceOilQuant, facewashQuant;// for personal care Quantities
        public int MetforminQuant, EliquisQuant, AntibioticsQuant, RispendoneQuant, AntidepressantsQuant, AntiHypQuant;// for Pescrition Medicatin Quantity
        public int ZimecterinQuant, CatSprayQuant, AllrepellentQuant, RepellentQuant, frontalQuant, sentinelQuant;//for vertenary Quantity




        public UserHome()
        {
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
            MyListBox = selected1;
        }

        private void SubPlasterlabel13_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(PlasterQuanttextBox1.Text);
            if (Que > 1)
            {
                Que--;
                plasterQuant = Que;
                PlasterQuanttextBox1.Text = plasterQuant.ToString();
            }
        }

        private void SubBandagelabel20_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(BundageQuanttextBox4.Text);
            if (Que > 1)
            {
                Que--;
                BandageQuant = Que;
                BundageQuanttextBox4.Text = BandageQuant.ToString();
            }
        }

        private void SubThemometerlabel24_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(ThemometerQuanttextBox6.Text);
            if (Que > 1)
            {
                Que--;
                ThermometerQuant = Que;
                ThemometerQuanttextBox6.Text = ThermometerQuant.ToString();
            }
        }

        private void SUbSyregnlabel18_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(SyringeQuanttextBox6.Text);
            if (Que > 1)
            {
                Que--;
                SyringeQuant = Que;
                SyringeQuanttextBox6.Text = SyringeQuant.ToString();
            }
        }

        private void SubBPmonitorlabel22_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(BPmonitorQuanttextBox4.Text);
            if (Que > 1)
            {
                Que--;
                BPmonitorQuant = Que;
                BPmonitorQuanttextBox4.Text = BPmonitorQuant.ToString();
            }
        }

        private void SubOxygenatorlabel16_Click(object sender, EventArgs e)
        {

            int Que = int.Parse(OxygenatorQuanttextBox1.Text);
            if (Que > 1)
            {
                Que--;
                OxygenatorQuant = Que;
                OxygenatorQuanttextBox1.Text = OxygenatorQuant.ToString();
            }
        }
        public void subract(string quanttxt, int Quantity)
        {

        }

        private void AddBundagelabel19_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(BundageQuanttextBox4.Text);
            Que++;
            BandageQuant = Que;
            BundageQuanttextBox4.Text = BandageQuant.ToString();
        }

        private void AddThemometerlabel23_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(ThemometerQuanttextBox6.Text);
            Que++;
            ThermometerQuant = Que;
            ThemometerQuanttextBox6.Text = ThermometerQuant.ToString();
        }

        private void AddSyringelabel17_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(SyringeQuanttextBox6.Text);
            Que++;
            SyringeQuant = Que;
            SyringeQuanttextBox6.Text = SyringeQuant.ToString();
        }

        private void AddBpMonitorlabel21_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(BPmonitorQuanttextBox4.Text);
            Que++;
            BPmonitorQuant = Que;
            BPmonitorQuanttextBox4.Text = BPmonitorQuant.ToString();
        }

        private void AddOxygenatlabel15_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(OxygenatorQuanttextBox1.Text);
            Que++;
            OxygenatorQuant = Que;
            OxygenatorQuanttextBox1.Text = OxygenatorQuant.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalSuppliespanel.Visible = false;
            Prescriptionpanel3.Visible = false;
            Veterinarypanel3.Visible = false;
            personalCarepanel3.Visible = false;

            Cartbutton1.Visible = false;
            Confirmbutton2.Visible = true;
            selected1.Visible = true;
            selected1.Items.Add("Items        Quant      subPrice");
            selected1.Items.Add("");
            selected1.Items.Add("");

            selected1.Location = new System.Drawing.Point(836, 95);
            selected1.Size = new System.Drawing.Size(522, 537);



            if (PlasterpictureBox8.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(PlasterPricetextBox8.Text, PlasterQuanttextBox1.Text).ToString());
                selected1.Items.Add($"Plaster       x{PlasterQuanttextBox1.Text.PadRight(14)}   R{Price(PlasterPricetextBox8.Text, PlasterQuanttextBox1.Text).ToString()}");
            }

            if (BundagePricetextBox17.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(BundagePricetextBox17.Text, BundageQuanttextBox4.Text).ToString());
                selected1.Items.Add($"Bandage.......x{BundageQuanttextBox4.Text.PadRight(14)}   R{Price(BundagePricetextBox17.Text, BundageQuanttextBox4.Text).ToString()}");
            }

            if (BPpictureBox11.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(BPMonitorPricetextBox15.Text, BPmonitorQuanttextBox4.Text).ToString());
                selected1.Items.Add($"BP Monitor....x{BPmonitorQuanttextBox4.Text.PadRight(14)}   R{Price(BPMonitorPricetextBox15.Text, BPmonitorQuanttextBox4.Text).ToString()}");
            }

            if (SyrengepictureBox10.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(SyringePricetextBox11.Text, SyringeQuanttextBox6.Text).ToString());
                selected1.Items.Add($"Syringe.......x{SyringeQuanttextBox6.Text.PadRight(14)}   R{Price(SyringePricetextBox11.Text, SyringeQuanttextBox6.Text).ToString()}");
            }

            if (OxypictureBox9.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(OxygenPricetextBox13.Text, OxygenatorQuanttextBox1.Text).ToString());
                selected1.Items.Add($"Oxygenator....x{OxygenatorQuanttextBox1.Text.PadRight(14)}   R{Price(OxygenPricetextBox13.Text, OxygenatorQuanttextBox1.Text).ToString()}");
            }

            if (ThemometerpictureBox12.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(ThemometerpricetextBox9.Text, ThemometerQuanttextBox6.Text).ToString());
                selected1.Items.Add($"Themometer    x{ThemometerQuanttextBox6.Text.PadRight(14)}   R{Price(ThemometerpricetextBox9.Text, ThemometerQuanttextBox6.Text).ToString()}");
            }

            //for Personal Care products

            if (faceoilpictureBox8.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(faceWashPricetextBox3.Text, faceOilQuanttextBox38.Text).ToString());
                selected1.Items.Add($"Face Oil    x{faceOilQuanttextBox38.Text.PadRight(14)}   R{Price(faceWashPricetextBox3.Text, faceOilQuanttextBox38.Text).ToString()}");
            }

            if (handCreampictureBox12.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(HandCreamPricetextBox5.Text, HandCreamQuanttextBox41.Text).ToString());
                selected1.Items.Add($"Hands Cream    x{HandCreamQuanttextBox41.Text.PadRight(14)}   R{Price(HandCreamPricetextBox5.Text, HandCreamQuanttextBox41.Text).ToString()}");
            }

            if (FacewashpictureBox10.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(faceWashPricetextBox3.Text, facewashQuanttextBox39.Text).ToString());
                selected1.Items.Add($"Face Washer    x{facewashQuanttextBox39.Text.PadRight(14)}   R{Price(faceWashPricetextBox3.Text, facewashQuanttextBox39.Text).ToString()}");
            }

            if (nightcreampictureBox13.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(nightcreampricetextBox15.Text, nightcreamQuanttextBox42.Text).ToString());
                selected1.Items.Add($"Night Cream    x{nightcreamQuanttextBox42.Text.PadRight(14)}   R{Price(nightcreampricetextBox15.Text, nightcreamQuanttextBox42.Text).ToString()}");
            }

            if (drypictureBox9.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(DryPricetextBox11.Text, dryQuanttextBox40.Text).ToString());
                selected1.Items.Add($"Dry Skin Oil    x{dryQuanttextBox40.Text.PadRight(14)}   R{Price(DryPricetextBox11.Text, dryQuanttextBox40.Text).ToString()}");
            }

            if (creamsoapPricetextBox8.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(creamsoapPricetextBox8.Text, creamsoapQuanttextBox37.Text).ToString());
                selected1.Items.Add($"Cream and Soap    x{creamsoapQuanttextBox37.Text.PadRight(14)}   R{Price(creamsoapPricetextBox8.Text, creamsoapQuanttextBox37.Text).ToString()}");
            }


            //
            //Veterinary products
            if (catspraypictureBox11.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(catspraypricetextBox44.Text, catsprayQuanttextBox49.Text).ToString());
                selected1.Items.Add($"Cats Spray    x{catsprayQuanttextBox49.Text.PadRight(14)}   R{Price(catspraypricetextBox44.Text, catsprayQuanttextBox49.Text).ToString()}");
            }

            if (SentinalpictureBox8.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(SentinalpricetextBox43.Text, SentinalQuanttextBox50.Text).ToString());
                selected1.Items.Add($"Sentinal      x{SentinalQuanttextBox50.Text.PadRight(14)}   R{Price(SentinalpricetextBox43.Text, SentinalQuanttextBox50.Text).ToString()}");
            }

            if (allrepellspictureBox12.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(allrepellspricetextBox46.Text, allrepellsQuanttextBox53.Text).ToString());
                selected1.Items.Add($"All Reppellents    x{allrepellsQuanttextBox53.Text.PadRight(14)}   R{Price(allrepellspricetextBox46.Text, allrepellsQuanttextBox53.Text).ToString()}");
            }

            if (repellentspraypictureBox10.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(repellentspraypricetextBox45.Text, repellentsprayQuanttextBox51.Text).ToString());
                selected1.Items.Add($"Repellents Dogs    x{repellentsprayQuanttextBox51.Text.PadRight(14)}   R{Price(repellentspraypricetextBox45.Text, repellentsprayQuanttextBox51.Text).ToString()}");
            }

            if (ZimecretinpictureBox38.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(ZimecretinpricetextBox47.Text, ZimecretinQuanttextBox55.Text).ToString());
                selected1.Items.Add($"Zimecretin    x{ZimecretinQuanttextBox55.Text.PadRight(14)}   R{Price(ZimecretinpricetextBox47.Text, ZimecretinQuanttextBox55.Text).ToString()}");
            }

            if (frontlinepictureBox9.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(frontlinepricetextBox41.Text, frontlineQuanttextBox52.Text).ToString());
                selected1.Items.Add($"Frontal     x{frontlineQuanttextBox52.Text.PadRight(14)}   R{Price(frontlinepricetextBox41.Text, frontlineQuanttextBox52.Text).ToString()}");
            }


            //
            //prescription Medication
            if (antidepictureBox11.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(antidepricetextBox37.Text, antidequanttextBox43.Text).ToString());
                selected1.Items.Add($"Antidepressants    x{antidequanttextBox43.Text.PadRight(14)}   R{Price(antidepricetextBox37.Text, antidequanttextBox43.Text).ToString()}");
            }

            if (mertforminpictureBox13.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(mertforminpricetextBox41.Text, mertforminQuanttextBox48.Text).ToString());
                selected1.Items.Add($"Mertformin    x{mertforminQuanttextBox48.Text.PadRight(14)}   R{Price(mertforminpricetextBox41.Text, mertforminQuanttextBox48.Text).ToString()}");
            }


            if (AntibioticpictureBox9.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(AntibioticpricetextBox39.Text, AntibioticQuanttextBox46.Text).ToString());
                selected1.Items.Add($"Antibiotics    x{AntibioticQuanttextBox46.Text.PadRight(14)}   R{Price(AntibioticpricetextBox39.Text, AntibioticQuanttextBox46.Text).ToString()}");
            }

            if (EliquispictureBox8.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(EliquisPricetextBox1.Text, EliquisQuanttextBox44.Text).ToString());
                selected1.Items.Add($"Eliquis        x{EliquisQuanttextBox44.Text.PadRight(14)}   R{Price(EliquisPricetextBox1.Text, EliquisQuanttextBox44.Text).ToString()}");
            }

            if (antihyppictureBox10.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(antihyppricetextBox5.Text, antihypQuanttextBox45.Text).ToString());
                selected1.Items.Add($"Lodipine      x{antihypQuanttextBox45.Text.PadRight(14)}   R{Price(antihyppricetextBox5.Text, antihypQuanttextBox45.Text).ToString()}");
            }

            if (risperidonepictureBox12.BackColor == Color.Red)
            {
                Total += decimal.Parse(Price(risperidonepricetextBox11.Text, risperidoneQuanttextBox47.Text).ToString());
                selected1.Items.Add($"Risperidone    x{risperidoneQuanttextBox47.Text.PadRight(14)}   R{Price(risperidonepricetextBox11.Text, risperidoneQuanttextBox47.Text).ToString()}");
            }
            selected1.Items.Add(" ");
            selected1.Items.Add(" ");
            selected1.Items.Add(" ");
            selected1.Items.Add("                                     Total "+ Total.ToString());












        }
        public decimal Price(string PriceBox, string QuantBox)
        {

            decimal originalPrice = decimal.Parse(PriceBox);
            int Quant = int.Parse(QuantBox);
            decimal price = originalPrice * Quant;

            return price;
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            string Title = "                       CART";
            int desiredLength = 50;
            Title = Title.PadRight(desiredLength);


            selected.Items.Add(Title);
            selected.Items.Add("   ");
            selected.Items.Add("   ");

        }

        private void Confirmbutton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have Successfully Placed Your Order");
            selected1.Visible = false;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void personalCarepictureBox_Click(object sender, EventArgs e)
        {
            numper++;
            if (numper % 2 != 0)
            {
                personalCarepictureBox.BackColor = Color.Red;
                productslabel1.Visible = true;
                productslabel1.Text = "Personal Care Products";
                personalCarepanel3.Visible = true;
                selected1.Visible = false;
                Cartbutton1.Visible = true;
                MedicalSuppliespanel.Visible = false;
                Prescriptionpanel3.Visible = false;
                Veterinarypanel3.Visible = false;
                personalCarepanel3.Size = new System.Drawing.Size(494, 578);
                personalCarepanel3.Location = new System.Drawing.Point(846, 64);
                Confirmbutton2.Visible = false;
                //MEDICALSUPPLIER PANEL
                //
                MedicalSuppliespanel.Size = new System.Drawing.Size(93, 78);
                MedicalSuppliespanel.Location = new System.Drawing.Point(86, 580);
                MedicalpictureBox7.BackColor = Color.FromArgb(0, 64, 0);

                //
                //prescription medication
                PrescriptionpictureBox3.BackColor = Color.FromArgb(0, 64, 0);
                Prescriptionpanel3.Location = new System.Drawing.Point(440, 575);
                Prescriptionpanel3.Size = new System.Drawing.Size(144, 83);

                //
                //vertenary Medications
                VaterinarypictureBox6.BackColor = Color.FromArgb(0, 64, 0);
                Veterinarypanel3.Location = new System.Drawing.Point(333, 513);
                Veterinarypanel3.Size = new System.Drawing.Size(80, 67);



            }
            else
            {
                personalCarepictureBox.BackColor = Color.FromArgb(0, 64, 0);
                productslabel1.Visible = false;
                MedicalSuppliespanel.Visible = false;
                Prescriptionpanel3.Visible = false;
                productslabel1.Text = "Products";
                selected1.Visible = false;
                Cartbutton1.Visible = true;

                personalCarepanel3.Visible = false;
                MedicalSuppliespanel.Location = new System.Drawing.Point(116, 25);
                MedicalSuppliespanel.Size = new System.Drawing.Size(846, 64);
                Prescriptionpanel3.Location = new System.Drawing.Point(440, 575);
                Prescriptionpanel3.Size = new System.Drawing.Size(144, 83);
                Veterinarypanel3.Size = new System.Drawing.Size(93, 78);
                Veterinarypanel3.Location = new System.Drawing.Point(86, 580);
                Confirmbutton2.Visible = false;

            }
        }

        private void PlasterpictureBox8_Click_1(object sender, EventArgs e)
        {
            numP++;
            if (numP % 2 != 0)
            {
                Plasterpanel.Visible = true;
                PlasterpictureBox8.BackColor = Color.Red;
            }
            else
            {
                Plasterpanel.Visible = false;
                PlasterpictureBox8.BackColor = Color.Black;

            }
        }

        private void BandagepictureBox13_Click(object sender, EventArgs e)
        {
            numB++;
            if (numB % 2 == 0)
            {
                Bundagepanel6.Visible = true;
                BandagepictureBox13.BackColor = Color.Red;
            }
            else
            {
                Bundagepanel6.Visible = false;
                BandagepictureBox13.BackColor = Color.Black;
            }
        }

        private void nightcreampictureBox13_Click(object sender, EventArgs e)
        {
            numNC++;
            if (numNC % 2 != 0)
            {
                nightcreampanel16.Visible = true;
                nightcreampictureBox13.BackColor = Color.Red;
            }
            else
            {
                nightcreampanel16.Visible = false;
                nightcreampictureBox13.BackColor = Color.Black;

            }
        }

        private void faceoilpictureBox8_Click(object sender, EventArgs e)
        {
            numFO++;
            if (numFO % 2 != 0)
            {
                FaceOilpanel5.Visible = true;
                FacewashpictureBox10.BackColor = Color.Red;
            }
            else
            {
                FaceOilpanel5.Visible = false;
                FacewashpictureBox10.BackColor = Color.Black;

            }
        }

        private void drypictureBox9_Click(object sender, EventArgs e)
        {
            numDS++;
            if (numDS % 2 != 0)
            {
                Drypanel7.Visible = true;
                DryPricetextBox11.BackColor = Color.Red;
            }
            else
            {
                FaceOilpanel5.Visible = false;
                DryPricetextBox11.BackColor = Color.Black;

            }
        }

        private void SubfaceOillabel15_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(faceOilQuanttextBox38.Text);
            if (Que > 1)
            {
                Que--;
                FaceOilQuant = Que;
                faceOilQuanttextBox38.Text = FaceOilQuant.ToString();
            }
        }

        private void subdrylabel19_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(dryQuanttextBox40.Text);
            if (Que > 1)
            {
                Que--;
                drykinOilQuant = Que;
                dryQuanttextBox40.Text = drykinOilQuant.ToString();
            }
        }

        private void subcreamsoaplabel13_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(creamsoapQuanttextBox37.Text);
            if (Que > 1)
            {
                Que--;
                creamsoapQuant = Que;
                creamsoapQuanttextBox37.Text = creamsoapQuant.ToString();
            }
        }

        private void Addfacewashlabel17_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(facewashQuanttextBox39.Text);
            if (Que > 1)
            {
                Que--;
                facewashQuant = Que;
                facewashQuanttextBox39.Text = facewashQuant.ToString();
            }
        }

        private void SubHandcreamlabel21_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(HandCreamQuanttextBox41.Text);
            if (Que > 1)
            {
                Que--;
                HandsCreamQuant = Que;
                HandCreamQuanttextBox41.Text = HandsCreamQuant.ToString();
            }
        }

        private void Addnightcreamlabel22_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(nightcreamQuanttextBox42.Text);
            Que++;
            nightcreamQuant = Que;
            nightcreamQuanttextBox42.Text = nightcreamQuant.ToString();
        }

        private void Addfaceoillabel14_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(facewashQuanttextBox39.Text);
            Que++;
            FaceOilQuant = Que;
            facewashQuanttextBox39.Text = FaceOilQuant.ToString();
        }

        private void AddDrylabel18_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(dryQuanttextBox40.Text);
            Que++;
            drykinOilQuant = Que;
            dryQuanttextBox40.Text = drykinOilQuant.ToString();
        }

        private void Addcreamsoaplabel12_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(creamsoapQuanttextBox37.Text);
            Que++;
            creamsoapQuant = Que;
            creamsoapQuanttextBox37.Text = creamsoapQuant.ToString();
        }

        private void EliquispictureBox8_Click(object sender, EventArgs e)
        {
            numEL++;
            if (numEL % 2 != 0)
            {
                Eliquispanel5.Visible = true;
                EliquispictureBox8.BackColor = Color.Red;
            }
            else
            {
                Eliquispanel5.Visible = false;
                EliquispictureBox8.BackColor = Color.Black;

            }
        }

        private void subEliquislabel15_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(EliquisQuanttextBox44.Text);
            if (Que > 1)
            {
                Que--;
                EliquisQuant = Que;
                EliquisQuanttextBox44.Text = EliquisQuant.ToString();
            }
        }

        private void subAntibioticlabel19_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(AntibioticQuanttextBox46.Text);
            if (Que > 1)
            {
                Que--;
                AntibioticsQuant = Que;
                AntibioticQuanttextBox46.Text = AntibioticsQuant.ToString();
            }
        }

        private void subantidelabel13_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(antidequanttextBox43.Text);
            if (Que > 1)
            {
                Que--;
                AntidepressantsQuant = Que;
                antidequanttextBox43.Text = AntidepressantsQuant.ToString();
            }
        }

        private void subantihyplabel17_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(antihypQuanttextBox45.Text);
            if (Que > 1)
            {
                Que--;
                AntiHypQuant = Que;
                antihypQuanttextBox45.Text = AntiHypQuant.ToString();
            }
        }

        private void subrisperidonelabel21_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(risperidoneQuanttextBox47.Text);
            if (Que > 1)
            {
                Que--;
                RispendoneQuant = Que;
                risperidoneQuanttextBox47.Text = RispendoneQuant.ToString();
            }
        }

        private void addmertforminlabel22_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(mertforminQuanttextBox48.Text);
            Que++;
            MetforminQuant = Que;
            mertforminQuanttextBox48.Text = MetforminQuant.ToString();
        }

        private void addEliquislabel14_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(EliquisQuanttextBox44.Text);
            Que++;
            EliquisQuant = Que;
            EliquisQuanttextBox44.Text = EliquisQuant.ToString();
        }

        private void addAntibioticlabel18_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(AntibioticQuanttextBox46.Text);
            Que++;
            AntibioticsQuant = Que;
            AntibioticQuanttextBox46.Text = AntibioticsQuant.ToString();
        }

        private void addantidelabel12_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(antidequanttextBox43.Text);
            Que++;
            AntidepressantsQuant = Que;
            antidequanttextBox43.Text = AntidepressantsQuant.ToString();
        }

        private void Veterinarypanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SentinalpictureBox8_Click(object sender, EventArgs e)
        {
            numSen++;
            if (numSen % 2 != 0)
            {
                Sentinalpanel5.Visible = true;
                SentinalpictureBox8.BackColor = Color.Red;
            }
            else
            {
                Sentinalpanel5.Visible = false;
                SentinalpictureBox8.BackColor = Color.Black;

            }
        }

        private void frontlinepictureBox9_Click(object sender, EventArgs e)
        {
            numFro++;
            if (numFro % 2 != 0)
            {
                frontlinepanel7.Visible = true;
                frontlinepictureBox9.BackColor = Color.Red;
            }
            else
            {
                frontlinepanel7.Visible = false;
                frontlinepictureBox9.BackColor = Color.Black;

            }
        }

        private void catspraypictureBox11_Click(object sender, EventArgs e)
        {
            numCat++;
            if (numCat % 2 != 0)
            {
                catspraypanel4.Visible = true;
                catspraypictureBox11.BackColor = Color.Red;
            }
            else
            {
                catspraypanel4.Visible = false;
                catspraypictureBox11.BackColor = Color.Black;

            }
        }

        private void repellentspraypictureBox10_Click(object sender, EventArgs e)
        {
            numRep++;
            if (numRep % 2 != 0)
            {
                repellentspraypanel6.Visible = true;
                repellentspraypictureBox10.BackColor = Color.Red;
            }
            else
            {
                repellentspraypanel6.Visible = false;
                repellentspraypictureBox10.BackColor = Color.Black;

            }
        }

        private void allrepellspictureBox12_Click(object sender, EventArgs e)
        {
            numAll++;
            if (numAll % 2 != 0)
            {
                Allrepellentspanel8.Visible = true;
                allrepellspictureBox12.BackColor = Color.Red;
            }
            else
            {
                Allrepellentspanel8.Visible = false;
                allrepellspictureBox12.BackColor = Color.Black;

            }
        }

        private void subZimecretinlabel37_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(ZimecretinQuanttextBox55.Text);
            if (Que > 1)
            {
                Que--;
                ZimecterinQuant = Que;
                ZimecretinQuanttextBox55.Text = ZimecterinQuant.ToString();
            }
        }

        private void subfrontlinelabel19_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(frontlineQuanttextBox52.Text);
            if (Que > 1)
            {
                Que--;
                frontalQuant = Que;
                frontlineQuanttextBox52.Text = frontalQuant.ToString();
            }
        }

        private void subSentinallabel15_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(SentinalQuanttextBox50.Text);
            if (Que > 1)
            {
                Que--;
                sentinelQuant = Que;
                SentinalQuanttextBox50.Text = sentinelQuant.ToString();
            }
        }

        private void subcatspraylabel13_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(catsprayQuanttextBox49.Text);
            if (Que > 1)
            {
                Que--;
                CatSprayQuant = Que;
                catsprayQuanttextBox49.Text = CatSprayQuant.ToString();
            }
        }

        private void subrepellentspraylabel17_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(repellentsprayQuanttextBox51.Text);
            if (Que > 1)
            {
                Que--;
                RepellentQuant = Que;
                repellentsprayQuanttextBox51.Text = RepellentQuant.ToString();
            }
        }

        private void suballrepellslabel21_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(allrepellsQuanttextBox53.Text);
            if (Que > 1)
            {
                Que--;
                AllrepellentQuant = Que;
                allrepellsQuanttextBox53.Text = AllrepellentQuant.ToString();
            }
        }

        private void addZimecretinlabel36_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(ZimecretinQuanttextBox55.Text);
            Que++;
            ZimecterinQuant = Que;
            ZimecretinQuanttextBox55.Text = ZimecterinQuant.ToString();
        }

        private void addSentinallabel14_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(SentinalQuanttextBox50.Text);
            Que++;
            sentinelQuant = Que;
            SentinalQuanttextBox50.Text = sentinelQuant.ToString();
        }

        private void Addfrontlinelabel18_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(frontlineQuanttextBox52.Text);
            Que++;
            frontalQuant = Que;
            frontlineQuanttextBox52.Text = frontalQuant.ToString();
        }

        private void Addcatspraylabel12_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(catsprayQuanttextBox49.Text);
            Que++;
            CatSprayQuant = Que;
            catsprayQuanttextBox49.Text = CatSprayQuant.ToString();
        }

        private void addrepellentspraylabel16_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(repellentsprayQuanttextBox51.Text);
            Que++;
            RepellentQuant = Que;
            repellentsprayQuanttextBox51.Text = RepellentQuant.ToString();
        }

        private void MedicalSuppliespanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Check if the  clicked OK
            if (result == DialogResult.OK)
            {
                Login l = new Login(MyListBox);
                l.Show();
            }
        }

        private void Prescriptionpanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addrisperidonelabel20_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(risperidoneQuanttextBox47.Text);
            Que++;
            RispendoneQuant = Que;
            risperidoneQuanttextBox47.Text = RispendoneQuant.ToString();
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void VaterinarypictureBox6_Click(object sender, EventArgs e)
        {
            numV++;
            if (numV % 2 != 0)
            {
                Confirmbutton2.Visible = false;

                VaterinarypictureBox6.BackColor = Color.Red;
                productslabel1.Visible = true;
                productslabel1.Text = "Veterinary  Products";
                Veterinarypanel3.Visible = true;
                selected1.Visible = false;
                Cartbutton1.Visible = true;

                MedicalSuppliespanel.Visible = false;
                Prescriptionpanel3.Visible = false;
                personalCarepanel3.Visible = false;
                Veterinarypanel3.Size = new System.Drawing.Size(494, 578);
                Veterinarypanel3.Location = new System.Drawing.Point(846, 64);

                //MEDICALSUPPLIER PANEL
                //
                MedicalSuppliespanel.Size = new System.Drawing.Size(93, 78);
                MedicalSuppliespanel.Location = new System.Drawing.Point(86, 580);
                MedicalpictureBox7.BackColor = Color.FromArgb(0, 64, 0);

                //
                //prescription medication
                PrescriptionpictureBox3.BackColor = Color.FromArgb(0, 64, 0);
                Prescriptionpanel3.Location = new System.Drawing.Point(440, 575);
                Prescriptionpanel3.Size = new System.Drawing.Size(144, 83);

                //
                //personal care panel
                personalCarepanel3.Location = new System.Drawing.Point(252, 575);
                personalCarepanel3.Size = new System.Drawing.Size(166, 83);
                personalCarepictureBox.BackColor = Color.FromArgb(0, 64, 0);



            }
            else
            {
                VaterinarypictureBox6.BackColor = Color.FromArgb(0, 64, 0);
                Veterinarypanel3.Size = new System.Drawing.Size(93, 78);
                Veterinarypanel3.Location = new System.Drawing.Point(86, 580);
                productslabel1.Visible = false;
                personalCarepanel3.Visible = false;
                Prescriptionpanel3.Visible = false;
                productslabel1.Text = "Products";
                Prescriptionpanel3.Location = new System.Drawing.Point(440, 575);
                Prescriptionpanel3.Size = new System.Drawing.Size(144, 83);
                personalCarepanel3.Location = new System.Drawing.Point(252, 575);
                personalCarepanel3.Size = new System.Drawing.Size(166, 83);
                MedicalSuppliespanel.Size = new System.Drawing.Size(93, 78);
                MedicalSuppliespanel.Location = new System.Drawing.Point(86, 580);
                selected1.Visible = false;
                Cartbutton1.Visible = true;
                Confirmbutton2.Visible = false;

                Veterinarypanel3.Visible = false;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(allrepellsQuanttextBox53.Text);
            Que++;
            AllrepellentQuant = Que;
            allrepellsQuanttextBox53.Text = AllrepellentQuant.ToString();
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void HealthpictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void personalCarepanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void ZimecretinpictureBox38_Click(object sender, EventArgs e)
        {
            numZim++;
            if (numZim % 2 != 0)
            {
                Zimecretinpanel17.Visible = true;
                ZimecretinpictureBox38.BackColor = Color.Red;
            }
            else
            {
                Zimecretinpanel17.Visible = false;
                ZimecretinpictureBox38.BackColor = Color.Black;

            }
        }

        private void AntibioticpictureBox9_Click(object sender, EventArgs e)
        {
            numAntiB++;
            if (numAntiB % 2 != 0)
            {
                Antibioticpanel7.Visible = true;
                AntibioticpictureBox9.BackColor = Color.Red;
            }
            else
            {
                Antibioticpanel7.Visible = false;
                AntibioticpictureBox9.BackColor = Color.Black;

            }
        }

        private void antidepictureBox11_Click(object sender, EventArgs e)
        {
            numAntiD++;
            if (numAntiD % 2 != 0)
            {
                antidepanel4.Visible = true;
                antidepictureBox11.BackColor = Color.Red;
            }
            else
            {
                antidepanel4.Visible = false;
                antidepictureBox11.BackColor = Color.Black;

            }
        }

        private void antihyppictureBox10_Click(object sender, EventArgs e)
        {
            numLod++;
            if (numLod % 2 != 0)
            {
                antihyppanel6.Visible = true;
                antihyppictureBox10.BackColor = Color.Red;
            }
            else
            {
                antihyppanel6.Visible = false;
                antihyppictureBox10.BackColor = Color.Black;

            }
        }

        private void risperidonepictureBox12_Click(object sender, EventArgs e)
        {
            numRes++;
            if (numRes % 2 != 0)
            {
                risperidonepanel8.Visible = true;
                risperidonepictureBox12.BackColor = Color.Red;
            }
            else
            {
                risperidonepanel8.Visible = false;
                risperidonepictureBox12.BackColor = Color.Black;

            }
        }

        private void submertforminlabel23_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(mertforminQuanttextBox48.Text);
            if (Que > 1)
            {
                Que--;
                MetforminQuant = Que;
                mertforminQuanttextBox48.Text = MetforminQuant.ToString();
            }
        }

        private void Addfacewashlabel16_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(facewashQuanttextBox39.Text);
            Que++;
            facewashQuant = Que;
            facewashQuanttextBox39.Text = facewashQuant.ToString();
        }

        private void AddHandcreamlabel20_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(HandCreamQuanttextBox41.Text);
            Que++;
            HandsCreamQuant = Que;
            HandCreamQuanttextBox41.Text = HandsCreamQuant.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(antihypQuanttextBox45.Text);
            Que++;
            AntiHypQuant = Que;
            antihypQuanttextBox45.Text = AntiHypQuant.ToString();
        }

        private void PrescriptionpictureBox3_Click(object sender, EventArgs e)
        {
            numPre++;
            if (numPre % 2 != 0)
            {
                Confirmbutton2.Visible = false;

                PrescriptionpictureBox3.BackColor = Color.Red;
                productslabel1.Visible = true;
                productslabel1.Text = "prescription Medications";
                Prescriptionpanel3.Visible = true;
                selected1.Visible = false;
                Cartbutton1.Visible = true;

                MedicalSuppliespanel.Visible = false;
                personalCarepanel3.Visible = false;
                Veterinarypanel3.Visible = false;
                Prescriptionpanel3.Size = new System.Drawing.Size(494, 578);
                Prescriptionpanel3.Location = new System.Drawing.Point(846, 64);

                //MEDICALSUPPLIER PANEL
                //
                MedicalSuppliespanel.Size = new System.Drawing.Size(93, 78);
                MedicalSuppliespanel.Location = new System.Drawing.Point(86, 580);
                MedicalpictureBox7.BackColor = Color.FromArgb(0, 64, 0);

                //
                //Personal Car Panel
                personalCarepanel3.Location = new System.Drawing.Point(252, 575);
                personalCarepanel3.Size = new System.Drawing.Size(166, 83);
                personalCarepictureBox.BackColor = Color.FromArgb(0, 64, 0);
                //
                //vertenary Medications
                VaterinarypictureBox6.BackColor = Color.FromArgb(0, 64, 0);
                Veterinarypanel3.Location = new System.Drawing.Point(333, 513);
                Veterinarypanel3.Size = new System.Drawing.Size(80, 67);

            }
            else
            {
                PrescriptionpictureBox3.BackColor = Color.FromArgb(0, 64, 0);
                Prescriptionpanel3.Location = new System.Drawing.Point(440, 575);
                Prescriptionpanel3.Size = new System.Drawing.Size(144, 83);
                productslabel1.Visible = false;
                MedicalSuppliespanel.Visible = false;
                personalCarepanel3.Visible = false;
                productslabel1.Text = "Products";
                Prescriptionpanel3.Visible = false;
                MedicalSuppliespanel.Location = new System.Drawing.Point(116, 25);
                MedicalSuppliespanel.Size = new System.Drawing.Size(846, 64);
                personalCarepanel3.Location = new System.Drawing.Point(252, 575);
                personalCarepanel3.Size = new System.Drawing.Size(166, 83);
                Veterinarypanel3.Size = new System.Drawing.Size(93, 78);
                Veterinarypanel3.Location = new System.Drawing.Point(86, 580);
                selected1.Visible = false;
                Cartbutton1.Visible = true;
                Confirmbutton2.Visible = false;


            }


        }

        private void mertforminpictureBox13_Click(object sender, EventArgs e)
        {
            numME++;
            if (numME % 2 != 0)
            {
                mertforminpanel16.Visible = true;
                mertforminpictureBox13.BackColor = Color.Red;
            }
            else
            {
                mertforminpanel16.Visible = false;
                mertforminpictureBox13.BackColor = Color.Black;

            }
        }

        private void selected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void creamsoappictureBox11_Click(object sender, EventArgs e)
        {
            numCS++;
            if (numCS % 2 != 0)
            {
                creamsoappanel4.Visible = true;
                creamsoappictureBox11.BackColor = Color.Red;
            }
            else
            {
                creamsoappanel4.Visible = false;
                creamsoappictureBox11.BackColor = Color.Black;

            }
        }

        private void FacewashpictureBox10_Click(object sender, EventArgs e)
        {
            numFW++;
            if (numFW % 2 != 0)
            {
                facewashpanel6.Visible = true;
                faceWashPricetextBox3.BackColor = Color.Red;
            }
            else
            {
                facewashpanel6.Visible = false;
                faceWashPricetextBox3.BackColor = Color.Black;

            }
        }

        private void handCreampictureBox12_Click(object sender, EventArgs e)
        {
            numHC++;
            if (numHC % 2 != 0)
            {
                handcreampanel8.Visible = true;
                HandCreamPricetextBox5.BackColor = Color.Red;
            }
            else
            {
                handcreampanel8.Visible = false;
                HandCreamPricetextBox5.BackColor = Color.Black;

            }
        }

        private void Subnightcreamlabel23_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(nightcreamQuanttextBox42.Text);
            if (Que > 1)
            {
                Que--;
                nightcreamQuant = Que;
                nightcreamQuanttextBox42.Text = nightcreamQuant.ToString();
            }
        }

        private void MedicalpictureBox7_Click_1(object sender, EventArgs e)
        {
            num++;
            if (num % 2 != 0)
            {
                Cartbutton1.Visible = true;
                Confirmbutton2.Visible = false;

                MedicalpictureBox7.BackColor = Color.Red;
                productslabel1.Visible = true;
                productslabel1.Text = "Medical Supplies Products";
                MedicalSuppliespanel.Visible = true;
                personalCarepanel3.Visible = false;
                selected1.Visible = false;

                Prescriptionpanel3.Visible = false;
                Veterinarypanel3.Visible = false;
                MedicalSuppliespanel.Size = new System.Drawing.Size(494, 578);
                MedicalSuppliespanel.Location = new System.Drawing.Point(846, 64);

                //
                //personalCare Panel
                //
                personalCarepanel3.Location = new System.Drawing.Point(252, 575);
                personalCarepanel3.Size = new System.Drawing.Size(166, 83);
                personalCarepictureBox.BackColor = Color.FromArgb(0, 64, 0);
                //
                //prescription medication
                //
                PrescriptionpictureBox3.BackColor = Color.FromArgb(0, 64, 0);
                Prescriptionpanel3.Location = new System.Drawing.Point(440, 575);
                Prescriptionpanel3.Size = new System.Drawing.Size(144, 83);
                //
                //vertenary Medications
                VaterinarypictureBox6.BackColor = Color.FromArgb(0, 64, 0);
                Veterinarypanel3.Location = new System.Drawing.Point(333, 513);
                Veterinarypanel3.Size = new System.Drawing.Size(80, 67);



            }
            else
            {
                MedicalpictureBox7.BackColor = Color.FromArgb(0, 64, 0);
                MedicalSuppliespanel.Size = new System.Drawing.Size(93, 78);
                MedicalSuppliespanel.Location = new System.Drawing.Point(86, 580);
                productslabel1.Visible = false;
                personalCarepanel3.Visible = false;
                Prescriptionpanel3.Visible = false;
                productslabel1.Text = "Products";
                Prescriptionpanel3.Location = new System.Drawing.Point(440, 575);
                Prescriptionpanel3.Size = new System.Drawing.Size(144, 83);
                personalCarepanel3.Location = new System.Drawing.Point(252, 575);
                personalCarepanel3.Size = new System.Drawing.Size(166, 83);
                Veterinarypanel3.Size = new System.Drawing.Size(93, 78);
                Veterinarypanel3.Location = new System.Drawing.Point(86, 580);
                MedicalSuppliespanel.Visible = false;
                selected1.Visible = false;
                Cartbutton1.Visible = true;
                Confirmbutton2.Visible = false;


            }
        }

        private void ThemometerpictureBox12_Click_1(object sender, EventArgs e)
        {
            numT++;
            if (numT % 2 != 0)
            {
                Themometerpanel.Visible = true;
                ThemometerpictureBox12.BackColor = Color.Red;
            }
            else
            {
                Themometerpanel.Visible = false;
                ThemometerpictureBox12.BackColor = Color.Black;

            }
        }

        private void SyrengepictureBox10_Click_1(object sender, EventArgs e)
        {
            numS++;
            if (numS % 2 != 0)
            {
                Syringepanel5.Visible = true;
                SyrengepictureBox10.BackColor = Color.Red;
            }
            else
            {
                Syringepanel5.Visible = false;
                SyrengepictureBox10.BackColor = Color.Black;

            }
        }

        private void BPpictureBox11_Click(object sender, EventArgs e)
        {
            numBP++;
            if (numBP % 2 != 0)
            {
                BPmonitorpanel7.Visible = true;
                BPpictureBox11.BackColor = Color.Red;
            }
            else
            {
                BPmonitorpanel7.Visible = false;
                BPpictureBox11.BackColor = Color.Black;

            }
        }

        private void OxypictureBox9_Click(object sender, EventArgs e)
        {
            numO++;
            if (numO % 2 != 0)
            {
                Oxygenatorpanel4.Visible = true;
                OxypictureBox9.BackColor = Color.Red;
            }
            else
            {
                Oxygenatorpanel4.Visible = false;
                OxypictureBox9.BackColor = Color.Black;

            }
        }

        private void AddPlasterlabel14_Click(object sender, EventArgs e)
        {
            int Que = int.Parse(PlasterQuanttextBox1.Text);
            Que++;
            plasterQuant = Que;
            PlasterQuanttextBox1.Text = plasterQuant.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void MedicalpictureBox7_Click(object sender, EventArgs e)
        {





        }

        private void label14_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void SyrengepictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void ThemometerpictureBox12_Click2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlasterpictureBox8_Click(object sender, EventArgs e)
        {


        }
    }
}

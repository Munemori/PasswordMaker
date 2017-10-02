using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PasswordMaker
{
    public partial class Form1 : Form
    {
        byte type = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // The characters to encode:
        //Kisbetűk:97-122
        //Nagybetűk: 65-90
        //Számok: 48-57
        //Szimbólumok: 33-47

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chk_low.Checked == false & chk_num.Checked == false & chk_hi.Checked == false & chk_symb.Checked == false)
            {
                MessageBox.Show("Legalább egyet ki kell választani a négy lehetőség közül", "Beállítási hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                
            }
            if (chk_low.Checked == true & chk_num.Checked == false & chk_hi.Checked == false & chk_symb.Checked == false)
            {
                //MessageBox.Show("Csak kis betűk");
                //OnlyLow();
                listBox1.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    OnlyOneType(97, 123,type); //Kisbetűk:97-122
                }
                return;
            }
            if (chk_low.Checked == false & chk_num.Checked == true & chk_hi.Checked == false & chk_symb.Checked == false)
            {
                //MessageBox.Show("Csak számok");
                listBox1.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    //Késleltetés();
                    //OnlyNumbers();
                    OnlyOneType(48, 58,type); //számok: 48-57
                }
                return;
            }
            if (chk_low.Checked == false & chk_num.Checked == false & chk_hi.Checked == true & chk_symb.Checked == false)
            {
                //MessageBox.Show("Csak nagy betűk");
                //OnlyHi();
                listBox1.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    OnlyOneType(65, 91,type);//Nagybetűk: 65-90
                }
                return;
            }
            if (chk_low.Checked == false & chk_num.Checked == false & chk_hi.Checked == false & chk_symb.Checked == true)
            {
                //MessageBox.Show("Csak szimbólumok");
                listBox1.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    OnlyOneType(33, 48,type);//Szimbólumok: 33-47
                }
                return;
            }
            else
            {
                listBox1.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    OnlyOneType(0, 0, type);
                }
            }
        }

        //nagybetű - kisbetű - szimbolum - kisbetű - nagybetű - szám - nagybetű - szimbolum - kisbetű - szimbolum - szám
        //kisbetű - szimbolum - nagybetű - szám - nagybetű

        private void OnlyLow()
        {
            MessageBox.Show("OnlyLow");
        }
        private void OnlyHi()
        {
            MessageBox.Show("OnlyHi");
        }
        private void OnlyNumbers()
        {
            //MessageBox.Show("Only Numbers");
            //Random rnd = new Random();
            //int KarakterSzám = Convert.ToInt32(numericUpDown1.Value);
            //int[] pass = new int[KarakterSzám];
            //while (KarakterSzám>0)
            //{
            //    pass[KarakterSzám-1] = Convert.ToInt32(rnd.Next(0, 9));
            //    KarakterSzám--;
            //}

            //MessageBox.Show("Only Numbers");

            Késleltetés();
            int KarakterSzám = Convert.ToInt32(numericUpDown1.Value);
            string Pass = "";
                Random rnd = new Random();
                while (KarakterSzám > 0)
                {
                rnd.Next();
                    Pass = Pass + rnd.Next(0, 10).ToString();
                    KarakterSzám--;
                }

                listBox1.Items.Add(Pass);
                listBox1.Update();
            
        }
        private void OnlySymb()
        {
            MessageBox.Show("OnlySymb");

        }
        private void Késleltetés()
        {
            System.Threading.Thread.Sleep(15);
            //for (double j = 0; j < 100901; j++)
            //{
            //    listBox1.Update();
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CopyPass = listBox1.SelectedItem.ToString();
            if (CopyPass != "")
            {
                Clipboard.SetText(CopyPass);
            }

            label2.Text = CopyPass;
            
        }
        private void OnlyOneType(int Min, int Max,byte Type)//típus átadás esetén switch/case
        {
            Késleltetés();
            int KarakterSzám = Convert.ToInt32(numericUpDown1.Value);
            string Pass = "";
            Random rnd = new Random();
            switch (Type)
            {
                case 1:
                    //Debug.Print("kb");
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(Min, Max)).ToString();//97-122
                        --KarakterSzám;
                    }
                    break;
                case 2:
                    //Debug.Print("nb");
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(Min, Max)).ToString();//65-90
                        --KarakterSzám;
                    }
                    break;
                case 3:
                    //Debug.Print("kb-nb");
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(97, 123)).ToString();//97-122 és 65-90
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        Debug.Print(KarakterSzám.ToString());
                        Pass += Convert.ToChar(rnd.Next(65, 91)).ToString();
                        --KarakterSzám;
                    }
                    break;
                case 4:
                    //Debug.Print("szá");
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(Min, Max)).ToString();//48-57
                        --KarakterSzám;
                    }
                    break;
                case 5:
                    //Debug.Print("kb-szá");//97-122  48-57
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(97, 123)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        Debug.Print(KarakterSzám.ToString());
                        Pass += Convert.ToChar(rnd.Next(48, 58)).ToString();
                        --KarakterSzám;
                    }
                    break;
                case 6:
                    //Debug.Print("nb-szá");//65-90   48-57
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(65, 91)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        Debug.Print(KarakterSzám.ToString());
                        Pass += Convert.ToChar(rnd.Next(48, 58)).ToString();
                        --KarakterSzám;
                    }
                    break;
                case 7:
                    //Debug.Print("kb-nb-szá");//97-122   65-90   48-57
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(97, 123)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        if (rnd.Next(1,3)==2)
                        {
                            Pass += Convert.ToChar(rnd.Next(65, 91)).ToString();
                        }
                        else
                        {
                            Pass += Convert.ToChar(rnd.Next(48, 58)).ToString();
                        }
                        --KarakterSzám;
                        //if (KarakterSzám == 0) break;
                        //Debug.Print(KarakterSzám.ToString());
                        //Pass += Convert.ToChar(rnd.Next(48, 58)).ToString();
                        //--KarakterSzám;
                    }
                    break;
                case 8:
                    //Debug.Print("szi");
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(Min, Max)).ToString();//33-47
                        --KarakterSzám;
                    }
                    break;
                case 9:
                    //Debug.Print("kb-szi");//97-122  33-47
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(97, 123)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        Debug.Print(KarakterSzám.ToString());
                        Pass += Convert.ToChar(rnd.Next(33, 48)).ToString();
                        --KarakterSzám;
                    }
                    break;
                case 10:
                    //Debug.Print("nb-szi");//65-90   33-47
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(65, 91)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        Debug.Print(KarakterSzám.ToString());
                        Pass += Convert.ToChar(rnd.Next(33, 48)).ToString();
                        --KarakterSzám;
                    }
                    break;
                case 11:
                    //Debug.Print("kb-nb-szi");//97-122   65-90   33-47
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(97, 123)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        if (rnd.Next(1, 3) == 2)
                        {
                            Pass += Convert.ToChar(rnd.Next(65, 91)).ToString();
                        }
                        else
                        {
                            Pass += Convert.ToChar(rnd.Next(33, 48)).ToString();
                        }
                        --KarakterSzám;
                        
                    }
                    break;
                case 12:
                    //Debug.Print("szá-szi");//48-57  33-47
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(48, 58)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        Debug.Print(KarakterSzám.ToString());
                        Pass += Convert.ToChar(rnd.Next(33, 48)).ToString();
                        --KarakterSzám;
                    }
                    break;
                case 13:
                    //Debug.Print("kb-szá-szi");//97-122  48-57   33-47
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(97, 123)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        if (rnd.Next(1, 3) == 2)
                        {
                            Pass += Convert.ToChar(rnd.Next(48, 58)).ToString();
                        }
                        else
                        {
                            Pass += Convert.ToChar(rnd.Next(33, 48)).ToString();
                        }
                        --KarakterSzám;

                    }
                    break;
                case 14:
                    //Debug.Print("nb-szá-szi");//65-90   48-57   33-47
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(65, 90)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        if (rnd.Next(1, 3) == 2)
                        {
                            Pass += Convert.ToChar(rnd.Next(48, 58)).ToString();
                        }
                        else
                        {
                            Pass += Convert.ToChar(rnd.Next(33, 48)).ToString();
                        }
                        --KarakterSzám;

                    }
                    break;
                case 15:
                    //Debug.Print("mind");//97-122    65-90   48-57   33-47
                    while (KarakterSzám > 0)
                    {
                        rnd.Next();
                        Pass += Convert.ToChar(rnd.Next(65, 90)).ToString();
                        --KarakterSzám;
                        if (KarakterSzám == 0) break;
                        int typC = rnd.Next(2, 5);
                        if (typC == 2)
                        {
                            Pass += Convert.ToChar(rnd.Next(97,123)).ToString();
                        }
                        else if(typC==3)
                        {
                            Pass += Convert.ToChar(rnd.Next(48,58)).ToString();
                        }
                        else
                        {
                            Pass += Convert.ToChar(rnd.Next(33, 48)).ToString();
                        }
                        --KarakterSzám;

                    }
                    break;
                default:
                    break;
            }
            //int KarakterSzám = Convert.ToInt32(numericUpDown1.Value);
            //char PassCh ='\0';
            //string Pass = "";
            //Random rnd = new Random();
            //while (KarakterSzám > 0)
            //{
            //    rnd.Next();
            //    //PassCh = Convert.ToChar(rnd.Next(Min, Max));
            //    Pass += Convert.ToChar(rnd.Next(Min, Max)).ToString();
            //    KarakterSzám--;
            //}

            listBox1.Items.Add(Pass);
            listBox1.SelectedIndex = 0;
            listBox1.Update();
        }



        private void chk_low_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_low.Checked==true)
            {
                type++;
                Debug.Print(type.ToString());
            }
            else
            {
                type--;
                Debug.Print(type.ToString());
            }
            
        }

        private void chk_hi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hi.Checked==true)
            {
                type += 2;
                Debug.Print(type.ToString());
            }
            else
            {
                type -= 2;
                Debug.Print(type.ToString());
            }
        }

        private void chk_num_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_num.Checked == true)
            {
                type += 4;
                Debug.Print(type.ToString());
            }
            else
            {
                type -= 4;
                Debug.Print(type.ToString());
            }
        }

        private void chk_symb_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_symb.Checked == true)
            {
                type += 8;
                Debug.Print(type.ToString());
            }
            else
            {
                type -= 8;
                Debug.Print(type.ToString());
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Process.Start(linkLabel2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

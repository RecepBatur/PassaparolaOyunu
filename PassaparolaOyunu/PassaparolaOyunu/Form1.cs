using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaparolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        void temizle()
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                
                switch (soruNo)
                {
                    //cevap1
                    case 1:
                        if(textBox1.Text == "ankara")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            

                        }
                        
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            
                        }
                        break;

                        //cevap2
                        case 2:
                        if(textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;

                        //cevap3
                        case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text= dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;

                    //cevap4
                    case 4:
                        if (textBox1.Text == "dekan")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                        //cevap5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap8
                    case 8:
                        if (textBox1.Text == "hatay")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap9
                    case 9:
                        if (textBox1.Text == "ısı")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap10
                    case 10:
                        if (textBox1.Text == "istanbul")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap12
                    case 12:
                        if (textBox1.Text == "kemal tahir")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap14
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap16
                    case 16:
                        if (textBox1.Text == "okey")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap20
                    case 20:
                        if (textBox1.Text == "teneke")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap21
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap22
                    case 22:
                        if (textBox1.Text == "vali")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap23
                    case 23:
                        if (textBox1.Text == "yaşar kemal")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    //cevap24
                    case 24:
                        if (textBox1.Text == "zaman")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                        }
                        break;
                        
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //form ilk açıldığında Başla yazacak. Tıklayınca sonraki yazacak.
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString(); //form başlığına soruNo'yu yazdırdık.
            temizle();



            if (soruNo == 1)
            {
                richTextBox1.Text = "Türkiye'nin başkenti neresidir?";
                button1.BackColor = Color.Yellow;

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara ilimiz?";
                button2.BackColor = Color.Yellow;

            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;

            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Fakülte yöneticisine ne denir?";
                button4.BackColor = Color.Yellow;

            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamı?";
                button5.BackColor = Color.Yellow;

            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;

            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünya'nın ısı kaynağı?";
                button7.BackColor = Color.Yellow;

            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Gazi Mustafa Kemal Atatürk'ün son olarak topraklarımıza kattığı şehir neresidir?";
                button8.BackColor = Color.Yellow;

            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Madde moleküllerinin hareketi nedeniyle meydana gelen enerji?";
                button9.BackColor = Color.Yellow;

            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Yeditepeli şehir olarak adlandırılan ilimiz neresidir?";
                button10.BackColor = Color.Yellow;

            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri birliklerimizden birisi?";
                button11.BackColor = Color.Yellow;

            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Devlet Ana eseri hangi yazarımıza aittir?";
                button12.BackColor = Color.Yellow;

            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                button13.BackColor = Color.Yellow;

            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı hangisidir?";
                button14.BackColor = Color.Yellow;

            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button15.BackColor = Color.Yellow;

            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "4 kişilik olarak oynanan bir masa oyunu?";
                button16.BackColor = Color.Yellow;

            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç ve havuç ile yapılan yemek?";
                button17.BackColor = Color.Yellow;

            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "On bir ayın sultanı?";
                button18.BackColor = Color.Yellow;

            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan kelimesinin karşılığı?";
                button19.BackColor = Color.Yellow;

            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Yaşar Kemal'in yazmış olduğu öykü kitabından biri?";
                button20.BackColor = Color.Yellow;

            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamı?";
                button21.BackColor = Color.Yellow;

            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Bir ilde işleri hükümet adına yöneten en yetkili yönetici?";
                button22.BackColor = Color.Yellow;

            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Gözüyle kartal avlayan yazarımız?";
                button23.BackColor = Color.Yellow;

            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Bir iş ya da oluşun, bir eylemin içinde geçmekte olduğu, geçtiği ya da geçeceği süre?";
                button24.BackColor = Color.Yellow;

            }
        }
    }
}

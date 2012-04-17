using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        // criar variaveis aqui :d
        bool computadorJoga = false;
        Random random = new Random();
        int sorteio;
        Button[] button = new Button[9];
        string escolhaPlayer;
        string escolhaComputador;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            button[0] = button1;
            button[1] = button2;
            button[2] = button3;
            button[3] = button4;
            button[4] = button5;
            button[5] = button6;
            button[6] = button7;
            button[7] = button8;
            button[8] = button9;

          
            
            
        }

        void Comecar() {

            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
        }

        void Termino() {

            for (int q = 0; q < button.Length; q++) {
                button[q].Enabled = false;
                
                
            }
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            escolhaPlayer = "X";
            escolhaComputador = "O";
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            escolhaPlayer = "O";
            escolhaComputador = "X";
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                Comecar();
                if (button[0].Text == escolhaPlayer || button[0].Text == escolhaComputador)
                button[0].Text = escolhaPlayer;
            
                computadorJoga = true;
                sorteio = random.Next(0, 9);
                i = 0;
                while (button[sorteio].Text != "")
                {
                    sorteio = random.Next(0, 9);

                    i++;
                    if (i >= button.Length - 1)
                    {
                        break;
                        
                    }
                    
                }
                if (i >= button.Length - 1)
                {
                    Termino();
                }
                
                button[sorteio].Text = escolhaComputador;
                

                
            

            
        
       
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                Comecar();
                button2.Text = escolhaPlayer;
                computadorJoga = true;
                sorteio = random.Next(0, 9);
                i = 0;
                while ( button[sorteio].Text != "")
                {
                    sorteio = random.Next(0, 9);

                    i ++;
                    if (i >= button.Length - 1) {
                        break;
                        
                    }
                    
                }
                if (i >= button.Length - 1)
                {
                    Termino();
                }
                button[sorteio].Text = escolhaComputador;
            }

            
        
        
        
        

        

        private void button3_Click(object sender, EventArgs e)
        {
            
                Comecar();
            button3.Text = escolhaPlayer;
            computadorJoga = true;
            sorteio = random.Next(0, 9);
            i = 0;
            while (button[sorteio].Text != "")
            {
                sorteio = random.Next(0, 9);

                i++;
                if (i >= button.Length - 1)
                {
                    break;
                    
                }
                
            }
            if (i >= button.Length - 1)
            {
                Termino();
            }
            button[sorteio].Text = escolhaComputador;
            


            
        
        
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                Comecar();
                button5.Text = escolhaPlayer;
                computadorJoga = true;
                sorteio = random.Next(0, 9);
                i = 0;
                while (button[sorteio].Text != "")
                {
                    sorteio = random.Next(0, 9);

                    i++;
                    if (i >= button.Length - 1)
                    {
                        break;
                        
                    }
                    
                }
                if (i >= button.Length - 1)
                {
                    Termino();
                }
                button[sorteio].Text = escolhaComputador;
            


            
        
        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                Comecar();
            button4.Text = escolhaPlayer;
            computadorJoga = true;
            sorteio = random.Next(0, 9);
            i = 0;
            while (button[sorteio].Text != "")
            {
                sorteio = random.Next(0, 9);

                i++;
                if (i >= button.Length - 1)
                {
                    break;
                    
                }
                
            }
            if (i >= button.Length - 1)
            {
                Termino();
            }
            button[sorteio].Text = escolhaComputador;
            


            
        
        
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                Comecar();
            button8.Text = escolhaPlayer;
            computadorJoga = true;
            sorteio = random.Next(0, 9);
            i = 0;
            while (button[sorteio].Text != "")
            {
                sorteio = random.Next(0, 9);

                i++;
                if (i >= button.Length - 1)
                {
                    break;
                    
                }
                
            }
            if (i >= button.Length - 1)
            {
                Termino();
            }
            button[sorteio].Text = escolhaComputador;
            


            
        
        
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                Comecar();
            button6.Text = escolhaPlayer;
            computadorJoga = true;
            sorteio = random.Next(0, 9);
            i = 0;
            while (button[sorteio].Text != "")
            {
                sorteio = random.Next(0, 9);

                i++;
                if (i >= button.Length - 1)
                {
                    break;
                }
                
            }
            if (i >= button.Length - 1)
            {
                Termino();
            }
            button[sorteio].Text = escolhaComputador;
            


            
        
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                Comecar();
            button7.Text = escolhaPlayer;
            computadorJoga = true;
            sorteio = random.Next(0, 9);
            i = 0;
            while (button[sorteio].Text != "")
            {
                sorteio = random.Next(0, 9);

                i++;
                if (i >= button.Length - 1)
                {
                    break;
                }
                
            }
            if (i >= button.Length - 1)
            {
                Termino();
            }
            button[sorteio].Text = escolhaComputador;
            

            

        }
        private void button9_Click(object sender, EventArgs e)
        {
            
                Comecar();
            button9.Text = escolhaPlayer;
            computadorJoga = true;
            sorteio = random.Next(0, 9);
            i = 0;
            while (button[sorteio].Text != "")
            {
                sorteio = random.Next(0, 9);

                i++;
                if (i >= button.Length )
                {
                    break;
                    
                }
                
            }
            if (i >= button.Length - 1)
            {   

                Termino();
            }
            button[sorteio].Text = escolhaComputador;
            

            
        
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        
    
        
    
    }
     
}

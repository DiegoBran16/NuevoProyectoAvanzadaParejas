using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
    public partial class ModReg : Form
    {
        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        string usuarioActualM;
        Reglamentos[] tmp = new Reglamentos[5];
        queue copiasLey = new queue();
        ArrayList mostrar = new ArrayList();
        ArrayList mostrarReg = new ArrayList();


        public ModReg(Usuario[] u, Grupo[] g, string us, Ley[] bl = null)
        {
            InitializeComponent();
            users = u;
            grupos = g;
            usuarioActualM = us;
            biblioLeyes = bl;

            for (int i = 0; i < 500; i++)
            {
                if (biblioLeyes[i] != null)
                {
                    mostrar.Add(biblioLeyes[i].getinfoDeLey());
                }
            }

            for (int i = 0; i < mostrar.Count; i++)
            {
                listBox1.Items.Add(mostrar[i]);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu(users, grupos, usuarioActualM, biblioLeyes);
            m.Show();
            this.Hide();
        }

        private void ModReg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (verificarLey() == false && verificarReg() == true)
            {

                if (verificarReg() == false)
                {
                    MessageBox.Show(" el reglamento  no se encuentra en el sistema");
                    break;
                }
                tmp[posicionReg()].retirarCopiasMod(txtReg.Text);
                tmp[posicionReg()].setInfoReglamento(txtNewReg.Text);
                tmp[posicionReg()].asignarCopiasR();



                menu m = new menu(users, grupos, usuarioActualM, biblioLeyes);
                m.Show();
                this.Hide();
                break;

            }
            if (verificarLey() == true)
            {
                MessageBox.Show(" la ley no se encuentra en el sistema");
            }



        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool verificarLey()
        {
            for (int n = 0; n < 500; n++)
            {
                if (biblioLeyes[n] != null)
                {
                    if (biblioLeyes[n].getinfoDeLey() == txtLey.Text)
                    {
                        return false;
                        break;
                    }
                }
            }

            return true;
        }

        private bool verificarReg()
        {
            if (verificarLey() == false)
            {
                for (int n = 0; n < 500; n++)
                {
                    if (biblioLeyes[n] != null)
                    {
                        tmp = biblioLeyes[n].getReglamentos();
                        if (tmp[posicionReg()].getInfoReglamento() == txtReg.Text)
                        {
                            return true;
                                break;
                        }
                           
                    }
                }
            }


            return false;
        }
        public int posicionReg()
        {
            int num = 0;
            for (int i = 0; i < 5; i++)
            {
                if (tmp[i] != null)
                {
                    if (tmp[i].getInfoReglamento() == txtReg.Text)
                    {
                        return i;
                    }
                }
            }
            return num;
        }

        private void txtLey_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (verificarLey() == true|| txtLey.Text=="")
            {
                MessageBox.Show(" la ley no esta disponible");
            }
            if (verificarLey() == false)
            {
                for (int i = 0; i < 500; i++)
                {
                    while (biblioLeyes[i] != null && biblioLeyes[i].getinfoDeLey() == txtLey.Text)
                    {
                        Reglamentos[] reg = new Reglamentos[5];
                        reg = biblioLeyes[i].getReglamentos();
                        for (int a = 0; a < 5; a++)
                        {
                            if (reg[a] != null)
                            {
                                mostrarReg.Add(reg[a].getInfoReglamento());
                                
                            }

                        }
                        for (int l = 0; l < mostrar.Count; l++)
                        {
                            listBox2.Items.Add(mostrarReg[l]);
                        }
                        break;
                      
                    }
                }
            }
        }
    }
}

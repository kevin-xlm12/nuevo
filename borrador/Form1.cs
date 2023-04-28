using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrador
{
    public partial class Form1 : Form
    {
        enum dias { lunes, martes, miercoles, jueves, viernes, sabado, domingo };
        public Form1()
        {
            InitializeComponent();
        }
        int []nums = new int[6]{4,3,32,21,2,3,};
        String []nombres = { "juan", "pedro", "javier", "roberto", "pedro", "raul" };
        private void Form1_Load(object sender, EventArgs e)
        {
          // foreach (int i in nums)
          //  {
          //     MessageBox.Show(i.ToString());
          // }
          
            listBox1.Items.AddRange(nombres);
            dataGridView1.Columns.Add("nombres","");
            foreach (String i in nombres)
            {
                dataGridView1.Rows.Add(i);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboDias.Items.AddRange(Enum.GetNames(typeof(dias)));
            cboDias.SelectedIndex = 0;
           

        }

        private void cboDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            dias miDia;
            miDia = (dias)cboDias.SelectedIndex;
             switch (miDia)
            {
              case dias.domingo:
              lblDias.Text = "feriado  " + Enum.GetName(typeof(dias), miDia);
              break;
             default:
             lblDias.Text ="laborable";
              break;
           }
        }
    }
}

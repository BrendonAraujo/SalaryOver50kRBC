using RBC_Salario.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBC_Salario
{
    public partial class Form2 : Form
    {
        List<Case> casesPrint;
        Case atualCase;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Case> cases, Case atualCase)
        {
            InitializeComponent();
            this.casesPrint = cases;
            this.atualCase = atualCase;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] row0 = { };
            int cont = 1;
            foreach (Case c in this.casesPrint)
            {
                tableOrderCase.Rows.Add(
                    Convert.ToString(cont),
                    Convert.ToString(Convert.ToInt32(c.Totalsimilarity*100))+" %",
                    Convert.ToString(c.handle),
                    Convert.ToString(c.age),
                    c.maritalStatus,
                    c.occupation,
                    c.relationShip,
                    c.race,
                    c.sex,
                    c.hourPerWeek,
                    c.workClass
                );
                cont++;
            }
            
            //string[] row0 = { "11/22/1968", "29", "Revolution 9",
            //"Beatles", "The Beatles [White Album]" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaseDAO.insertCase(atualCase);
        }
    }
}

using System.Data.SqlClient;
using RBC_Salario.DB;
using RBC_Salario.Controler;

namespace RBC_Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(ageInput.Value);
            string workClass = workClasscomboBox.Text;
            string education = educationComboBox.Text;
            string maritalStatus = maritalStatuscomboBox.Text;
            string occupation =  occupationcomboBox.Text;
            string relationShip = relactionshipComboBox.Text;
            string race = raceComboBox.Text;
            string sex = femaleRadio.Checked ? femaleRadio.Text : maleRadio.Text;
            int hourPerWeek = Convert.ToInt32(hourPerWekInput.Value);
            string nativeCountry = nativeCountrycomboBox.Text;

            //RBC É o validador que executará toda a lógica para comparação dos dados
            RBC sys = new RBC(age, workClass, education, maritalStatus, occupation,relationShip, race, sex, hourPerWeek, nativeCountry);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> educationList = CaseDAO.getEducationList();
            foreach(String education in educationList)
            {
                educationComboBox.Items.Add(education);
            }

            List<String> maritalStatusList = CaseDAO.getMaritalStatusList();
            foreach (String maritalStatus in maritalStatusList)
            {
                maritalStatuscomboBox.Items.Add(maritalStatus);
            }

            List<String> OcupationList = CaseDAO.getOcupationList();
            foreach (String ocupation in OcupationList)
            {
                occupationcomboBox.Items.Add(ocupation);
            }

            List<String> relationshipList = CaseDAO.getRelationShipList();
            foreach (String relationship in relationshipList)
            {
                relactionshipComboBox.Items.Add(relationship);
            }

            List<String> raceList = CaseDAO.getRaceList();
            foreach (String race in raceList)
            {
                raceComboBox.Items.Add(race);
            }

            List<String> workClassList = CaseDAO.getWorkClassList();
            foreach (String workClass in workClassList)
            {
                workClasscomboBox.Items.Add(workClass);
            }

            List<String> nativeCountryList = CaseDAO.getNativeCountryList();
            foreach (String nativeCountry in nativeCountryList)
            {
                nativeCountrycomboBox.Items.Add(nativeCountry);
            }
        }
    }
}
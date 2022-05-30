using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBC_Salario.Controler
{
    public class RBC
    { 
        //Método RBC é responsável por toda a lógica de comparação
        // Ideia é criar obter uma lista de dados do DAO e criar todos os casos e em seguida validar individualmente sua similariedade
        // Com o "NewCase", cada setando para cada atributo um valor de similariedade.
        // Depois, criar chamar um novo método, responsável por verificar o peso de cada atributo e calcular a similariedade geral.
        public RBC(int age, string workClass, string education, string maritalStatus, string occupation, string relationShip, string race, string sex, int hourPerWeek, string nativeCountry)
        {
            List<Case> caseList = new List<Case>();
            List<Case> orderCaseList = new List<Case>();

            Case newCase = new Case(age, workClass, education, maritalStatus, occupation, relationShip, race, sex, hourPerWeek, nativeCountry);
            int contador = 0;
            caseList = buildCaseList(CaseDAO.GetCases());
            checkSimilarityAttribute(newCase, caseList);

            foreach( Case c in caseList)
            {
                calcSimitarityTotal(c);
            }

            orderCaseList = caseList.OrderByDescending(x => x.Totalsimilarity).ToList();
            new Form2(orderCaseList, newCase).Show();

        }
        public static List<Case> buildCaseList(SqlDataReader queryResult) {
            List<Case> caseList = new List<Case>();

            //Busca a posicação da coluna na tabela
            int handleCollumPosition = queryResult.GetOrdinal("handle");
            int ageCollumPosition = queryResult.GetOrdinal("age");
            int workClassCollumPosition = queryResult.GetOrdinal("workclass");
            int educationCollumPosition = queryResult.GetOrdinal("education");
            int maritalStatusCollumPosition = queryResult.GetOrdinal("marital_status");
            int occupationCollumPosition = queryResult.GetOrdinal("occupation");
            int relationShipCollumPosition = queryResult.GetOrdinal("relationship");
            int raceCollumPosition = queryResult.GetOrdinal("race");
            int sexCollumPosition = queryResult.GetOrdinal("sex");
            int hourPerWeekCollumPosition = queryResult.GetOrdinal("hour_per_week");
            int nativeCountryCollumPosition = queryResult.GetOrdinal("native_country");

            //Percorre o resultado do banco de dados e cria um caso para cada linha, adcionando numa lista de objetos
            while (queryResult.Read())
            {
                Case dbCase = new Case(
                     queryResult.GetInt32(handleCollumPosition),
                     Convert.ToInt32(queryResult.GetDouble(ageCollumPosition)) , 
                     queryResult.GetString(workClassCollumPosition),
                     queryResult.GetString(educationCollumPosition),
                     queryResult.GetString(maritalStatusCollumPosition),
                     queryResult.GetString(occupationCollumPosition),
                     queryResult.GetString(relationShipCollumPosition),
                     queryResult.GetString(raceCollumPosition),
                     queryResult.GetString(sexCollumPosition),
                     Convert.ToInt32(queryResult.GetDouble(hourPerWeekCollumPosition)),
                     queryResult.GetString(nativeCountryCollumPosition)
                 );
                 caseList.Add(dbCase);
            }
            queryResult.Close();
            return caseList;
        }
        public static void calcSimitarityTotal(Case listedCase)
        {
            int totalWeight = listedCase.getTotalWeight();
            int totalCase = CaseDAO.getSumRowCase();
            double totalsimilarity = 0;

            double ageWeight = Convert.ToDouble(listedCase.getWeightAge());
            int workClassWeight = listedCase.getWeightWorkClass();
            int educationWeight = listedCase.getWeightEducation();
            int maritalStatusWeight = listedCase.getWeightMaritalStatus();
            int occupationWeight = listedCase.getWeightOccupation();
            int relationshipWeight = listedCase.getWeightRelationship();
            int raceWeight = listedCase.getWeightRace();
            int hourPerWeekWeight = listedCase.getWeightHourPerWeek();
            int nativeCountryWeight = listedCase.getWeightNativeCountry();


            //Calc for real age weight
            totalsimilarity += (listedCase.getSimilarityAge() * ageWeight) / totalWeight;
            totalsimilarity += (listedCase.getSimilarityWorkClass() * workClassWeight) / totalWeight;
            totalsimilarity += (listedCase.getSimilarityEducation() * educationWeight) / totalWeight;
            totalsimilarity += (listedCase.getSimilarityMaritalStatus() * maritalStatusWeight) / totalWeight;
            totalsimilarity += (listedCase.getSimilarityOccupation() * occupationWeight) / totalWeight;
            totalsimilarity += (listedCase.getSimilarityRelationship() * relationshipWeight) / totalWeight;
            totalsimilarity += (listedCase.getSimilarityRace() * raceWeight) / totalWeight;
            totalsimilarity += (listedCase.getSimilarityHourPerWeek() * hourPerWeekWeight) / totalWeight;
            totalsimilarity += (listedCase.getSimilarityNativeCountry() * nativeCountryWeight) / totalWeight;

            listedCase.setSimilarityTotal(totalsimilarity);
        }
        public static void checkSimilarityAttribute(Case atualCase,List<Case> caseList)
        {
            //Passa caso por caso da base calculando a similariedade de cada caso;
            foreach (Case lookCase in caseList)
            {
                lookCase.setSimilarityAge(calcSimilarityAge(atualCase.age, lookCase.age));
                lookCase.setSimilarityWorkClass(calcSimilarityWorkClass(atualCase.workClass, lookCase.workClass));
                lookCase.setSimilarityEducation(calcSimilarityEducation(atualCase.education, lookCase.education));
                lookCase.setSimilarityMaritalStatus(calcSimilarityMaritalStatus(atualCase.maritalStatus, lookCase.maritalStatus));
                lookCase.setSimilarityOccupation(calcSimilarityOccupation(atualCase.occupation, lookCase.occupation));
                lookCase.setSimilarityRelationship(calcSimilarityRelationShip(atualCase.relationShip, lookCase.relationShip));
                lookCase.setSimilarityRace(calcSimilarityRace(atualCase.race, lookCase.race));
                lookCase.setSimilaritySex(calcSimilaritySex(atualCase.sex, lookCase.sex));
                lookCase.setSimilarityHourPerWeek(calcSimilarityHourPerWeek(atualCase.hourPerWeek, lookCase.hourPerWeek));
                lookCase.setSimilarityNativeCountry(calcSimilarityNativeCountry(atualCase.nativeCountry, lookCase.nativeCountry));
            }
        }
        public static double calcSimilarityAge(int newAge, int ageCase)
        {
            double similarity = 0;
            if ( newAge == ageCase )
            {
                similarity = 1;
            }else if ( (newAge > (ageCase - 3)) || (newAge > (ageCase + 3)) )
            {
                similarity = 0.5;
            }
            return similarity;
        }
        public static double calcSimilarityWorkClass(string newWorkClass, string c)
        {
            double similarity = 0;
            if (newWorkClass == newWorkClass)
            {
                similarity = 1;
            }
            return similarity;
        }
        public static double calcSimilarityEducation(string newEducation, string educationCase)
        {
            double similarity = 0;
            if ( newEducation == educationCase)
            {
                similarity = 1;
            }
            return similarity;
        }
        public static double calcSimilarityMaritalStatus(string newMaritalStatus, string maritalStatusCase)
        {
            double similarity = 0;
            if (newMaritalStatus == maritalStatusCase)
            {
                similarity = 1;
            }
            return similarity;
        }
        public static double calcSimilarityOccupation(string newOccupation, string OccupationCase)
        {
            double similarity = 0;
            if (newOccupation == OccupationCase)
            {
                similarity = 1;
            }
            return similarity;
        }
        public static double calcSimilarityRelationShip(string newRelationship, string RelationshipCase)
        {
            double similarity = 0;
            if (newRelationship == RelationshipCase)
            {
                similarity = 1;
            }
            return similarity;
        }
        public static double calcSimilarityRace(string newRace, string raceCase)
        {
            double similarity = 0;
            if (newRace == raceCase)
            {
                similarity = 1;
            }
            return similarity;
        }
        public static double calcSimilaritySex(string newSex, string sexCase)
        {
            double similarity = 0;
            if (newSex == sexCase)
            {
                similarity = 1;
            }
            return similarity;
        }
        public static double calcSimilarityHourPerWeek(int newHourPerWeek, int hourPerWeekCase)
        {
            double similarity = 0;
            if (newHourPerWeek == hourPerWeekCase)
            {
                similarity = 1;
            }
            return similarity;
        }
        public static double calcSimilarityNativeCountry(string newNativeCountry, string nativeCountryCase)
        {
            double similarity = 0;
            if (newNativeCountry == nativeCountryCase)
            {
                similarity = 1;
            }
            return similarity;
        }
    }
}

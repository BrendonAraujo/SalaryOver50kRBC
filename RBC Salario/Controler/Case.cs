using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBC_Salario.Controler
{
    public class Case
    {
        //Atributos do caso
        public int handle;
        public int age;
        public string workClass;
        public string education;
        public string maritalStatus;
        public string occupation;
        public string relationShip;
        public string race;
        public string sex;
        public int hourPerWeek;
        public string nativeCountry;

        public double Totalsimilarity;

        // Similariedade individual de cada atributo
        private double similarity_Age;
        private double similarity_WorkClass;
        private double similarity_Education;
        private double similarityMaritalStatus;
        private double similarityOccupation;
        private double similarityRelationShip;
        private double similarityRace;
        private double similaritySex;
        private double similarityhourPerWeek;
        private double similarityNativeCountry;

        //Peso de cada atributo (alterar aqui quando quiser alterar prioridade dos atributos
        private int weight_Age = 3;
        private int weight_WorkClass = 4;
        private int weight_Education = 4;
        private int weightMaritalStatus = 3;
        private int weightOccupation = 5;
        private int weightRelationShip = 3;
        private int weightRace = 3;
        private int weightSex = 4;
        private int weighthourPerWeek = 3;
        private int weightNativeCountry = 5;

        //Método criador da classe para método atual
        public Case(int age, string workClass, string education, string maritalStatus, string occupation, string relationShip, string race, string sex, int hourPerWeek, string nativeCountry)
        {
            this.age = age;
            this.workClass = workClass;
            this.education = education;
            this.maritalStatus = maritalStatus;
            this.occupation = occupation;
            this.relationShip = relationShip;
            this.race = race;
            this.sex = sex;
            this.hourPerWeek = hourPerWeek;
            this.nativeCountry = nativeCountry;
        }
        //Método criador da classe para usar na lista retornada do banco.
        public Case(int handle, int age, string workClass, string education, string maritalStatus, string occupation, string relationShip, string race, string sex, int hourPerWeek, string nativeCountry)
        {
            this.handle = handle;
            this.age = age;
            this.workClass = workClass;
            this.education = education;
            this.maritalStatus = maritalStatus;
            this.occupation = occupation;
            this.relationShip = relationShip;
            this.race = race;
            this.sex = sex;
            this.hourPerWeek = hourPerWeek;
            this.nativeCountry = nativeCountry;
        }


        //Get weight block
        public int getTotalWeight()
        {
            return this.weight_Age + this.weight_WorkClass + this.weight_Education + this.weightMaritalStatus + this.weightOccupation + this.weightRelationShip + this.weightRace + this.weighthourPerWeek + this.weightNativeCountry;
        }
        public int getWeightAge()
        {
            return this.weight_Age;
        }
        public int getWeightWorkClass()
        {
            return this.weight_WorkClass;
        }
        public int getWeightEducation()
        {
            return this.weight_Education;
        }
        public int getWeightMaritalStatus()
        {
            return this.weightMaritalStatus;
        }
        public int getWeightOccupation()
        {
            return this.weightOccupation;
        }
        public int getWeightRelationship()
        {
            return this.weightRelationShip;
        }
        public int getWeightRace()
        {
            return this.weightRace;
        }
        public int getWeightSex()
        {
            return this.weightSex;
        }
        public int getWeightHourPerWeek()
        {
            return this.weighthourPerWeek;
        }
        public int getWeightNativeCountry()
        {
            return this.weightNativeCountry;
        }
        // End of get Weight

        //Set similariity block
        public void setSimilarityTotal(double similarity)
        {
            this.Totalsimilarity = similarity;
        }
        public void setSimilarityAge(double similarity)
        {
            this.similarity_Age = similarity;
        }
        public void setSimilarityWorkClass(double similarity)
        {
            this.similarity_WorkClass = similarity;
        }
        public void setSimilarityEducation(double similarity)
        {
            this.similarity_Education = similarity;
        }
        public void setSimilarityMaritalStatus(double similarity)
        {
            this.similarityMaritalStatus = similarity;
        }
        public void setSimilarityOccupation(double similarity)
        {
            this.similarityOccupation = similarity;
        }
        public void setSimilarityRelationship(double similarity)
        {
            this.similarityRelationShip = similarity;
        }
        public void setSimilarityRace(double similarity)
        {
            this.similarityRace = similarity;
        }
        public void setSimilaritySex(double similarity)
        {
            this.similaritySex = similarity;
        }
        public void setSimilarityHourPerWeek(double similarity)
        {
            this.similarityhourPerWeek = similarity;
        }
        public void setSimilarityNativeCountry(double similarity)
        {
            this.similarityNativeCountry = similarity;
        }
        //End of Set similariity block

        //Get Similarity block
        public double getSimilarityTotal()
        {
            return this.Totalsimilarity;
        }
        public double getSimilarityAge()
        {
            return this.similarity_Age;
        }
        public double getSimilarityWorkClass()
        {
            return this.similarity_WorkClass;
        }
        public double getSimilarityEducation()
        {
            return this.similarity_Education;
        }
        public double getSimilarityMaritalStatus()
        {
            return this.similarityMaritalStatus;
        }
        public double getSimilarityOccupation()
        {
            return this.similarityOccupation;
        }
        public double getSimilarityRelationship()
        {
            return this.similarityRelationShip;
        }
        public double getSimilarityRace()
        {
            return this.similarityRace;
        }
        public double getSimilaritySex()
        {
            return this.similaritySex;
        }
        public double getSimilarityHourPerWeek()
        {
            return this.similarityhourPerWeek;
        }
        public double getSimilarityNativeCountry()
        {
            return this.similarityNativeCountry;
        }
    }
}

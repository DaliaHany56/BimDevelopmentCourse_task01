using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
        
            //As a Structural Engineer

            int NoOfFloor = 5;
            Console.WriteLine(" please insert number of the floor ");
            Console.ReadLine();
            Console.WriteLine(NoOfFloor);

            Console.WriteLine();
            Console.WriteLine("----------------------------");

            //As an Architecture Engineer 

            int length = 3;
            int width = 5;
            int height = 6;

            Console.WriteLine(" please insert the value of length , width , height ");
            Console.ReadLine();
            Console.WriteLine(length);
            Console.WriteLine(width);
            Console.WriteLine(height);
            Console.WriteLine();

            Console.WriteLine("----------------------------");
            Console.ReadLine();
            //As an MEP engineer
            string equipment01 = "DUCT";
            string equipment02 = "Hydronic Heating";

            Console.WriteLine("equipment 01=" + equipment01);
            Console.WriteLine("equipment 02=" + equipment02);
            bool result = (equipment01 != equipment02);
            Console.WriteLine(result);

            if (result != false)
            {
                equipment02 = equipment01;
            }
            Console.WriteLine("equipment 01=" + equipment02);
            Console.WriteLine("equipment 02=" + equipment02);
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.ReadLine();
            //DATA TYPE
            Double lenght1 = 5.5;
            double weight1 =6.7;
            double totalWeight0fSteelBeams = lenght1*weight1;
            Console.WriteLine(totalWeight0fSteelBeams);

            Console.WriteLine("insert lenght2");
           double UserRespond01 = double.Parse(Console.ReadLine()); 
         
            Console.WriteLine("lenght2=" + UserRespond01);
            Console.WriteLine("insert weight2 ");
           double userRespond02 = double.Parse(Console.ReadLine());

            Console.WriteLine("weight2=" + userRespond02);

            double totalWeight0fSteelBeams2 = UserRespond01 * userRespond02;
            Console.WriteLine(totalWeight0fSteelBeams2);

            Console.WriteLine();

            Console.WriteLine("----------------------------");
            Console.ReadLine();
            Console.WriteLine("Is a room accessible to disabled individuals?");
            int ARoomAccessibleToDisabledIndividuals = 1;
            int ARoomNnotAccessibleToDisabledIndividuals =0;
            int x = 1;
          
            bool result3 = (ARoomAccessibleToDisabledIndividuals == x);
            Console.WriteLine(result3);
            if (result3 == true)
            {
                Console.WriteLine("A room accessible to disabled individuals"); 
            }
            bool result4 = (ARoomNnotAccessibleToDisabledIndividuals == x);
            Console.WriteLine(result4);
            if (result4 == false)
            {
                Console.WriteLine("A room isn't accessible to disabled individuals");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ReadLine();
            //Opertors
            //As an Architecture Engineer
            int areaOfTheFloor_m = 157;
            int COST_EGP = 550;
                int result5 = areaOfTheFloor_m * COST_EGP;
            Console.WriteLine(result5);
            Console.WriteLine();

            Console.WriteLine("----------------------------");
            Console.ReadLine();
            //As a structural Engineer
            int fcu_MPA = 25;
            int fy_MPA = 360;
            int columnWidth_mm = 250;
            int columnDepth_mm = 700;
            int Ac = columnWidth_mm * columnDepth_mm;
            double As = 0.01 * Ac;
            double Pu = 0.35 * Ac * fcu_MPA + 0.67 * As * fy_MPA;
            Console.WriteLine("PU="+Pu);
            Console.WriteLine();

            Console.WriteLine("----------------------------");
            Console.ReadLine();
            //As an MEP Engineer
            int NumberOfLightBulbs = 3;
                int PowerConsumptionPer_Bu = 60;
            int TotalPowerConsumption = NumberOfLightBulbs * PowerConsumptionPer_Bu;
            Console.WriteLine(TotalPowerConsumption);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            



        }

    }
          
        }











        
    



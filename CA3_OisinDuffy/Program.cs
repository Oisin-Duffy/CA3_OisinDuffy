namespace CA3_OisinDuffy

{
    using System;
    using System.Linq;
    using System.Xml;
    using static Passengers;




    internal class Program
    {



        static void Main(string[] args)
        {
            string path = @"C:\Users\User\OneDrive - Atlantic TU\programming CA3\CA3_OisinDuffy\faminefile.csv";


            int MenuChoice = 0;

            while (MenuChoice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1.Ship Reports");
                Console.WriteLine("2.Occupation Report");
                Console.WriteLine("3.Age Report");
                Console.WriteLine("4.Exit");
                Console.WriteLine();

                Console.WriteLine("Enter Choice:");
                MenuChoice = int.Parse(Console.ReadLine());

                if (MenuChoice == 1)
                {
                    ShipReports(path);
                }
                else if (MenuChoice == 2)
                {
                    OccupationReport(path);
                }
                else if (MenuChoice == 3) ;
                {
                    AgeReport(path);
                }


            }
        }

        static List<Passengers> readingFile(string path)
        {
            string occupation = "";
            List<Passengers> passengers = new List<Passengers>();
            using (StreamReader sr = File.OpenText(path))

            {
                string? lineIn = sr.ReadLine();
                while (lineIn != null)
                {


                    string[] splitString = lineIn.Split(',');



                    Passengers passenger = new Passengers(splitString[1], splitString[0], splitString[2], splitString[3], splitString[4], splitString[5], splitString[6],
                       splitString[7], splitString[8], splitString[9]);

                    passengers.Add(passenger);
                    occupation = splitString[8];






                    lineIn = sr.ReadLine();

                }
                return passengers;



            }
        }

        static void OccupationReport(string path)
        {

            int counterSpinster = 0;
            int counterCultivatorAndFarmer = 0;
            int countermatron = 0;
            int counterdressMaker = 0;
            int counterchild = 0;
            int counterclerk = 0;
            int counterimmigrant = 0;
            int counterundefinedCode = 0;
            int countercarpenter = 0;
            int counterfisherMan = 0;
            int counterLaborer = 0;
            int counternone = 0;
            int counterchambermaid = 0;
            int countersmith = 0;
            int countermason = 0;
            int counterbakerormacaronimaker = 0;
            int countertannerorgerber = 0;
            int counterinfant = 0;
            int counterstudent = 0;
            int countercoachman = 0;
            int countersaddler = 0;





            using (StreamReader sr = File.OpenText(path))
            {

                string lineIn = sr.ReadLine();

                while (lineIn != null)
                {

                    string[] splitString = lineIn.Split(',');
                    if (lineIn.Contains("Spinster"))
                    {
                        counterSpinster++;


                    }
                    else if (lineIn.Contains("Cultivator or Farmer"))
                    {
                        counterCultivatorAndFarmer++;

                    }
                    else if (lineIn.Contains("Matron"))
                    {
                        countermatron++;
                    }
                    else if (lineIn.Contains("Dressmaker"))
                    {
                        counterdressMaker++;
                    }
                    else if (lineIn.Contains("Child"))
                    {
                        counterchild++;
                    }
                    else if (lineIn.Contains("Clerk"))
                    {
                        counterclerk++;
                    }
                    else if (lineIn.Contains("Immigrant"))
                    {
                        counterimmigrant++;
                    }
                    else if (lineIn.Contains("Undefined Code"))
                    {
                        counterundefinedCode++;
                    }
                    else if (lineIn.Contains("Carpenter"))
                    {
                        countercarpenter++;
                    }
                    else if (lineIn.Contains("Fisher Man"))
                    {
                        counterfisherMan++;
                    }
                    else if (lineIn.Contains("Laborer (Ital. 'operaia') or Workman/Woman"))
                    {
                        counterLaborer++;
                    }
                    else if (lineIn.Contains("None"))
                    {
                        counternone++;
                    }
                    else if (lineIn.Contains("Chamber Maid or Maid or Servant"))
                    {
                        counterchambermaid++;
                    }
                    else if (lineIn.Contains("Smith"))
                    {
                        countersmith++;
                    }
                    else if (lineIn.Contains("Mason"))
                    {
                        countermason++;
                    }
                    else if (lineIn.Contains("Baker or Macaroni Maker"))
                    {
                        counterbakerormacaronimaker++;
                    }
                    else if (lineIn.Contains("Tanner or Gerber"))
                    {
                        countertannerorgerber++;
                    }
                    else if (lineIn.Contains("Infant"))
                    {
                        counterinfant++;
                    }
                    else if (lineIn.Contains("Student"))
                    {
                        counterstudent++;
                    }
                    else if (lineIn.Contains("Coachman/Coach Driver or Driver"))
                    {
                        countercoachman++;
                    }
                    else if (lineIn.Contains("Saddler"))
                    {
                        countersaddler++;
                    }



                    lineIn = sr.ReadLine();
                }

                Console.WriteLine($"this is the total amount of Spinsters {counterSpinster}");
                Console.WriteLine($"this is the total amount of Cultivator and farmers {counterCultivatorAndFarmer}");
                Console.WriteLine($"this is the total amount of Matrons {countermatron}");
                Console.WriteLine($"this is the total amount of Dressmakers {counterdressMaker}");
                Console.WriteLine($"this is the total amount of Children {counterchild}");
                Console.WriteLine($"this is the total amount of Clerks {counterclerk}");
                Console.WriteLine($"this is the total amount of Immigrants {counterimmigrant}");
                Console.WriteLine($"this is the total amount of Undefined Code {counterundefinedCode}");
                Console.WriteLine($"this is the total amount of Carpenters {countercarpenter}");
                Console.WriteLine($"this is the total amount of Fishermans {counterfisherMan}");
                Console.WriteLine($"this is the total amount of Laborers {counterLaborer}");
                Console.WriteLine($"this is the total amount of None {counternone}");
                Console.WriteLine($"this is the total amount of Chamber Maids {counterchambermaid}");
                Console.WriteLine($"this is the total amount of Smiths {countersmith}");
                Console.WriteLine($"this is the total amount of Masons {countermason}");
                Console.WriteLine($"this is the total amount of Bakers {counterbakerormacaronimaker}");
                Console.WriteLine($"this is the total amount of Tanners or Gerbers {countertannerorgerber}");
                Console.WriteLine($"this is the total amount of Infants {counterinfant}");
                Console.WriteLine($"this is the total amount of Students {counterstudent}");
                Console.WriteLine($"this is the total amount of Coachmen {countercoachman}");
                Console.WriteLine($"this is the total amount of Saddlers {countersaddler}");


            }





        }






        static void ShipReports(string filePath)
        {
            string path = @"C:\Users\User\OneDrive - Atlantic TU\programming CA3\CA3_OisinDuffy\faminefile.csv";
            List<Passengers> passengers = readingFile(path);


            string menuChoice2 = "0";
            int menuInt;
            Console.WriteLine("ship report");
            Console.WriteLine("1.The Mary Harrington");
            Console.WriteLine("2.The Lincoln");
            Console.WriteLine("3.Clare");
            Console.WriteLine("4.The Disbatch");
            menuChoice2 = Console.ReadLine();
            while (!int.TryParse(menuChoice2, out menuInt))
            {
                Console.WriteLine("invalid choice please try again");
                Console.ReadLine();
            }

            int counter = 0;
            int i = 0;

            if (menuInt == 1)
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    string lineIn = sr.ReadLine();

                    while (lineIn != null)
                    {


                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("MARY HARRINGTON  187  07-06-1848  102"))
                        {
                            string firstname = splitString[1];
                            string lastname = splitString[0];
                            counter++;
                            Console.WriteLine($"FirstName {firstname}  lastname  {lastname}   ");

                        }
                        lineIn = sr.ReadLine();
                    }

                    Console.WriteLine($"The total number of passengers is : {counter}");
                }


            }


            if (menuInt == 2)
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    string lineIn = sr.ReadLine();

                    while (lineIn != null)
                    {

                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("LINCOLN 187 02-05-1849 071"))
                        {
                            string firstname = splitString[1];
                            string lastname = splitString[0];
                            counter++;
                            Console.WriteLine($"FirstName  {firstname}  lastname {lastname}   ");

                        }
                        lineIn = sr.ReadLine();
                    }

                    Console.WriteLine($"The total number of passengers is : {counter}");
                }


            }

            if (menuInt == 3)
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    string lineIn = sr.ReadLine();

                    while (lineIn != null)
                    {

                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("CLARE 187 06-06-1849 123"))
                        {
                            string firstname = splitString[1];
                            string lastname = splitString[0];
                            counter++;
                            Console.WriteLine($"FirstName  {firstname}   LastName {lastname}   ");

                        }
                        lineIn = sr.ReadLine();
                    }

                    Console.WriteLine($"The total number of passengers is : {counter}");
                }

            }

            if (menuInt == 4)
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    string lineIn = sr.ReadLine();

                    while (lineIn != null)
                    {

                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("DISPATCH 187 06-26-1851 049"))
                        {
                            string firstname = splitString[1];
                            string lastname = splitString[0];
                            counter++;
                            Console.WriteLine($"FirstName  {firstname}     LastName {lastname}   ");

                        }
                        lineIn = sr.ReadLine();
                    }

                    Console.WriteLine($"The total number of passengers is  : {counter}");
                }
            }





        }


        static void AgeReport(string filepath)
        {
            string path = @"C:\Users\User\OneDrive - Atlantic TU\programming CA3\CA3_OisinDuffy\faminefile.csv";
           
            List<Passengers> passengers = readingFile(path);

            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uh oh an error occured when trying to read the csv file : {ex.Message}");
            }




            var ageCategories = new Dictionary<string, int>()
            {
                {"Infants (<1 year)",0 },
                {"Children (1-12 years)", 0 },
                {"Teenage (12-19)", 0 },
                {"Young Adult (20-29)", 0  },
                {"Adult (30+)", 0 },
                {"Older Adult (50+)", 0 },
                {"unknown",0 },

            };

          

        }


    }
}

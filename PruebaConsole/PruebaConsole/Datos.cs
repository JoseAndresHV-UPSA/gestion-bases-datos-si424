using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsole
{
    public static class Datos
    {
        public static List<string> alias = new()
        {
            "Thor", "Rocco", "Baloo", "Baloo", "Nana", "Chucky", "Potter", "Rei", "Dama", "Hulk", "Jack", "Uggie", "Dante", "Conan", "Luna", "Akira", "Molly", "Thanos", "Beethoven", "Frank", "Golfo", "Dumbo", "Merlín", "Vader", "Penny", "Rocky", "Brian", "Verdell", "Reina", "Dino", "Troya", "Obi Wan", "Starsky", "Nemo", "Golfo", "Totó", "Bolt", "Frodo", "Leia", "R2", "Indiana", "Nala", "Hachiko", "Slinky", "Truman", "Fiona", "Luke", "Vito", "Scooby", "Simba", "Lassie", "Dug", "Pongo", "Máximo", "Toby", "Electra", "Copito", "Butkus", "Marley", "Sam", "Perdita", "Neo", "Rambo", "Valentín", "Coco", "Milo", "Zero", "Balto", "Spock", "Arwen", "Minnie", "Max", "Charlie", "Fang", "Casper", "Yago", "Pumba", "Samantha"
        };

        public static List<string> especies = new()
        {
            "Perro", "Gato", "Hamster", "Pajaro"
        };

        public static Dictionary<string, List<string>> razas = new()
        {
            { "Perro",   new() { "Husky siberiano", "Golden retriever", "Caniche", "Pastor alemán", "Yorkshire terrier", "Dálmata", "Bóxer", "Chihuahua", "Bulldog inglés", "Beagle" } },
            { "Gato",    new() { "Siamés", "Ragdoll", "Maine Coon", "Gato exótico", "Birmano", "Bombay", "Habana", "Persa", "Gato comun" } },
            { "Hamster", new() { "Ruso enano", "Sirio o dorado", "Chino", "Campbell" } },
            { "Pajaro",  new() { "Periquito", "Canario", "Jilguero" } }
        };

        public static Dictionary<string, List<string>> colores = new()
        {
            { "Perro",   new() { "Negro", "Blanco", "Gris", "Cafe", "Dorado", "Plateado" } },
            { "Gato",    new() { "Negro", "Blanco", "Gris", "Cafe", "Naranja" } },
            { "Hamster", new() { "Cafe", "Negro", "Blanco" } },
            { "Pajaro",  new() { "Azul", "Rojo", "Blanco", "Verde" } }
        };

        public static Dictionary<string, int> pesos = new()
        {
            { "Perro",   10 },
            { "Gato",    4  },
            { "Hamster", 1  },
            { "Pajaro",  1  }
        };

        public static Dictionary<string, double> pesosDesv = new()
        {
            { "Perro",   0.6  },
            { "Gato",    0.35 },
            { "Hamster", 0.25 },
            { "Pajaro",  0.1  }
        };

        public static List<string> enfermedades = new()
        {
            "Infeccion", "Alergia", "Hongos", "Parvovirus", "Parasitos", "Moquillo"
        };

        public static Dictionary<string, List<string>> medicacion = new()
        {
            { "Infeccion",  new() { "Antibioticos", "Inyectable"} },
            { "Alergia",    new() { "Antialergicos", "Crema antialergica" } },
            { "Hongos",     new() { "Cafe", "Negro", "Blanco" } },
            { "Parvovirus", new() { "Inyectable", "Transfusion de sangre", "Antibioticos"} },
            { "Parasitos",  new() { "NexGard", "Tableta antiparatitaria", "Pipeta" } },
            { "Moquillo",   new() { "Inyectable", "Antibioticos" } }
        };

        public static Dictionary<string, string> vacunas = new()
        {
            { "Distemper",     "Vacuna contra el distemper" },
            { "Parvovirus",    "Vacuna contra parvovirus" },
            { "Hepatitis",     "Vacuna contra la hepatitis infecciosa" },
            { "Leptospirosis", "Vacuna contra la leptospirosis" },
            { "Rabia",         "Vacuna contra la rabia" },
        };

        public static List<string> nombres = new()
        {
            "Preston", "Olivia", "Richard", "Jessica", "Alan", "Bruce", "Ashton", "Aiden", "Samantha", "Sawyer", "David", "Fenton", "Kate", "Richard", "Adele", "Sam", "Tiana", "Lydia", "Robert", "Paige", "Walter", "Olivia", "Frederick", "Joyce", "Rubie", "Abigail", "Byron", "Reid", "Stella", "Michael", "Daniel", "Abigail", "Jacob", "Vivian", "Frederick", "Hailey", "Deanna", "Jordan", "Vivian", "Agata", "Edward", "Blake", "Deanna", "Bruce", "Spike", "Edgar", "Ada", "Freddie", "Julia", "Rosie", "Florrie", "Cherry", "Jasmine", "Carina", "James", "Arianna", "Alford", "Michael", "Jessica", "Stella", "Mary", "George", "Kate", "Lenny", "Alina", "Nicholas", "Kristian", "Julian", "Chelsea", "Steven", "Andrew", "Maria", "Ryan", "Alissa", "Lyndon", "Melissa", "Naomi", "Abigail", "Alford", "Henry", "Byron", "Tony", "Leonardo", "Kelvin", "Stuart", "Aida", "Alford", "Briony", "Adele", "Annabella", "Maria", "Michelle", "Max", "Marcus", "Charlie", "Agata", "Agata", "Aldus", "Nicholas", "Rafael"
        };

        public static List<string> apellidos = new()
        {
            "Moore", "Mason", "Stevens", "Armstrong", "Howard", "Turner", "Spencer", "Lloyd", "Murray", "Roberts", "Jones", "Miller", "Gray", "Roberts", "Johnston", "Moore", "Armstrong", "Stewart", "Martin", "Rogers", "Clark", "Bailey", "Ryan", "Brooks", "Hall", "Murray", "Walker", "Johnson", "Perry", "Morris", "Johnson", "Perkins", "Ryan", "Grant", "Payne", "Wilson", "Morris", "Morrison", "Richardson", "Morrison", "Hill", "Robinson", "Hunt", "Henderson", "Henderson", "Stevens", "Wright", "Phillips", "Phillips", "Barrett", "Mitchell", "Mason", "Baker", "Lloyd", "Warren", "Robinson", "Harrison", "Adams", "Stewart", "Cole", "Andrews", "Hamilton", "Johnston", "Payne", "Grant", "Cole", "Higgins", "Wells", "Farrell", "Robinson", "Wells", "Morris", "Owens", "Campbell", "Williams", "Chapman", "Howard", "Robinson", "Smith", "Williams", "Kelly", "Walker", "Hall", "Wells", "Evans", "Tucker", "Brooks", "Grant", "Perkins", "Harris", "Crawford", "Mitchell", "Ryan", "Kelly", "Carroll", "Cunningham", "Alexander", "Williams", "Tucker", "Craig"
        };

        public static List<string> direcciones = new()
        {
            "90660 Loeprich Drive", "142 Grasskamp Crossing", "27980 Southridge Plaza", "463 Spohn Alley", "7044 John Wall Junction", "015 Pepper Wood Parkway", "159 Bashford Park", "31336 Morning Road", "76672 Eagan Park", "748 Northview Drive", "4 Crest Line Pass", "80 La Follette Avenue", "1908 Southridge Pass", "591 Cambridge Hill", "662 Aberg Crossing", "47 Magdeline Trail", "0914 Bellgrove Avenue", "690 Magdeline Crossing", "60552 Oriole Pass", "32453 Prairie Rose Court", "90 La Follette Plaza", "0 Walton Pass", "8 Pine View Parkway", "1009 Burning Wood Junction", "45 Rigney Junction", "5 Autumn Leaf Hill", "36 Red Cloud Center", "6602 Larry Pass", "23 Coleman Park", "11886 Derek Way", "81 Talmadge Road", "02 Starling Alley", "77225 Cordelia Pass", "20975 Trailsway Terrace", "506 Towne Trail", "17 Jackson Circle", "6 Anniversary Court", "6 Mariners Cove Drive", "78110 Meadow Vale Alley", "8 Fremont Terrace", "32 Bultman Court", "1126 Kim Point", "85456 Bartelt Road", "19 Nancy Pass", "09349 Victoria Trail", "229 Texas Plaza", "9 Huxley Parkway", "8 Hermina Junction", "514 Coleman Point", "74891 Mcguire Terrace", "3232 Elgar Place", "3669 Springs Terrace", "993 Harper Road", "575 Southridge Trail", "7 Saint Paul Avenue", "226 Fremont Plaza", "84 Canary Center", "10157 Almo Street", "06 Village Green Crossing", "42 Warbler Street", "76 Glacier Hill Trail", "17 Manufacturers Trail", "294 Clarendon Drive", "0 Esch Terrace", "4 American Road", "0060 Texas Parkway", "751 Twin Pines Road", "880 Leroy Terrace", "22132 Carioca Avenue", "702 Granby Way", "32485 Monterey Hill", "627 Michigan Park", "561 Erie Trail", "5630 Riverside Avenue", "9811 Clyde Gallagher Court", "9843 American Park", "5665 Redwing Point", "4742 Oneill Road", "73 Lakewood Gardens Parkway", "04177 Ohio Point", "2 Morningstar Center", "45 International Point", "951 Magdeline Hill", "35 Bonner Way", "7 Pierstorff Terrace", "17214 Browning Lane", "15425 Saint Paul Circle", "77415 Elka Lane", "92096 Brentwood Center", "01 Emmet Avenue", "9350 Spohn Parkway", "27458 Northport Way", "777 Meadow Ridge Plaza", "99750 South Street", "766 Evergreen Court", "78 Hagan Terrace", "1 Bobwhite Plaza", "9811 Golf Alley", "8 Hauk Drive", "225 Hazelcrest Lane", "507 Pankratz Plaza", "17782 Gerald Center", "7608 Grim Place", "79014 Fallview Road", "085 Summer Ridge Hill", "18523 Eagan Junction", "3400 7th Drive", "1 Sunbrook Drive", "0431 Lakewood Road", "5 Granby Lane", "10 Rockefeller Lane", "45 Sauthoff Pass", "00299 Westport Parkway", "04725 Melody Terrace", "72561 Atwood Road", "76965 Bunker Hill Point", "352 Dapin Center", "24595 Kensington Terrace", "4950 Ridgeway Pass", "05109 Hazelcrest Circle", "5940 Badeau Avenue", "9966 Mifflin Alley", "7 Dexter Way", "2 Goodland Crossing", "1 Garrison Place", "58 Village Green Avenue", "5093 Marquette Court", "97 Mayer Drive", "04 4th Street", "8 Canary Pass", "459 Farragut Center", "49592 Di Loreto Alley", "81769 Shelley Court", "62 Independence Hill", "2 Farmco Avenue", "5444 Golf Parkway", "7 Mockingbird Way", "34548 Debra Road", "0640 Mandrake Place", "58 Starling Lane", "2385 Dunning Center", "348 Valley Edge Way", "17 Vera Hill", "8729 Holy Cross Park", "48101 Oriole Terrace", "21448 Homewood Point", "77416 Messerschmidt Pass", "54512 Granby Court", "3 Duke Lane", "3 Mayfield Trail", "57205 Pennsylvania Point", "8 Arizona Parkway", "125 Arrowood Circle", "6503 Lunder Street", "39000 Meadow Ridge Lane", "0929 Raven Crossing", "01198 Coolidge Court", "9149 5th Trail", "64549 Butterfield Terrace", "2781 Graedel Way", "32 Upham Lane", "90165 Autumn Leaf Drive", "434 Clove Circle", "1 Toban Pass", "93065 Ramsey Circle", "861 Marcy Center", "928 Drewry Parkway", "39 Pond Crossing", "6017 Welch Pass", "309 Red Cloud Road", "98 Jay Crossing", "0 Di Loreto Terrace", "0217 Superior Trail", "6219 Southridge Hill", "83 Butterfield Lane", "1 West Center", "999 Golf Plaza", "387 Glacier Hill Trail", "526 Monterey Court", "29 Warner Park", "96 Anzinger Lane", "94 Graceland Terrace", "90 Cody Lane", "87 Brentwood Place", "2057 Bultman Trail", "900 Mosinee Hill", "429 Tomscot Plaza", "01039 Farmco Road", "1 Huxley Road", "1012 Boyd Alley", "2 Hauk Junction", "7965 Northport Alley", "64 Blue Bill Park Crossing", "71 Stone Corner Terrace", "6983 Ridgeview Hill", "677 Rusk Road", "374 Center Parkway", "6506 Crownhardt Trail", "592 Bluestem Park", "843 Harper Alley"
        };
    }
}

using System;

namespace HunterKelly.ECS.SoilsTemplateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var location = "location";
            var testType = "testType";
            var density = "density";
            var moisture = "moisture";

            Console.WriteLine("Welcome to the Standard Paragraph Generator for Soils. DISCLAIMER STILL IN ALPHA!! Press ENTER to continue.");
            Console.ReadLine();

            Console.Write("Enter test location ");
            location = Console.ReadLine();

            Console.Write("Enter type of material tested: ");
            testType = Console.ReadLine();

            Console.Write("Enter density % requirement: ");
            density = Console.ReadLine();

            Console.Write("Enter moisture % range: ");
            moisture = Console.ReadLine();

            var soils = $@"Soil Standard Template
The Undersigned arrived on site, as requested, to observe: 

1. The placement and compaction of {testType} Soils for {location}. 

    Utilizing the ASTM D6938 to test the compaction of {testType} Soils, test results indicated that the
    compacted material, at the areas and elevations tested, met or exceeded project requirements of {density} 
of the maximum density at {moisture} of the optimum moisture content as determined in ECS' Laboratory.";

            Console.WriteLine(soils);
            Console.ReadLine();
        }

    }
}

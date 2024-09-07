using System; // If i use system here then don't need to write Syste.Console.WriteLine() in the Main()

class Test{
    public static void Main(string[] args){
        // Console.WriteLine(123);
        // Console.WriteLine("Testing");
        // Console.WriteLine("Enter a character");
        // var test = Console.Read();
        // Console.WriteLine(test);

        // string name = "Shovan Nag";
        // int age = 32;

        // Console.WriteLine(name);
        // Console.WriteLine(age);

        // name = "John Doe";
        // Console.WriteLine(name);

        // age = 21;
        // Console.WriteLine(age);


        double sallary = 150000.500;

        Console.WriteLine(sallary);

        //int sallary2 = (int)sallary; // This is example of type casting
        int sallary2 = (Convert.ToInt16(sallary));
        Console.WriteLine(sallary2);

        /*There are two kind of type casting
            1. Implicit conversions -> int->double->char That means bottom to top
            2. Explicit conversions -> char->int->double That means top to bottom

            There is another example to change type. We can also use library method from covert class.
            For example, 

            double sallary = 150000.500;

            Console.WriteLine(sallary);

            int sallary2 = (covert.toInt(sallary));
            Console.WriteLine(sallary2);
        */

    }
}

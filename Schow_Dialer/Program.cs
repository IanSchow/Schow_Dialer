using System;

// Ian Schow
// IT112
// NOTES: This was both hard and easy 
// at the same time. For the most part, I
// think it was deceptively simple,
// which threw me off for a while. Still
// pretty fun though!
// ALL BEHAVIORS IMPLEMENTED
namespace Schow_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Phone Array, and Calling Methods
            Phone[] dialList = new Phone[10];
            ConstructAndCompile(ref dialList);
            DialLoop(dialList);

        }

        static void ConstructAndCompile(ref Phone[] dialList)
        {
            // Constructing Companies
            HomePhone compu = new HomePhone("3039855060", "CompuTest", "1");
            CellPhone curtis = new CellPhone("6035324123", "Curtis Manufacturing", "2");
            HomePhone data = new HomePhone("8008762524", "Data Functions", "1");
            HomePhone donnay = new HomePhone("7083973330", "Donnay Repair", "1");
            HomePhone ergoN = new HomePhone("3604343894", "ErgoNomic Inc", "1");
            HomePhone ergoS = new HomePhone("8009694374", "ErgoSource", "1");
            CellPhone fox = new CellPhone("8008748527", "Fox Bay Industries", "2");
            CellPhone glare = new CellPhone("8005456254", "Glare-Guard", "2");
            CellPhone hazard = new CellPhone("4077836641", "Hazard Comm Specialists", "2");
            CellPhone komfort = new CellPhone("7144724409", "Komfort Support", "2");

            // Filling array
            dialList[0] = compu;
            dialList[1] = curtis;
            dialList[2] = data;
            dialList[3] = donnay;
            dialList[4] = ergoN;
            dialList[5] = ergoS;
            dialList[6] = fox;
            dialList[7] = glare;
            dialList[8] = hazard;
            dialList[9] = komfort;
        }

        static void DialLoop(Phone[] dialList)
        {
            // Creating variables
            string prepend = "";
            string dialing;
            // Looping the dial function for each phone number
            for (int i = 0; i < 10; i++)
            { 
                // Calling Dial and writing it on Console
                dialing = dialList[i].Dial(prepend);
                Console.WriteLine(dialing);
            }
        }
    }
}
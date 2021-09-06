namespace object_oriented_analysis_and_design.ObjectOrientedPrinciples.LooseCoupling
{
    // Coupling pertains to the degree of dependency or knowledge of one class
    // to another. For instance, it is said that class A is higly coupled with class B
    // if class A can't function without class B as well as if class A can access 
    // all methods/functions of class B regardless if class A needs it or not.
    // Loose coupling specifies that two classes are highly independent of each other.

    // The AutoTellerMachine class below has direct knowledge of the inner workings
    // of the ATMScreen class; however, all it needs to do was to print a data.
    // These two classes are highly coupled with one another, that when either class is 
    // removed, the other would break.
    class AutoTellerMachine
    {
        ATMScreen screen;
        public void GetBalance(int balance)
        {
            screen = new ATMScreen();
            screen.printInMonitor(balance);
        }
    }

    class ATMScreen
    {
        public void printInMonitor(int funds)
        { }

        public void displayOptions()
        { }
    }

    // In the improved version of the AutoTellerMachine below,
    // instead of directly accessing the ATMScreen, it accesses
    // the Display interface which provides the functionality
    // print which can either print tha data on the screen or receipt.
    // It is no longer important how the print functionality is performed.
    // Aside from that, the new AutoTellerMachine class has now knowledge of the 
    // actual classes such as ATMScreen and Receipt which performs that actual printing 
    // of data; Hence, AutoTellerMachine is loosely coupled with ATMScreen and Receipt classes.
    class NewAutoTellerMachine
    {
        Display disp;
        public void GetBalance(int balance)
        {
            disp = new Display();
            disp.print(balance);
        }
    }

    class Display
    {
        public void print(int funds)
        { }
    }

    class Receipt
    {
        public void printInReceipt(int funds)
        { }
    }
}

namespace object_oriented_analysis_and_design.ObjectOrientedPrinciples.EncapsulateWhatVaries
{
    class Transaction
    {
        public void SetFunds()
        { }
        public void GetAccount()
        { }
    }

    class Withdrawal : Transaction
    { }

    class Deposit : Transaction
    { }

    class TellerMachine
    {
        // Given the GetTransaction function below,
        // we can see that the conditions can further be modified in
        // the future, in case that the teller machine
        // would perform more transactions
        // such as pay bills, change password etc.
        // With that, this part of the code is prone to changes
        // compared to other lines such as SetFunds and GetAccount
        // which remains the same regardless of the transaction type.
        public Transaction GetTransaction(string type)
        {
            Transaction trans;
            if (type == "withdrawal")
                trans = new Withdrawal();
            else if (type == "deposit")
                trans = new Deposit();
            else
                trans = null;

            trans.SetFunds();
            trans.GetAccount();

            return trans;
        }

        // Code improvement: Encapsulate what varies
        // this means to say that put the part of the code that will 
        // most likely be modified in the future, in a separate function 
        // such as below:
        public Transaction SetTransaction(string type)
        {
            Transaction trans;
            if (type == "withdrawal")
                trans = new Withdrawal();
            else if (type == "deposit")
                trans = new Deposit();
            else
                trans = null;

            return trans;
        }

        // Use the new function on the calling function.
        // The code does not only became simpler
        // but better as well as the function GetNewTransaction()
        // will no longer be modified whenever there are new transactions
        // added on the teller machine.
        // Aside from that, in case, setting transaction would be needed
        // in other parts of the code, there's no need to create another
        // function/method.
        public Transaction GetNewTransaction(string type)
        {
            Transaction trans = SetTransaction(type);
            trans.SetFunds();
            trans.GetAccount();

            return trans;
        }


    }
}

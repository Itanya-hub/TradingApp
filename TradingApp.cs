//Repersent the lost to hold the objects

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Tradingapp 
{
    private DataStore store;   //The DataStore object is PRIVATE.
    private User currentUser = null; //The currently logged-in user is PRIVATE.
    
    public TradingApp(DataStore dataHandler)   // dataHandler is placeholder value of data store
    {
        store = dataHandler;  // to perform Dependency Injection,the necessary external component (DataStore) into the class 
    }
}

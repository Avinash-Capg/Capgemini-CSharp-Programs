using System;

namespace PhoneCallSubscription;

public delegate void Notify();
public class PhoneCall
{
    
    public event Notify PhoneCallEvent;
    public string Message{get; private set;}
    private void OnSubscribe()
    {
        Message="Subscribed to Call";
    }
    private void OnUnSubscribe()
    {
        Message="UnSubscribed to Call";
    }
    public void MakeAPhoneCall(bool notify)
    {
        PhoneCallEvent=null;
        if(notify==true)
        {
            PhoneCallEvent+=OnSubscribe;
        }
        else if(notify==false)
        {
            PhoneCallEvent+=OnUnSubscribe;
        }
        PhoneCallEvent?.Invoke();
    }
   
}

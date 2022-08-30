namespace AgoraChat
{
    public class ContactManager
    {
        internal ContactManager(NativeListener nativeListener) 
        {
            nativeListener.contactManagerEvent += NativeEventHandle;
        }

        void NativeEventHandle(string method, string jsonString) 
        { 

        }
    }
}
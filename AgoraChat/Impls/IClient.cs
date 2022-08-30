using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgoraChat
{
    internal class IClient
    {
        public NativeListener nativeListener;

        public ChatManager chatManager;
        public ContactManager contactManager;
        public GroupManager groupManager;
        public RoomManager roomManager;
        public PresenceManager presenceManager;
        public ChatThreadManager chatThreadManager;
        public UserInfoManager userInfoManager;

        public ConversationManager conversationManager;
        public MessageManager messageManager;

        internal IClient() 
        {
            nativeListener = new NativeListener();
            // 将 listener 和 native 挂钩
            CWrapperNative.AddListener(nativeListener.nativeListenerEvent);

            chatManager = new ChatManager(nativeListener);
            contactManager = new ContactManager(nativeListener);
            groupManager = new GroupManager(nativeListener);
            roomManager = new RoomManager(nativeListener);
            presenceManager = new PresenceManager(nativeListener);
            chatThreadManager = new ChatThreadManager(nativeListener);
            userInfoManager = new UserInfoManager();

            conversationManager = new ConversationManager();
            messageManager = new MessageManager();
        } 
    }
}

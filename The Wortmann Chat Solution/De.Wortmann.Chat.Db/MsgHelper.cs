using De.Wortmann.Chat.Db.Models;

namespace De.Wortmann.Chat.Db
{
    public class MsgHelper : IDisposable
    {
        public ChatdbContext Ctx { get; set; }
        public MsgHelper()
        { 
            Ctx = new ChatdbContext();
        }
        public void Dispose()
        {
        }
        public MsgHelper AddMsg(Models.Chat c)
        {
            Ctx.Chats.Add(c);
            Ctx.SaveChanges();
            return this;
        }
        public MsgHelper AddMsg(string content, string header, string sender)
        {
            return AddMsg(new Models.Chat() 
            { Content = content,
                Header = header,
                Sender = sender,
                Datecreate = DateTime.Now.ToString()
            });
        }
        public MsgHelper DeleteMsg(Models.Chat c)
        {
            Ctx.Chats.Remove(c);
            Ctx.SaveChanges();
            return this;
        }
        public MsgHelper DeleteMsg(int id)
        {
            return DeleteMsg(Ctx.Chats.Find(id));
        }
        public int CountMsgs => Ctx.Chats.Count();
    }
}

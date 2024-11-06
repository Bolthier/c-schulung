using De.Wortmann.Chat.Db.Models;

namespace De.Wortmann.Chat.Db
{
    public class MsgHelper : IDisposable
    {
        public ChatContext Ctx { get; set; }

        public Models.Chat[] AlleMessages => Ctx.Chats.ToArray();

        public MsgHelper()
        {
            Ctx = new ChatContext();
        }
        public void Dispose()
        {
            Ctx.Dispose();
        }
        public MsgHelper AddMsg(Models.Chat c)
        {
            Ctx.Chats.Add(c);
            Ctx.SaveChanges();
            return this;
        }
        public MsgHelper AddMsg(string content, string header, string sender)
        {
             return AddMsg(new Models.Chat() { 
                Content=content, Header=header, 
                Sender=sender, 
                DateCreate=DateTime.Now.ToString()
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

//Scaffold-DbContext "Data Source=T:/andi/chat.db" Microsoft.EntityFrameworkCore.Sqlite -f -o Models -t chat
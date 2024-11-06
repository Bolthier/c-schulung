using De.Wortmann.Chat.CodeFirstDb.Models;

namespace De.Wortmann.Chat.CodeFirstDb
{
    public class MsgHelper
    {
        public void AddMsg(string content, string header)
        {
            using (var ctx=new MyChatContext())
            {
                ctx.Chats.Add(new ChatModel()
                {
                    Content = content,
                    Header = header,
                    DateCreate = DateTime.Now.ToString(),
                    Sender = "ICH"
                });
                ctx.SaveChanges();
            }
        }

    }
}

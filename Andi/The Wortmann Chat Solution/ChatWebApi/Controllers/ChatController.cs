using De.Wortmann.Chat.Db;
using De.Wortmann.Chat.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatWebApi.Controllers
{
    [ApiController]
    public class ChatController : ControllerBase
    {
        [HttpGet]
        [Route("/chat")]
        public Chat[] GetChats()
        {
            return new MsgHelper().AlleMessages;
        }
        [HttpGet]
        [Route("/chat/{id}")]
        public Chat GetChatsById(int id)
        {
            return new MsgHelper().AlleMessages.SingleOrDefault(x=>x.Id==id);
        }
        [Route("/chat")]
        [HttpPost]
        public void PostChat(Chat chat)
        {
            new MsgHelper().AddMsg(chat);
        }
    }
}

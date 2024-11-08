using WortmannNoteWebApi.Models;

namespace WortmannNoteWebApi.Business
{
    public class NoteHelper
    {
        private WortmannNoteContext _context;
        public  NoteHelper(WortmannNoteContext context)
        {
            _context = context;
        }
        public void NewNote(UserModel user, string header, string content = "")
        {
            NoteModel e = new NoteModel()
            {
                Id = Guid.NewGuid(),
                Header = header,
                Content = content,
                Posted = DateTime.Now,
                User = user
            };
            _context.Notes.Add(e);
            _context.SaveChanges();
        }
        public void NewNote(string user, string header, string content)
        {
            var userEntity = _context.Users.FirstOrDefault(x => x.Name.Equals(user));
            if (userEntity != null)
            {
                NewNote(userEntity, header, content);
            }
            else
            {
                throw new Exception("User note exists");
            }
        }
    }
}

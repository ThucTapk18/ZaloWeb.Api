using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaloweb.Data.Tables;

namespace Zaloweb.Data.Serviecs
{
   public class EmojiService: IEmojiService
    {
        private readonly DBContext context;
        public EmojiService(DBContext context)
        {
            this.context = context;
        }
        public async Task<bool> IsEmojiExistAsync(string Emojivalue)
        {
            var emoji = await context.Emojis.AsNoTracking()
                .Where(e => e.Emojivalue == Emojivalue)
                .FirstOrDefaultAsync();

            if (emoji == null)
            {
                return false;
            }

            return true;
        }
        public async Task<GetEmojiResult> GetEmojiAsync(
            string Emojivalue = null, long? EmojiId = null)
        {
            if (Emojivalue != null && EmojiId != null)
            {
                throw new InvalidOperationException("Chỉ được truyền 1 trong 2 tham số");
            }

             Emoji emoji = null;

            if (Emojivalue != null)
            {
                emoji = await context.Emojis.AsNoTracking()
                    .Where(e => e.Emojivalue == Emojivalue)
                    .FirstOrDefaultAsync();
            }
            else
            {
                emoji = await context.Emojis.AsNoTracking()
                    .Where(e => e.EmojiId == EmojiId.Value)
                    .FirstOrDefaultAsync();
            }

            if (emoji == null)
            {
                throw new InvalidOperationException("Không tìm thấy emoji");
            }

            return new GetEmojiResult
            {
                EmojiId = emoji.EmojiId,
                Emojivalue = emoji.Emojivalue
            };
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

using LiveChat_Backend.Context;
using LiveChat_Backend.Models;
using LiveChat_Backend.Converters;
using LiveChat_Backend.DTOS;

namespace LiveChat_Backend.Containers
{
    public class MessageContainer
    {
        private readonly ApplicationDbContext _dbContext;

        public MessageContainer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool SaveMessage(Message message)
        {
            try
            {
                var converter = new MessageDTOC();
                var messageDto = new MessageDTO();
                messageDto = converter.ModelToDto(message);

                _dbContext.messages.Add(messageDto);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

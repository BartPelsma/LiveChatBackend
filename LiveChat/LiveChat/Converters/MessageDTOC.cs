﻿using LiveChat_Backend.Models;
using LiveChat_Backend.DTOS;

namespace LiveChat_Backend.Converters
{
    public class MessageDTOC
    {
        public MessageDTO ModelToDto(Message model)
        {
            MessageDTO dto = new MessageDTO()
            {
                MessageID = model.MessageID,
                Content = model.Content,
                AccountID =  model.Account.AccountID,
                DialogID = model.Dialog.DialogID,
            };

            return dto;
        }

        public Message DtoToModel(MessageDTO dto)
        {
            Message model = new Message()
            {
                MessageID = dto.MessageID,
                Content = dto.Content,
                Account = new Account() { AccountID = dto.AccountID },
                Dialog = new Dialog() { DialogID = dto.DialogID },
            };

            return model;
        }
    }
}

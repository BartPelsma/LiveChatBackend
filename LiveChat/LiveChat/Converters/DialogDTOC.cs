﻿using LiveChat_Backend.DTOS;
using LiveChat_Backend.Models;

namespace LiveChat_Backend.Converters
{
    public class DialogDTOC
    {
        public DialogDTO ModelToDto(Dialog model)
        {
            DialogDTO dto = new DialogDTO();
            dto.DialogID = model.DialogID;
            dto.CreationDate = model.CreationDate;
            dto.Status = model.Status;
            dto.DialogName = model.DialogName;
            return dto;
        }

        public Dialog DtoToModel(DialogDTO dto)
        {
            Dialog model = new Dialog();
            model.DialogID = dto.DialogID;
            model.CreationDate = dto.CreationDate;
            model.Status = dto.Status;
            model.DialogName = dto.DialogName;
            return model;
        }
    }
}

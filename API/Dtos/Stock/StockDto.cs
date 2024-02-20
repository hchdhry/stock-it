﻿using API.Dtos.Comment;
namespace API.Dtos.Stock{

public class StockDto
{
        public int Id { get; set; }

        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public decimal LastDiv { get; set; }
       
        public decimal Purchase { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarkeyCap { get; set; }

        public List<CommentDto> Comments{get;set;}

    }
}
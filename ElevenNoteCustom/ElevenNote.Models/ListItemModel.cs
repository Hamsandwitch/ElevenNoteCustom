﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
   public class NoteListItemModel
    {

        [Display(Name = "Note #")]
        public int NoteId { get; set; }

        public string Title { get; set; }

        [UIHint("Starred")]
        [Display(Name = "Starred")]
        public bool IsStarred { get; set; }

        [Display(Name = "Created")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]

        public DateTimeOffset CreatedUtc { get; set; }
        public override string ToString()
        {
            return $"[{NoteId}] {Title}";
         
        }

    }
}

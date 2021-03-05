﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.DotNetNote
{
    public class NoteComment
    {
        public int Id { get; set; }
        public string BoardName { get; set; }
        public int BoardId { get; set; }
        [Required(ErrorMessage = "이름을 입력하세요")]
        public string Name { get; set; }
        [Required(ErrorMessage = "내용을 입력하세요")]
        public string Opinion { get; set; }
        public string PostDate { get; set; }
        [Required(ErrorMessage = "비밀번호를 입력하세요")]
        public string Password { get; set; }
    }
}

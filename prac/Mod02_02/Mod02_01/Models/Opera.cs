using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Mod02_01.Models
{
    public class Opera
    {
        [DisplayName("編號")]
        [Key]
        public int OperaID { set; get; }

        [DisplayName("劇院名稱")]
        [Required(ErrorMessage ="歌劇名稱不能空白")]
        [StringLength(200)]
        public string Title { get; set; }
        [DisplayName("年代")]
        public int Year { get; set; }
        [DisplayName("作者")]
        [Required]
        public string Composer { get; set; }
    }
}
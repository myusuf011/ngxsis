﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.ViewModel
{
    public class SumberLokerViewModel
    {
        public long id { get; set; }
        //public long created_by { get; set; }
        //public DateTime created_on { get; set; }
        //public long? modified_by { get; set; }
        //public DateTime? modified_on { get; set; }
        //public long? deleted_by { get; set; }
        //public DateTime? deleted_on { get; set; }
        //public bool is_delete { get; set; }
        public long biodata_id { get; set; }

        [Required(ErrorMessage = "Sumber tidak boleh kosong")]
        [DisplayName("Sumber"), StringLength(20)]
        public string vacancy_source { get; set; }

        [Required(ErrorMessage = "Pilih salah satu tipe pelamar")]
        [DisplayName("Tipe Pelamar"), StringLength(10)]
        public string candidate_type { get; set; }

        [Required(ErrorMessage = "Nama Event tidak boleh kosong")]
        [DisplayName("Nama Event *"), StringLength(100)]
        public string event_name { get; set; }

        [Required(ErrorMessage = "Karir Center tidak boleh kosong")]
        [DisplayName("Nama Karir Center *"), StringLength(100)]
        public string career_center_name { get; set; }

        [Required(ErrorMessage = "Referrer Name tidak boleh kosong")]
        [DisplayName("Referrer Name *"), StringLength(100)]
        public string referrer_name { get; set; }

        [Required(ErrorMessage = "No telepon tidak valid/tidak boleh kosong")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        [DisplayName("Referrer Mobile Number *"), StringLength(20)]
        public string referrer_phone { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$")]
        [Required(ErrorMessage = "E-mail tidak valid")]
        [DisplayName("Referrer Email *"), StringLength(100)]
        public string referrer_email { get; set; }

        [Required(ErrorMessage = "Sumber Lain tidak boleh kosong")]
        [DisplayName("Sumber Lain *"), StringLength(100)]
        public string other_source { get; set; }

        [DisplayName("Penghasilan Terakhir (IDR)"), StringLength(100)]
        public string last_income { get; set; }

        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [Display(Name = "Tgl. Lamaran Kerja (yyyy-mm-dd)")]
        public DateTime? apply_date { get; set; }
    }
}

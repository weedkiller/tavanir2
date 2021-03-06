﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tavanir2.Models
{
    public class UploadViewModel
    {
        [Required(ErrorMessage = "تعیین {0} ضروری است.")]
        [Display(Name = "فایل اکسل")]
        public IFormFile File { get; set; }

        [Required(ErrorMessage = "تکمیل فیلد {0} ضروری است.")]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "فیلد {0} بایستی از نوع یک رشته با حداقل طول {2} و حداکثر طول {1} باشد.")]
        [Display(Name = "نام Sheet")]
        public string SheetName { get; set; }

        [Required(ErrorMessage = "تعیین {0} ضروری است.")]
        [Display(Name = "عنوان ستون‌ها")]
        public string ColumnsType { get; set; }

        [Required(ErrorMessage = "تعیین {0} ضروری است.")]
        [Display(Name = "گروه داده‌ای")]
        public Guid DataCategoryID { get; set; }

        public List<DataCategories> ListDataCategories { get; set; }
    }

    public class DataCategories
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Model_Meta_Data_Type_Validation.Models.MetaDataTypes;
using System.Collections.Generic;

namespace Model_Meta_Data_Type_Validation.Models
{
    [ModelMetadataType(typeof(AuthorMetaData))]
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}

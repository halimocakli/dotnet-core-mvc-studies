using Microsoft.AspNetCore.Mvc;
using Model_Meta_Data_Type_Validation.Models.MetaDataTypes;
using System.Collections.Generic;

namespace Model_Meta_Data_Type_Validation.Models
{
    [ModelMetadataType(typeof(BookTypeMetaData))]
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}

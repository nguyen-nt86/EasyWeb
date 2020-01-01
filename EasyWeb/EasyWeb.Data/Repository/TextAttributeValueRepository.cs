using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface ITextAttributeValueRepository
    { }
    public class TextAttributeValueRepository: RepositoryBase<TextAttributeValue>, ITextAttributeValueRepository
    {
        public TextAttributeValueRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}

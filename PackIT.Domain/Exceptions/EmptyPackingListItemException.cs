using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingListItemException : PackITException
    {
        public EmptyPackingListItemException(): base("Packing item name cannot be empty") {}
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiamiPalms.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Court
    {
        public Court()
        {
            this.Game = new HashSet<Game>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    
        public virtual ICollection<Game> Game { get; set; }
    }
}

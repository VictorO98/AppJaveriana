using System;
using System.Collections.Generic;
using System.Text;

namespace Javeriana.WebServiceResults
{
    public class DetalleNoticia
    {
        public string nid { get; set; }
        public string Publicado { get; set; }
        public string path { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string body { get; set; }
        public string field_image_box { get; set; }
    }
    public class NoticiasResult
    {
        public int lastPage { get; set; }
        public List<DetalleNoticia> rows { get; set; }
    }
}

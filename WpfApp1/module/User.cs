using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.module
{
    public class TypesOfDivision
    {
        public int Id { get; set; }
        public string? Name { get; set; }


        public List<MainCheckOuts> MainCheckouts { get; set; } = new();
        public List<OtherCheckOuts> OtherCheckOuts { get; set; } = new();
    }

    public class MainTypes
    {
        public int Id {get; set; }
        public string? Name { get; set; }

        public List<MainCheckOuts> MainCheckouts { get; set; } = new();
    }

    public class OtherTypes
    {
        public int Id {get; set; }
        public string? Name {get; set; }

        public List<OtherCheckOuts> OtherCheckOuts { get; set; } = new();
    }

    public class MainCheckOuts
    {
        public int Id { get; set;}
        public int TypesOfDivisionId { get; set; }
        public TypesOfDivision? TypesOfDivision { get; set; }
        public int MainTypesId { get; set; }
        public MainTypes? MainTypes { get; set; }
        public int Count { get; set; }
        public string? Date { get; set; }
    }

    public class OtherCheckOuts
    {
        public int Id { set; get; }
        public int TypesOfDivisionId { get; set; }
        public TypesOfDivision? TypesOfDivision { get; set; }
        public int OtherTypesId { get; set; }
        public OtherTypes? OtherTypes { get; set; }
        public int Count { get; set; }
        public string? Date { get; set; }
    }
}

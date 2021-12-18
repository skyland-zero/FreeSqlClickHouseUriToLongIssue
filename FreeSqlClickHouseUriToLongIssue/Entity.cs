using FreeSql.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace FreeSqlClickHouseUriToLongIssue
{
    internal class Entity
    {
        [Required]
        [Column(IsIdentity = true)]
        public string Id { get; set; }

        [Column(StringLength = -2)]
        public string Content { get; set; }

        [Column(StringLength = -2)]
        public string Content2 { get; set; }

        [Column(StringLength = -2)]
        public string Content3 { get; set; }

        [Column(StringLength = -2)]
        public string Content4 { get; set; }

        [Column(StringLength = -2)]
        public string Content5 { get; set; }

        [Column(StringLength = -2)]
        public string Content6 { get; set; }


        [Column(StringLength = -2)]
        public string Content7 { get; set; }


        [Column(StringLength = -2)]
        public string Content8 { get; set; }

        [Column(StringLength = -2)]
        public string Content9 { get; set; }

        [Column(StringLength = -2)]
        public string Content10 { get; set; }
    }
}

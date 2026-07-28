using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TTAK_BLZRV2.Core.Models;

namespace TTAK_BLZRV2.Data
{
    [Table("Album")]
    public class AlbumE //: BaseModel
    {

        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }

        //AlbumId Title   ArtistId
        //1	MPM For Those About To Rock We Salute You	1


    }
}
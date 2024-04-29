using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220084.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static readonly List<Mahasiswa> DaftarMahasiswa =
        [
            new Mahasiswa("Febry Twenido Firmanio", "1302220084", new List<String> { "KPL", "Basis Data", "PBO"}, 2022),
            new Mahasiswa("Indra Mahesa", "1302220067", new List<String> { "Pengalaman Pengguna", "Basis Data", "PBO", "Proyek Tingkat 2" }, 2022),
            new Mahasiswa("Fionadhilla Gustriani", "1302220002", new List<String> { "KPL", "Basis Data" }, 2022),
        ];

        [HttpGet()]
        public IEnumerable<Mahasiswa> Get()
        {
            return DaftarMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id) 
        { 
            return DaftarMahasiswa[id];
        }

        [HttpPost()]
        public void Post(Mahasiswa mahasiswa)
        {
            DaftarMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            DaftarMahasiswa.Remove(DaftarMahasiswa[id]);
        }
    }
}

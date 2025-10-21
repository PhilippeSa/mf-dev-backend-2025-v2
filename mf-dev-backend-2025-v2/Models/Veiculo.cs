using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mf_dev_backend_2025_v2.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação!")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricação { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano de Modelo!")]
        [Display(Name = "Ano de Modelo")]
        public int AnoModelo { get; set; }
    }
}

namespace Design1.Controllers
{
    public class VeiculosController : ControllerBase
        
    {
        private readonly IVeiculoRepository veiculoRepository1;
      public VeiculoControler (IVeiculoRepository veiculoRepository, IVeiculoRepository veiculoDetran)
        {
            this.veiculoRepository = veiculoRepository;
            this.veiculoDetran = veiculoDetran;
        }  
         [HttpGet()]
        public TactionResult Get() => ok(veiculoRepository.GetAll()); //retorna tudo
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var veiculo = veiculoRepository.GetById(id);
            if (veiculo == null)
                return NotFound();
            return Ok(veiculo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Veiculo veiculo)
        {
            veiculoRepository.Add(veiculo);
            return CreatedAtAction(nameof(Get), new { id = veiculo.Id }, veiculo);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Veiculo veiculo)
        {
            veiculoRepository.Update(veiculo);

            return NoContent();
        }

         [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var veiculo = veiculoRepository.GetById(id);
            if (veiculo == null)
                return NotFound();

            veiculoRepository.Delete(veiculo);

            return NoContent();
        }

        [HttpPut("{id}/vistoria")]
        public IActionResult Put(Guid id)
        {
            veiculoDetran.AgendarVistoriaDetran(id);

            return NoContent();
        }

    }
}
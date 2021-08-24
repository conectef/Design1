namespace Design1.Controllers.Repository
{
    public interface IVeiculoDetran
    {
        public Task AgendarVistoriaDetran(Guid VeiculoId);
    }
}
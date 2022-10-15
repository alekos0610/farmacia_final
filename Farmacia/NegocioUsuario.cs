namespace Farmacia
{
    internal class NegocioUsuario
    {
        private object repositorioPaciente;

        public NegocioUsuario(object repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }
    }
}
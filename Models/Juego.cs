public class Juego
{
    public List<Sala> Salas { get; set; }

    public Sala ObtenerSalaPorNumero(int numero)
    {
        foreach (Sala sala in Salas)
        {
            if (sala.Numero == numero)
            {
                return sala;
            }
        }
        return null;
    }

    public bool ValidarClave(int numeroSala, string claveIngresada)
    {
        Sala salaBuscada = ObtenerSalaPorNumero(numeroSala);
        if (salaBuscada != null && salaBuscada.ClaveCorrecta != null)
        { 
            return salaBuscada.ClaveCorrecta.ToLower() == claveIngresada.ToLower();
        }
        return false;
    }   
}

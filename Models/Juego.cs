public class Juego
{
    public List<Sala> LSalas { get; set; }

    public Sala ObtenerSalaPorNumero(int numero)
    {
        foreach (Sala sala in LSalas)
        {
            if (sala.Numero == numero)
            {
                return sala;
            }
        }
        return null;
    }
    

    public bool ValidarClave(Sala sala, string claveIngresada)
    {
        if(sala.ClaveCorrecta==claveIngresada)
        {
            return true;
        }else
        {
            return false;
        }
    }   
}

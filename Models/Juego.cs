public class Juego
{
    public List<Sala> LSalas { get; set; }

   public List<Sala> InicializarSalas()
{
    List<Sala> salas = new List<Sala>();

    salas.Add(new Sala
    {
        Numero = 1,
        Pista = "Parecido a la bacteria",
        ClaveCorrecta = "VIRUS"
    });

    salas.Add(new Sala
    {
        Numero = 2,
        Pista = "",
        ClaveCorrecta = ""
    });

    salas.Add(new Sala
    {
        Numero = 3,
        Pista = "",
        ClaveCorrecta = ""
    });

    salas.Add(new Sala
    {
        Numero = 4,
        Pista = "",
        ClaveCorrecta = ""
    });

    return salas;
}


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
    

    
}

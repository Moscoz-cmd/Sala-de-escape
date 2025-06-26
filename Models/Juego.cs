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
        ClaveCorrecta = "4"
    });

    salas.Add(new Sala
    {
        Numero = 3,
        Pista = "",
        ClaveCorrecta = "15"
    });

    salas.Add(new Sala
    {
        Numero = 4,
        Pista = "",
        ClaveCorrecta = "27"
    });
    salas.Add(new Sala
    {
        Numero = 5,
        Pista = "",
        ClaveCorrecta = "C10H13N5O3"
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

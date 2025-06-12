using Newtonsoft.Json;

public class Sala
{
    public int Numero { get; set; }
    public string Pista { get; set; }
    public string ClaveCorrecta { get; set; }

public string definirPista()
{
    switch(Numero)
    {
        case 1:
        return "";
        break;
        case 2:
        return "";
        break;
        case 3:
        return "";
        break;
        case 4:
        return "";
        break;
        default: return ""; 
        break;
    }
}

}

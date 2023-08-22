public class Microwave
{
    private readonly IMicrowaveUI _ui;

    public Microwave(IMicrowaveUI ui)
    {
        _ui = ui;
    }

public void StartHeating(int timeInSeconds, int power)
{
    _ui.DisplayMessage($"Iniciando aquecimento por {timeInSeconds} segundos, potência: {power}");

    for (int second = 1; second <= timeInSeconds; second++)
    {
        string dots = new string('.', second * power / 10);
        _ui.DisplayMessage(dots);
        System.Threading.Thread.Sleep(1000);
    }

    _ui.DisplayMessage("Aquecimento concluído.");
}

}


class Program
{
    static void Main(string[] args)
    {
        IMicrowaveUI ui = new UserInterface();
        Microwave microwave = new Microwave(ui);

        ui.DisplayMessage("Bem-vindo ao Micro-ondas App!");

        int time = GetValidTimeFromUser(ui);
        int power = GetValidPowerFromUser(ui);

        microwave.StartHeating(time, power);

        ui.DisplayMessage("Obrigado por usar o Micro-ondas App!");
    }

    static int GetValidTimeFromUser(IMicrowaveUI ui)
{
    int time = 0;

    do
    {
        ui.DisplayMessage("Digite o tempo desejado (segundos): ");
        string input = ui.GetInput();

        if (int.TryParse(input, out time))
        {
            if (time < 1 || time > 120)
            {
                ui.DisplayMessage("Tempo inválido. O tempo deve ser entre 1 segundo e 2 minutos.");
            }
            else if (time >= 60 && time < 100)
            {
                ui.DisplayMessage($"Tempo convertido: {time / 60}:{time % 60:00}");
            }
        }
        else
        {
            ui.DisplayMessage("Entrada inválida. Digite um número inteiro.");
        }
    } while (time < 1 || time > 120);

    return time;
}


 static int GetValidPowerFromUser(IMicrowaveUI ui)
{
    int power = 10;

    do
    {
        ui.DisplayMessage("Digite a potência desejada (1-10, padrão 10): ");
        string input = ui.GetInput();

        if (int.TryParse(input, out power))
        {
            if (power < 1 || power > 10)
            {
                ui.DisplayMessage("Potência inválida. A potência deve estar entre 1 e 10.");
            }
        }
        else
        {
            ui.DisplayMessage("Entrada inválida. Digite um número inteiro.");
        }
    } while (power < 1 || power > 10);

    return power;
}

}


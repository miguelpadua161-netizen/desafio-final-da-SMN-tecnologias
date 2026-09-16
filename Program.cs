List<string> codigos = new List<string> {"PU-001", "PU-002", "PU-002", "PU-001", "PU-003", "PU-003", "P-005", "U-004"};
List<string> codigosunicos = new List<string> {};
List<int> quilometragem = new List<int> {1500, 3200, 800, 4100, 2200};

int validos = 0;
List<string> invalidos = new List<string> {};

int maiorQuilometragem = quilometragem[0];
int indiceMaior = 0;

for (int i = 0; i < quilometragem.Count; i++)
{
    if (quilometragem[i] > maiorQuilometragem)
    {
        maiorQuilometragem = quilometragem[i];
        indiceMaior = i;
    }
}



foreach (string codigo in codigos)
{
    if (!codigosunicos.Contains(codigo))
    {
        codigosunicos.Add(codigo);
    }
}

codigosunicos.Sort();

foreach (string codigo in codigosunicos)
{
    if (codigo.StartsWith("PU-"))
    {
        validos++;
    }
    else
    {
        invalidos.Add(codigo);
    }
}


if (codigosunicos.Count == 0)
{
    Console.WriteLine("Nenhuma bike para auditar.");
}
else
{
    Console.WriteLine("=== Relatorio de Auditoria ===");
    Console.WriteLine("Codigos ordenados:");
    foreach (string codigo in codigosunicos)
    {
        Console.WriteLine($" {codigo}");
    }
    Console.WriteLine($"Duplicados descartados {codigos.Count - codigosunicos.Count}");
    Console.WriteLine($"Válidos: {validos}");
    Console.WriteLine($"invalidos: {invalidos.Count}");
}


Console.WriteLine($"codigos no total {codigos.Count}");
Console.WriteLine($"codigos unicos: {codigosunicos.Count}");
Console.WriteLine($"Bike com maior quilometragem: {codigosunicos[indiceMaior]} - {maiorQuilometragem} km");
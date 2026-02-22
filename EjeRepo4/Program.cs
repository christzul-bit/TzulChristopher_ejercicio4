//Programa con repositorio 4
int nvlAmenaza = 0;
string recomendacion = "";
Console.WriteLine("Seleccione el incidente ocurrido \n" +
    "1)Malware \n" + //+2
    "2)Phishing \n" + //+3
    "3)Acceso no autorizado \n" + //+1
    "4)Fuga de informacion_"); //+4
int incidente = int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione el dispositivo afectado \n" +
    "1)PC \n" + //0
    "2)Servidor \n" + //+1
    "3)Base de datos \n" + //+2
    "4)Red_"); //+3
int device = int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione los datos afectados \n" +
    "1)Ninguno \n" + //0
    "2)Internos \n" + //+1
    "3)Personales \n" + //+2
    "4)Finacieros_"); //+3
int datos = int.Parse(Console.ReadLine());
Console.WriteLine("La amenaza persiste? (s/n)_");
string persiste = Console.ReadLine();
Console.WriteLine("Ingrese el número de usuarios afectados_");
int usuarios = int.Parse(Console.ReadLine());
if(persiste == "s" || persiste == "n" && usuarios > 0)
{
    switch (incidente)
    {
        case 1:
            nvlAmenaza += 2;
            switch (device)
            {
                case 1:
                    switch (datos)
                    {
                        case 1:
                            if(persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if(usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                             break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 2:
                    nvlAmenaza += 1;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 3:
                    nvlAmenaza += 2;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 15)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 4:
                    nvlAmenaza += 4;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 20)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 15)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                default: Console.WriteLine("Opcion invalida en dispisitivos afectados"); break;
            }
            break;
        case 2:
            nvlAmenaza += 3;
            switch(device)
            {
                case 1:
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 2:
                    nvlAmenaza += 1;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 3:
                    nvlAmenaza += 2;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 15)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 4:
                    nvlAmenaza += 4;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 20)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 15)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                default: Console.WriteLine("Opcion invalida en dispisitivos afectados"); break;
                }
            break;
        case 3:
            nvlAmenaza += 1;
            switch(device)
            {
                case 1:
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 2:
                    nvlAmenaza += 1;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 3:
                    nvlAmenaza += 2;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 15)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 4:
                    nvlAmenaza += 4;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 20)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 15)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                default: Console.WriteLine("Opcion invalida en dispisitivos afectados"); break;
            }
            break;
        case 4:
            nvlAmenaza += 4;
            switch(device)
            {
                case 1:
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 2:
                    nvlAmenaza += 1;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 3:
                    nvlAmenaza += 2;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 15)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                case 4:
                    nvlAmenaza += 4;
                    switch (datos)
                    {
                        case 1:
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 20)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 2:
                            nvlAmenaza += 1;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 15)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 3:
                            nvlAmenaza += 2;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 10)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        case 4:
                            nvlAmenaza += 3;
                            if (persiste == "s")
                            {
                                nvlAmenaza += 1;
                            }
                            if (usuarios > 5)
                            {
                                nvlAmenaza += 1;
                            }
                            break;
                        default: Console.WriteLine("Opcion invalida en datos afectados"); break;
                    }
                    break;
                default: Console.WriteLine("Opcion invalida en dispisitivos afectados"); break;
            }
            break;
        default: Console.WriteLine("Opcion invalida en insidente"); break;
    }

}else
{
    Console.WriteLine("Datos invalidos, rebise su respuesta en amenaza existencia y usuarios afectados");
}